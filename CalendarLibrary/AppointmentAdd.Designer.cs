using System.Windows.Forms;
using System;

namespace AC.ExtendedRenderer.Toolkit.CalendarLibrary
{
    partial class AppointmentAdd
    {

    // Define the CS_DROPSHADOW constant
    private const int CS_DROPSHADOW = 0x00020000;

    // Override the CreateParams property
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ClassStyle |= CS_DROPSHADOW;
            return cp;
        }
    }

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
            this.kryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtColor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.endHour = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.endMinute = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtKey = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.datePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.label1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.label2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.tentativeCheckBox = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.label3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.descriptionTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.addItem = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.startMinute = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.startHour = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).BeginInit();
            this.kryptonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel
            // 
            this.kryptonPanel.Controls.Add(this.lblDate);
            this.kryptonPanel.Controls.Add(this.txtColor);
            this.kryptonPanel.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel.Controls.Add(this.endHour);
            this.kryptonPanel.Controls.Add(this.endMinute);
            this.kryptonPanel.Controls.Add(this.txtKey);
            this.kryptonPanel.Controls.Add(this.label5);
            this.kryptonPanel.Controls.Add(this.datePicker);
            this.kryptonPanel.Controls.Add(this.label1);
            this.kryptonPanel.Controls.Add(this.label2);
            this.kryptonPanel.Controls.Add(this.tentativeCheckBox);
            this.kryptonPanel.Controls.Add(this.label3);
            this.kryptonPanel.Controls.Add(this.descriptionTextBox);
            this.kryptonPanel.Controls.Add(this.addItem);
            this.kryptonPanel.Controls.Add(this.startMinute);
            this.kryptonPanel.Controls.Add(this.startHour);
            this.kryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel.Name = "kryptonPanel";
            this.kryptonPanel.Size = new System.Drawing.Size(608, 88);
            this.kryptonPanel.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(12, 8);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 20);
            this.lblDate.TabIndex = 39;
            this.lblDate.Values.Text = "Date:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(155, 60);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(202, 20);
            this.txtColor.TabIndex = 38;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(106, 60);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(43, 20);
            this.kryptonLabel1.TabIndex = 37;
            this.kryptonLabel1.Values.Text = "Color:";
            // 
            // endHour
            // 
            this.endHour.Location = new System.Drawing.Point(420, 8);
            this.endHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.endHour.Name = "endHour";
            this.endHour.Size = new System.Drawing.Size(46, 22);
            this.endHour.TabIndex = 32;
            // 
            // endMinute
            // 
            this.endMinute.DropDownWidth = 40;
            this.endMinute.FormattingEnabled = true;
            this.endMinute.Items.AddRange(new object[] {
            "00",
            "30"});
            this.endMinute.Location = new System.Drawing.Point(476, 9);
            this.endMinute.Name = "endMinute";
            this.endMinute.Size = new System.Drawing.Size(40, 21);
            this.endMinute.TabIndex = 33;
            this.endMinute.Text = "00";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(402, 60);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(114, 20);
            this.txtKey.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(363, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 35;
            this.label5.Values.Text = "Key:";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(57, 7);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(114, 21);
            this.datePicker.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(177, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 25;
            this.label1.Values.Text = "Start Time:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(350, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 26;
            this.label2.Values.Text = "End Time:";
            // 
            // tentativeCheckBox
            // 
            this.tentativeCheckBox.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.tentativeCheckBox.Location = new System.Drawing.Point(12, 60);
            this.tentativeCheckBox.Name = "tentativeCheckBox";
            this.tentativeCheckBox.Size = new System.Drawing.Size(79, 20);
            this.tentativeCheckBox.TabIndex = 34;
            this.tentativeCheckBox.Text = "Tentative?";
            this.tentativeCheckBox.Values.Text = "Tentative?";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 27;
            this.label3.Values.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(106, 36);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(410, 20);
            this.descriptionTextBox.TabIndex = 28;
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(522, 8);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(78, 72);
            this.addItem.TabIndex = 29;
            this.addItem.Values.Text = "Add Item";
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // startMinute
            // 
            this.startMinute.DropDownWidth = 40;
            this.startMinute.FormattingEnabled = true;
            this.startMinute.Items.AddRange(new object[] {
            "00",
            "30"});
            this.startMinute.Location = new System.Drawing.Point(304, 9);
            this.startMinute.Name = "startMinute";
            this.startMinute.Size = new System.Drawing.Size(40, 21);
            this.startMinute.TabIndex = 31;
            this.startMinute.Text = "00";
            // 
            // startHour
            // 
            this.startHour.Location = new System.Drawing.Point(252, 8);
            this.startHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.startHour.Name = "startHour";
            this.startHour.Size = new System.Drawing.Size(46, 22);
            this.startHour.TabIndex = 30;
            this.startHour.ValueChanged += new System.EventHandler(this.startHour_ValueChanged);
            // 
            // AppointmentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 88);
            this.Controls.Add(this.kryptonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AppointmentAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Appointment Add";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel)).EndInit();
            this.kryptonPanel.ResumeLayout(false);
            this.kryptonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtColor;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown endHour;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox endMinute;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtKey;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label5;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker datePicker;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label2;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox tentativeCheckBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox descriptionTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton addItem;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox startMinute;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown startHour;
    }
}

