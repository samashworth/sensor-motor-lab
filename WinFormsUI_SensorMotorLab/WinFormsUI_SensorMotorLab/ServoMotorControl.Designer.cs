namespace WinFormsUI_SensorMotorLab
{
    partial class ServoMotorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._labelName = new System.Windows.Forms.Label();
            this._labelSensor = new System.Windows.Forms.Label();
            this._comboBoxSensor = new System.Windows.Forms.ComboBox();
            this._labelDirection = new System.Windows.Forms.Label();
            this._radioButtonCCW = new System.Windows.Forms.RadioButton();
            this._radioButtonCW = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this._radioButtonManual = new System.Windows.Forms.RadioButton();
            this._radioButtonSensor = new System.Windows.Forms.RadioButton();
            this._labelControl = new System.Windows.Forms.Label();
            this._groupBoxSensor = new System.Windows.Forms.GroupBox();
            this._buttonSensorControlSet = new System.Windows.Forms.Button();
            this._groupBoxManual = new System.Windows.Forms.GroupBox();
            this._buttonAngleSet = new System.Windows.Forms.Button();
            this._labelDegrees = new System.Windows.Forms.Label();
            this._textBoxSetAngle = new System.Windows.Forms.TextBox();
            this._labelSetAngle = new System.Windows.Forms.Label();
            this._labelSpeed = new System.Windows.Forms.Label();
            this._textBoxAngle = new System.Windows.Forms.TextBox();
            this._labelDegrees2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this._groupBoxSensor.SuspendLayout();
            this._groupBoxManual.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelName
            // 
            this._labelName.AutoSize = true;
            this._labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelName.Location = new System.Drawing.Point(3, 0);
            this._labelName.Name = "_labelName";
            this._labelName.Size = new System.Drawing.Size(103, 37);
            this._labelName.TabIndex = 0;
            this._labelName.Text = "Name";
            // 
            // _labelSensor
            // 
            this._labelSensor.AutoSize = true;
            this._labelSensor.Location = new System.Drawing.Point(9, 23);
            this._labelSensor.Name = "_labelSensor";
            this._labelSensor.Size = new System.Drawing.Size(95, 13);
            this._labelSensor.TabIndex = 1;
            this._labelSensor.Text = "Controlling Sensor:";
            // 
            // _comboBoxSensor
            // 
            this._comboBoxSensor.FormattingEnabled = true;
            this._comboBoxSensor.Location = new System.Drawing.Point(110, 20);
            this._comboBoxSensor.Name = "_comboBoxSensor";
            this._comboBoxSensor.Size = new System.Drawing.Size(121, 21);
            this._comboBoxSensor.TabIndex = 2;
            // 
            // _labelDirection
            // 
            this._labelDirection.AutoSize = true;
            this._labelDirection.Location = new System.Drawing.Point(38, 52);
            this._labelDirection.Name = "_labelDirection";
            this._labelDirection.Size = new System.Drawing.Size(52, 13);
            this._labelDirection.TabIndex = 3;
            this._labelDirection.Text = "Direction:";
            this._labelDirection.Visible = false;
            // 
            // _radioButtonCCW
            // 
            this._radioButtonCCW.AutoSize = true;
            this._radioButtonCCW.Checked = true;
            this._radioButtonCCW.Location = new System.Drawing.Point(3, 3);
            this._radioButtonCCW.Name = "_radioButtonCCW";
            this._radioButtonCCW.Size = new System.Drawing.Size(50, 17);
            this._radioButtonCCW.TabIndex = 4;
            this._radioButtonCCW.TabStop = true;
            this._radioButtonCCW.Text = "CCW";
            this._radioButtonCCW.UseVisualStyleBackColor = true;
            // 
            // _radioButtonCW
            // 
            this._radioButtonCW.AutoSize = true;
            this._radioButtonCW.Location = new System.Drawing.Point(59, 3);
            this._radioButtonCW.Name = "_radioButtonCW";
            this._radioButtonCW.Size = new System.Drawing.Size(43, 17);
            this._radioButtonCW.TabIndex = 5;
            this._radioButtonCW.Text = "CW";
            this._radioButtonCW.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._radioButtonCCW);
            this.panel1.Controls.Add(this._radioButtonCW);
            this.panel1.Location = new System.Drawing.Point(110, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 23);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._radioButtonManual);
            this.panel3.Controls.Add(this._radioButtonSensor);
            this.panel3.Location = new System.Drawing.Point(60, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(141, 23);
            this.panel3.TabIndex = 8;
            // 
            // _radioButtonManual
            // 
            this._radioButtonManual.AutoSize = true;
            this._radioButtonManual.Location = new System.Drawing.Point(3, 3);
            this._radioButtonManual.Name = "_radioButtonManual";
            this._radioButtonManual.Size = new System.Drawing.Size(60, 17);
            this._radioButtonManual.TabIndex = 4;
            this._radioButtonManual.Text = "Manual";
            this._radioButtonManual.UseVisualStyleBackColor = true;
            this._radioButtonManual.CheckedChanged += new System.EventHandler(this._radioButtonManual_CheckedChanged);
            // 
            // _radioButtonSensor
            // 
            this._radioButtonSensor.AutoSize = true;
            this._radioButtonSensor.Location = new System.Drawing.Point(69, 3);
            this._radioButtonSensor.Name = "_radioButtonSensor";
            this._radioButtonSensor.Size = new System.Drawing.Size(58, 17);
            this._radioButtonSensor.TabIndex = 5;
            this._radioButtonSensor.Text = "Sensor";
            this._radioButtonSensor.UseVisualStyleBackColor = true;
            this._radioButtonSensor.CheckedChanged += new System.EventHandler(this._radioButtonSensor_CheckedChanged);
            // 
            // _labelControl
            // 
            this._labelControl.AutoSize = true;
            this._labelControl.Location = new System.Drawing.Point(10, 44);
            this._labelControl.Name = "_labelControl";
            this._labelControl.Size = new System.Drawing.Size(43, 13);
            this._labelControl.TabIndex = 9;
            this._labelControl.Text = "Control:";
            // 
            // _groupBoxSensor
            // 
            this._groupBoxSensor.Controls.Add(this._buttonSensorControlSet);
            this._groupBoxSensor.Controls.Add(this._labelSensor);
            this._groupBoxSensor.Controls.Add(this._comboBoxSensor);
            this._groupBoxSensor.Controls.Add(this._labelDirection);
            this._groupBoxSensor.Controls.Add(this.panel1);
            this._groupBoxSensor.Location = new System.Drawing.Point(13, 123);
            this._groupBoxSensor.Name = "_groupBoxSensor";
            this._groupBoxSensor.Size = new System.Drawing.Size(270, 86);
            this._groupBoxSensor.TabIndex = 11;
            this._groupBoxSensor.TabStop = false;
            this._groupBoxSensor.Text = "Sensor";
            // 
            // _buttonSensorControlSet
            // 
            this._buttonSensorControlSet.Location = new System.Drawing.Point(189, 49);
            this._buttonSensorControlSet.Name = "_buttonSensorControlSet";
            this._buttonSensorControlSet.Size = new System.Drawing.Size(75, 23);
            this._buttonSensorControlSet.TabIndex = 9;
            this._buttonSensorControlSet.Text = "Apply";
            this._buttonSensorControlSet.UseVisualStyleBackColor = true;
            this._buttonSensorControlSet.Click += new System.EventHandler(this._buttonSensorControlSet_Click);
            // 
            // _groupBoxManual
            // 
            this._groupBoxManual.Controls.Add(this._buttonAngleSet);
            this._groupBoxManual.Controls.Add(this._labelDegrees);
            this._groupBoxManual.Controls.Add(this._textBoxSetAngle);
            this._groupBoxManual.Controls.Add(this._labelSetAngle);
            this._groupBoxManual.Location = new System.Drawing.Point(13, 68);
            this._groupBoxManual.Name = "_groupBoxManual";
            this._groupBoxManual.Size = new System.Drawing.Size(270, 49);
            this._groupBoxManual.TabIndex = 12;
            this._groupBoxManual.TabStop = false;
            this._groupBoxManual.Text = "Manual";
            // 
            // _buttonAngleSet
            // 
            this._buttonAngleSet.Location = new System.Drawing.Point(189, 15);
            this._buttonAngleSet.Name = "_buttonAngleSet";
            this._buttonAngleSet.Size = new System.Drawing.Size(75, 23);
            this._buttonAngleSet.TabIndex = 8;
            this._buttonAngleSet.Text = "Apply";
            this._buttonAngleSet.UseVisualStyleBackColor = true;
            this._buttonAngleSet.Click += new System.EventHandler(this._buttonAngleSet_Click);
            // 
            // _labelDegrees
            // 
            this._labelDegrees.AutoSize = true;
            this._labelDegrees.Location = new System.Drawing.Point(116, 20);
            this._labelDegrees.Name = "_labelDegrees";
            this._labelDegrees.Size = new System.Drawing.Size(45, 13);
            this._labelDegrees.TabIndex = 6;
            this._labelDegrees.Text = "degrees";
            // 
            // _textBoxSetAngle
            // 
            this._textBoxSetAngle.Location = new System.Drawing.Point(56, 17);
            this._textBoxSetAngle.Name = "_textBoxSetAngle";
            this._textBoxSetAngle.Size = new System.Drawing.Size(54, 20);
            this._textBoxSetAngle.TabIndex = 4;
            // 
            // _labelSetAngle
            // 
            this._labelSetAngle.AutoSize = true;
            this._labelSetAngle.Location = new System.Drawing.Point(9, 20);
            this._labelSetAngle.Name = "_labelSetAngle";
            this._labelSetAngle.Size = new System.Drawing.Size(37, 13);
            this._labelSetAngle.TabIndex = 3;
            this._labelSetAngle.Text = "Angle:";
            // 
            // _labelSpeed
            // 
            this._labelSpeed.AutoSize = true;
            this._labelSpeed.Location = new System.Drawing.Point(14, 222);
            this._labelSpeed.Name = "_labelSpeed";
            this._labelSpeed.Size = new System.Drawing.Size(74, 13);
            this._labelSpeed.TabIndex = 13;
            this._labelSpeed.Text = "Current Angle:";
            // 
            // _textBoxAngle
            // 
            this._textBoxAngle.Location = new System.Drawing.Point(98, 219);
            this._textBoxAngle.Name = "_textBoxAngle";
            this._textBoxAngle.ReadOnly = true;
            this._textBoxAngle.Size = new System.Drawing.Size(54, 20);
            this._textBoxAngle.TabIndex = 14;
            // 
            // _labelDegrees2
            // 
            this._labelDegrees2.AutoSize = true;
            this._labelDegrees2.Location = new System.Drawing.Point(158, 222);
            this._labelDegrees2.Name = "_labelDegrees2";
            this._labelDegrees2.Size = new System.Drawing.Size(45, 13);
            this._labelDegrees2.TabIndex = 7;
            this._labelDegrees2.Text = "degrees";
            // 
            // ServoMotorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._labelDegrees2);
            this.Controls.Add(this._textBoxAngle);
            this.Controls.Add(this._labelSpeed);
            this.Controls.Add(this._groupBoxManual);
            this.Controls.Add(this._groupBoxSensor);
            this.Controls.Add(this._labelControl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this._labelName);
            this.Name = "ServoMotorControl";
            this.Size = new System.Drawing.Size(301, 251);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this._groupBoxSensor.ResumeLayout(false);
            this._groupBoxSensor.PerformLayout();
            this._groupBoxManual.ResumeLayout(false);
            this._groupBoxManual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelName;
        private System.Windows.Forms.Label _labelSensor;
        private System.Windows.Forms.ComboBox _comboBoxSensor;
        private System.Windows.Forms.Label _labelDirection;
        private System.Windows.Forms.RadioButton _radioButtonCCW;
        private System.Windows.Forms.RadioButton _radioButtonCW;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton _radioButtonManual;
        private System.Windows.Forms.RadioButton _radioButtonSensor;
        private System.Windows.Forms.Label _labelControl;
        private System.Windows.Forms.GroupBox _groupBoxSensor;
        private System.Windows.Forms.GroupBox _groupBoxManual;
        private System.Windows.Forms.TextBox _textBoxSetAngle;
        private System.Windows.Forms.Label _labelSetAngle;
        private System.Windows.Forms.Label _labelSpeed;
        private System.Windows.Forms.Label _labelDegrees;
        private System.Windows.Forms.TextBox _textBoxAngle;
        private System.Windows.Forms.Label _labelDegrees2;
        private System.Windows.Forms.Button _buttonAngleSet;
        private System.Windows.Forms.Button _buttonSensorControlSet;
    }
}
