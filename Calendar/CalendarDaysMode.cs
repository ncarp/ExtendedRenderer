using System;
using System.Collections.Generic;
using System.Text;

namespace System.Windows.Forms.Calendar
{
    /// <summary>
    /// Enumerates the possible modes of the days visualization on the <see cref="Calendar"/>
    /// </summary>
    public enum CalendarDaysMode
    {
        /// <summary>
        /// A short version of the day is visible without time scale.
        /// </summary>
        Short,

        /// <summary>
        /// The day is fully visible with time scale.
        /// </summary>
        Expanded
    }
}
