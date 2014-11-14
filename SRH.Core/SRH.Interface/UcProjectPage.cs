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
            base.OnLoad( e );
            _projects = GameContext.CurrentGame.PlayerCompany.Project;
            _possibleProjects = GameContext.CurrentGame.PossibleProjects;
            _projectNameText.Text = "";

            //list.Add( new Project() { ProjectName = "titi", Duration = "trois semaines", Earnings = "trois cents", Level = "****" } );

            listPossibleProjects.Items.AddRange( PossibleProjects.Select( p => Create( p ) ).ToArray() );

            // TODO : Ajouter la liste pour les projets en cours lorsque le temps sera définis.
        }

        static ListViewItem Create( Project p )
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
                _projectNameText.Text = _currentProj.Name;
                _difficulty.Text = _currentProj.Difficulty.ToString();
                _earnings.Text = _currentProj.Earnings.ToString();
                _estimatedTime.Text = _currentProj.Duration.ToString();
                _numberOfWorkers.Text = _currentProj.NumberOfWorkers.ToString();
                if( _currentProj.Activated )
                {
                    _startOrStopProject.Text = "Arrêter un projet";
                } else
                {
                    _startOrStopProject.Text = "Lancer un projet";
                }
            }
        }

        private void _startOrStopProject_Click( object sender, EventArgs e )
        {
            if( _currentProj.Activated )
            {
                _currentProj.StopProject();
                _startOrStopProject.Text = "Lancer un projet";

            }
            else
            {
                _currentProj.BeginProject();
                _startOrStopProject.Text = "Arrêter un projet";

            }
        }

    }
}
