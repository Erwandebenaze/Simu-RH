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
	public partial class UcSkillsDisplay : UserControl
	{
		Person _currentPerson;

		public UcSkillsDisplay()
		{
			InitializeComponent();
		}

		public Person CurrentPerson
		{
			get { return _currentPerson; }
			set { _currentPerson = value; }
		}

		protected override void OnLoad( EventArgs e )
		{
			if( this.IsInRuntimeMode() )
			{
				base.OnLoad( e );
				LoadUc();
			}
		}

		internal void LoadUc()
		{
			if( _currentPerson != null )
			{
				selectedPersonSkillList.Items.Clear();
				selectedPersonSkillList.Items.AddRange( _currentPerson.Skills.Select( s => AddSkills( s ) ).ToArray() );
			}
		}

		/// <summary>
		/// Creates a Skill Item for the SelectedPerson or SelectedEMployee
		/// </summary>
		/// <param name="s">The Skill to display</param>
		/// <returns>A ListViewItem containing the information to display about a Skill</returns>
		static ListViewItem AddSkills( Skill s )
		{
			ListViewItem i = new ListViewItem( s.SkillName );
			i.Tag = s;
			i.SubItems.Add( new ListViewItem.ListViewSubItem( i, s.Level.CurrentLevel.ToString() ) );
			return i;
		}

		/// <summary>
		/// Sets the informations to display about a Person's Skills
		/// </summary>
		/// <param name="p">The Person who's Skill to display</param>
		/// <param name="l">The ListView to edit</param>
		private void SetSkillsInForm( Person p, ListView l )
		{
			l.Items.Clear();
			l.Items.AddRange( p.Skills.Select( s => AddSkills( s ) ).ToArray() );
		}
	}
}
