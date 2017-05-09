

using System;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;

namespace AC.ExtendedRenderer.Toolkit.KryptonOutlookGrid
{
    /// <summary>
    /// Column for the OutlookGrid GroupBox
    /// </summary>
    public class OutlookGridGroupBoxColumn : IEquatable<OutlookGridGroupBoxColumn>
    {
        #region "Constructor"
        ///// <summary>
        ///// Constructor
        ///// </summary>
        //public OutlookGridGroupBoxColumn()
        //{}

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="columnName">The column name.</param>
        /// <param name="columnText">The display text of the column.</param>
        /// <param name="sort">The column sort order.</param>
        public OutlookGridGroupBoxColumn(string columnName, string columnText, SortOrder sort)
        {
            Text = columnText;
            ColumnName = columnName;
            SortOrder = sort;
        }
        #endregion

        #region "Properties"

        public Rectangle Rect { get; set; }
        public string Text { get; set;}
        public bool Pressed { get; set; }
        public SortOrder SortOrder { get; set; }
        public string ColumnName { get; set; }
        public bool IsMoving { get; set; }
        public bool IsHovered { get; set; }

        #endregion

        #region "Implements"
        /// <summary>
        /// Defines Equals method on the columnName
        /// </summary>
        /// <param name="other">The OutlookGridGroupBoxColumn to compare with.</param>
        /// <returns>True or False.</returns>
        public bool Equals(OutlookGridGroupBoxColumn other)
        {
            return this.ColumnName.Equals(other.ColumnName);
        }
        #endregion
    }
}
