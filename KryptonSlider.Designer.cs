namespace AC.ExtendedRenderer.Toolkit
{
    partial class KryptonSlider
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kplus = new AC.ExtendedRenderer.Toolkit.KryptonSliderButton();
            this.kminus = new AC.ExtendedRenderer.Toolkit.KryptonSliderButton();
            this.SuspendLayout();
            // 
            // kplus
            // 
            this.kplus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kplus.BackColor = System.Drawing.Color.Transparent;
            this.kplus.ButtonStyle = AC.ExtendedRenderer.Toolkit.KryptonSliderButton.ButtonStyles.PlusButton;
            this.kplus.EventFireRate = 200;
            this.kplus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kplus.Location = new System.Drawing.Point(124, 0);
            this.kplus.Name = "kplus";
            this.kplus.Orientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top;
            this.kplus.SingleClick = false;
            this.kplus.Size = new System.Drawing.Size(16, 16);
            this.kplus.TabIndex = 1;
            this.kplus.VisualLook = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kplus.SliderButtonFire += new AC.ExtendedRenderer.Toolkit.KryptonSliderButton.SliderButtonFireEventHandler(this.kplus_SliderButtonFire);
            // 
            // kminus
            // 
            this.kminus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kminus.BackColor = System.Drawing.Color.Transparent;
            this.kminus.ButtonStyle = AC.ExtendedRenderer.Toolkit.KryptonSliderButton.ButtonStyles.MinusButton;
            this.kminus.EventFireRate = 200;
            this.kminus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kminus.Location = new System.Drawing.Point(0, 0);
            this.kminus.Name = "kminus";
            this.kminus.Orientation = ComponentFactory.Krypton.Toolkit.VisualOrientation.Top;
            this.kminus.SingleClick = false;
            this.kminus.Size = new System.Drawing.Size(16, 16);
            this.kminus.TabIndex = 0;
            this.kminus.VisualLook = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kminus.SliderButtonFire += new AC.ExtendedRenderer.Toolkit.KryptonSliderButton.SliderButtonFireEventHandler(this.kminus_SliderButtonFire);
            // 
            // KryptonSlider
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.kplus);
            this.Controls.Add(this.kminus);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KryptonSlider";
            this.Size = new System.Drawing.Size(140, 16);
            this.MouseLeave += new System.EventHandler(this.KryptonSliderButton_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.KryptonSlider_MouseMove);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KryptonSliderButton_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.KryptonSliderButton_MouseUp);
            this.MouseEnter += new System.EventHandler(this.KryptonSliderButton_MouseEnter);
            this.ResumeLayout(false);

        }
        internal KryptonSliderButton kminus;
        internal KryptonSliderButton kplus;


        #endregion
    }
}
