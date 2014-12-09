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
		bool _showProj = true;

		public UcSkillsDisplay()
		{
			InitializeComponent();
		}

		IGameContext GameContext
		{
			get { return (IGameContext)TopLevelControl; }
		}

		public Person CurrentPerson
		{
			get { return _currentPerson; }
			set { _currentPerson = value; }
		}

		public bool ShowProj
		{
			set { _showProj = value; }
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
				Func<bool, IEnumerable<Skill>> f = GetProjSkills;

				selectedPersonSkillList.Items.Clear();
				selectedPersonSkillList.Items.AddRange( f( _showProj ).Select( s => AddSkills( s ) ).ToArray() );
			}
		}

		private IEnumerable<Skill> GetProjSkills( bool arg )
		{
			if( !arg )
				return _currentPerson.Skills.Where( s => !GameContext.CurrentGame.IsProjSkill( s.SkillName ) );
			else
				return _currentPerson.Skills;
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
	}
}
