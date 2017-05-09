using System;
using System.Collections.Generic;
using System.Text;

namespace System.Windows.Forms.Calendar
{
    /// <summary>
    /// Event data with a <see cref="CalendarDay"/> element
    /// </summary>
    public class CalendarDayEventArgs
        :EventArgs
    {
        #region Ctor

        /// <summary>
        /// Creates a new event with the specified day
        /// </summary>
        /// <param name="day">Day of the event</param>
        public CalendarDayEventArgs(CalendarDay day)
        {
            _calendarDay = day;
        }

        #endregion

        #region Props
        private CalendarDay _calendarDay;

        /// <summary>
        /// Gets the day related to the event
        /// </summary>
        public CalendarDay CalendarDay
        {
            get { return _calendarDay; }
        }

        #endregion
    }
}
