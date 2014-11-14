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
	public partial class UcEmployeePage : UserControl
	{

		public UcEmployeePage()
		{
			InitializeComponent();
		}

		IGameContext GameContext
		{
			get { return (IGameContext)TopLevelControl; }
		}

		private void UcEmployeePage_Load(object sender, EventArgs e)
		{
			
		}
		protected override void OnLoad( EventArgs e )
		{
			base.OnLoad( e );
			List<Person> persons = GameContext.CurrentGame.Market.JoblessPersons;
			PersonList.Items.AddRange(persons.Select( p => Create( p ) ).ToArray() );

		}

		static ListViewItem Create( Person p )
		{
			ListViewItem i = new ListViewItem( p.LastName );
			i.Tag = p;
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.FirstName ) );
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, p.Age.ToString() ) );
			return i;
		}
	}
}
