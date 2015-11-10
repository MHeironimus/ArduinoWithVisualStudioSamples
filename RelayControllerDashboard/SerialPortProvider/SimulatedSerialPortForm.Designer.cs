namespace SerialPortProvider
{
    partial class SimulatedSerialPortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulatedSerialPortForm));
            this.txtSendValue = new System.Windows.Forms.TextBox();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoThrowException = new System.Windows.Forms.RadioButton();
            this.rdoReturnOnce = new System.Windows.Forms.RadioButton();
            this.rdoAlwaysReturn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSendValue
            // 
            this.txtSendValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendValue.Location = new System.Drawing.Point(134, 41);
            this.txtSendValue.Name = "txtSendValue";
            this.txtSendValue.Size = new System.Drawing.Size(262, 20);
            this.txtSendValue.TabIndex = 2;
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.AutoSize = true;
            this.lblSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialPort.Location = new System.Drawing.Point(12, 9);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Size = new System.Drawing.Size(201, 20);
            this.lblSerialPort.TabIndex = 0;
            this.lblSerialPort.Text = "<Serial Port Display Name>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ReadLine return value:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdoReturnOnce);
            this.groupBox1.Controls.Add(this.rdoAlwaysReturn);
            this.groupBox1.Controls.Add(this.rdoThrowException);
            this.groupBox1.Location = new System.Drawing.Point(134, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ReadLine Behavior";
            // 
            // rdoThrowException
            // 
            this.rdoThrowException.AutoSize = true;
            this.rdoThrowException.Checked = true;
            this.rdoThrowException.Location = new System.Drawing.Point(19, 25);
            this.rdoThrowException.Name = "rdoThrowException";
            this.rdoThrowException.Size = new System.Drawing.Size(143, 17);
            this.rdoThrowException.TabIndex = 0;
            this.rdoThrowException.TabStop = true;
            this.rdoThrowException.Text = "Throw TimeoutException";
            this.rdoThrowException.UseVisualStyleBackColor = true;
            // 
            // rdoReturnOnce
            // 
            this.rdoReturnOnce.AutoSize = true;
            this.rdoReturnOnce.Location = new System.Drawing.Point(19, 48);
            this.rdoReturnOnce.Name = "rdoReturnOnce";
            this.rdoReturnOnce.Size = new System.Drawing.Size(225, 17);
            this.rdoReturnOnce.TabIndex = 1;
            this.rdoReturnOnce.Text = "Return value once then TimeoutException";
            this.rdoReturnOnce.UseVisualStyleBackColor = true;
            // 
            // rdoAlwaysReturn
            // 
            this.rdoAlwaysReturn.AutoSize = true;
            this.rdoAlwaysReturn.Location = new System.Drawing.Point(19, 71);
            this.rdoAlwaysReturn.Name = "rdoAlwaysReturn";
            this.rdoAlwaysReturn.Size = new System.Drawing.Size(117, 17);
            this.rdoAlwaysReturn.TabIndex = 2;
            this.rdoAlwaysReturn.Text = "Always return value";
            this.rdoAlwaysReturn.UseVisualStyleBackColor = true;
            // 
            // SimulatedSerialPortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 181);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSerialPort);
            this.Controls.Add(this.txtSendValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(424, 219);
            this.Name = "SimulatedSerialPortForm";
            this.Text = "Simulated Serial Port Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSendValue;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoReturnOnce;
        private System.Windows.Forms.RadioButton rdoAlwaysReturn;
        private System.Windows.Forms.RadioButton rdoThrowException;
    }
}