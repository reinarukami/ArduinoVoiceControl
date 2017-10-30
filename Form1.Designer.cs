namespace ArduinoVoiceControl
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
            this.LED1 = new System.Windows.Forms.CheckBox();
            this.LED2 = new System.Windows.Forms.CheckBox();
            this.LED3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usb_ports = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LED1
            // 
            this.LED1.AutoSize = true;
            this.LED1.Location = new System.Drawing.Point(6, 21);
            this.LED1.Name = "LED1";
            this.LED1.Size = new System.Drawing.Size(65, 21);
            this.LED1.TabIndex = 0;
            this.LED1.Text = "LED1";
            this.LED1.UseVisualStyleBackColor = true;
            this.LED1.CheckedChanged += new System.EventHandler(this.LED1_CheckedChanged);
            // 
            // LED2
            // 
            this.LED2.AutoSize = true;
            this.LED2.Location = new System.Drawing.Point(6, 48);
            this.LED2.Name = "LED2";
            this.LED2.Size = new System.Drawing.Size(65, 21);
            this.LED2.TabIndex = 1;
            this.LED2.Text = "LED2";
            this.LED2.UseVisualStyleBackColor = true;
            this.LED2.CheckedChanged += new System.EventHandler(this.LED2_CheckedChanged);
            // 
            // LED3
            // 
            this.LED3.AutoSize = true;
            this.LED3.Location = new System.Drawing.Point(6, 75);
            this.LED3.Name = "LED3";
            this.LED3.Size = new System.Drawing.Size(65, 21);
            this.LED3.TabIndex = 2;
            this.LED3.Text = "LED3";
            this.LED3.UseVisualStyleBackColor = true;
            this.LED3.CheckedChanged += new System.EventHandler(this.LED3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LED2);
            this.groupBox1.Controls.Add(this.LED3);
            this.groupBox1.Controls.Add(this.LED1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED";
            // 
            // usb_ports
            // 
            this.usb_ports.FormattingEnabled = true;
            this.usb_ports.Location = new System.Drawing.Point(225, 44);
            this.usb_ports.Name = "usb_ports";
            this.usb_ports.Size = new System.Drawing.Size(197, 24);
            this.usb_ports.TabIndex = 4;
            this.usb_ports.SelectedIndexChanged += new System.EventHandler(this.usb_ports_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 571);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usb_ports);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox LED1;
        private System.Windows.Forms.CheckBox LED2;
        private System.Windows.Forms.CheckBox LED3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox usb_ports;
        private System.Windows.Forms.Button button1;
    }
}

