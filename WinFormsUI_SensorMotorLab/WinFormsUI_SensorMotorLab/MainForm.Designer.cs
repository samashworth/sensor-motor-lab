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
            this._motorControlDC = new WinFormsUI_SensorMotorLab.MotorControl();
            this._tabPageServo = new System.Windows.Forms.TabPage();
            this._servoMotorControl = new WinFormsUI_SensorMotorLab.ServoMotorControl();
            this._tabPageStepper = new System.Windows.Forms.TabPage();
            this._motorControlStepper = new WinFormsUI_SensorMotorLab.MotorControl();
            this._tabPageDummyMotor = new System.Windows.Forms.TabPage();
            this._motorControlDummy = new WinFormsUI_SensorMotorLab.MotorControl();
            this._tabControlSensor = new System.Windows.Forms.TabControl();
            this._tabPageForceSensor = new System.Windows.Forms.TabPage();
            this._sensorControlForce = new WinFormsUI_SensorMotorLab.SensorControl();
            this._tabPagePotentiometer = new System.Windows.Forms.TabPage();
            this._sensorControlPotentiometer = new WinFormsUI_SensorMotorLab.SensorControl();
            this._tabPageSonar = new System.Windows.Forms.TabPage();
            this._sensorControlSonar = new WinFormsUI_SensorMotorLab.SensorControl();
            this._tabPageThermistor = new System.Windows.Forms.TabPage();
            this._sensorControlThermistor = new WinFormsUI_SensorMotorLab.SensorControl();
            this._tabPageDummySensor = new System.Windows.Forms.TabPage();
            this._sensorControlDummy = new WinFormsUI_SensorMotorLab.SensorControl();
            this._labelComPort = new System.Windows.Forms.Label();
            this._comboBoxPorts = new System.Windows.Forms.ComboBox();
            this._buttonConnect = new System.Windows.Forms.Button();
            this._labelConnectionStatus = new System.Windows.Forms.Label();
            this._buttonRefresh = new System.Windows.Forms.Button();
            this.debugControl1 = new WinFormsUI_SensorMotorLab.DebugControl();
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
            this._tabControlMotor.Size = new System.Drawing.Size(323, 353);
            this._tabControlMotor.TabIndex = 0;
            // 
            // _tabPageDCMotor
            // 
            this._tabPageDCMotor.Controls.Add(this._motorControlDC);
            this._tabPageDCMotor.Location = new System.Drawing.Point(4, 22);
            this._tabPageDCMotor.Name = "_tabPageDCMotor";
            this._tabPageDCMotor.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageDCMotor.Size = new System.Drawing.Size(315, 327);
            this._tabPageDCMotor.TabIndex = 0;
            this._tabPageDCMotor.Text = "DC";
            this._tabPageDCMotor.UseVisualStyleBackColor = true;
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
            // _tabPageServo
            // 
            this._tabPageServo.Controls.Add(this._servoMotorControl);
            this._tabPageServo.Location = new System.Drawing.Point(4, 22);
            this._tabPageServo.Name = "_tabPageServo";
            this._tabPageServo.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageServo.Size = new System.Drawing.Size(315, 327);
            this._tabPageServo.TabIndex = 1;
            this._tabPageServo.Text = "Servo";
            this._tabPageServo.UseVisualStyleBackColor = true;
            // 
            // _servoMotorControl
            // 
            this._servoMotorControl.Location = new System.Drawing.Point(6, 6);
            this._servoMotorControl.Messenger = null;
            this._servoMotorControl.Name = "_servoMotorControl";
            this._servoMotorControl.Size = new System.Drawing.Size(306, 298);
            this._servoMotorControl.TabIndex = 0;
            // 
            // _tabPageStepper
            // 
            this._tabPageStepper.Controls.Add(this._motorControlStepper);
            this._tabPageStepper.Location = new System.Drawing.Point(4, 22);
            this._tabPageStepper.Name = "_tabPageStepper";
            this._tabPageStepper.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageStepper.Size = new System.Drawing.Size(315, 327);
            this._tabPageStepper.TabIndex = 2;
            this._tabPageStepper.Text = "Stepper";
            this._tabPageStepper.UseVisualStyleBackColor = true;
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
            // _tabPageDummyMotor
            // 
            this._tabPageDummyMotor.Controls.Add(this._motorControlDummy);
            this._tabPageDummyMotor.Location = new System.Drawing.Point(4, 22);
            this._tabPageDummyMotor.Name = "_tabPageDummyMotor";
            this._tabPageDummyMotor.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageDummyMotor.Size = new System.Drawing.Size(315, 327);
            this._tabPageDummyMotor.TabIndex = 3;
            this._tabPageDummyMotor.Text = "Dummy";
            this._tabPageDummyMotor.UseVisualStyleBackColor = true;
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
            // _sensorControlPotentiometer
            // 
            this._sensorControlPotentiometer.Location = new System.Drawing.Point(6, 6);
            this._sensorControlPotentiometer.Messenger = null;
            this._sensorControlPotentiometer.Name = "_sensorControlPotentiometer";
            this._sensorControlPotentiometer.SensorType = Communication.SensorType.POTENTIOMETER;
            this._sensorControlPotentiometer.Size = new System.Drawing.Size(324, 93);
            this._sensorControlPotentiometer.TabIndex = 0;
            this._sensorControlPotentiometer.Units = "degrees";
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
            // _tabPageThermistor
            // 
            this._tabPageThermistor.Controls.Add(this._sensorControlThermistor);
            this._tabPageThermistor.Location = new System.Drawing.Point(4, 22);
            this._tabPageThermistor.Name = "_tabPageThermistor";
            this._tabPageThermistor.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageThermistor.Size = new System.Drawing.Size(564, 122);
            this._tabPageThermistor.TabIndex = 3;
            this._tabPageThermistor.Text = "Temperature";
            this._tabPageThermistor.UseVisualStyleBackColor = true;
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
            // _labelComPort
            // 
            this._labelComPort.AutoSize = true;
            this._labelComPort.Location = new System.Drawing.Point(9, 380);
            this._labelComPort.Name = "_labelComPort";
            this._labelComPort.Size = new System.Drawing.Size(56, 13);
            this._labelComPort.TabIndex = 3;
            this._labelComPort.Text = "COM Port:";
            // 
            // _comboBoxPorts
            // 
            this._comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboBoxPorts.FormattingEnabled = true;
            this._comboBoxPorts.Location = new System.Drawing.Point(71, 377);
            this._comboBoxPorts.Name = "_comboBoxPorts";
            this._comboBoxPorts.Size = new System.Drawing.Size(92, 21);
            this._comboBoxPorts.TabIndex = 4;
            // 
            // _buttonConnect
            // 
            this._buttonConnect.Location = new System.Drawing.Point(260, 375);
            this._buttonConnect.Name = "_buttonConnect";
            this._buttonConnect.Size = new System.Drawing.Size(75, 23);
            this._buttonConnect.TabIndex = 5;
            this._buttonConnect.Text = "Connect";
            this._buttonConnect.UseVisualStyleBackColor = true;
            this._buttonConnect.Click += new System.EventHandler(this._buttonConnect_Click);
            // 
            // _labelConnectionStatus
            // 
            this._labelConnectionStatus.AutoSize = true;
            this._labelConnectionStatus.Location = new System.Drawing.Point(68, 401);
            this._labelConnectionStatus.Name = "_labelConnectionStatus";
            this._labelConnectionStatus.Size = new System.Drawing.Size(35, 13);
            this._labelConnectionStatus.TabIndex = 6;
            this._labelConnectionStatus.Text = "label1";
            // 
            // _buttonRefresh
            // 
            this._buttonRefresh.Location = new System.Drawing.Point(169, 377);
            this._buttonRefresh.Name = "_buttonRefresh";
            this._buttonRefresh.Size = new System.Drawing.Size(53, 23);
            this._buttonRefresh.TabIndex = 7;
            this._buttonRefresh.Text = "Refresh";
            this._buttonRefresh.UseVisualStyleBackColor = true;
            this._buttonRefresh.Click += new System.EventHandler(this._buttonRefresh_Click);
            // 
            // debugControl1
            // 
            this.debugControl1.Location = new System.Drawing.Point(341, 166);
            this.debugControl1.Messenger = null;
            this.debugControl1.Name = "debugControl1";
            this.debugControl1.Size = new System.Drawing.Size(572, 310);
            this.debugControl1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 499);
            this.Controls.Add(this._buttonRefresh);
            this.Controls.Add(this._labelConnectionStatus);
            this.Controls.Add(this._buttonConnect);
            this.Controls.Add(this._comboBoxPorts);
            this.Controls.Add(this._labelComPort);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label _labelComPort;
        private System.Windows.Forms.ComboBox _comboBoxPorts;
        private System.Windows.Forms.Button _buttonConnect;
        private System.Windows.Forms.Label _labelConnectionStatus;
        private System.Windows.Forms.Button _buttonRefresh;
    }
}

