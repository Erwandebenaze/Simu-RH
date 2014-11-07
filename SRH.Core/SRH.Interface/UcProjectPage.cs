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
        class DemoProject
        {
            public string ProjectName { get; set; }
            public string Level { get; set; }
            public string Earnings { get; set; }
            public string Duration { get; set; }
            

        }
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad( e );
            List<Project> possibleProjects = new List<Project>();
            possibleProjects.Add( new Project( "Danone", 1, 2, 1000, 3 ) );
            possibleProjects.Add( new Project( "Nestle", 1, 2, 2000, 4 ) );
            possibleProjects.Add( new Project( "Accord", 1, 2, 3000, 5 ) );
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
