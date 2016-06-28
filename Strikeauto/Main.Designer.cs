namespace Strikeauto
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.SecTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.HostTxt = new System.Windows.Forms.TextBox();
            this.PortTxt = new System.Windows.Forms.NumericUpDown();
            this.MethodTxt = new System.Windows.Forms.ComboBox();
            this.TimeTxt = new System.Windows.Forms.NumericUpDown();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.RepeatTxt = new System.Windows.Forms.NumericUpDown();
            this.BootStatusTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NotificationLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PortTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Location = new System.Drawing.Point(12, 47);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(141, 20);
            this.UsernameTxt.TabIndex = 0;
            this.UsernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsernameTxt.TextChanged += new System.EventHandler(this.ValidateLogin);
            // 
            // SecTxt
            // 
            this.SecTxt.Location = new System.Drawing.Point(12, 123);
            this.SecTxt.Name = "SecTxt";
            this.SecTxt.Size = new System.Drawing.Size(141, 20);
            this.SecTxt.TabIndex = 2;
            this.SecTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(12, 85);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '•';
            this.PasswordTxt.Size = new System.Drawing.Size(141, 20);
            this.PasswordTxt.TabIndex = 1;
            this.PasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.ValidateLogin);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Enabled = false;
            this.LoginBtn.Location = new System.Drawing.Point(12, 149);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(141, 23);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "StrikeOut - Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "2FA Code:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(-3, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(162, -19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 220);
            this.panel2.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(0, 53);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 1);
            this.panel6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.StatusLbl.Location = new System.Drawing.Point(48, 179);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(30, 13);
            this.StatusLbl.TabIndex = 11;
            this.StatusLbl.Text = "Idle..";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(0, -6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 220);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(-8, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 1);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(743, -11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 220);
            this.panel5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(563, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "StrikeOut - Booter Menu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Location = new System.Drawing.Point(163, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(800, 1);
            this.panel7.TabIndex = 13;
            // 
            // HostTxt
            // 
            this.HostTxt.Location = new System.Drawing.Point(202, 72);
            this.HostTxt.Name = "HostTxt";
            this.HostTxt.Size = new System.Drawing.Size(371, 20);
            this.HostTxt.TabIndex = 14;
            this.HostTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HostTxt.TextChanged += new System.EventHandler(this.HostTxt_TextChanged);
            // 
            // PortTxt
            // 
            this.PortTxt.Location = new System.Drawing.Point(579, 72);
            this.PortTxt.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(120, 20);
            this.PortTxt.TabIndex = 15;
            this.PortTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PortTxt.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // MethodTxt
            // 
            this.MethodTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodTxt.FormattingEnabled = true;
            this.MethodTxt.Items.AddRange(new object[] {
            "SSDP",
            "TCP",
            "OVH",
            "TCPFLAG",
            "SOURCE",
            "NTP",
            "CHARGEN",
            "XTS3"});
            this.MethodTxt.Location = new System.Drawing.Point(202, 109);
            this.MethodTxt.Name = "MethodTxt";
            this.MethodTxt.Size = new System.Drawing.Size(371, 21);
            this.MethodTxt.TabIndex = 16;
            // 
            // TimeTxt
            // 
            this.TimeTxt.Location = new System.Drawing.Point(579, 110);
            this.TimeTxt.Maximum = new decimal(new int[] {
            2147000000,
            0,
            0,
            0});
            this.TimeTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeTxt.Name = "TimeTxt";
            this.TimeTxt.Size = new System.Drawing.Size(120, 20);
            this.TimeTxt.TabIndex = 17;
            this.TimeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TimeTxt.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // StartBtn
            // 
            this.StartBtn.Enabled = false;
            this.StartBtn.Location = new System.Drawing.Point(202, 136);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(111, 23);
            this.StartBtn.TabIndex = 18;
            this.StartBtn.Text = "Start (1)";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(462, 136);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(111, 23);
            this.StopBtn.TabIndex = 19;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            // 
            // RepeatTxt
            // 
            this.RepeatTxt.Location = new System.Drawing.Point(325, 138);
            this.RepeatTxt.Maximum = new decimal(new int[] {
            2147000000,
            0,
            0,
            0});
            this.RepeatTxt.Name = "RepeatTxt";
            this.RepeatTxt.Size = new System.Drawing.Size(120, 20);
            this.RepeatTxt.TabIndex = 20;
            this.RepeatTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RepeatTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RepeatTxt.ValueChanged += new System.EventHandler(this.RepeatTxt_ValueChanged);
            // 
            // BootStatusTxt
            // 
            this.BootStatusTxt.AutoSize = true;
            this.BootStatusTxt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BootStatusTxt.Location = new System.Drawing.Point(615, 133);
            this.BootStatusTxt.Name = "BootStatusTxt";
            this.BootStatusTxt.Size = new System.Drawing.Size(30, 13);
            this.BootStatusTxt.TabIndex = 22;
            this.BootStatusTxt.Text = "Idle..";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(576, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Internet Protocol (IP) / Hostname:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Booting Method:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(576, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Port:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(576, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Time:";
            // 
            // NotificationLbl
            // 
            this.NotificationLbl.AutoSize = true;
            this.NotificationLbl.Location = new System.Drawing.Point(199, 162);
            this.NotificationLbl.Name = "NotificationLbl";
            this.NotificationLbl.Size = new System.Drawing.Size(204, 13);
            this.NotificationLbl.TabIndex = 27;
            this.NotificationLbl.Text = "*Putting repeat to 0 results in infinite boots";
            this.NotificationLbl.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 202);
            this.Controls.Add(this.NotificationLbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BootStatusTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RepeatTxt);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.TimeTxt);
            this.Controls.Add(this.MethodTxt);
            this.Controls.Add(this.PortTxt);
            this.Controls.Add(this.HostTxt);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.SecTxt);
            this.Controls.Add(this.UsernameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "StrikeAuto - Booting the easy way!";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PortTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox SecTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StatusLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox HostTxt;
        private System.Windows.Forms.NumericUpDown PortTxt;
        private System.Windows.Forms.ComboBox MethodTxt;
        private System.Windows.Forms.NumericUpDown TimeTxt;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.NumericUpDown RepeatTxt;
        private System.Windows.Forms.Label BootStatusTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label NotificationLbl;
    }
}

