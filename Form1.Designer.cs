namespace C__inclass_assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabcontrol1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tabcontrol1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol1
            // 
            this.tabcontrol1.Controls.Add(this.tabLogin);
            this.tabcontrol1.Controls.Add(this.tabHome);
            this.tabcontrol1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tabcontrol1.Location = new System.Drawing.Point(2, 1);
            this.tabcontrol1.Name = "tabcontrol1";
            this.tabcontrol1.SelectedIndex = 0;
            this.tabcontrol1.Size = new System.Drawing.Size(1138, 781);
            this.tabcontrol1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabLogin.BackgroundImage")));
            this.tabLogin.Controls.Add(this.button1);
            this.tabLogin.Controls.Add(this.txtPassword);
            this.tabLogin.Controls.Add(this.txtUsername);
            this.tabLogin.Controls.Add(this.textBox2);
            this.tabLogin.Controls.Add(this.textBox1);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(1130, 755);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(508, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtPassword.Location = new System.Drawing.Point(389, 231);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(94, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password:";
            this.txtPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtUsername.Location = new System.Drawing.Point(386, 187);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(97, 22);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Username:";
            this.txtUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(508, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(508, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabHome
            // 
            this.tabHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabHome.BackgroundImage")));
            this.tabHome.Controls.Add(this.radioButton3);
            this.tabHome.Controls.Add(this.radioButton2);
            this.tabHome.Controls.Add(this.label2);
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Controls.Add(this.listBox2);
            this.tabHome.Controls.Add(this.listBox1);
            this.tabHome.Controls.Add(this.checkBox4);
            this.tabHome.Controls.Add(this.checkBox3);
            this.tabHome.Controls.Add(this.checkBox2);
            this.tabHome.Controls.Add(this.checkBox1);
            this.tabHome.Controls.Add(this.radioButton1);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(1130, 755);
            this.tabHome.TabIndex = 1;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox4.Location = new System.Drawing.Point(346, 145);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(60, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Scarab";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox3.Location = new System.Drawing.Point(346, 122);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(62, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Fennec";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox2.Location = new System.Drawing.Point(346, 99);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Octane";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(346, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Dominus";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(452, 76);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "0-1000";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Ranks",
            "Gamemodes",
            "Players"});
            this.listBox1.Location = new System.Drawing.Point(560, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 69);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(734, 50);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(146, 121);
            this.listBox2.TabIndex = 6;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(343, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Favorite Car?";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(459, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hours?";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(452, 98);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(76, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "1000-5000";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton3.Location = new System.Drawing.Point(452, 121);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 17);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "5000+";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 794);
            this.Controls.Add(this.tabcontrol1);
            this.Name = "Form1";
            this.Text = "C# assignment ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabcontrol1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtPassword;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

