namespace LoRaWAN
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenPort = new System.Windows.Forms.Button();
            this.ClosePort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoRaCOMPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoRaOutputWindow = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.StopWatch = new System.Windows.Forms.Label();
            this.StartTimer = new System.Windows.Forms.Button();
            this.StopTimer = new System.Windows.Forms.Button();
            this.ResetTimer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ReadLoRaData = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenPort
            // 
            this.OpenPort.Location = new System.Drawing.Point(12, 37);
            this.OpenPort.Name = "OpenPort";
            this.OpenPort.Size = new System.Drawing.Size(75, 39);
            this.OpenPort.TabIndex = 0;
            this.OpenPort.Text = "Open Port";
            this.OpenPort.UseVisualStyleBackColor = true;
            this.OpenPort.Click += new System.EventHandler(this.OpenPort_Click);
            // 
            // ClosePort
            // 
            this.ClosePort.Location = new System.Drawing.Point(95, 37);
            this.ClosePort.Name = "ClosePort";
            this.ClosePort.Size = new System.Drawing.Size(75, 39);
            this.ClosePort.TabIndex = 1;
            this.ClosePort.Text = "Close Port";
            this.ClosePort.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "LoRaWAN Port";
            // 
            // LoRaCOMPort
            // 
            this.LoRaCOMPort.FormattingEnabled = true;
            this.LoRaCOMPort.Location = new System.Drawing.Point(12, 82);
            this.LoRaCOMPort.Name = "LoRaCOMPort";
            this.LoRaCOMPort.Size = new System.Drawing.Size(158, 21);
            this.LoRaCOMPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(186, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "LoRaWAN Incoming Data";
            // 
            // LoRaOutputWindow
            // 
            this.LoRaOutputWindow.BackColor = System.Drawing.SystemColors.MenuText;
            this.LoRaOutputWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoRaOutputWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LoRaOutputWindow.Location = new System.Drawing.Point(191, 37);
            this.LoRaOutputWindow.Name = "LoRaOutputWindow";
            this.LoRaOutputWindow.Size = new System.Drawing.Size(272, 326);
            this.LoRaOutputWindow.TabIndex = 5;
            this.LoRaOutputWindow.Text = "";
            this.LoRaOutputWindow.TextChanged += new System.EventHandler(this.LoRaOutputWindow_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoRaWAN.Properties.Resources.LoRa;
            this.pictureBox1.Location = new System.Drawing.Point(12, 316);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(469, 37);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(268, 250);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.Url = new System.Uri("C:\\TestFolder", System.UriKind.Absolute);
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime.ForeColor = System.Drawing.Color.Green;
            this.CurrentTime.Location = new System.Drawing.Point(469, 290);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(128, 31);
            this.CurrentTime.TabIndex = 8;
            this.CurrentTime.Text = "00:00:00";
            // 
            // StopWatch
            // 
            this.StopWatch.AutoSize = true;
            this.StopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopWatch.ForeColor = System.Drawing.Color.Green;
            this.StopWatch.Location = new System.Drawing.Point(609, 290);
            this.StopWatch.Name = "StopWatch";
            this.StopWatch.Size = new System.Drawing.Size(128, 31);
            this.StopWatch.TabIndex = 9;
            this.StopWatch.Text = "00:00:00";
            // 
            // StartTimer
            // 
            this.StartTimer.Location = new System.Drawing.Point(615, 324);
            this.StartTimer.Name = "StartTimer";
            this.StartTimer.Size = new System.Drawing.Size(122, 26);
            this.StartTimer.TabIndex = 10;
            this.StartTimer.Text = "Start";
            this.StartTimer.UseVisualStyleBackColor = true;
            this.StartTimer.Click += new System.EventHandler(this.StartTimer_Click);
            // 
            // StopTimer
            // 
            this.StopTimer.Location = new System.Drawing.Point(615, 356);
            this.StopTimer.Name = "StopTimer";
            this.StopTimer.Size = new System.Drawing.Size(122, 24);
            this.StopTimer.TabIndex = 11;
            this.StopTimer.Text = "Stop";
            this.StopTimer.UseVisualStyleBackColor = true;
            this.StopTimer.Click += new System.EventHandler(this.StopTimer_Click);
            // 
            // ResetTimer
            // 
            this.ResetTimer.Location = new System.Drawing.Point(615, 386);
            this.ResetTimer.Name = "ResetTimer";
            this.ResetTimer.Size = new System.Drawing.Size(122, 24);
            this.ResetTimer.TabIndex = 12;
            this.ResetTimer.Text = "Reset";
            this.ResetTimer.UseVisualStyleBackColor = true;
            this.ResetTimer.Click += new System.EventHandler(this.ResetTimer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(470, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "LoRaWAN Stored Data";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            this.serialPort1.ReadTimeout = 5000;
            this.serialPort1.RtsEnable = true;
            // 
            // ReadLoRaData
            // 
            this.ReadLoRaData.Location = new System.Drawing.Point(191, 369);
            this.ReadLoRaData.Name = "ReadLoRaData";
            this.ReadLoRaData.Size = new System.Drawing.Size(272, 49);
            this.ReadLoRaData.TabIndex = 14;
            this.ReadLoRaData.Text = "Read LoRa Data";
            this.ReadLoRaData.UseVisualStyleBackColor = true;
            this.ReadLoRaData.Click += new System.EventHandler(this.ReadLoRaData_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(749, 434);
            this.Controls.Add(this.ReadLoRaData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResetTimer);
            this.Controls.Add(this.StopTimer);
            this.Controls.Add(this.StartTimer);
            this.Controls.Add(this.StopWatch);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoRaOutputWindow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoRaCOMPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClosePort);
            this.Controls.Add(this.OpenPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "IoT LoRa WAN Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenPort;
        private System.Windows.Forms.Button ClosePort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LoRaCOMPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox LoRaOutputWindow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Label StopWatch;
        private System.Windows.Forms.Button StartTimer;
        private System.Windows.Forms.Button StopTimer;
        private System.Windows.Forms.Button ResetTimer;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ReadLoRaData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

