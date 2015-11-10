namespace RelayControllerConsole
{
    partial class ConsoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleForm));
            this.cmdRedOn = new System.Windows.Forms.Button();
            this.cmdRedOff = new System.Windows.Forms.Button();
            this.cmdYellowOff = new System.Windows.Forms.Button();
            this.cmdYellowOn = new System.Windows.Forms.Button();
            this.cmdGreenOff = new System.Windows.Forms.Button();
            this.cmdGreenOn = new System.Windows.Forms.Button();
            this.txtConsoleLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdChristmasOff = new System.Windows.Forms.Button();
            this.cmdChristmasOn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picGreenLight = new System.Windows.Forms.PictureBox();
            this.picYellowLight = new System.Windows.Forms.PictureBox();
            this.picRedLight = new System.Windows.Forms.PictureBox();
            this.picChristmasLights = new System.Windows.Forms.PictureBox();
            this.tmrReadSerialPort = new System.Windows.Forms.Timer(this.components);
            this.tmrStoplight = new System.Windows.Forms.Timer(this.components);
            this.chkStoplight = new System.Windows.Forms.CheckBox();
            this.chkFlashChristmas = new System.Windows.Forms.CheckBox();
            this.tmrChristmasLights = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChristmasLights)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdRedOn
            // 
            this.cmdRedOn.Location = new System.Drawing.Point(12, 66);
            this.cmdRedOn.Name = "cmdRedOn";
            this.cmdRedOn.Size = new System.Drawing.Size(75, 23);
            this.cmdRedOn.TabIndex = 0;
            this.cmdRedOn.Text = "Turn On";
            this.cmdRedOn.UseVisualStyleBackColor = true;
            this.cmdRedOn.Click += new System.EventHandler(this.cmdRedOn_Click);
            // 
            // cmdRedOff
            // 
            this.cmdRedOff.Location = new System.Drawing.Point(12, 95);
            this.cmdRedOff.Name = "cmdRedOff";
            this.cmdRedOff.Size = new System.Drawing.Size(75, 23);
            this.cmdRedOff.TabIndex = 1;
            this.cmdRedOff.Text = "Turn Off";
            this.cmdRedOff.UseVisualStyleBackColor = true;
            this.cmdRedOff.Click += new System.EventHandler(this.cmdRedOff_Click);
            // 
            // cmdYellowOff
            // 
            this.cmdYellowOff.Location = new System.Drawing.Point(93, 95);
            this.cmdYellowOff.Name = "cmdYellowOff";
            this.cmdYellowOff.Size = new System.Drawing.Size(75, 23);
            this.cmdYellowOff.TabIndex = 3;
            this.cmdYellowOff.Text = "Turn Off";
            this.cmdYellowOff.UseVisualStyleBackColor = true;
            this.cmdYellowOff.Click += new System.EventHandler(this.cmdYellowOff_Click);
            // 
            // cmdYellowOn
            // 
            this.cmdYellowOn.Location = new System.Drawing.Point(93, 66);
            this.cmdYellowOn.Name = "cmdYellowOn";
            this.cmdYellowOn.Size = new System.Drawing.Size(75, 23);
            this.cmdYellowOn.TabIndex = 2;
            this.cmdYellowOn.Text = "Turn On";
            this.cmdYellowOn.UseVisualStyleBackColor = true;
            this.cmdYellowOn.Click += new System.EventHandler(this.cmdYellowOn_Click);
            // 
            // cmdGreenOff
            // 
            this.cmdGreenOff.Location = new System.Drawing.Point(174, 95);
            this.cmdGreenOff.Name = "cmdGreenOff";
            this.cmdGreenOff.Size = new System.Drawing.Size(75, 23);
            this.cmdGreenOff.TabIndex = 5;
            this.cmdGreenOff.Text = "Turn Off";
            this.cmdGreenOff.UseVisualStyleBackColor = true;
            this.cmdGreenOff.Click += new System.EventHandler(this.cmdGreenOff_Click);
            // 
            // cmdGreenOn
            // 
            this.cmdGreenOn.Location = new System.Drawing.Point(174, 66);
            this.cmdGreenOn.Name = "cmdGreenOn";
            this.cmdGreenOn.Size = new System.Drawing.Size(75, 23);
            this.cmdGreenOn.TabIndex = 4;
            this.cmdGreenOn.Text = "Turn On";
            this.cmdGreenOn.UseVisualStyleBackColor = true;
            this.cmdGreenOn.Click += new System.EventHandler(this.cmdGreenOn_Click);
            // 
            // txtConsoleLog
            // 
            this.txtConsoleLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsoleLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtConsoleLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsoleLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsoleLog.Location = new System.Drawing.Point(260, 25);
            this.txtConsoleLog.Name = "txtConsoleLog";
            this.txtConsoleLog.ReadOnly = true;
            this.txtConsoleLog.Size = new System.Drawing.Size(245, 304);
            this.txtConsoleLog.TabIndex = 9;
            this.txtConsoleLog.TabStop = false;
            this.txtConsoleLog.Text = "";
            this.txtConsoleLog.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Serial Port Log";
            // 
            // cmdChristmasOff
            // 
            this.cmdChristmasOff.Location = new System.Drawing.Point(93, 222);
            this.cmdChristmasOff.Name = "cmdChristmasOff";
            this.cmdChristmasOff.Size = new System.Drawing.Size(75, 23);
            this.cmdChristmasOff.TabIndex = 7;
            this.cmdChristmasOff.Text = "Turn Off";
            this.cmdChristmasOff.UseVisualStyleBackColor = true;
            this.cmdChristmasOff.Click += new System.EventHandler(this.cmdChristmasOff_Click);
            // 
            // cmdChristmasOn
            // 
            this.cmdChristmasOn.Location = new System.Drawing.Point(93, 193);
            this.cmdChristmasOn.Name = "cmdChristmasOn";
            this.cmdChristmasOn.Size = new System.Drawing.Size(75, 23);
            this.cmdChristmasOn.TabIndex = 6;
            this.cmdChristmasOn.Text = "Turn On";
            this.cmdChristmasOn.UseVisualStyleBackColor = true;
            this.cmdChristmasOn.Click += new System.EventHandler(this.cmdChristmasOn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFlashChristmas);
            this.groupBox1.Controls.Add(this.chkStoplight);
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Modes";
            // 
            // picGreenLight
            // 
            this.picGreenLight.Image = global::RelayControllerConsole.Properties.Resources.bulb_green_on;
            this.picGreenLight.Location = new System.Drawing.Point(187, 12);
            this.picGreenLight.Name = "picGreenLight";
            this.picGreenLight.Size = new System.Drawing.Size(48, 48);
            this.picGreenLight.TabIndex = 2;
            this.picGreenLight.TabStop = false;
            // 
            // picYellowLight
            // 
            this.picYellowLight.Image = global::RelayControllerConsole.Properties.Resources.bulb_yellow_on;
            this.picYellowLight.Location = new System.Drawing.Point(106, 12);
            this.picYellowLight.Name = "picYellowLight";
            this.picYellowLight.Size = new System.Drawing.Size(48, 48);
            this.picYellowLight.TabIndex = 1;
            this.picYellowLight.TabStop = false;
            // 
            // picRedLight
            // 
            this.picRedLight.Image = global::RelayControllerConsole.Properties.Resources.bulb_red_on;
            this.picRedLight.Location = new System.Drawing.Point(25, 12);
            this.picRedLight.Name = "picRedLight";
            this.picRedLight.Size = new System.Drawing.Size(48, 48);
            this.picRedLight.TabIndex = 0;
            this.picRedLight.TabStop = false;
            // 
            // picChristmasLights
            // 
            this.picChristmasLights.Image = global::RelayControllerConsole.Properties.Resources.christmas_lights_on;
            this.picChristmasLights.Location = new System.Drawing.Point(46, 127);
            this.picChristmasLights.Name = "picChristmasLights";
            this.picChristmasLights.Size = new System.Drawing.Size(168, 60);
            this.picChristmasLights.TabIndex = 14;
            this.picChristmasLights.TabStop = false;
            // 
            // tmrReadSerialPort
            // 
            this.tmrReadSerialPort.Tick += new System.EventHandler(this.tmrReadSerialPort_Tick);
            // 
            // tmrStoplight
            // 
            this.tmrStoplight.Interval = 3000;
            this.tmrStoplight.Tick += new System.EventHandler(this.tmrStoplight_Tick);
            // 
            // chkStoplight
            // 
            this.chkStoplight.AutoSize = true;
            this.chkStoplight.Location = new System.Drawing.Point(13, 21);
            this.chkStoplight.Name = "chkStoplight";
            this.chkStoplight.Size = new System.Drawing.Size(67, 17);
            this.chkStoplight.TabIndex = 0;
            this.chkStoplight.Text = "Stoplight";
            this.chkStoplight.UseVisualStyleBackColor = true;
            this.chkStoplight.CheckedChanged += new System.EventHandler(this.chkStoplight_CheckedChanged);
            // 
            // chkFlashChristmas
            // 
            this.chkFlashChristmas.AutoSize = true;
            this.chkFlashChristmas.Location = new System.Drawing.Point(13, 44);
            this.chkFlashChristmas.Name = "chkFlashChristmas";
            this.chkFlashChristmas.Size = new System.Drawing.Size(130, 17);
            this.chkFlashChristmas.TabIndex = 1;
            this.chkFlashChristmas.Text = "Flash Christmas Lights";
            this.chkFlashChristmas.UseVisualStyleBackColor = true;
            this.chkFlashChristmas.CheckedChanged += new System.EventHandler(this.chkFlashChristmas_CheckedChanged);
            // 
            // tmrChristmasLights
            // 
            this.tmrChristmasLights.Interval = 500;
            this.tmrChristmasLights.Tick += new System.EventHandler(this.tmrChristmasLights_Tick);
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 330);
            this.Controls.Add(this.picChristmasLights);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdChristmasOff);
            this.Controls.Add(this.cmdChristmasOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsoleLog);
            this.Controls.Add(this.cmdGreenOff);
            this.Controls.Add(this.cmdGreenOn);
            this.Controls.Add(this.cmdYellowOff);
            this.Controls.Add(this.cmdYellowOn);
            this.Controls.Add(this.cmdRedOff);
            this.Controls.Add(this.cmdRedOn);
            this.Controls.Add(this.picGreenLight);
            this.Controls.Add(this.picYellowLight);
            this.Controls.Add(this.picRedLight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(275, 368);
            this.Name = "ConsoleForm";
            this.Text = "Arduino Relay Controller Console";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsoleForm_FormClosed);
            this.Load += new System.EventHandler(this.Startup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRedLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChristmasLights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRedLight;
        private System.Windows.Forms.PictureBox picYellowLight;
        private System.Windows.Forms.PictureBox picGreenLight;
        private System.Windows.Forms.Button cmdRedOn;
        private System.Windows.Forms.Button cmdRedOff;
        private System.Windows.Forms.Button cmdYellowOff;
        private System.Windows.Forms.Button cmdYellowOn;
        private System.Windows.Forms.Button cmdGreenOff;
        private System.Windows.Forms.Button cmdGreenOn;
        private System.Windows.Forms.RichTextBox txtConsoleLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdChristmasOff;
        private System.Windows.Forms.Button cmdChristmasOn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picChristmasLights;
        private System.Windows.Forms.Timer tmrReadSerialPort;
        private System.Windows.Forms.Timer tmrStoplight;
        private System.Windows.Forms.CheckBox chkStoplight;
        private System.Windows.Forms.CheckBox chkFlashChristmas;
        private System.Windows.Forms.Timer tmrChristmasLights;
    }
}

