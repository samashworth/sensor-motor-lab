namespace WinFormsUI_SensorMotorLab
{
    partial class SensorControl
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
            this._labelReading = new System.Windows.Forms.Label();
            this._textBoxReading = new System.Windows.Forms.TextBox();
            this._labelUnits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _labelName
            // 
            this._labelName.AutoSize = true;
            this._labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelName.Location = new System.Drawing.Point(3, 0);
            this._labelName.Name = "_labelName";
            this._labelName.Size = new System.Drawing.Size(103, 37);
            this._labelName.TabIndex = 1;
            this._labelName.Text = "Name";
            // 
            // _labelReading
            // 
            this._labelReading.AutoSize = true;
            this._labelReading.Location = new System.Drawing.Point(7, 49);
            this._labelReading.Name = "_labelReading";
            this._labelReading.Size = new System.Drawing.Size(50, 13);
            this._labelReading.TabIndex = 2;
            this._labelReading.Text = "Reading:";
            // 
            // _textBoxReading
            // 
            this._textBoxReading.Location = new System.Drawing.Point(63, 46);
            this._textBoxReading.Name = "_textBoxReading";
            this._textBoxReading.ReadOnly = true;
            this._textBoxReading.Size = new System.Drawing.Size(55, 20);
            this._textBoxReading.TabIndex = 3;
            // 
            // _labelUnits
            // 
            this._labelUnits.AutoSize = true;
            this._labelUnits.Location = new System.Drawing.Point(124, 49);
            this._labelUnits.Name = "_labelUnits";
            this._labelUnits.Size = new System.Drawing.Size(29, 13);
            this._labelUnits.TabIndex = 4;
            this._labelUnits.Text = "units";
            // 
            // SensorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._labelUnits);
            this.Controls.Add(this._textBoxReading);
            this.Controls.Add(this._labelReading);
            this.Controls.Add(this._labelName);
            this.Name = "SensorControl";
            this.Size = new System.Drawing.Size(324, 93);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelName;
        private System.Windows.Forms.Label _labelReading;
        private System.Windows.Forms.TextBox _textBoxReading;
        private System.Windows.Forms.Label _labelUnits;
    }
}
