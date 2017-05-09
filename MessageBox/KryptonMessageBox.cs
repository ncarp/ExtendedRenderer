using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Media;
using System.Drawing;

namespace AC.ExtendedRenderer.Toolkit
{
    [ Obsolete("This class is obsolete, use ComponentFactory.Krypton.Toolkit.KryptonMessageBox instead.") ]
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.Form))]
    public partial class KryptonMessageBox : ComponentFactory.Krypton.Toolkit.KryptonForm
    {

        public KryptonMessageBox()
        {
            InitializeComponent();
            this.lblDetails.Values.Image = ilDetails.Images[3];
        }

        private string _caption = string.Empty;
        private string _message = string.Empty;
        private string _details = string.Empty;

        private bool _showHeaderImage = false;
        private bool _showFooterImage = false;
        private bool _showDetails = false;

        private bool _showFooter = false;

        #region "Properties"

        //static object KryptonMessageBoxButtons;

        private string Caption
        {
            get { return _caption; }
            set
            {
                _caption = value;
                this.Text = value;
            }
        }

        private string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                this.lblHeader.Text = value;
            }
        }

        private string Details
        {
            get { return _details; }
            set
            {
                _details = value;
                this.lblFooter.Text = value;
            }
        }

        private bool ShowHeaderImage
        {
            get { return _showHeaderImage; }
            set
            {
                _showHeaderImage = value;
                this.pnlHeaderImage.Visible = value;
            }
        }

        private bool ShowFooterImage
        {
            get { return _showFooterImage; }
            set
            {
                _showFooterImage = value;
                this.pnlFooterImage.Visible = value;
            }
        }

        private bool ShowDetails
        {
            get { return _showDetails; }
            set
            {
                _showDetails = value;
                this.pnlDetails.Visible = value;
            }
        }

        private bool ShowFooter
        {
            get { return _showFooter; }
            set { _showFooter = value; }
        }
        #endregion


        public static DialogResult Show(string Message)
        {
            return Show(Message, "");
        }

        public static DialogResult Show(object sender, string Message)
        {
            return Show(Message);
        }

        public static DialogResult Show(object sender, string Message, string Caption)
        {
            return Show(Message, Caption);
        }

        public static DialogResult Show(object sender, string Message, string Caption, MessageBoxButtons Buttons)
        {
            return Show(Message, Caption, Buttons);
        }

        public static DialogResult Show(string Message, MessageBoxButtons Buttons, MessageBoxIcon Icon)
        {
            return Show(Message, "", Buttons, Icon);
        }

        public static DialogResult Show(object Sender, string Message, MessageBoxButtons Buttons, MessageBoxIcon Icon)
        {
            return Show(Message, Buttons, Icon);
        }

        public static DialogResult Show(object Sender, string Message, string Caption, MessageBoxButtons Buttons, MessageBoxIcon Icon)
        {
            return Show(Message, Caption, Buttons, Icon);
        }


        public static DialogResult Show(string message, string caption)
        {
            return Show(message, caption, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxIcon.None);
        }

        public static DialogResult Show(string message, string caption, MessageBoxButtons buttons)
        {
            return Show(message, caption, string.Empty, buttons, MessageBoxIcon.None, MessageBoxIcon.None);
        }

        public static DialogResult Show(string message, string caption, MessageBoxButtons buttons, MessageBoxIcon headerImage)
        {
            return Show(message, caption, string.Empty, buttons, headerImage, MessageBoxIcon.None);
        }

        public static DialogResult Show(string message, string caption, string details)
        {
            return Show(message, caption, details, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxIcon.None);
        }

        public static DialogResult Show(string message, string caption, string details, MessageBoxButtons buttons)
        {
            return Show(message, caption, details, buttons, MessageBoxIcon.None, MessageBoxIcon.None);
        }

        public static DialogResult Show(string message, string caption, string details, MessageBoxButtons buttons, MessageBoxIcon headerImage)
        {
            return Show(message, caption, details, buttons, headerImage, MessageBoxIcon.None);
        }

        public static DialogResult Show(string message, string caption, string details, MessageBoxButtons buttons, MessageBoxIcon headerImage, MessageBoxIcon footerImage)
        {

            KryptonMessageBox box = new KryptonMessageBox();

            box.Caption = caption;
            box.Message = message;
            box.Details = details;

            box.SetButtons(buttons);
            box.SetHeaderImage(headerImage);
            box.SetFooterImage(footerImage);

            if (!string.IsNullOrEmpty(box.Details))
            {
                box.ShowDetails = true;
            }

            box.ResizeForm();

            box.StartPosition = FormStartPosition.CenterScreen;

            box.Activate();
            box.Focus();

            switch (headerImage)
            {
                case MessageBoxIcon.Error:
                    SystemSounds.Exclamation.Play();
                    break;
                case MessageBoxIcon.Information:
                    SystemSounds.Exclamation.Play();
                    break;
                case MessageBoxIcon.None:
                    break;
                case MessageBoxIcon.Question:
                    SystemSounds.Question.Play();
                    break;
                case MessageBoxIcon.Warning:
                    SystemSounds.Asterisk.Play();
                    break;
            }

            return box.ShowDialog();

        }

        private void ResizeForm()
        {

            int topWidth = 0;
            int middleWidth = 0;
            int bottomWidth = 0;

            int width = 0;
            int height = 0;

            Font headerFont = default(Font);
            Font footerFont = default(Font);

            Size headerSize = default(Size);
            Size footerSize = default(Size);

            headerFont = (Font)this.KryptonManager.GlobalPalette.GetContentShortTextFont(PaletteContentStyle.LabelNormalControl, PaletteState.Normal);
            footerFont = (Font)this.KryptonManager.GlobalPalette.GetContentShortTextFont(PaletteContentStyle.LabelNormalControl, PaletteState.Normal);

            headerSize = (Size)this.MeasureString(this.lblHeader.Text, headerFont, (int)320);
            footerSize = (Size)this.MeasureString(this.lblFooter.Text, footerFont, (int)320);

            this.lblHeader.Size = Size.Add(headerSize, new Size(10, 0));
            this.lblFooter.Size = Size.Add(footerSize, new Size(10, 0));

            topWidth = this.pnlHeader.Width;

            if (this.ShowHeaderImage)
            {
                topWidth += this.pnlHeaderImage.Width;
            }

            middleWidth = this.pnlButtons.Width;

            if (this.ShowDetails)
            {
                middleWidth += this.pnlDetails.Width;
            }

            bottomWidth = this.pnlFooter.Width;

            if (this.ShowFooterImage)
            {
                bottomWidth += this.pnlFooterImage.Width;
            }

            width = Math.Max(Math.Max(topWidth, bottomWidth), middleWidth);

            this.PanelTop.Height = Math.Max(this.pnlHeaderImage.Height, this.pnlHeader.Height);
            this.PanelMiddle.Height = Math.Max(this.pnlDetails.Height, this.pnlButtons.Height);
            this.PanelBottom.Height = Math.Max(this.pnlFooterImage.Height, this.pnlFooter.Height);

            height = this.PanelTop.Height + this.PanelMiddle.Height;

            if (this.ShowFooter)
            {
                height += this.PanelBottom.Height;
            }

            this.pnlHeaderImage.Location = new Point(0, 0);

            if (this.ShowHeaderImage)
            {
                this.pnlHeader.Location = new Point(this.pnlHeaderImage.Width, 0);
            }
            else
            {
                this.pnlHeader.Location = new Point(0, 0);
            }

            this.pnlDetails.Location = new Point(0, 0);
            this.pnlButtons.Location = new Point(width - this.pnlButtons.Width, 0);

            this.pnlFooterImage.Location = new Point(0, 0);

            if (this.ShowFooterImage)
            {
                this.pnlFooter.Location = new Point(this.pnlFooterImage.Width, 0);
            }
            else
            {
                this.pnlFooter.Location = new Point(0, 0);
            }

            this.ClientSize = new Size(width, height);

        }

        private object MeasureString(string text, Font font, int width)
        {

            Graphics graphics = default(Graphics);
            Size size = default(Size);

            graphics = this.CreateGraphics();

            size = graphics.MeasureString(text, font, width).ToSize();

            graphics.Dispose();

            return size;

        }

        private void SetButtons(MessageBoxButtons buttons)
        {

            switch (buttons)
            {
                case MessageBoxButtons.AbortRetryIgnore:

                    this.Button1.Visible = true;
                    this.Button1.Text = "Abort";
                    this.Button1.DialogResult = System.Windows.Forms.DialogResult.Abort;

                    this.Button2.Visible = true;
                    this.Button2.Text = "Retry";
                    this.Button2.DialogResult = System.Windows.Forms.DialogResult.Retry;

                    this.Button3.Visible = true;
                    this.Button3.Text = "Ignore";
                    this.Button3.DialogResult = System.Windows.Forms.DialogResult.Ignore;

                    this.pnlButtons.Width = 265;

                    break;
                case MessageBoxButtons.OK:

                    this.Button1.Visible = true;
                    this.Button1.Text = "OK";
                    this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;

                    this.pnlButtons.Width = 95;

                    break;
                case MessageBoxButtons.OKCancel:

                    this.Button1.Visible = true;
                    this.Button1.Text = "OK";
                    this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;

                    this.Button2.Visible = true;
                    this.Button2.Text = "Cancel";
                    this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;

                    this.pnlButtons.Width = 180;

                    break;
                case MessageBoxButtons.RetryCancel:

                    this.Button1.Visible = true;
                    this.Button1.Text = "Retry";
                    this.Button1.DialogResult = System.Windows.Forms.DialogResult.Retry;

                    this.Button2.Visible = true;
                    this.Button2.Text = "Cancel";
                    this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;

                    this.pnlButtons.Width = 180;

                    break;
                case MessageBoxButtons.YesNo:

                    this.Button1.Visible = true;
                    this.Button1.Text = "Yes";
                    this.Button1.DialogResult = System.Windows.Forms.DialogResult.Yes;

                    this.Button2.Visible = true;
                    this.Button2.Text = "No";
                    this.Button2.DialogResult = System.Windows.Forms.DialogResult.No;

                    this.pnlButtons.Width = 180;

                    break;
                case MessageBoxButtons.YesNoCancel:

                    this.Button1.Visible = true;
                    this.Button1.Text = "Yes";
                    this.Button1.DialogResult = System.Windows.Forms.DialogResult.Yes;

                    this.Button2.Visible = true;
                    this.Button2.Text = "No";
                    this.Button2.DialogResult = System.Windows.Forms.DialogResult.No;

                    this.Button3.Visible = true;
                    this.Button3.Text = "Cancel";
                    this.Button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;

                    this.pnlButtons.Width = 265;

                    break;
            }

        }

        private void SetHeaderImage(MessageBoxIcon image)
        {

            switch (image)
            {
                case MessageBoxIcon.Error:
                    //SystemIcons.Asterisk.ToBitmap()
                    this.Icon = SystemIcons.Error;
                    this.boxHeaderImage.Image = SystemIcons.Error.ToBitmap();
                    this.ShowHeaderImage = true;

                    break;
                case MessageBoxIcon.Information:

                    this.Icon = SystemIcons.Information;
                    this.boxHeaderImage.Image = SystemIcons.Information.ToBitmap();
                    this.ShowHeaderImage = true;

                    break;
                case MessageBoxIcon.None:

                    this.Icon = null;
                    this.boxHeaderImage.Image = null;
                    this.ShowHeaderImage = false;

                    break;
                case MessageBoxIcon.Question:

                    this.Icon = SystemIcons.Question;
                    this.boxHeaderImage.Image = SystemIcons.Question.ToBitmap();
                    this.ShowHeaderImage = true;

                    break;
                case MessageBoxIcon.Warning:

                    this.Icon = SystemIcons.Application;
                    this.boxHeaderImage.Image = SystemIcons.Warning.ToBitmap();
                    this.ShowHeaderImage = true;

                    break;
            }

        }

        private void SetFooterImage(MessageBoxIcon image)
        {

            switch (image)
            {
                case MessageBoxIcon.Error:

                    this.boxFooterImage.Image = SystemIcons.Error.ToBitmap();
                    this.ShowFooterImage = true;

                    break;
                case MessageBoxIcon.Information:

                    this.boxFooterImage.Image = SystemIcons.Information.ToBitmap();
                    this.ShowFooterImage = true;

                    break;
                case MessageBoxIcon.None:

                    this.boxFooterImage.Image = null;
                    this.ShowFooterImage = false;

                    break;
                case MessageBoxIcon.Question:

                    this.boxFooterImage.Image = SystemIcons.Question.ToBitmap();
                    this.ShowFooterImage = true;

                    break;
                case MessageBoxIcon.Warning:

                    this.boxFooterImage.Image = SystemIcons.Warning.ToBitmap();
                    this.ShowFooterImage = true;

                    break;
            }

        }

        private void lblDetails_MouseEnter(object sender, System.EventArgs e)
        {
            
            if (this.ShowFooter)
            {
                
                this.lblDetails.Values.Image = ilDetails.Images[2];
                //My.Resources.DetailsLessHover
                
            }
            else
            {
                
                this.lblDetails.Values.Image = ilDetails.Images[5];
                //My.Resources.DetailsMoreHover
                
            }
            
        }

        private void lblDetails_MouseLeave(object sender, System.EventArgs e)
        {
            
            if (this.ShowFooter)
            {
                
                this.lblDetails.Values.Image = ilDetails.Images[0];
                //My.Resources.DetailsLess
                
            }
            else
            {
                
                this.lblDetails.Values.Image = ilDetails.Images[3];
                //My.Resources.DetailsMore
                
            }
            
        }

        private void lblDetails_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
            if (this.ShowFooter)
            {
                
                this.lblDetails.Values.Image = ilDetails.Images[1];
                //My.Resources.DetailsLessDown
                
            }
            else
            {
                
                this.lblDetails.Values.Image = ilDetails.Images[4];
                //My.Resources.DetailsMoreDown
                
            }
            
        }

        private void lblDetails_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
            if (this.ShowFooter)
            {
                
                this.lblDetails.Values.Image = ilDetails.Images[0];
                //My.Resources.DetailsLess
                
            }
            else
            {
                
                this.lblDetails.Values.Image = ilDetails.Images[3];
                //My.Resources.DetailsMore
                
            }
            
        }

        private void lblDetails_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
            if (this.ShowFooter)
            {
                
                this.ShowFooter = false;
                
            }
            else
            {
                
                this.ShowFooter = true;
                
            }
            
            this.ResizeForm();
            
        }
    }
}