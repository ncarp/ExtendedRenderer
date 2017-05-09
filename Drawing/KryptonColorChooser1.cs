using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace AC.ExtendedRenderer.Toolkit.Drawing
{
  /// <summary>
  /// Summary description for ColorChooser1.
  /// </summary>
[System.Drawing.ToolboxBitmapAttribute(typeof(System.Windows.Forms.Form))]
  public class KryptonColorChooser1 : ComponentFactory.Krypton.Toolkit.KryptonForm
  {
    internal ComponentFactory.Krypton.Toolkit.KryptonButton btnCancel;
    internal ComponentFactory.Krypton.Toolkit.KryptonButton btnOK;
    internal System.Windows.Forms.Label Label3;
    internal System.Windows.Forms.NumericUpDown nudSaturation;
    internal System.Windows.Forms.Label Label7;
    internal System.Windows.Forms.NumericUpDown nudBrightness;
    internal System.Windows.Forms.NumericUpDown nudRed;
    internal System.Windows.Forms.Panel pnlColor;
    internal System.Windows.Forms.Label Label6;
    internal System.Windows.Forms.Label Label1;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.Panel pnlSelectedColor;
    internal System.Windows.Forms.Panel pnlBrightness;
    internal System.Windows.Forms.NumericUpDown nudBlue;
    internal System.Windows.Forms.Label Label4;
    internal System.Windows.Forms.NumericUpDown nudGreen;
    internal System.Windows.Forms.Label Label2;
    internal System.Windows.Forms.NumericUpDown nudHue;
      private TextBox txtWebColor;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    public KryptonColorChooser1()
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();

      //
      // TODO: Add any constructor code after InitializeComponent call
      //
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if(components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose( disposing );
    }

		#region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.btnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
        this.btnOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
        this.Label3 = new System.Windows.Forms.Label();
        this.nudSaturation = new System.Windows.Forms.NumericUpDown();
        this.Label7 = new System.Windows.Forms.Label();
        this.nudBrightness = new System.Windows.Forms.NumericUpDown();
        this.nudRed = new System.Windows.Forms.NumericUpDown();
        this.pnlColor = new System.Windows.Forms.Panel();
        this.Label6 = new System.Windows.Forms.Label();
        this.Label1 = new System.Windows.Forms.Label();
        this.Label5 = new System.Windows.Forms.Label();
        this.pnlSelectedColor = new System.Windows.Forms.Panel();
        this.pnlBrightness = new System.Windows.Forms.Panel();
        this.nudBlue = new System.Windows.Forms.NumericUpDown();
        this.Label4 = new System.Windows.Forms.Label();
        this.nudGreen = new System.Windows.Forms.NumericUpDown();
        this.Label2 = new System.Windows.Forms.Label();
        this.nudHue = new System.Windows.Forms.NumericUpDown();
        this.txtWebColor = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)(this.nudSaturation)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudHue)).BeginInit();
        this.SuspendLayout();
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnCancel.Location = new System.Drawing.Point(192, 320);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(64, 24);
        this.btnCancel.TabIndex = 55;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.Values.ExtraText = "";
        this.btnCancel.Values.Image = null;
        this.btnCancel.Values.ImageStates.ImageCheckedNormal = null;
        this.btnCancel.Values.ImageStates.ImageCheckedPressed = null;
        this.btnCancel.Values.ImageStates.ImageCheckedTracking = null;
        this.btnCancel.Values.Text = "Cancel";
        // 
        // btnOK
        // 
        this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.btnOK.Location = new System.Drawing.Point(120, 320);
        this.btnOK.Name = "btnOK";
        this.btnOK.Size = new System.Drawing.Size(64, 24);
        this.btnOK.TabIndex = 54;
        this.btnOK.Text = "OK";
        this.btnOK.Values.ExtraText = "";
        this.btnOK.Values.Image = null;
        this.btnOK.Values.ImageStates.ImageCheckedNormal = null;
        this.btnOK.Values.ImageStates.ImageCheckedPressed = null;
        this.btnOK.Values.ImageStates.ImageCheckedTracking = null;
        this.btnOK.Values.Text = "OK";
        // 
        // Label3
        // 
        this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Label3.Location = new System.Drawing.Point(152, 280);
        this.Label3.Name = "Label3";
        this.Label3.Size = new System.Drawing.Size(48, 23);
        this.Label3.TabIndex = 45;
        this.Label3.Text = "Blue:";
        this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // nudSaturation
        // 
        this.nudSaturation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.nudSaturation.Location = new System.Drawing.Point(96, 256);
        this.nudSaturation.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
        this.nudSaturation.Name = "nudSaturation";
        this.nudSaturation.Size = new System.Drawing.Size(48, 22);
        this.nudSaturation.TabIndex = 42;
        this.nudSaturation.ValueChanged += new System.EventHandler(this.HandleHSVChange);
        this.nudSaturation.TextChanged += new System.EventHandler(this.HandleTextChanged);
        // 
        // Label7
        // 
        this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Label7.Location = new System.Drawing.Point(16, 280);
        this.Label7.Name = "Label7";
        this.Label7.Size = new System.Drawing.Size(72, 23);
        this.Label7.TabIndex = 50;
        this.Label7.Text = "Brightness:";
        this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // nudBrightness
        // 
        this.nudBrightness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.nudBrightness.Location = new System.Drawing.Point(96, 280);
        this.nudBrightness.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
        this.nudBrightness.Name = "nudBrightness";
        this.nudBrightness.Size = new System.Drawing.Size(48, 22);
        this.nudBrightness.TabIndex = 47;
        this.nudBrightness.ValueChanged += new System.EventHandler(this.HandleHSVChange);
        this.nudBrightness.TextChanged += new System.EventHandler(this.HandleTextChanged);
        // 
        // nudRed
        // 
        this.nudRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.nudRed.Location = new System.Drawing.Point(208, 232);
        this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
        this.nudRed.Name = "nudRed";
        this.nudRed.Size = new System.Drawing.Size(48, 22);
        this.nudRed.TabIndex = 38;
        this.nudRed.ValueChanged += new System.EventHandler(this.HandleRGBChange);
        this.nudRed.TextChanged += new System.EventHandler(this.HandleTextChanged);
        // 
        // pnlColor
        // 
        this.pnlColor.Location = new System.Drawing.Point(8, 8);
        this.pnlColor.Name = "pnlColor";
        this.pnlColor.Size = new System.Drawing.Size(176, 176);
        this.pnlColor.TabIndex = 51;
        this.pnlColor.Visible = false;
        this.pnlColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
        // 
        // Label6
        // 
        this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Label6.Location = new System.Drawing.Point(16, 256);
        this.Label6.Name = "Label6";
        this.Label6.Size = new System.Drawing.Size(72, 23);
        this.Label6.TabIndex = 49;
        this.Label6.Text = "Saturation:";
        this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // Label1
        // 
        this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Label1.Location = new System.Drawing.Point(152, 232);
        this.Label1.Name = "Label1";
        this.Label1.Size = new System.Drawing.Size(48, 23);
        this.Label1.TabIndex = 43;
        this.Label1.Text = "Red:";
        this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // Label5
        // 
        this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Label5.Location = new System.Drawing.Point(16, 232);
        this.Label5.Name = "Label5";
        this.Label5.Size = new System.Drawing.Size(72, 23);
        this.Label5.TabIndex = 48;
        this.Label5.Text = "Hue:";
        this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // pnlSelectedColor
        // 
        this.pnlSelectedColor.Location = new System.Drawing.Point(136, 203);
        this.pnlSelectedColor.Name = "pnlSelectedColor";
        this.pnlSelectedColor.Size = new System.Drawing.Size(48, 20);
        this.pnlSelectedColor.TabIndex = 53;
        this.pnlSelectedColor.Visible = false;
        // 
        // pnlBrightness
        // 
        this.pnlBrightness.Location = new System.Drawing.Point(208, 8);
        this.pnlBrightness.Name = "pnlBrightness";
        this.pnlBrightness.Size = new System.Drawing.Size(16, 176);
        this.pnlBrightness.TabIndex = 52;
        this.pnlBrightness.Visible = false;
        // 
        // nudBlue
        // 
        this.nudBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.nudBlue.Location = new System.Drawing.Point(208, 280);
        this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
        this.nudBlue.Name = "nudBlue";
        this.nudBlue.Size = new System.Drawing.Size(48, 22);
        this.nudBlue.TabIndex = 40;
        this.nudBlue.ValueChanged += new System.EventHandler(this.HandleRGBChange);
        this.nudBlue.TextChanged += new System.EventHandler(this.HandleTextChanged);
        // 
        // Label4
        // 
        this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Label4.Location = new System.Drawing.Point(82, 203);
        this.Label4.Name = "Label4";
        this.Label4.Size = new System.Drawing.Size(48, 20);
        this.Label4.TabIndex = 46;
        this.Label4.Text = "Color:";
        this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // nudGreen
        // 
        this.nudGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.nudGreen.Location = new System.Drawing.Point(208, 256);
        this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
        this.nudGreen.Name = "nudGreen";
        this.nudGreen.Size = new System.Drawing.Size(48, 22);
        this.nudGreen.TabIndex = 39;
        this.nudGreen.ValueChanged += new System.EventHandler(this.HandleRGBChange);
        this.nudGreen.TextChanged += new System.EventHandler(this.HandleTextChanged);
        // 
        // Label2
        // 
        this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.Label2.Location = new System.Drawing.Point(152, 256);
        this.Label2.Name = "Label2";
        this.Label2.Size = new System.Drawing.Size(48, 23);
        this.Label2.TabIndex = 44;
        this.Label2.Text = "Green:";
        this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // nudHue
        // 
        this.nudHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.nudHue.Location = new System.Drawing.Point(96, 232);
        this.nudHue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
        this.nudHue.Name = "nudHue";
        this.nudHue.Size = new System.Drawing.Size(48, 22);
        this.nudHue.TabIndex = 41;
        this.nudHue.ValueChanged += new System.EventHandler(this.HandleHSVChange);
        this.nudHue.TextChanged += new System.EventHandler(this.HandleTextChanged);
        // 
        // txtWebColor
        // 
        this.txtWebColor.Location = new System.Drawing.Point(190, 203);
        this.txtWebColor.Name = "txtWebColor";
        this.txtWebColor.Size = new System.Drawing.Size(66, 20);
        this.txtWebColor.TabIndex = 56;
        // 
        // KryptonColorChooser1
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(264, 349);
        this.Controls.Add(this.txtWebColor);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnOK);
        this.Controls.Add(this.Label3);
        this.Controls.Add(this.nudSaturation);
        this.Controls.Add(this.Label7);
        this.Controls.Add(this.nudBrightness);
        this.Controls.Add(this.nudRed);
        this.Controls.Add(this.pnlColor);
        this.Controls.Add(this.Label6);
        this.Controls.Add(this.Label1);
        this.Controls.Add(this.Label5);
        this.Controls.Add(this.pnlSelectedColor);
        this.Controls.Add(this.pnlBrightness);
        this.Controls.Add(this.nudBlue);
        this.Controls.Add(this.Label4);
        this.Controls.Add(this.nudGreen);
        this.Controls.Add(this.Label2);
        this.Controls.Add(this.nudHue);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "KryptonColorChooser1";
        this.Text = "Select Color";
        this.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorChooser1_Paint);
        this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
        this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HandleMouse);
        this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleMouse);
        this.Load += new System.EventHandler(this.ColorChooser1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.nudSaturation)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudHue)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }
		#endregion

    private enum ChangeStyle
    {
      MouseMove,
      RGB,
      HSV,
      None
    }

    private ChangeStyle changeType = ChangeStyle.None;
    private Point selectedPoint;

    private ColorWheel myColorWheel;
    private ColorHandler.RGB RGB;
    private ColorHandler.HSV HSV;
    private bool isInUpdate = false;

    private void ColorChooser1_Load(object sender, System.EventArgs e)
    {
      // Turn on double-buffering, so the form looks better. 
      this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
      this.SetStyle(ControlStyles.UserPaint, true);
      this.SetStyle(ControlStyles.DoubleBuffer, true);


      // These properties are set in design view, as well, but they
      // have to be set to false in order for the Paint
      // event to be able to display their contents.
      // Never hurts to make sure they're invisible.
      pnlSelectedColor.Visible = false;
      pnlBrightness.Visible = false;
      pnlColor.Visible = false;

      // Calculate the coordinates of the three
      // required regions on the form.
      Rectangle SelectedColorRectangle =  
        new Rectangle(pnlSelectedColor.Location, pnlSelectedColor.Size);
      Rectangle BrightnessRectangle = 
        new Rectangle(pnlBrightness.Location, pnlBrightness.Size);
      Rectangle ColorRectangle = 
        new Rectangle(pnlColor.Location, pnlColor.Size);

      // Create the new ColorWheel class, indicating
      // the locations of the color wheel itself, the
      // brightness area, and the position of the selected color.
      myColorWheel = new ColorWheel(
        ColorRectangle, BrightnessRectangle, 
        SelectedColorRectangle);
      myColorWheel.ColorChanged += 
        new ColorWheel.ColorChangedEventHandler(
        this.myColorWheel_ColorChanged);

      // Set the RGB and HSV values 
      // of the NumericUpDown controls.
      SetRGB(RGB);
      SetHSV(HSV);		

    }

    private void HandleMouse(object sender,  MouseEventArgs e)
    {
      // If you have the left mouse button down, 
      // then update the selectedPoint value and 
      // force a repaint of the color wheel.
      if ( e.Button == MouseButtons.Left ) 
      {
        changeType = ChangeStyle.MouseMove;
        selectedPoint = new Point(e.X, e.Y);
        this.Invalidate();
      }
    }

    private void frmMain_MouseUp( object sender,  MouseEventArgs e)
    {
      myColorWheel.SetMouseUp();
      changeType = ChangeStyle.None;
    }

    private void HandleRGBChange(object sender,  System.EventArgs e)
    {

      // If the R, G, or B values change, use this 
      // code to update the HSV values and invalidate
      // the color wheel (so it updates the pointers).
      // Check the isInUpdate flag to avoid recursive events
      // when you update the NumericUpdownControls.
      if (!isInUpdate ) 
      {
        changeType = ChangeStyle.RGB;
        RGB = new ColorHandler.RGB((int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
        SetHSV(ColorHandler.RGBtoHSV(RGB));
        this.Invalidate();
      }
    }

    private void HandleHSVChange(  object sender,  EventArgs e)  
    {
      // If the H, S, or V values change, use this 
      // code to update the RGB values and invalidate
      // the color wheel (so it updates the pointers).
      // Check the isInUpdate flag to avoid recursive events
      // when you update the NumericUpdownControls.
      if (! isInUpdate ) 
      {
        changeType = ChangeStyle.HSV;
        HSV = new ColorHandler.HSV((int)(nudHue.Value), (int)(nudSaturation.Value), (int)(nudBrightness.Value));
        SetRGB(ColorHandler.HSVtoRGB(HSV));
        this.Invalidate();
      }
    }

    private void SetRGB( ColorHandler.RGB RGB) 
    {
      // Update the RGB values on the form, but don't trigger
      // the ValueChanged event of the form. The isInUpdate
      // variable ensures that the event procedures
      // exit without doing anything.
      isInUpdate = true;
      RefreshValue(nudRed, RGB.Red);
      RefreshValue(nudBlue, RGB.Blue);
      RefreshValue(nudGreen, RGB.Green);
      isInUpdate = false;
      this.txtWebColor.Text = ColorTranslator.ToHtml(Color.FromArgb(RGB.Red,RGB.Green,RGB.Blue)).ToString();
    }

    private void SetHSV(ColorHandler.HSV HSV) 
    {
      // Update the HSV values on the form, but don't trigger
      // the ValueChanged event of the form. The isInUpdate
      // variable ensures that the event procedures
      // exit without doing anything.
      isInUpdate = true;
      RefreshValue(nudHue, HSV.Hue);
      RefreshValue(nudSaturation, HSV.Saturation);
      RefreshValue(nudBrightness, HSV.value);
      isInUpdate = false;
    }

    private void HandleTextChanged(object sender, System.EventArgs e)
    {
      // This step works around a bug -- unless you actively
      // retrieve the value, the min and max settings for the 
      // control aren't honored when you type text. This may
      // be fixed in the 1.1 version, but in VS.NET 1.0, this 
      // step is required.
      Decimal x = ((NumericUpDown)sender).Value;
    }

    private void RefreshValue(  NumericUpDown nud,  int value) 
    {
      // Update the value of the NumericUpDown control, 
      // if the value is different than the current value.
      // Refresh the control, causing an immediate repaint.
      if ( nud.Value != value ) 
      {
        nud.Value = value;
        nud.Refresh();
      }
    }

    public Color Color  
    {
      // Get or set the color to be
      // displayed in the color wheel.
      get 
      {
        return myColorWheel.Color;
      }

      set 
      {
        // Indicate the color change type. Either RGB or HSV
        // will cause the color wheel to update the position
        // of the pointer.
        changeType = ChangeStyle.RGB;
        RGB = new ColorHandler.RGB(value.R, value.G, value.B);
        HSV = ColorHandler.RGBtoHSV(RGB);
      }
    }

    private void myColorWheel_ColorChanged(object sender,  ColorChangedEventArgs e)  
    {
      SetRGB(e.RGB);
      SetHSV(e.HSV);
      //this.txtWebColor.Text = ColorTranslator.ToHtml(Color).ToString();
    }

    private void ColorChooser1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
    {
      // Depending on the circumstances, force a repaint
      // of the color wheel passing different information.
      switch (changeType)
      {
        case ChangeStyle.HSV:
          myColorWheel.Draw(e.Graphics, HSV);
          break;
        case ChangeStyle.MouseMove:
        case ChangeStyle.None:
          myColorWheel.Draw(e.Graphics, selectedPoint);
          break;
        case ChangeStyle.RGB:
          myColorWheel.Draw(e.Graphics, RGB);
          break;
      }
    }
  }
}
