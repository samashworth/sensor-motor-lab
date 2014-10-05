namespace WinFormsUI_SensorMotorLab
{
    partial class MainForm
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
            if (_messenger != null)
                _messenger.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._tabControlMotor = new System.Windows.Forms.TabControl();
            this._tabPageDCMotor = new System.Windows.Forms.TabPage();
            this._tabPageServo = new System.Windows.Forms.TabPage();
            this._tabPageStepper = new System.Windows.Forms.TabPage();
            this._tabPageDummyMotor = new System.Windows.Forms.TabPage();
            this._tabControlSensor = new System.Windows.Forms.TabControl();
            this._tabPageForceSensor = new System.Windows.Forms.TabPage();
            this._tabPagePotentiometer = new System.Windows.Forms.TabPage();
            this._tabPageSonar = new System.Windows.Forms.TabPage();
            this._tabPageThermistor = new System.Windows.Forms.TabPage();
            this._tabPageDummySensor = new System.Windows.Forms.TabPage();
            this.debugControl1 = new WinFormsUI_SensorMotorLab.DebugControl();
            this._sensorControlForce = new WinFormsUI_SensorMotorLab.SensorControl();
            this._sensorControlPotentiometer = new WinFormsUI_SensorMotorLab.SensorControl();
            this._sensorControlSonar = new WinFormsUI_SensorMotorLab.SensorControl();
            this._sensorControlThermistor = new WinFormsUI_SensorMotorLab.SensorControl();
            this._sensorControlDummy = new WinFormsUI_SensorMotorLab.SensorControl();
            this._motorControlDC = new WinFormsUI_SensorMotorLab.MotorControl();
            this._servoMotorControl = new WinFormsUI_SensorMotorLab.ServoMotorControl();
            this._motorControlStepper = new WinFormsUI_SensorMotorLab.MotorControl();
            this._motorControlDummy = new WinFormsUI_SensorMotorLab.MotorControl();
            this._tabControlMotor.SuspendLayout();
            this._tabPageDCMotor.SuspendLayout();
            this._tabPageServo.SuspendLayout();
            this._tabPageStepper.SuspendLayout();
            this._tabPageDummyMotor.SuspendLayout();
            this._tabControlSensor.SuspendLayout();
            this._tabPageForceSensor.SuspendLayout();
            this._tabPagePotentiometer.SuspendLayout();
            this._tabPageSonar.SuspendLayout();
            this._tabPageThermistor.SuspendLayout();
            this._tabPageDummySensor.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tabControlMotor
            // 
            this._tabControlMotor.Controls.Add(this._tabPageDCMotor);
            this._tabControlMotor.Controls.Add(this._tabPageServo);
            this._tabControlMotor.Controls.Add(this._tabPageStepper);
            this._tabControlMotor.Controls.Add(this._tabPageDummyMotor);
            this._tabControlMotor.Location = new System.Drawing.Point(12, 12);
            this._tabControlMotor.Name = "_tabControlMotor";
            this._tabControlMotor.SelectedIndex = 0;
            this._tabControlMotor.Size = new System.Drawing.Size(323, 464);
            this._tabControlMotor.TabIndex = 0;
            // 
            // _tabPageDCMotor
            // 
            this._tabPageDCMotor.Controls.Add(this._motorControlDC);
            this._tabPageDCMotor.Location = new System.Drawing.Point(4, 22);
            this._tabPageDCMotor.Name = "_tabPageDCMotor";
            this._tabPageDCMotor.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageDCMotor.Size = new System.Drawing.Size(315, 438);
            this._tabPageDCMotor.TabIndex = 0;
            this._tabPageDCMotor.Text = "DC";
            this._tabPageDCMotor.UseVisualStyleBackColor = true;
            // 
            // _tabPageServo
            // 
            this._tabPageServo.Controls.Add(this._servoMotorControl);
            this._tabPageServo.Location = new System.Drawing.Point(4, 22);
            this._tabPageServo.Name = "_tabPageServo";
            this._tabPageServo.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageServo.Size = new System.Drawing.Size(315, 438);
            this._tabPageServo.TabIndex = 1;
            this._tabPageServo.Text = "Servo";
            this._tabPageServo.UseVisualStyleBackColor = true;
            // 
            // _tabPageStepper
            // 
            this._tabPageStepper.Controls.Add(this._motorControlStepper);
            this._tabPageStepper.Location = new System.Drawing.Point(4, 22);
            this._tabPageStepper.Name = "_tabPageStepper";
            this._tabPageStepper.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageStepper.Size = new System.Drawing.Size(315, 438);
            this._tabPageStepper.TabIndex = 2;
            this._tabPageStepper.Text = "Stepper";
            this._tabPageStepper.UseVisualStyleBackColor = true;
            // 
            // _tabPageDummyMotor
            // 
            this._tabPageDummyMotor.Controls.Add(this._motorControlDummy);
            this._tabPageDummyMotor.Location = new System.Drawing.Point(4, 22);
            this._tabPageDummyMotor.Name = "_tabPageDummyMotor";
            this._tabPageDummyMotor.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageDummyMotor.Size = new System.Drawing.Size(315, 438);
            this._tabPageDummyMotor.TabIndex = 3;
            this._tabPageDummyMotor.Text = "Dummy";
            this._tabPageDummyMotor.UseVisualStyleBackColor = true;
            // 
            // _tabControlSensor
            // 
            this._tabControlSensor.Controls.Add(this._tabPageForceSensor);
            this._tabControlSensor.Controls.Add(this._tabPagePotentiometer);
            this._tabControlSensor.Controls.Add(this._tabPageSonar);
            this._tabControlSensor.Controls.Add(this._tabPageThermistor);
            this._tabControlSensor.Controls.Add(this._tabPageDummySensor);
            this._tabControlSensor.Location = new System.Drawing.Point(341, 12);
            this._tabControlSensor.Name = "_tabControlSensor";
            this._tabControlSensor.SelectedIndex = 0;
            this._tabControlSensor.Size = new System.Drawing.Size(572, 148);
            this._tabControlSensor.TabIndex = 1;
            // 
            // _tabPageForceSensor
            // 
            this._tabPageForceSensor.Controls.Add(this._sensorControlForce);
            this._tabPageForceSensor.Location = new System.Drawing.Point(4, 22);
            this._tabPageForceSensor.Name = "_tabPageForceSensor";
            this._tabPageForceSensor.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageForceSensor.Size = new System.Drawing.Size(564, 122);
            this._tabPageForceSensor.TabIndex = 0;
            this._tabPageForceSensor.Text = "Force";
            this._tabPageForceSensor.UseVisualStyleBackColor = true;
            // 
            // _tabPagePotentiometer
            // 
            this._tabPagePotentiometer.Controls.Add(this._sensorControlPotentiometer);
            this._tabPagePotentiometer.Location = new System.Drawing.Point(4, 22);
            this._tabPagePotentiometer.Name = "_tabPagePotentiometer";
            this._tabPagePotentiometer.Padding = new System.Windows.Forms.Padding(3);
            this._tabPagePotentiometer.Size = new System.Drawing.Size(564, 122);
            this._tabPagePotentiometer.TabIndex = 1;
            this._tabPagePotentiometer.Text = "Pot";
            this._tabPagePotentiometer.UseVisualStyleBackColor = true;
            // 
            // _tabPageSonar
            // 
            this._tabPageSonar.Controls.Add(this._sensorControlSonar);
            this._tabPageSonar.Location = new System.Drawing.Point(4, 22);
            this._tabPageSonar.Name = "_tabPageSonar";
            this._tabPageSonar.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageSonar.Size = new System.Drawing.Size(564, 122);
            this._tabPageSonar.TabIndex = 2;
            this._tabPageSonar.Text = "Sonar";
            this._tabPageSonar.UseVisualStyleBackColor = true;
            // 
            // _tabPageThermistor
            // 
            this._tabPageThermistor.Controls.Add(this._sensorControlThermistor);
            this._tabPageThermistor.Location = new System.Drawing.Point(4, 22);
            this._tabPageThermistor.Name = "_tabPageThermistor";
            this._tabPageThermistor.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageThermistor.Size = new System.Drawing.Size(564, 122);
            this._tabPageThermistor.TabIndex = 3;
            this._tabPageThermistor.Text = "Thermistor";
            this._tabPageThermistor.UseVisualStyleBackColor = true;
            // 
            // _tabPageDummySensor
            // 
            this._tabPageDummySensor.Controls.Add(this._sensorControlDummy);
            this._tabPageDummySensor.Location = new System.Drawing.Point(4, 22);
            this._tabPageDummySensor.Name = "_tabPageDummySensor";
            this._tabPageDummySensor.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageDummySensor.Size = new System.Drawing.Size(564, 122);
            this._tabPageDummySensor.TabIndex = 4;
            this._tabPageDummySensor.Text = "Dummy";
            this._tabPageDummySensor.UseVisualStyleBackColor = true;
            // 
            // debugControl1
            // 
            this.debugControl1.Location = new System.Drawing.Point(341, 166);
            this.debugControl1.Messenger = null;
            this.debugControl1.Name = "debugControl1";
            this.debugControl1.Size = new System.Drawing.Size(572, 310);
            this.debugControl1.TabIndex = 2;
            // 
            // _sensorControlForce
            // 
            this._sensorControlForce.Location = new System.Drawing.Point(6, 6);
            this._sensorControlForce.Messenger = null;
            this._sensorControlForce.Name = "_sensorControlForce";
            this._sensorControlForce.SensorType = Communication.SensorType.FORCE_SENSOR;
            this._sensorControlForce.Size = new System.Drawing.Size(324, 93);
            this._sensorControlForce.TabIndex = 0;
            this._sensorControlForce.Units = "newtons";
            // 
            // _sensorControlPotentiometer
            // 
            this._sensorControlPotentiometer.Location = new System.Drawing.Point(6, 6);
            this._sensorControlPotentiometer.Messenger = null;
            this._sensorControlPotentiometer.Name = "_sensorControlPotentiometer";
            this._sensorControlPotentiometer.SensorType = Communication.SensorType.POTENTIOMETER;
            this._sensorControlPotentiometer.Size = new System.Drawing.Size(324, 93);
            this._sensorControlPotentiometer.TabIndex = 0;
            this._sensorControlPotentiometer.Units = "ohms";
            // 
            // _sensorControlSonar
            // 
            this._sensorControlSonar.Location = new System.Drawing.Point(6, 6);
            this._sensorControlSonar.Messenger = null;
            this._sensorControlSonar.Name = "_sensorControlSonar";
            this._sensorControlSonar.SensorType = Communication.SensorType.SONAR_SENSOR;
            this._sensorControlSonar.Size = new System.Drawing.Size(324, 93);
            this._sensorControlSonar.TabIndex = 0;
            this._sensorControlSonar.Units = "centimeters";
            // 
            // _sensorControlThermistor
            // 
            this._sensorControlThermistor.Location = new System.Drawing.Point(6, 6);
            this._sensorControlThermistor.Messenger = null;
            this._sensorControlThermistor.Name = "_sensorControlThermistor";
            this._sensorControlThermistor.SensorType = Communication.SensorType.THERMISTOR;
            this._sensorControlThermistor.Size = new System.Drawing.Size(324, 93);
            this._sensorControlThermistor.TabIndex = 0;
            this._sensorControlThermistor.Units = "celsius";
            // 
            // _sensorControlDummy
            // 
            this._sensorControlDummy.Location = new System.Drawing.Point(6, 6);
            this._sensorControlDummy.Messenger = null;
            this._sensorControlDummy.Name = "_sensorControlDummy";
            this._sensorControlDummy.SensorType = Communication.SensorType.DUMMY_SENSOR;
            this._sensorControlDummy.Size = new System.Drawing.Size(324, 93);
            this._sensorControlDummy.TabIndex = 0;
            this._sensorControlDummy.Units = "units";
            // 
            // _motorControlDC
            // 
            this._motorControlDC.Location = new System.Drawing.Point(6, 6);
            this._motorControlDC.Messenger = null;
            this._motorControlDC.MotorType = Communication.MotorType.DC_MOTOR;
            this._motorControlDC.Name = "_motorControlDC";
            this._motorControlDC.Size = new System.Drawing.Size(301, 321);
            this._motorControlDC.TabIndex = 0;
            // 
            // _servoMotorControl
            // 
            this._servoMotorControl.Location = new System.Drawing.Point(6, 6);
            this._servoMotorControl.Messenger = null;
            this._servoMotorControl.Name = "_servoMotorControl";
            this._servoMotorControl.Size = new System.Drawing.Size(306, 298);
            this._servoMotorControl.TabIndex = 0;
            // 
            // _motorControlStepper
            // 
            this._motorControlStepper.Location = new System.Drawing.Point(6, 6);
            this._motorControlStepper.Messenger = null;
            this._motorControlStepper.MotorType = Communication.MotorType.DC_MOTOR;
            this._motorControlStepper.Name = "_motorControlStepper";
            this._motorControlStepper.Size = new System.Drawing.Size(301, 317);
            this._motorControlStepper.TabIndex = 1;
            // 
            // _motorControlDummy
            // 
            this._motorControlDummy.Location = new System.Drawing.Point(6, 6);
            this._motorControlDummy.Messenger = null;
            this._motorControlDummy.MotorType = Communication.MotorType.DC_MOTOR;
            this._motorControlDummy.Name = "_motorControlDummy";
            this._motorControlDummy.Size = new System.Drawing.Size(301, 317);
            this._motorControlDummy.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 499);
            this.Controls.Add(this.debugControl1);
            this.Controls.Add(this._tabControlSensor);
            this.Controls.Add(this._tabControlMotor);
            this.Name = "MainForm";
            this.Text = "Sensor/Motor Control";
            this._tabControlMotor.ResumeLayout(false);
            this._tabPageDCMotor.ResumeLayout(false);
            this._tabPageServo.ResumeLayout(false);
            this._tabPageStepper.ResumeLayout(false);
            this._tabPageDummyMotor.ResumeLayout(false);
            this._tabControlSensor.ResumeLayout(false);
            this._tabPageForceSensor.ResumeLayout(false);
            this._tabPagePotentiometer.ResumeLayout(false);
            this._tabPageSonar.ResumeLayout(false);
            this._tabPageThermistor.ResumeLayout(false);
            this._tabPageDummySensor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControlMotor;
        private System.Windows.Forms.TabPage _tabPageDCMotor;
        private MotorControl _motorControlDC;
        private System.Windows.Forms.TabPage _tabPageServo;
        private System.Windows.Forms.TabPage _tabPageStepper;
        private MotorControl _motorControlStepper;
        private System.Windows.Forms.TabPage _tabPageDummyMotor;
        private MotorControl _motorControlDummy;
        private ServoMotorControl _servoMotorControl;
        private System.Windows.Forms.TabControl _tabControlSensor;
        private System.Windows.Forms.TabPage _tabPageForceSensor;
        private System.Windows.Forms.TabPage _tabPagePotentiometer;
        private SensorControl _sensorControlForce;
        private SensorControl _sensorControlPotentiometer;
        private System.Windows.Forms.TabPage _tabPageSonar;
        private SensorControl _sensorControlSonar;
        private System.Windows.Forms.TabPage _tabPageThermistor;
        private SensorControl _sensorControlThermistor;
        private System.Windows.Forms.TabPage _tabPageDummySensor;
        private SensorControl _sensorControlDummy;
        private DebugControl debugControl1;
    }
}

