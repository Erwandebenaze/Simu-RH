using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            List<DemoProject> list = new List<DemoProject>();
            list.Add( new DemoProject() { ProjectName = "toto", Duration = "une semaine", Earnings = "cent", Level = "***" } );
            list.Add( new DemoProject() { ProjectName = "tata", Duration = "deux semaines", Earnings = "deux cents", Level = "**" } );
            list.Add( new DemoProject() { ProjectName = "titi", Duration = "trois semaines", Earnings = "trois cents", Level = "****" } );

            listView1.Items.AddRange( list.Select( p => Create( p ) ).ToArray() );
        }

        static ListViewItem Create(DemoProject dp)
        {
            ListViewItem i = new ListViewItem(dp.ProjectName);
            i.Tag = dp;
            i.SubItems.Add(new ListViewItem.ListViewSubItem( i, dp.Level ));
            i.SubItems.Add(new ListViewItem.ListViewSubItem( i, dp.Earnings ));
            i.SubItems.Add(new ListViewItem.ListViewSubItem( i, dp.Duration ));
            return i;
        }
    }
}
