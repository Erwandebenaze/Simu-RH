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
        public UcProjectPage()
        {
            InitializeComponent();

        }

        IGameContext GameContext
        { 
            get { return (IGameContext)TopLevelControl; } 
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad( e );
            List<Project> possibleProjects = GameContext.CurrentGame.PossibleProjects;
            //list.Add( new Project() { ProjectName = "titi", Duration = "trois semaines", Earnings = "trois cents", Level = "****" } );

            listView1.Items.AddRange( possibleProjects.Select( p => Create( p ) ).ToArray() );

            // TODO : Ajouter la liste pour les projets en cours lorsque le temps sera définit.
        }

        static ListViewItem Create( Project p )
        {
            ListViewItem i = new ListViewItem(p.Name);
            i.Tag = p;
            i.SubItems.Add(new ListViewItem.ListViewSubItem( i, p.Difficulty.ToString() ));
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Earnings.ToString() ) );
            i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Duration.ToString() ) );
            return i;
        }
    }
}
