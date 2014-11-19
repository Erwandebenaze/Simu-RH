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
        static DateTime _timeOfGame;
        DayOfWeek _dayOfTheWeek;
        string _frenchTranslationDay;

      

        public GameTime()
        {
            _timeOfGame = new DateTime(2015,01,26);
            _dayOfTheWeek = _timeOfGame.DayOfWeek; 
        }
        public static DateTime TimeOfGame
        {
            get { return _timeOfGame.Date; }
        }
        public string FrenchDayOfWeek
        {
            get
            {
                if( _timeOfGame.DayOfWeek == DayOfWeek.Monday )
                    _frenchTranslationDay = "Lundi";
                else if( _timeOfGame.DayOfWeek == DayOfWeek.Tuesday )
                    _frenchTranslationDay = "Mardi";
                else if( _timeOfGame.DayOfWeek == DayOfWeek.Wednesday )
                    _frenchTranslationDay = "Mercredi";
                else if( _timeOfGame.DayOfWeek == DayOfWeek.Thursday )
                    _frenchTranslationDay = "Jeudi";
                else if( _timeOfGame.DayOfWeek == DayOfWeek.Friday )
                    _frenchTranslationDay = "Vendredi";

                return _frenchTranslationDay;
            }
        }

        public void newDay()
        {
            _timeOfGame = _timeOfGame.AddDays( 1 );
            
            if( _timeOfGame.DayOfWeek == DayOfWeek.Saturday )
            {
                _timeOfGame = _timeOfGame.AddDays( 2 );
            }
        }

        public int intervalOfTimeInDays( DateTime beginningDate )
        {
            //TimeSpan ts = new TimeSpan();
            //ts = _timeOfGame - beginningDate;
            int days = 0;

            while (beginningDate < _timeOfGame)
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
