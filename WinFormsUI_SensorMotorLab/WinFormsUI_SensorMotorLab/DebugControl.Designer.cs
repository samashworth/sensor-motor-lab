namespace WinFormsUI_SensorMotorLab
{
    partial class DebugControl
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
            this._groupBoxDebug = new System.Windows.Forms.GroupBox();
            this._checkBoxDebugOn = new System.Windows.Forms.CheckBox();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._columnMessageType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._columnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._buttonClear = new System.Windows.Forms.Button();
            this._checkBoxStringGet = new System.Windows.Forms.CheckBox();
            this._checkBoxReadingGet = new System.Windows.Forms.CheckBox();
            this._checkBoxSpeedGet = new System.Windows.Forms.CheckBox();
            this._checkBoxAngleGet = new System.Windows.Forms.CheckBox();
            this._groupBoxDebug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _groupBoxDebug
            // 
            this._groupBoxDebug.Controls.Add(this._checkBoxAngleGet);
            this._groupBoxDebug.Controls.Add(this._checkBoxSpeedGet);
            this._groupBoxDebug.Controls.Add(this._checkBoxReadingGet);
            this._groupBoxDebug.Controls.Add(this._checkBoxStringGet);
            this._groupBoxDebug.Controls.Add(this._buttonClear);
            this._groupBoxDebug.Controls.Add(this._dataGridView);
            this._groupBoxDebug.Controls.Add(this._checkBoxDebugOn);
            this._groupBoxDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this._groupBoxDebug.Location = new System.Drawing.Point(0, 0);
            this._groupBoxDebug.Name = "_groupBoxDebug";
            this._groupBoxDebug.Size = new System.Drawing.Size(628, 310);
            this._groupBoxDebug.TabIndex = 3;
            this._groupBoxDebug.TabStop = false;
            this._groupBoxDebug.Text = "Debug";
            // 
            // _checkBoxDebugOn
            // 
            this._checkBoxDebugOn.AutoSize = true;
            this._checkBoxDebugOn.Location = new System.Drawing.Point(6, 19);
            this._checkBoxDebugOn.Name = "_checkBoxDebugOn";
            this._checkBoxDebugOn.Size = new System.Drawing.Size(75, 17);
            this._checkBoxDebugOn.TabIndex = 4;
            this._checkBoxDebugOn.Text = "Debug On";
            this._checkBoxDebugOn.UseVisualStyleBackColor = true;
            this._checkBoxDebugOn.CheckedChanged += new System.EventHandler(this._checkBoxDebugOn_CheckedChanged);
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._columnMessageType,
            this._columnData});
            this._dataGridView.Location = new System.Drawing.Point(6, 42);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.Size = new System.Drawing.Size(616, 262);
            this._dataGridView.TabIndex = 5;
            // 
            // _columnMessageType
            // 
            this._columnMessageType.HeaderText = "Message Type";
            this._columnMessageType.Name = "_columnMessageType";
            this._columnMessageType.ReadOnly = true;
            // 
            // _columnData
            // 
            this._columnData.HeaderText = "Data";
            this._columnData.Name = "_columnData";
            this._columnData.ReadOnly = true;
            this._columnData.Width = 400;
            // 
            // _buttonClear
            // 
            this._buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonClear.Location = new System.Drawing.Point(547, 13);
            this._buttonClear.Name = "_buttonClear";
            this._buttonClear.Size = new System.Drawing.Size(75, 23);
            this._buttonClear.TabIndex = 6;
            this._buttonClear.Text = "Clear";
            this._buttonClear.UseVisualStyleBackColor = true;
            this._buttonClear.Click += new System.EventHandler(this._buttonClear_Click);
            // 
            // _checkBoxStringGet
            // 
            this._checkBoxStringGet.AutoSize = true;
            this._checkBoxStringGet.Location = new System.Drawing.Point(87, 19);
            this._checkBoxStringGet.Name = "_checkBoxStringGet";
            this._checkBoxStringGet.Size = new System.Drawing.Size(95, 17);
            this._checkBoxStringGet.TabIndex = 7;
            this._checkBoxStringGet.Text = "STRING_GET";
            this._checkBoxStringGet.UseVisualStyleBackColor = true;
            // 
            // _checkBoxReadingGet
            // 
            this._checkBoxReadingGet.AutoSize = true;
            this._checkBoxReadingGet.Location = new System.Drawing.Point(188, 19);
            this._checkBoxReadingGet.Name = "_checkBoxReadingGet";
            this._checkBoxReadingGet.Size = new System.Drawing.Size(103, 17);
            this._checkBoxReadingGet.TabIndex = 8;
            this._checkBoxReadingGet.Text = "READING_GET";
            this._checkBoxReadingGet.UseVisualStyleBackColor = true;
            // 
            // _checkBoxSpeedGet
            // 
            this._checkBoxSpeedGet.AutoSize = true;
            this._checkBoxSpeedGet.Location = new System.Drawing.Point(297, 19);
            this._checkBoxSpeedGet.Name = "_checkBoxSpeedGet";
            this._checkBoxSpeedGet.Size = new System.Drawing.Size(90, 17);
            this._checkBoxSpeedGet.TabIndex = 9;
            this._checkBoxSpeedGet.Text = "SPEED_GET";
            this._checkBoxSpeedGet.UseVisualStyleBackColor = true;
            // 
            // _checkBoxAngleGet
            // 
            this._checkBoxAngleGet.AutoSize = true;
            this._checkBoxAngleGet.Location = new System.Drawing.Point(393, 19);
            this._checkBoxAngleGet.Name = "_checkBoxAngleGet";
            this._checkBoxAngleGet.Size = new System.Drawing.Size(90, 17);
            this._checkBoxAngleGet.TabIndex = 10;
            this._checkBoxAngleGet.Text = "ANGLE_GET";
            this._checkBoxAngleGet.UseVisualStyleBackColor = true;
            // 
            // DebugControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._groupBoxDebug);
            this.Name = "DebugControl";
            this.Size = new System.Drawing.Size(628, 310);
            this._groupBoxDebug.ResumeLayout(false);
            this._groupBoxDebug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _groupBoxDebug;
        private System.Windows.Forms.CheckBox _checkBoxDebugOn;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnMessageType;
        private System.Windows.Forms.DataGridViewTextBoxColumn _columnData;
        private System.Windows.Forms.Button _buttonClear;
        private System.Windows.Forms.CheckBox _checkBoxAngleGet;
        private System.Windows.Forms.CheckBox _checkBoxSpeedGet;
        private System.Windows.Forms.CheckBox _checkBoxReadingGet;
        private System.Windows.Forms.CheckBox _checkBoxStringGet;
    }
}
