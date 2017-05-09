namespace AC.ExtendedRenderer.Toolkit
{
    partial class KryptonMessageBoxStd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonMessageBoxStd));
            this.btnOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnIgnore = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAbort = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnRetry = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnYes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnNo = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rtbMessage = new System.Windows.Forms.Label();
            this.ilIcons = new System.Windows.Forms.ImageList(this.components);
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(99, 14);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 25);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.Values.ExtraText = "";
            this.btnOK.Values.Image = null;
            this.btnOK.Values.ImageStates.ImageCheckedNormal = null;
            this.btnOK.Values.ImageStates.ImageCheckedPressed = null;
            this.btnOK.Values.ImageStates.ImageCheckedTracking = null;
            this.btnOK.Values.Text = "OK";
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnIgnore
            // 
            this.btnIgnore.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnIgnore.Location = new System.Drawing.Point(194, 14);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(90, 25);
            this.btnIgnore.TabIndex = 2;
            this.btnIgnore.Text = "Ignore";
            this.btnIgnore.Values.ExtraText = "";
            this.btnIgnore.Values.Image = null;
            this.btnIgnore.Values.ImageStates.ImageCheckedNormal = null;
            this.btnIgnore.Values.ImageStates.ImageCheckedPressed = null;
            this.btnIgnore.Values.ImageStates.ImageCheckedTracking = null;
            this.btnIgnore.Values.Text = "Ignore";
            this.btnIgnore.Visible = false;
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnAbort.Location = new System.Drawing.Point(4, 14);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(90, 25);
            this.btnAbort.TabIndex = 3;
            this.btnAbort.Text = "Abort";
            this.btnAbort.Values.ExtraText = "";
            this.btnAbort.Values.Image = null;
            this.btnAbort.Values.ImageStates.ImageCheckedNormal = null;
            this.btnAbort.Values.ImageStates.ImageCheckedPressed = null;
            this.btnAbort.Values.ImageStates.ImageCheckedTracking = null;
            this.btnAbort.Values.Text = "Abort";
            this.btnAbort.Visible = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnRetry.Location = new System.Drawing.Point(99, 14);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(90, 25);
            this.btnRetry.TabIndex = 4;
            this.btnRetry.Text = "Retry";
            this.btnRetry.Values.ExtraText = "";
            this.btnRetry.Values.Image = null;
            this.btnRetry.Values.ImageStates.ImageCheckedNormal = null;
            this.btnRetry.Values.ImageStates.ImageCheckedPressed = null;
            this.btnRetry.Values.ImageStates.ImageCheckedTracking = null;
            this.btnRetry.Values.Text = "Retry";
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnYes
            // 
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Location = new System.Drawing.Point(4, 14);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(90, 25);
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "Yes";
            this.btnYes.Values.ExtraText = "";
            this.btnYes.Values.Image = null;
            this.btnYes.Values.ImageStates.ImageCheckedNormal = null;
            this.btnYes.Values.ImageStates.ImageCheckedPressed = null;
            this.btnYes.Values.ImageStates.ImageCheckedTracking = null;
            this.btnYes.Values.Text = "Yes";
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Location = new System.Drawing.Point(99, 14);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(90, 25);
            this.btnNo.TabIndex = 6;
            this.btnNo.Text = "No";
            this.btnNo.Values.ExtraText = "";
            this.btnNo.Values.Image = null;
            this.btnNo.Values.ImageStates.ImageCheckedNormal = null;
            this.btnNo.Values.ImageStates.ImageCheckedPressed = null;
            this.btnNo.Values.ImageStates.ImageCheckedTracking = null;
            this.btnNo.Values.Text = "No";
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(194, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Values.ExtraText = "";
            this.btnCancel.Values.Image = null;
            this.btnCancel.Values.ImageStates.ImageCheckedNormal = null;
            this.btnCancel.Values.ImageStates.ImageCheckedPressed = null;
            this.btnCancel.Values.ImageStates.ImageCheckedTracking = null;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(12, 2);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(266, 72);
            this.rtbMessage.TabIndex = 8;
            this.rtbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ilIcons
            // 
            this.ilIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilIcons.ImageStream")));
            this.ilIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilIcons.Images.SetKeyName(0, "Information.png");
            this.ilIcons.Images.SetKeyName(1, "Question.png");
            this.ilIcons.Images.SetKeyName(2, "Error.png");
            this.ilIcons.Images.SetKeyName(3, "Warning.png");
            this.ilIcons.Images.SetKeyName(4, "Stop.png");
            this.ilIcons.Images.SetKeyName(5, "empty.png");
            // 
            // pbIcon
            // 
            this.pbIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbIcon.InitialImage")));
            this.pbIcon.Location = new System.Drawing.Point(30, 22);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(32, 32);
            this.pbIcon.TabIndex = 9;
            this.pbIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.btnIgnore);
            this.panel1.Controls.Add(this.btnYes);
            this.panel1.Controls.Add(this.btnAbort);
            this.panel1.Controls.Add(this.btnRetry);
            this.panel1.Controls.Add(this.btnNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 52);
            this.panel1.TabIndex = 10;
            // 
            // KryptonMessageBoxStd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 129);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.rtbMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonMessageBoxStd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KryptonMessageBoxStd";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilIcons;
        private System.Windows.Forms.Panel panel1;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnOK;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnIgnore;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnAbort;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnRetry;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnYes;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnNo;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
        public System.Windows.Forms.Label rtbMessage;
        public System.Windows.Forms.PictureBox pbIcon;
    }
}