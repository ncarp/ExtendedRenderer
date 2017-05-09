using ComponentFactory.Krypton.Toolkit;

namespace AC.ExtendedRenderer.Toolkit
{
    partial class KryptonMessageBox 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KryptonMessageBox));
            this.KryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.PanelBottom = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlFooter = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblFooter = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.pnlFooterImage = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.boxFooterImage = new System.Windows.Forms.PictureBox();
            this.Button1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlDetails = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblDetails = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Button2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ilDetails = new System.Windows.Forms.ImageList(this.components);
            this.BorderBottom = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            this.Button3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnlHeader = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblHeader = new ComponentFactory.Krypton.Toolkit.KryptonWrapLabel();
            this.pnlButtons = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.PanelTop = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlHeaderImage = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.boxHeaderImage = new System.Windows.Forms.PictureBox();
            this.PanelMiddle = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.BorderTop = new ComponentFactory.Krypton.Toolkit.KryptonBorderEdge();
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFooter)).BeginInit();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFooterImage)).BeginInit();
            this.pnlFooterImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxFooterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetails)).BeginInit();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).BeginInit();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).BeginInit();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeaderImage)).BeginInit();
            this.pnlHeaderImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxHeaderImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMiddle)).BeginInit();
            this.PanelMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.pnlFooter);
            this.PanelBottom.Controls.Add(this.pnlFooterImage);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBottom.Location = new System.Drawing.Point(0, 99);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(355, 40);
            this.PanelBottom.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.PanelBottom.TabIndex = 8;
            // 
            // pnlFooter
            // 
            this.pnlFooter.AutoSize = true;
            this.pnlFooter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Location = new System.Drawing.Point(26, 0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(10);
            this.pnlFooter.Size = new System.Drawing.Size(120, 33);
            this.pnlFooter.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pnlFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = false;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lblFooter.Location = new System.Drawing.Point(10, 10);
            this.lblFooter.Margin = new System.Windows.Forms.Padding(0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(100, 13);
            this.lblFooter.Text = "Footer";
            // 
            // pnlFooterImage
            // 
            this.pnlFooterImage.AutoSize = true;
            this.pnlFooterImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFooterImage.Controls.Add(this.boxFooterImage);
            this.pnlFooterImage.Location = new System.Drawing.Point(0, 0);
            this.pnlFooterImage.Name = "pnlFooterImage";
            this.pnlFooterImage.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.pnlFooterImage.Size = new System.Drawing.Size(26, 36);
            this.pnlFooterImage.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pnlFooterImage.TabIndex = 1;
            this.pnlFooterImage.Visible = false;
            // 
            // boxFooterImage
            // 
            this.boxFooterImage.BackColor = System.Drawing.Color.Transparent;
            this.boxFooterImage.Location = new System.Drawing.Point(10, 10);
            this.boxFooterImage.Margin = new System.Windows.Forms.Padding(0);
            this.boxFooterImage.Name = "boxFooterImage";
            this.boxFooterImage.Size = new System.Drawing.Size(16, 16);
            this.boxFooterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxFooterImage.TabIndex = 1;
            this.boxFooterImage.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(10, 10);
            this.Button1.Margin = new System.Windows.Forms.Padding(0);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 25);
            this.Button1.TabIndex = 1;
            this.Button1.Values.Text = "Button1";
            this.Button1.Visible = false;
            // 
            // pnlDetails
            // 
            this.pnlDetails.AutoSize = true;
            this.pnlDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDetails.Controls.Add(this.lblDetails);
            this.pnlDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.pnlDetails.Size = new System.Drawing.Size(85, 45);
            this.pnlDetails.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pnlDetails.TabIndex = 0;
            this.pnlDetails.Visible = false;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = false;
            this.lblDetails.Location = new System.Drawing.Point(10, 10);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(75, 25);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Values.Text = "Details";
            this.lblDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblDetails_MouseClick);
            this.lblDetails.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblDetails_MouseDown);
            this.lblDetails.MouseEnter += new System.EventHandler(this.lblDetails_MouseEnter);
            this.lblDetails.MouseLeave += new System.EventHandler(this.lblDetails_MouseLeave);
            this.lblDetails.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblDetails_MouseUp);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(95, 10);
            this.Button2.Margin = new System.Windows.Forms.Padding(0);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 25);
            this.Button2.TabIndex = 2;
            this.Button2.Values.Text = "Button2";
            this.Button2.Visible = false;
            // 
            // ilDetails
            // 
            this.ilDetails.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilDetails.ImageStream")));
            this.ilDetails.TransparentColor = System.Drawing.Color.Transparent;
            this.ilDetails.Images.SetKeyName(0, "DetailsLess.png");
            this.ilDetails.Images.SetKeyName(1, "DetailsLessDown.png");
            this.ilDetails.Images.SetKeyName(2, "DetailsLessHover.png");
            this.ilDetails.Images.SetKeyName(3, "DetailsMore.png");
            this.ilDetails.Images.SetKeyName(4, "DetailsMoreDown.png");
            this.ilDetails.Images.SetKeyName(5, "DetailsMoreHover.png");
            // 
            // BorderBottom
            // 
            this.BorderBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderBottom.Location = new System.Drawing.Point(0, 1);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(355, 1);
            this.BorderBottom.StateCommon.Color1 = System.Drawing.Color.LightGray;
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(180, 10);
            this.Button3.Margin = new System.Windows.Forms.Padding(0);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 25);
            this.Button3.TabIndex = 3;
            this.Button3.Values.Text = "Button3";
            this.Button3.Visible = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.AutoSize = true;
            this.pnlHeader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Location = new System.Drawing.Point(42, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(10);
            this.pnlHeader.Size = new System.Drawing.Size(120, 33);
            this.pnlHeader.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = false;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.lblHeader.Location = new System.Drawing.Point(10, 10);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(100, 13);
            this.lblHeader.Text = "Header";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.Button3);
            this.pnlButtons.Controls.Add(this.Button2);
            this.pnlButtons.Controls.Add(this.Button1);
            this.pnlButtons.Location = new System.Drawing.Point(85, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(10);
            this.pnlButtons.Size = new System.Drawing.Size(265, 45);
            this.pnlButtons.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pnlButtons.TabIndex = 0;
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.pnlHeader);
            this.PanelTop.Controls.Add(this.pnlHeaderImage);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(355, 52);
            this.PanelTop.StateCommon.Color1 = System.Drawing.Color.White;
            this.PanelTop.TabIndex = 6;
            // 
            // pnlHeaderImage
            // 
            this.pnlHeaderImage.AutoSize = true;
            this.pnlHeaderImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHeaderImage.Controls.Add(this.boxHeaderImage);
            this.pnlHeaderImage.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderImage.Name = "pnlHeaderImage";
            this.pnlHeaderImage.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.pnlHeaderImage.Size = new System.Drawing.Size(42, 52);
            this.pnlHeaderImage.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pnlHeaderImage.TabIndex = 0;
            this.pnlHeaderImage.Visible = false;
            // 
            // boxHeaderImage
            // 
            this.boxHeaderImage.BackColor = System.Drawing.Color.Transparent;
            this.boxHeaderImage.Location = new System.Drawing.Point(10, 10);
            this.boxHeaderImage.Margin = new System.Windows.Forms.Padding(0);
            this.boxHeaderImage.Name = "boxHeaderImage";
            this.boxHeaderImage.Size = new System.Drawing.Size(32, 32);
            this.boxHeaderImage.TabIndex = 1;
            this.boxHeaderImage.TabStop = false;
            // 
            // PanelMiddle
            // 
            this.PanelMiddle.Controls.Add(this.pnlDetails);
            this.PanelMiddle.Controls.Add(this.pnlButtons);
            this.PanelMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMiddle.Location = new System.Drawing.Point(0, 54);
            this.PanelMiddle.Name = "PanelMiddle";
            this.PanelMiddle.Size = new System.Drawing.Size(355, 45);
            this.PanelMiddle.StateCommon.Color1 = System.Drawing.Color.WhiteSmoke;
            this.PanelMiddle.TabIndex = 7;
            // 
            // BorderTop
            // 
            this.BorderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderTop.Location = new System.Drawing.Point(0, 0);
            this.BorderTop.Name = "BorderTop";
            this.BorderTop.Size = new System.Drawing.Size(355, 1);
            this.BorderTop.StateCommon.Color1 = System.Drawing.Color.LightGray;
            // 
            // KryptonMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 156);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelMiddle);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.BorderBottom);
            this.Controls.Add(this.BorderTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KryptonMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KryptonMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.PanelBottom)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFooter)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFooterImage)).EndInit();
            this.pnlFooterImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxFooterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetails)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeader)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelTop)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHeaderImage)).EndInit();
            this.pnlHeaderImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxHeaderImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMiddle)).EndInit();
            this.PanelMiddle.ResumeLayout(false);
            this.PanelMiddle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal ComponentFactory.Krypton.Toolkit.KryptonManager KryptonManager;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel PanelBottom;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel pnlFooter;
        internal ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblFooter;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel pnlFooterImage;
        internal System.Windows.Forms.PictureBox boxFooterImage;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton Button1;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel pnlDetails;
        internal ComponentFactory.Krypton.Toolkit.KryptonLabel lblDetails;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton Button2;
        internal System.Windows.Forms.ImageList ilDetails;
        internal ComponentFactory.Krypton.Toolkit.KryptonBorderEdge BorderBottom;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton Button3;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel pnlHeader;
        internal ComponentFactory.Krypton.Toolkit.KryptonWrapLabel lblHeader;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel pnlButtons;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel PanelTop;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel pnlHeaderImage;
        internal System.Windows.Forms.PictureBox boxHeaderImage;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel PanelMiddle;
        internal ComponentFactory.Krypton.Toolkit.KryptonBorderEdge BorderTop;



    }
}