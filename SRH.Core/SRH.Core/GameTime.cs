using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRH.Core
{
    [Serializable]
    public class GameTime
    {
        DateTime _currentTimeOfGame;
        DayOfWeek _dayOfTheWeek;
        string _frenchTranslationDay;
        Game _myGame;


        internal GameTime( Game myGame )
        {
            _myGame = myGame;
            _currentTimeOfGame = new DateTime(2015,01,26);
            _dayOfTheWeek = _currentTimeOfGame.DayOfWeek; 
        }
        public DateTime CurrentTimeOfGame
        {
            get { return _currentTimeOfGame; }
        }
        public string FrenchDayOfWeek
        {
            get
            {
                if( _currentTimeOfGame.DayOfWeek == DayOfWeek.Monday )
                    _frenchTranslationDay = "Lundi";
                else if( _currentTimeOfGame.DayOfWeek == DayOfWeek.Tuesday )
                    _frenchTranslationDay = "Mardi";
                else if( _currentTimeOfGame.DayOfWeek == DayOfWeek.Wednesday )
                    _frenchTranslationDay = "Mercredi";
                else if( _currentTimeOfGame.DayOfWeek == DayOfWeek.Thursday )
                    _frenchTranslationDay = "Jeudi";
                else if( _currentTimeOfGame.DayOfWeek == DayOfWeek.Friday )
                    _frenchTranslationDay = "Vendredi";

                return _frenchTranslationDay;
            }
        }

        public void newDay()
        {
            _currentTimeOfGame = _currentTimeOfGame.AddDays( 1 );
            
            if( _currentTimeOfGame.DayOfWeek == DayOfWeek.Saturday )
            {
                _currentTimeOfGame = _currentTimeOfGame.AddDays( 2 );
            }
        }

		public DateTime TryAddDay()
		{
			DateTime currentDate = _currentTimeOfGame;
			
			currentDate = currentDate.AddDays( 1 );
			if( currentDate.DayOfWeek == DayOfWeek.Saturday )
			{
				currentDate = currentDate.AddDays( 2 );
			}
			return currentDate;
		}

        public int intervalOfTimeInDays( DateTime? beginningDateNullable )
        {
            //TimeSpan ts = new TimeSpan();
            //ts = _timeOfGame - beginningDate;
            int days = 0;
            if( beginningDateNullable == null )
            {
                return 0;
            }
            DateTime beginningDate = (DateTime)beginningDateNullable;
            while (beginningDate < _currentTimeOfGame)
            {
                if( IsWorkingDay( beginningDate ) )
                {
                    days++;
                }

                beginningDate = beginningDate.AddDays( 1 );
            }

            return days;

            #region comments
            //if( beginningDate.DayOfWeek == _timeOfGame.DayOfWeek || beginningDate.DayOfWeek == DayOfWeek.Monday )
            //{

            //    int div = ts.Days / 7;
            //    return ts.Days - (div * 2);
            //}
            //else if( beginningDate.DayOfWeek == DayOfWeek.Tuesday )
            //{
            //    ts = _timeOfGame - beginningDate;
            //    int div = ts.Days / 7;
            //    return ts.Days - div;
            //}
            //return 1; 
            #endregion
        }


        /// <summary>
        /// Indique si la date est un jour ouvré
        /// </summary>
        /// <param name="date">La date à vérifier</param>
        /// <returns><c>true</c> si la date est un jour ouvré, sinon <c>false</c>.</returns>
        public static bool IsWorkingDay(DateTime date)
        {
            return !(date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);
        }
        
       
    }
}
