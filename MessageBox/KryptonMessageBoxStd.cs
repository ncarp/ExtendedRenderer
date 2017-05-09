using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace AC.ExtendedRenderer.Toolkit
{
    [Obsolete("This class is obsolete, use ComponentFactory.Krypton.Toolkit.KryptonMessageBox instead.")]
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.Form))]
    public partial class KryptonMessageBoxStd : ComponentFactory.Krypton.Toolkit.KryptonForm
    {
        public KryptonMessageBoxStd()
        {
            InitializeComponent();
        }

        #region ... Show ...
        public static DialogResult Show(string Message)
        {
            return Show(Message, "");
        }

        public static DialogResult Show(object sender, string Message)
        {
            return Show(Message);
        }

        public static DialogResult Show(string Message, string Caption)
        {

            KryptonMessageBoxStd mb = new KryptonMessageBoxStd();

            mb.Text = Caption;
            mb.rtbMessage.Text = Message;
            mb.btnOK.Visible = true;
            //mb.btnOK.Text = AC.ExtendedRenderer.Toolkit.Properties.Resources.cptOK;
            mb.pbIcon.Visible = false;
            SystemSounds.Exclamation.Play();
            mb.ShowDialog();

            return mb.DialogResult;
        }

        public static DialogResult Show(object sender, string Message, string Caption)
        {
            return Show(Message, Caption);
        }

        public static DialogResult Show(string Message, string Caption, MessageBoxButtons Buttons)
        {
            return Show(Message, Caption, Buttons, MessageBoxIcon.None);
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

        public static DialogResult Show(string Message, string Caption, MessageBoxButtons Buttons, MessageBoxIcon Icon)
        {
            KryptonMessageBoxStd mb = new KryptonMessageBoxStd();

            mb.Text = Caption;
            mb.rtbMessage.Text = Message;
            switch (Buttons)
            {
                case MessageBoxButtons.AbortRetryIgnore:
                    mb.btnAbort.Visible = true;
                    mb.btnRetry.Visible = true;
                    mb.btnIgnore.Visible = true;
                    break;
                case MessageBoxButtons.OK:
                    mb.btnOK.Visible = true;
                    break;
                case MessageBoxButtons.OKCancel:
                    mb.btnOK.Visible = true;
                    mb.btnCancel.Visible = true;
                    mb.btnOK.Location = new Point(59, 14);
                    mb.btnCancel.Location = new Point(159, 14);
                    break;
                case MessageBoxButtons.RetryCancel:
                    mb.btnRetry.Visible = true;
                    mb.btnCancel.Visible = true;
                    mb.btnRetry.Location = new Point(59, 14);
                    mb.btnCancel.Location = new Point(159, 14);
                    break;
                case MessageBoxButtons.YesNo:
                    mb.btnYes.Visible = true;
                    mb.btnNo.Visible = true;
                    mb.btnYes.Location = new Point(59, 14);
                    mb.btnNo.Location = new Point(159, 14);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    mb.btnYes.Visible = true;
                    mb.btnNo.Visible = true;
                    mb.btnCancel.Visible = true;
                    break;
                default:
                    //this.btnOK.Visible = true;
                    break;
            }
            Point PIcon = new Point(mb.rtbMessage.Location.X, mb.rtbMessage.Location.Y);
            Size SIcon = new Size(mb.rtbMessage.Size.Width, mb.rtbMessage.Size.Height);

            switch (Icon)
            {
                case MessageBoxIcon.Asterisk:
                    mb.pbIcon.Image = SystemIcons.Asterisk.ToBitmap();
                    //mb.pbIcon.Image = mb.ilIcons.Images[0];
                    mb.rtbMessage.Location = new Point(mb.rtbMessage.Location.X + 63, mb.rtbMessage.Location.Y);
                    mb.rtbMessage.Width = mb.rtbMessage.Size.Width - 63;
                    SystemSounds.Asterisk.Play();
                    break;
                case MessageBoxIcon.Error:
                    mb.pbIcon.Image = SystemIcons.Error.ToBitmap();
                    //mb.pbIcon.Image = mb.ilIcons.Images[2];
                    mb.rtbMessage.Location = new Point(mb.rtbMessage.Location.X + 63, mb.rtbMessage.Location.Y);
                    mb.rtbMessage.Width = mb.rtbMessage.Size.Width - 63;
                    SystemSounds.Exclamation.Play();
                    break;
                case MessageBoxIcon.Exclamation:
                    mb.pbIcon.Image = SystemIcons.Exclamation.ToBitmap();
                    //mb.pbIcon.Image = mb.ilIcons.Images[3];
                    mb.rtbMessage.Location = new Point(mb.rtbMessage.Location.X + 63, mb.rtbMessage.Location.Y);
                    mb.rtbMessage.Width = mb.rtbMessage.Size.Width - 63;
                    SystemSounds.Exclamation.Play();
                    break;
                case MessageBoxIcon.None:
                    mb.pbIcon.Visible = false;
                    mb.pbIcon.Image = SystemIcons.Question.ToBitmap();
                    //SystemSounds.Exclamation.Play();
                    //pbIcon.Image = this.ilIcons.Images[0];
                    //rtbMessage.Location = new Point(rtbMessage.Location.X + 63,rtbMessage.Location.Y);
                    //this.rtbMessage..Width = rtbMessage.Size.Width - 63;
                    break;
                case MessageBoxIcon.Question:
                    mb.pbIcon.Image = SystemIcons.Question.ToBitmap();
                    //mb.pbIcon.Image = mb.ilIcons.Images[1];
                    mb.rtbMessage.Location = new Point(mb.rtbMessage.Location.X + 63, mb.rtbMessage.Location.Y);
                    mb.rtbMessage.Width = mb.rtbMessage.Size.Width - 63;
                    SystemSounds.Question.Play();
                    break;
                default:
                    //this.btnOK.Visible = true;
                    break;
            }
            mb.ShowDialog();
            mb.rtbMessage.Location = PIcon;
            mb.rtbMessage.Size = SIcon;
            //mb.pbIcon.Image = null;
            mb.ResetButtonsLocation();

            return mb.DialogResult;
        }

        #endregion

        #region ... Buttons Click ...


        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Ignore;
            this.Close();
        }
        #endregion

        #region ... Reset Things ...
        private void ResetButtonsLocation()
        {

            //reset location
            this.btnYes.Location = new Point(3, 14);
            this.btnNo.Location = new Point(98, 14);
            this.btnCancel.Location = new Point(193, 14);

            this.btnOK.Location = new Point(98, 14);

            this.btnAbort.Location = new Point(3, 14);
            this.btnRetry.Location = new Point(98, 14);
            this.btnIgnore.Location = new Point(193, 14);

            //reset visibility
            this.btnYes.Visible = false;
            this.btnNo.Visible = false;
            this.btnCancel.Visible = false;

            this.btnOK.Visible = false;

            this.btnAbort.Visible = false;
            this.btnRetry.Visible = false;
            this.btnIgnore.Visible = false;

            this.pbIcon.Visible = true;
            this.pbIcon.Image = this.ilIcons.Images[5];


        }
        #endregion

    }
}