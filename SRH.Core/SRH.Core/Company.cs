using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
    public abstract class Company
    {
		protected readonly Game _game;
        protected readonly string _name;
        protected int _maxEmployees;
        protected int _wealth;
        protected int _maxWealth;
        private readonly List<Employee> _employees;
        readonly protected Game _myGame;


        public Company( Game game, string name )
        {
			_game = game;
            _name = name;
            _myGame = game;
            _maxEmployees = 10;
            _employees = new List<Employee>();
        }

		#region Getters Setters
		internal Game Game
		{
			get { return _game; }
		}

		public List<Employee> Employees
		{
			get { return _employees; }
		}

		public string Name
		{
			get { return _name; }
		}

		public int Wealth
		{
			get { return _wealth; }
			set
			{
				if( _wealth + value > _maxWealth )
				{
					_maxWealth = _wealth + value;
				}
				_wealth = value;
			}
		}
		public int MaxWealth
		{
			get { return _maxWealth; }
		}
		public int MaxEmployees
		{
			get { return _maxEmployees; }
		} 
		#endregion

        /// <summary>
        /// Adds an <see cref="Employee"/> to <see cref="MyCompany"/>
        /// </summary>
        /// <param name="p">The Worker to add, it becomes an <see cref="Employee"/> when added</param>
        /// <returns>Returns True if the <see cref="Employee"/> was added</returns>
        internal Employee AddEmployee( Person p )
        {
            Employee e = new Employee( this, p );
            _employees.Add( e );

            if( !(_employees.Exists( x => x.Equals( e ) )) ) throw new InvalidOperationException( "The Employee wasn't properly added to the List." );
            if( !(p.Lb.RemovePerson( p )) ) throw new InvalidOperationException( "The Person wasn't properly removed from the List." );
            return e;
        }
        /// <summary>
        /// Removes an <see cref="Employee"/> from <see cref="MyCompany"/>
        /// </summary>
        /// <param name="e">The <see cref="Employee"/> to remove</param>
        /// <returns>Returns True id the <see cref="Employee"/> was removes</returns>
        internal Person RemoveEmployee( Employee e )
        {
            _employees.Remove( e );
            if( _employees.Exists( x => x.Equals( e ) ) )
                throw new InvalidOperationException( "The Employee was not removed properly from the List." );
            if( !(e.Worker.Lb.AddPerson( e.Worker )) )
                throw new InvalidOperationException( "The Person was not added properly to te List." );

            return e.Worker;
        }

		public bool HireEmployee(Person p)
		{
			double cost = p.ExpectedSalary * 0.1;
			if( _wealth >= cost )
			{
				_wealth -= (int)cost;
				AddEmployee( p );
				return true;
			}
			else return false;
		}

		public bool FireEmployee( Employee e )
		{
			double cost = e.Salary* 0.5;
			if( _wealth >= cost )
			{
				_wealth -= (int)cost;
				RemoveEmployee( e );
				return true;
			}
			else
				return false;
		}

    }
}
