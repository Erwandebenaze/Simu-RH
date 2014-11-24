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

        protected override void OnLoad( EventArgs e )
        {
            if( this.IsInRuntimeMode() )
            {
                base.OnLoad( e );
                _projects = GameContext.CurrentGame.PlayerCompany.Projects;
                _possibleProjects = GameContext.CurrentGame.PlayerCompany.PossibleProjects;
                //_projectNameText.Text = "";

                //list.Add( new Project() { ProjectName = "titi", Duration = "trois semaines", Earnings = "trois cents", Level = "****" } );

                listPossibleProjects.Items.AddRange( PossibleProjects.Select( p => CreateListItemViewProjects( p ) ).ToArray() );
                listCurrentProjects.Items.AddRange( Projects.Select( p => CreateListItemViewProjects( p ) ).ToArray() );

                // TODO : Ajouter la liste pour les projets en cours lorsque le temps sera définis.
            }
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

        static ListViewItem CreateListItemViewSkillsRequired( Project p )
        {
            ListViewItem i = new ListViewItem( p.Name );
            i.Tag = p;
            //i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.SkillsRequired.Keys. ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.SkillsRequired.Values.ToString() ) );
            //i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Duration.ToString() ) );
            return i;
        }



        private void listPossibleProjects_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( listPossibleProjects.SelectedItems.Count > 0 )
            {
                _startOrStopProject.Enabled = true;
                EstimatedTime.Text = "Temps estimé";

                _currentProj = (Project)listPossibleProjects.SelectedItems[listPossibleProjects.SelectedItems.Count - 1].Tag;
                AffectCurrentProjectFields();
                //if( _currentProj.Activated )
                //{
                //    _startOrStopProject.Text = "Arrêter un projet";
                //    // TODO : Disable tous les élèments d'affectation aux compétences.
                //}
                //else
                //{
                    _startOrStopProject.Text = "Lancer un projet";
                    // Todo : Gestion des affectations des compétences.
                    //SelectedEmployeeSkillList.Items.AddRange( _currentEmployee.Worker.Skills.Values.Select( s => AddSkills( s ) ).ToArray() );
                    //int nbSkillsRequired = _currentProj.SkillsRequired.Count;
                    //listSkillsRequired.Items.AddRange( _currentProj.SkillsRequired.Select( p => CreateListItemViewSkillsRequired( _currentProj ) ).ToArray() );
            } 
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
                    _startOrStopProject.Text = "Lancer un projet";
                    
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
    }
}
