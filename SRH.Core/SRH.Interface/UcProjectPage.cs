using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SRH.Core;

namespace SRH.Interface
{

    public partial class UcProjectPage : UserControl
    {
        List<Project> _possibleProjects;
        List<Project> _projects;
        Project _currentProj;
        Skill _currentSkill;
        Employee _currentEmployee;
        ListViewItem _projectItem;

        #region Getter
        public List<Project> Projects
        {
            get { return _projects; }
        }

        public UcProjectPage()
        {
            InitializeComponent();
        }
        public List<Project> PossibleProjects
        {
            get { return _possibleProjects; }
        }
        IGameContext GameContext
        {
            get { return (IGameContext)TopLevelControl; }
        } 
        #endregion

        protected override void OnLoad( EventArgs e )
        {
            if( this.IsInRuntimeMode() )
            {
                base.OnLoad( e );
				LoadPage();
            }
        }
		internal void LoadPage()
		{

			_projects = GameContext.CurrentGame.PlayerCompany.Projects;
			_possibleProjects = GameContext.CurrentGame.PlayerCompany.PossibleCompanyProjects;

			listPossibleProjects.Items.Clear();
			listCurrentProjects.Items.Clear();
            listSkillsAvailable.Items.Clear();
            listSkillsRequired.Items.Clear();
            GenerateProjectPageToolTip();

			listPossibleProjects.Items.AddRange( _possibleProjects.Select( p => CreateListItemViewProjects( p ) ).ToArray() );
			listCurrentProjects.Items.AddRange( _projects.Select( p => CreateListItemViewProjects( p ) ).ToArray() );
            #region TODO
            // TODO : Ajouter la liste pour les projets en cours lorsque le temps sera défini.
            #endregion

		}

        private void GenerateProjectPageToolTip()
        {
            
            _infoPossibleProjects.InitialDelay = 1700;
            _infoPossibleProjects.SetToolTip( this.listPossibleProjects, "Liste des projets possible à l'entreprise." );
            _infoProjects.SetToolTip( this.listCurrentProjects, "Liste des projets en cours dans l'entreprise." );
        }
        private ListViewItem CreateListItemViewProjects( Project project )
        {
            Project p = project.Clone();
            ListViewItem i = new ListViewItem( p.Name );
            i.Tag = p;
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Difficulty.ToString() ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, GameContext.CurrentGame.PlayerCompany.EstimatePourcentCommerciaux( p ).ToString() ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Duration.ToString() ) );
            return i;
        }
        internal ListViewItem CreateListItemViewCurrentProjects( Project p )
        {
            ListViewItem i = new ListViewItem( p.Name );
            i.Tag = p;
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Difficulty.ToString() ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, GameContext.CurrentGame.PlayerCompany.EstimatePourcentCommerciaux(p).ToString() ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.TimeLeft.ToString() ) );
            return i;
        }
        private void listPossibleProjects_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( listPossibleProjects.SelectedItems.Count > 0 )
            {
                listSkillsAvailable.Items.Clear();
                listSkillsRequired.Enabled = true;



                _startOrStopProject.Enabled = true;
                EstimatedTime.Text = "Temps estimé";
                if( _currentProj != null && !_currentProj.Activated )
                {
                    _currentProj.AnBusyEmployees();
                }

                _currentProj = (Project)listPossibleProjects.SelectedItems[listPossibleProjects.SelectedItems.Count - 1].Tag;
                _projectItem = listPossibleProjects.SelectedItems[listPossibleProjects.SelectedItems.Count - 1];

                AffectCurrentProjectFields();

                AffectStartButtonFields();
				listSkillsRequired.Items.Clear();
                listSkillsRequired.Items.AddRange( _currentProj.SkillsRequired.Select( k => CreateListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );
                if ( _currentProj.EmployeesAffectedWithSkill.Count != 0 )
                {
                    listSkillsRequired.Items.AddRange( _currentProj.EmployeesAffectedWithSkill.Select( k => CompleteListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );
                }

                listPossibleProjects.Items.Clear();
                listPossibleProjects.Items.AddRange( _possibleProjects.Select( p => CreateListItemViewProjects( p ) ).ToArray() );
            
            } 
        }
        private void listSkillsRequired_SelectedIndexChanged( object sender, EventArgs e )
        {

            if( listSkillsRequired.SelectedItems.Count > 0 )
            {
                if (!_currentProj.Activated)
                {

                
                    listSkillsAvailable.Items.Clear();

                    _currentSkill = (Skill)listSkillsRequired.SelectedItems[listSkillsRequired.SelectedItems.Count - 1].Tag;
                    if (_currentProj.SkillsRequired.ContainsKey(_currentSkill))
                    {
                        listSkillsAvailable.Items.AddRange( _currentProj.MyComp.Employees.Where( emp => emp.Worker.Skills.Any( s => s.SkillName == _currentSkill.SkillName ) )
                                                                     .Where( emp => !emp.Busy )
                                                                     .Select( emp => CreateListItemViewEmployeeWithSkill( emp, _currentSkill ) )
                                                                     .OrderBy( emp => _currentSkill.Level.CurrentLevel )
                                                                     .ToArray() );
                    }
                }

            }
        }
        private ListViewItem CreateListItemViewSkillsRequired( Skill skill, int level )
        {
            ListViewItem i = new ListViewItem();
            i.Tag = skill;
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, skill.SkillName ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, "0 ("+level.ToString()+")" ) );
            return i;
        }
        private ListViewItem CompleteListItemViewSkillsRequired( Employee e, Skill skill )
        {
            ListViewItem i = new ListViewItem( e.Worker.FirstName + " " + e.Worker.LastName );
            i.Tag = skill;
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, skill.SkillName ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, skill.Level.CurrentLevel.ToString() + " (" + _currentSkill.Level.CurrentLevel + ")" ) );
           // Risque de problème sur le level entre parenthèses.
            return i;
        }
        private ListViewItem CreateListItemViewEmployeeWithSkill( Employee emp, Skill s )
        {
            ListViewItem i = new ListViewItem( emp.Worker.FirstName + " " + emp.Worker.LastName );
            foreach( Skill sk in emp.Worker.Skills.Where(ski => ski.SkillName == s.SkillName) )
            {
                i.Tag = emp;
                i.SubItems.Add( new ListViewItem.ListViewSubItem( i, s.SkillName ) );
                i.SubItems.Add( new ListViewItem.ListViewSubItem( i, sk.Level.CurrentLevel.ToString() ) );     
            }
            return i;
        }
        private void listCurrentProjects_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( listCurrentProjects.SelectedItems.Count > 0 )
            {
                
                listSkillsRequired.Enabled = false;
                EstimatedTime.Text = "Temps restant estimé";
                _currentProj = (Project)listCurrentProjects.SelectedItems[listCurrentProjects.SelectedItems.Count - 1].Tag;
                //_projectItem = listCurrentProjects.SelectedItems[listCurrentProjects.SelectedItems.Count - 1];

                AffectCurrentProjectFields();
              
                if( _currentProj.Activated )
                {
                    _startOrStopProject.Text = "Arrêter un projet";
                    _startOrStopProject.Enabled = true;
                    listSkillsRequired.Items.Clear();
                    listSkillsRequired.Items.AddRange( _currentProj.EmployeesAffectedWithSkill.Select( k => CompleteListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );

                }
                else
                {
                    AffectStartButtonFields();
                }
            }
        }
        private void AffectCurrentProjectFields()
        {
            _projectNameText.Text = _currentProj.Name;
            _difficulty.Text = _currentProj.Difficulty.ToString();
            _earnings.Text = GameContext.CurrentGame.PlayerCompany.EstimatePourcentCommerciaux( _currentProj ).ToString();
            AffectVariableFields();
            _numberOfWorkers.Text = _currentProj.NumberOfWorkers.ToString();
        }

        internal void AffectVariableFields()
        {
            if( _currentProj != null )
            {

                if( _currentProj.Activated )
                {

                    _estimatedTime.Text = _currentProj.TimeLeft.ToString();
                    projectProgressBar.Minimum = 0;
                    projectProgressBar.Maximum = _currentProj.ProjectTasks;
                    projectProgressBar.Value = (_currentProj.ProjectTasks - _currentProj.ActualTasks);
                }
                else
                {
                    _estimatedTime.Text = _currentProj.Duration.ToString();
                    projectProgressBar.Value = 0;
                    //listSkillsRequired.Items.Clear();
                    //listSkillsRequired.Enabled = true;
                    
                }
            }
        }
        private void _startOrStopProject_Click( object sender, EventArgs e )
        {
            Project pr;
            bool flag = true;

            if( _currentProj.Activated )
            {
                listSkillsRequired.Enabled = true;
                pr = GameContext.CurrentGame.PlayerCompany.StopAProject( _currentProj );
                _startOrStopProject.Text = "Lancer un projet";
                var projectItem = listCurrentProjects.Items.Cast<ListViewItem>().Where( item => item.Tag == pr ).Single();

                listCurrentProjects.Items.Remove( projectItem );
                //listPossibleProjects.Items.Add( projectItem );
            }
            else
            {
                foreach( Employee emp in _currentProj.EmployeesAffectedWithSkill.Keys)
                {
                    if(emp.InVacation.Value != 0 || emp.IsSick.Value != 0 )
                    {
                        MessageBox.Show( "Un employé est parti en vacances ou en congé maladie pendant la préparation du projet, merci de resélectionner des membres pour le projet." );
                        flag = false;
                        break;
                    }
                }
                if( flag )
                {
                    GameContext.CurrentGame.PlayerCompany.BeginAProject( _currentProj );
                    _startOrStopProject.Text = "Arrêter un projet";
                    listSkillsRequired.Enabled = false;
                    //listPossibleProjects.Items.Remove( projectItem );
                    //var projectItemCopy = (ListViewItem)projectItem.Clone();
                    listCurrentProjects.Items.Add( _projectItem );
                }

            }
            //_projects = GameContext.CurrentGame.PlayerCompany.Projects;
        }
        private void listSkillsAvailable_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            if( listSkillsAvailable.SelectedItems.Count > 0 )
            {
                _currentEmployee = (Employee)listSkillsAvailable.SelectedItems[listSkillsAvailable.SelectedItems.Count - 1].Tag;
                _currentProj.AffectEmployeeToAJob( _currentEmployee, _currentSkill ); 
                //listSkillsAvailable.Enabled = false;
                listSkillsAvailable.Items.Clear();

                listSkillsRequired.Items.Clear();
                listSkillsRequired.Items.AddRange( _currentProj.SkillsRequired.Select( k => CreateListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );
                listSkillsRequired.Items.AddRange( _currentProj.EmployeesAffectedWithSkill.Select( k => CompleteListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );

                AffectStartButtonFields();
            }  
        }
        private void listSkillsRequired_MouseDoubleClick( object sender, MouseEventArgs e )
        {

            if( !_currentProj.SkillsRequired.ContainsKey( _currentSkill ) )
            {
                if (_currentProj.EmployeesAffectedWithSkill.Count != 0)
                {
                    if( _currentProj.EmployeesAffectedWithSkill.ContainsValue( _currentSkill ) )
                    {
                    foreach( Employee emp in _currentProj.EmployeesAffectedWithSkill.Keys )
                    {
                            if( emp.Worker.Skills.Contains(_currentSkill))
                            {
                                _currentProj.RemoveEmployeeFromAJob( emp, _currentSkill );
                                break;
                            }

                        }
                    }
                }
                //_currentEmployee = (Employee)listSkillsRequired.SelectedItems[listSkillsRequired.SelectedItems.Count - 1].Tag;

                AffectStartButtonFields();

                listSkillsRequired.Items.Clear();
                listSkillsRequired.Items.AddRange( _currentProj.SkillsRequired.Select( k => CreateListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );
                listSkillsRequired.Items.AddRange( _currentProj.EmployeesAffectedWithSkill.Select( k => CompleteListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );

                listSkillsAvailable.Items.Clear();
                listSkillsAvailable.Items.AddRange( _currentProj.MyComp.Employees.Where( emp => emp.Worker.Skills.Any( s => s.SkillName == _currentSkill.SkillName ) )
                                             .Where( emp => !emp.Busy )
                                             .Select( emp => CreateListItemViewEmployeeWithSkill( emp, _currentSkill ) )
                                             .OrderBy( emp => _currentSkill.Level.CurrentLevel )
                                             .ToArray() );
            }

        }
        private void AffectStartButtonFields()
        {
            if( !_currentProj.Activated )
            {
                if( _currentProj.SkillsRequired.Count != 0 )
                {
                    _startOrStopProject.Enabled = false;
                    _startOrStopProject.Text = "Affectez les employés avant de lancer.";

                }
                else
                {
                    _startOrStopProject.Enabled = true;
                    _startOrStopProject.Text = "Lancer un projet";
                }
                listSkillsRequired.Enabled = true;

            }

        }

		private void desaffectEmployee_Click( object sender, EventArgs e )
		{
            if (_currentProj != null )
            {

            
			    if( !_currentProj.SkillsRequired.ContainsKey( _currentSkill ) )
			    {
				    if( _currentProj.EmployeesAffectedWithSkill.Count != 0 )
				    {
					    foreach( Employee emp in _currentProj.EmployeesAffectedWithSkill.Keys )
					    {
						    if( _currentProj.EmployeesAffectedWithSkill.ContainsValue( _currentSkill ) )
						    {
							    _currentProj.RemoveEmployeeFromAJob( emp, _currentSkill );
							    break;
						    }
					    }
				    }
				    //_currentEmployee = (Employee)listSkillsRequired.SelectedItems[listSkillsRequired.SelectedItems.Count - 1].Tag;

				    AffectStartButtonFields();

				    listSkillsRequired.Items.Clear();
				    listSkillsRequired.Items.AddRange( _currentProj.SkillsRequired.Select( k => CreateListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );
				    listSkillsRequired.Items.AddRange( _currentProj.EmployeesAffectedWithSkill.Select( k => CompleteListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );

				    listSkillsAvailable.Items.Clear();
				    listSkillsAvailable.Items.AddRange( _currentProj.MyComp.Employees.Where( emp => emp.Worker.Skills.Any( s => s.SkillName == _currentSkill.SkillName ) )
											     .Where( emp => !emp.Busy )
											     .Select( emp => CreateListItemViewEmployeeWithSkill( emp, _currentSkill ) )
											     .OrderBy( emp => _currentSkill.Level.CurrentLevel )
											     .ToArray() );
			    }
            }
		}

		private void affectEmployee_Click( object sender, EventArgs e )
		{
            if( _currentProj != null )
            {
			    if( listSkillsAvailable.SelectedItems.Count > 0 )
			    {
				    _currentEmployee = (Employee)listSkillsAvailable.SelectedItems[ listSkillsAvailable.SelectedItems.Count - 1 ].Tag;
				    _currentProj.AffectEmployeeToAJob( _currentEmployee, _currentSkill );
				    //listSkillsAvailable.Enabled = false;
				    listSkillsAvailable.Items.Clear();

				    listSkillsRequired.Items.Clear();
				    listSkillsRequired.Items.AddRange( _currentProj.SkillsRequired.Select( k => CreateListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );
				    listSkillsRequired.Items.AddRange( _currentProj.EmployeesAffectedWithSkill.Select( k => CompleteListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );

				    AffectStartButtonFields();
			    }

            }
		}

        private void listPossibleProjects_ColumnClick( object sender, ColumnClickEventArgs e )
        {
            //listPossibleProjects.Items.Clear();
            //listPossibleProjects.Items.AddRange
            //( _possibleProjects.Select( p => CreateListItemViewProjects( p ) )
            //                   .OrderBy( i => new SortWrapper(i, e.Column))
            //                   .ToArray()
            //);
            if( listPossibleProjects.Sorting == SortOrder.Ascending )
                listPossibleProjects.Sorting = SortOrder.Descending;
            else
                listPossibleProjects.Sorting = SortOrder.Ascending;

        }

    }
}
