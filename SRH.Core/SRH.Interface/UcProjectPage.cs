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
			listPossibleProjects.Items.AddRange( PossibleProjects.Select( p => CreateListItemViewProjects( p ) ).ToArray() );
			listCurrentProjects.Items.AddRange( Projects.Select( p => CreateListItemViewProjects( p ) ).ToArray() );
            #region TODO
            // TODO : Ajouter la liste pour les projets en cours lorsque le temps sera définis.
            // TODO : si un projet était en cours, ne pas le loader de nouveau dans la liste des projets possibles 
            #endregion

		}

        static ListViewItem CreateListItemViewProjects( Project p )
        {
            ListViewItem i = new ListViewItem( p.Name );
            i.Tag = p;
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Difficulty.ToString() ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Earnings.ToString() ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Duration.ToString() ) );
            return i;
        }

        private void listPossibleProjects_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( listPossibleProjects.SelectedItems.Count > 0 )
            {
                listSkillsAvailable.Items.Clear();

                _startOrStopProject.Enabled = true;
                EstimatedTime.Text = "Temps estimé";

                _currentProj = (Project)listPossibleProjects.SelectedItems[listPossibleProjects.SelectedItems.Count - 1].Tag;
                AffectCurrentProjectFields();
                #region TODO
                //if( _currentProj.Activated )
                //{
                //    _startOrStopProject.Text = "Arrêter un projet";
                //    // TODO : Disable tous les élèments d'affectation aux compétences.
                //listSkillsRequired.Items.AddRange( _currentProj.EmployeesAffectedWithSkill.Select( k => CompleteListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );
                //}
                //else
                //{         
                #endregion
                AffectStartButtonFields();
					listSkillsRequired.Items.Clear();
                    listSkillsRequired.Items.AddRange( _currentProj.SkillsRequired.Select( k => CreateListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );
                    if ( _currentProj.EmployeesAffectedWithSkill.Count != 0 )
                    {
                        listSkillsRequired.Items.AddRange( _currentProj.EmployeesAffectedWithSkill.Select( k => CompleteListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );
                    }
            } 
        }



        private void listSkillsRequired_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( listSkillsRequired.SelectedItems.Count > 0 )
            {
                listSkillsAvailable.Items.Clear();

                _currentSkill = (Skill)listSkillsRequired.SelectedItems[listSkillsRequired.SelectedItems.Count - 1].Tag;
                if (_currentProj.SkillsRequired.ContainsKey(_currentSkill))
                {
                    listSkillsAvailable.Items.AddRange( _currentProj.MyComp.Employees.Where( emp => emp.Worker.Skills.Any( s => s.SkillNameEnglish == _currentSkill.SkillNameEnglish ) )
                                                                 .Where( emp => !emp.Busy )
                                                                 .Select( emp => CreateListItemViewEmployeeWithSkill( emp, _currentSkill ) )
                                                                 .OrderBy( emp => _currentSkill.Level.CurrentLevel )
                                                                 .ToArray() );
                }

            }
        }
        private ListViewItem CreateListItemViewSkillsRequired( Skill skill, int level )
        {
            ListViewItem i = new ListViewItem(skill.FrenchSkillName + "("+level.ToString()+")");
            i.Tag = skill;
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, skill.FrenchSkillName ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, "0 ("+level.ToString()+")" ) );
            return i;
        }
        private ListViewItem CompleteListItemViewSkillsRequired( Employee e, Skill skill )
        {
            ListViewItem i = new ListViewItem( e.Worker.FirstName + " " + e.Worker.LastName );
            i.Tag = skill;
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, skill.FrenchSkillName ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, skill.Level.CurrentLevel.ToString() + " (" + _currentSkill.Level.CurrentLevel + ")" ) );
           // Risque de problème sur le level entre parenthèses.
            return i;
        }
        private ListViewItem CreateListItemViewEmployeeWithSkill( Employee emp, Skill s )
        {
            ListViewItem i = new ListViewItem( emp.Worker.FirstName + " " + emp.Worker.LastName );
            foreach( Skill sk in emp.Worker.Skills )
            {
                
                i.Tag = emp;
                i.SubItems.Add( new ListViewItem.ListViewSubItem( i, s.FrenchSkillName ) );
                i.SubItems.Add( new ListViewItem.ListViewSubItem( i, s.Level.CurrentLevel.ToString() ) );     
            }
            return i;
        }
        private void listCurrentProjects_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( listCurrentProjects.SelectedItems.Count > 0 )
            {
                _startOrStopProject.Enabled = true;
                EstimatedTime.Text = "Temps restant estimé";
                _currentProj = (Project)listCurrentProjects.SelectedItems[listCurrentProjects.SelectedItems.Count - 1].Tag;
                AffectCurrentProjectFields();
                if( _currentProj.Activated )
                {
                    _startOrStopProject.Text = "Arrêter un projet";
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
            _earnings.Text = _currentProj.Earnings.ToString();
            if( _currentProj.Activated ) _estimatedTime.Text = _currentProj.TimeLeft.ToString();
            else _estimatedTime.Text = _currentProj.Duration.ToString();
            _numberOfWorkers.Text = _currentProj.NumberOfWorkers.ToString();
        }
        private void _startOrStopProject_Click( object sender, EventArgs e )
        {
            Project pr;

            if( _currentProj.Activated )
            {
                pr = GameContext.CurrentGame.PlayerCompany.StopAProject( _currentProj );
                _startOrStopProject.Text = "Lancer un projet";
                var projectItem = listCurrentProjects.Items.Cast<ListViewItem>().Where( item => item.Tag == pr ).Single();

                listCurrentProjects.Items.Remove( projectItem );
                listPossibleProjects.Items.Add( projectItem );
            }
            else
            {
                pr = GameContext.CurrentGame.PlayerCompany.BeginAProject( _currentProj );
                _startOrStopProject.Text = "Arrêter un projet";

                var projectItem = listPossibleProjects.Items.Cast<ListViewItem>().Where( item => item.Tag == pr ).Single();
                listPossibleProjects.Items.Remove( projectItem );
                listCurrentProjects.Items.Add( projectItem );
            }
            _projects = GameContext.CurrentGame.PlayerCompany.Projects;


            //GameContext.CurrentGame.PlayerCompany.MoveProject( pr );
        }
        public void RemoveEndingProject(Project p)
        {
            var projectItem = listCurrentProjects.Items.Cast<ListViewItem>().Where( item => item.Tag == p ).Single();
            listCurrentProjects.Items.Remove( projectItem );
            listPossibleProjects.Items.Add( projectItem );
        }

        private void listSkillsAvailable_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            _currentEmployee = (Employee)listSkillsAvailable.SelectedItems[listSkillsRequired.SelectedItems.Count - 1].Tag;
            _currentProj.AffectEmployeeToAJob( _currentEmployee, _currentSkill );
            
            listSkillsRequired.Items.Clear();
            listSkillsRequired.Items.AddRange( _currentProj.SkillsRequired.Select( k => CreateListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );
            listSkillsRequired.Items.AddRange( _currentProj.EmployeesAffectedWithSkill.Select( k => CompleteListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );
            
            listSkillsAvailable.Items.Clear();

            AffectStartButtonFields();

          
        }

        private void AffectStartButtonFields()
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
        }

        private void listSkillsRequired_MouseDoubleClick( object sender, MouseEventArgs e )
        {

            if( !_currentProj.SkillsRequired.ContainsKey( _currentSkill ) )
            {
                if (_currentProj.EmployeesAffectedWithSkill.Count != 0)
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
                AffectStartButtonFields();


                listSkillsRequired.Items.Clear();
                listSkillsRequired.Items.AddRange( _currentProj.SkillsRequired.Select( k => CreateListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );
                listSkillsRequired.Items.AddRange( _currentProj.EmployeesAffectedWithSkill.Select( k => CompleteListItemViewSkillsRequired( k.Key, k.Value ) ).ToArray() );

                listSkillsAvailable.Items.Clear();
                listSkillsAvailable.Items.AddRange( _currentProj.MyComp.Employees.Where( emp => emp.Worker.Skills.Any( s => s.SkillNameEnglish == _currentSkill.SkillNameEnglish ) )
                                             .Where( emp => !emp.Busy )
                                             .Select( emp => CreateListItemViewEmployeeWithSkill( emp, _currentSkill ) )
                                             .OrderBy( emp => _currentSkill.Level.CurrentLevel )
                                             .ToArray() );

            }

        }


    }
}
