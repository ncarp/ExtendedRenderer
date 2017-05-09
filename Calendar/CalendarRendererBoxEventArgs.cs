using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace System.Windows.Forms.Calendar
{
    /// <summary>
    /// Contains information about something's bounds and text to draw on the calendar
    /// </summary>
    public class CalendarRendererBoxEventArgs
        : CalendarRendererEventArgs
    {
        #region Fields
        private Color _backgroundColor;
        private Rectangle _bounds;
        private Font _font;
        private TextFormatFlags _format;
        private string _text;
        private Color _textColor;
        private Size _textSize;
        #endregion

        #region Ctor

        /// <summary>
        /// Initializes some fields
        /// </summary>
        private CalendarRendererBoxEventArgs()
        {
            
        }

        public CalendarRendererBoxEventArgs(CalendarRendererEventArgs original)
            : base(original)
        {
            Font = original.Calendar.Font;
            Format |= TextFormatFlags.Default | TextFormatFlags.WordBreak | TextFormatFlags.PreserveGraphicsClipping;// | TextFormatFlags.WordEllipsis;
            TextColor = SystemColors.ControlText;
        }

        public CalendarRendererBoxEventArgs(CalendarRendererEventArgs original, Rectangle bounds)
            : this(original)
        {
            Bounds = bounds;
        }

        public CalendarRendererBoxEventArgs(CalendarRendererEventArgs original, Rectangle bounds, string text)
            : this(original)
        {
            Bounds = bounds;
            Text = text;
        }

        public CalendarRendererBoxEventArgs(CalendarRendererEventArgs original, Rectangle bounds, string text, TextFormatFlags flags)
            : this(original)
        {
            Bounds = bounds;
            Text = text;
            Format |= flags;
        }

        public CalendarRendererBoxEventArgs(CalendarRendererEventArgs original, Rectangle bounds, string text, Color textColor)
            : this(original)
        {
            Bounds = bounds;
            Text = text;
            TextColor = textColor;
        }

        public CalendarRendererBoxEventArgs(CalendarRendererEventArgs original, Rectangle bounds, string text, Color textColor, TextFormatFlags flags)
            : this(original)
        {
            Bounds = bounds;
            Text = text;
            TextColor = TextColor;
            Format |= flags;
        }

        public CalendarRendererBoxEventArgs(CalendarRendererEventArgs original, Rectangle bounds, string text, Color textColor, Color backgroundColor)
            : this(original)
        {
            Bounds = bounds;
            Text = text;
            TextColor = TextColor;
            BackgroundColor = backgroundColor;
        }


        #endregion

        #region Props

        /// <summary>
        /// Gets or sets the background color of the text
        /// </summary>
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; }
        }

        /// <summary>
        /// Gets or sets the bounds to draw the text
        /// </summary>
        public Rectangle Bounds
        {
            get { return _bounds; }
            set { _bounds = value; }
        }

        /// <summary>
        /// Gets or sets the font of the text to be rendered
        /// </summary>
        public Font Font
        {
            get { return _font; }
            set { _font = value; _textSize = Size.Empty; }
        }

        /// <summary>
        /// Gets or sets the format to draw the text
        /// </summary>
        public TextFormatFlags Format
        {
            get { return _format; }
            set { _format = value; _textSize = Size.Empty; }
        }

        /// <summary>
        /// Gets or sets the text to draw
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; _textSize = Size.Empty; }
        }

        /// <summary>
        /// Gets the result of measuring the text
        /// </summary>
        public Size TextSize
        {
            get 
            {
                if (_textSize.IsEmpty)
                {
                    _textSize = TextRenderer.MeasureText(Text, Font);
                }
                return _textSize; 
            }
        }


        /// <summary>
        /// Gets or sets the color to draw the text
        /// </summary>
        public Color TextColor
        {
            get { return _textColor; }
            set { _textColor = value; }
        }

        

        #endregion

        #region Methods

        #endregion
    }
}
