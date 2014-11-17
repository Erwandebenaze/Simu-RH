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

                listPossibleProjects.Items.AddRange( PossibleProjects.Select( p => CreateListItemView( p ) ).ToArray() );
                listCurrentProjects.Items.AddRange( Projects.Select( p => CreateListItemView( p ) ).ToArray() );

                // TODO : Ajouter la liste pour les projets en cours lorsque le temps sera définis.
            }
        }

        static ListViewItem CreateListItemView( Project p )
        {
            ListViewItem i = new ListViewItem( p.Name );
            i.Tag = p;
            i.SubItems.Add(new ListViewItem.ListViewSubItem( i, p.Difficulty.ToString() ));
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Earnings.ToString() ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Duration.ToString() ) );
            return i;
        }

        private void listPossibleProjects_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( listPossibleProjects.SelectedItems.Count > 0 )
            {
                _currentProj = (Project)listPossibleProjects.SelectedItems[listPossibleProjects.SelectedItems.Count - 1].Tag;
                AffectCurrentProjectFields();
                if( _currentProj.Activated )
                {
                    _startOrStopProject.Text = "Arrêter un projet";
                } else
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
            _estimatedTime.Text = _currentProj.Duration.ToString();
            _numberOfWorkers.Text = _currentProj.NumberOfWorkers.ToString();
        }

        private void listCurrentProjects_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( listCurrentProjects.SelectedItems.Count > 0 )
            {
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

        private void _startOrStopProject_Click( object sender, EventArgs e )
        {
            Project pr;

            if( _currentProj.Activated )
            {
                pr = GameContext.CurrentGame.PlayerCompany.StopAProject( _currentProj );
                _startOrStopProject.Text = "Lancer un projet";
                ListViewItem projectItem = null;
                foreach( ListViewItem pI in listPossibleProjects.Items )
                {
                    if( pI.Tag == pr ) 
                    {
                        if( projectItem != null ) throw new InvalidOperationException( "2 items with the same Tag == project!" );
                        projectItem = pI;
                    }
                }
                if( projectItem == null ) throw new InvalidOperationException( "No item with the Tag == project!" );

                listCurrentProjects.Items.Remove( projectItem );
                listPossibleProjects.Items.Add( projectItem );
               
                //listPossibleProjects.Items.AddRange( PossibleProjects.Select( p => Create( p ) ).ToArray() );
            }
            else
            {
                pr = GameContext.CurrentGame.PlayerCompany.BeginAProject(_currentProj);
                _startOrStopProject.Text = "Arrêter un projet";
                
                var projectItem = listPossibleProjects.Items.Cast<ListViewItem>().Where( item => item.Tag == pr ).Single();
                listPossibleProjects.Items.Remove( projectItem );

                listCurrentProjects.Items.Add( projectItem );

            }

            listCurrentProjects.Refresh();
            listPossibleProjects.Refresh();

        }



    }
}
