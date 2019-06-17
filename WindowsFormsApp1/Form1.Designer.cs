namespace WindowsFormsApp1
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
            this.Tabcontrol = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.accountGrp = new System.Windows.Forms.GroupBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BOTbOX = new System.Windows.Forms.GroupBox();
            this.startBotBtn = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.GroupBox();
            this.logRTB = new System.Windows.Forms.RichTextBox();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secondePopdracht = new System.Windows.Forms.Label();
            this.secondsNumeric = new System.Windows.Forms.NumericUpDown();
            this.OpdrachtNumeric = new System.Windows.Forms.NumericUpDown();
            this.ParagraafNumeric = new System.Windows.Forms.NumericUpDown();
            this.OpdrachtLbl = new System.Windows.Forms.Label();
            this.ParagraafLbl = new System.Windows.Forms.Label();
            this.hoofdstukLbl = new System.Windows.Forms.Label();
            this.hoofdstukCB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.amountOfErrorsLbl = new System.Windows.Forms.Label();
            this.amountOfMistakesCB = new System.Windows.Forms.NumericUpDown();
            this.randomMistakesLbl = new System.Windows.Forms.Label();
            this.randomMistakesCb = new System.Windows.Forms.CheckBox();
            this.enableMistakesLbl = new System.Windows.Forms.Label();
            this.enableMistakesCb = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tabcontrol.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.accountGrp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.BOTbOX.SuspendLayout();
            this.logBox.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpdrachtNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParagraafNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfMistakesCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabcontrol
            // 
            this.Tabcontrol.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.Tabcontrol.Controls.Add(this.mainTab);
            this.Tabcontrol.Controls.Add(this.tabPage1);
            this.Tabcontrol.Controls.Add(this.settingsTab);
            this.Tabcontrol.Location = new System.Drawing.Point(0, 110);
            this.Tabcontrol.Name = "Tabcontrol";
            this.Tabcontrol.SelectedIndex = 0;
            this.Tabcontrol.Size = new System.Drawing.Size(627, 202);
            this.Tabcontrol.TabIndex = 0;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.accountGrp);
            this.mainTab.Location = new System.Drawing.Point(4, 4);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(619, 176);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // accountGrp
            // 
            this.accountGrp.Controls.Add(this.logoutBtn);
            this.accountGrp.Controls.Add(this.PasswordLbl);
            this.accountGrp.Controls.Add(this.passwordTb);
            this.accountGrp.Controls.Add(this.usernameLbl);
            this.accountGrp.Controls.Add(this.usernameTb);
            this.accountGrp.Controls.Add(this.submitBtn);
            this.accountGrp.Location = new System.Drawing.Point(8, 6);
            this.accountGrp.Name = "accountGrp";
            this.accountGrp.Size = new System.Drawing.Size(601, 164);
            this.accountGrp.TabIndex = 0;
            this.accountGrp.TabStop = false;
            this.accountGrp.Text = " Account  | Logged in: false";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Enabled = false;
            this.logoutBtn.Location = new System.Drawing.Point(339, 74);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(195, 25);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(33, 48);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(53, 13);
            this.PasswordLbl.TabIndex = 4;
            this.PasswordLbl.Text = "Password";
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(103, 48);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(431, 20);
            this.passwordTb.TabIndex = 3;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(33, 22);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "Username";
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(103, 19);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(431, 20);
            this.usernameTb.TabIndex = 1;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(138, 74);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(195, 25);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Login/Authenticate";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BOTbOX);
            this.tabPage1.Controls.Add(this.logBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(619, 176);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Bot";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BOTbOX
            // 
            this.BOTbOX.Controls.Add(this.startBotBtn);
            this.BOTbOX.Location = new System.Drawing.Point(8, 6);
            this.BOTbOX.Name = "BOTbOX";
            this.BOTbOX.Size = new System.Drawing.Size(143, 164);
            this.BOTbOX.TabIndex = 1;
            this.BOTbOX.TabStop = false;
            this.BOTbOX.Text = "Bot";
            // 
            // startBotBtn
            // 
            this.startBotBtn.Location = new System.Drawing.Point(6, 19);
            this.startBotBtn.Name = "startBotBtn";
            this.startBotBtn.Size = new System.Drawing.Size(131, 139);
            this.startBotBtn.TabIndex = 0;
            this.startBotBtn.Text = "Start bot";
            this.startBotBtn.UseVisualStyleBackColor = true;
            this.startBotBtn.Click += new System.EventHandler(this.startBotBtn_Click);
            // 
            // logBox
            // 
            this.logBox.Controls.Add(this.logRTB);
            this.logBox.Location = new System.Drawing.Point(157, 6);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(452, 164);
            this.logBox.TabIndex = 0;
            this.logBox.TabStop = false;
            this.logBox.Text = "Log(s)";
            // 
            // logRTB
            // 
            this.logRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logRTB.Location = new System.Drawing.Point(6, 19);
            this.logRTB.Name = "logRTB";
            this.logRTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.logRTB.Size = new System.Drawing.Size(440, 139);
            this.logRTB.TabIndex = 0;
            this.logRTB.Text = "";
            // 
            // settingsTab
            // 
            this.settingsTab.Controls.Add(this.groupBox2);
            this.settingsTab.Controls.Add(this.groupBox1);
            this.settingsTab.Location = new System.Drawing.Point(4, 4);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(619, 176);
            this.settingsTab.TabIndex = 1;
            this.settingsTab.Text = "Bot settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.secondePopdracht);
            this.groupBox2.Controls.Add(this.secondsNumeric);
            this.groupBox2.Controls.Add(this.OpdrachtNumeric);
            this.groupBox2.Controls.Add(this.ParagraafNumeric);
            this.groupBox2.Controls.Add(this.OpdrachtLbl);
            this.groupBox2.Controls.Add(this.ParagraafLbl);
            this.groupBox2.Controls.Add(this.hoofdstukLbl);
            this.groupBox2.Controls.Add(this.hoofdstukCB);
            this.groupBox2.Location = new System.Drawing.Point(238, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 148);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General settings";
            // 
            // secondePopdracht
            // 
            this.secondePopdracht.AutoSize = true;
            this.secondePopdracht.Location = new System.Drawing.Point(18, 116);
            this.secondePopdracht.Name = "secondePopdracht";
            this.secondePopdracht.Size = new System.Drawing.Size(113, 13);
            this.secondePopdracht.TabIndex = 8;
            this.secondePopdracht.Text = "Seconde per opdracht";
            // 
            // secondsNumeric
            // 
            this.secondsNumeric.Location = new System.Drawing.Point(164, 114);
            this.secondsNumeric.Name = "secondsNumeric";
            this.secondsNumeric.Size = new System.Drawing.Size(191, 20);
            this.secondsNumeric.TabIndex = 7;
            this.secondsNumeric.ValueChanged += new System.EventHandler(this.secondsNumeric_ValueChanged);
            // 
            // OpdrachtNumeric
            // 
            this.OpdrachtNumeric.Location = new System.Drawing.Point(164, 88);
            this.OpdrachtNumeric.Name = "OpdrachtNumeric";
            this.OpdrachtNumeric.Size = new System.Drawing.Size(191, 20);
            this.OpdrachtNumeric.TabIndex = 6;
            this.OpdrachtNumeric.ValueChanged += new System.EventHandler(this.OpdrachtNumeric_ValueChanged);
            // 
            // ParagraafNumeric
            // 
            this.ParagraafNumeric.Location = new System.Drawing.Point(164, 59);
            this.ParagraafNumeric.Name = "ParagraafNumeric";
            this.ParagraafNumeric.Size = new System.Drawing.Size(191, 20);
            this.ParagraafNumeric.TabIndex = 5;
            this.ParagraafNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // OpdrachtLbl
            // 
            this.OpdrachtLbl.AutoSize = true;
            this.OpdrachtLbl.Location = new System.Drawing.Point(18, 88);
            this.OpdrachtLbl.Name = "OpdrachtLbl";
            this.OpdrachtLbl.Size = new System.Drawing.Size(51, 13);
            this.OpdrachtLbl.TabIndex = 4;
            this.OpdrachtLbl.Text = "Opdracht";
            // 
            // ParagraafLbl
            // 
            this.ParagraafLbl.AutoSize = true;
            this.ParagraafLbl.Location = new System.Drawing.Point(18, 59);
            this.ParagraafLbl.Name = "ParagraafLbl";
            this.ParagraafLbl.Size = new System.Drawing.Size(53, 13);
            this.ParagraafLbl.TabIndex = 3;
            this.ParagraafLbl.Text = "Paragraaf";
            // 
            // hoofdstukLbl
            // 
            this.hoofdstukLbl.AutoSize = true;
            this.hoofdstukLbl.Location = new System.Drawing.Point(18, 27);
            this.hoofdstukLbl.Name = "hoofdstukLbl";
            this.hoofdstukLbl.Size = new System.Drawing.Size(56, 13);
            this.hoofdstukLbl.TabIndex = 2;
            this.hoofdstukLbl.Text = "Hoofdstuk";
            // 
            // hoofdstukCB
            // 
            this.hoofdstukCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoofdstukCB.FormattingEnabled = true;
            this.hoofdstukCB.ImeMode = System.Windows.Forms.ImeMode.On;
            this.hoofdstukCB.Location = new System.Drawing.Point(164, 24);
            this.hoofdstukCB.Name = "hoofdstukCB";
            this.hoofdstukCB.Size = new System.Drawing.Size(191, 21);
            this.hoofdstukCB.TabIndex = 1;
            this.hoofdstukCB.Tag = "";
            this.hoofdstukCB.SelectedIndexChanged += new System.EventHandler(this.hoofdstukCB_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.amountOfErrorsLbl);
            this.groupBox1.Controls.Add(this.amountOfMistakesCB);
            this.groupBox1.Controls.Add(this.randomMistakesLbl);
            this.groupBox1.Controls.Add(this.randomMistakesCb);
            this.groupBox1.Controls.Add(this.enableMistakesLbl);
            this.groupBox1.Controls.Add(this.enableMistakesCb);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mistake settings";
            // 
            // amountOfErrorsLbl
            // 
            this.amountOfErrorsLbl.AutoSize = true;
            this.amountOfErrorsLbl.Enabled = false;
            this.amountOfErrorsLbl.Location = new System.Drawing.Point(6, 88);
            this.amountOfErrorsLbl.Name = "amountOfErrorsLbl";
            this.amountOfErrorsLbl.Size = new System.Drawing.Size(99, 13);
            this.amountOfErrorsLbl.TabIndex = 5;
            this.amountOfErrorsLbl.Text = "Amount of mistakes";
            // 
            // amountOfMistakesCB
            // 
            this.amountOfMistakesCB.Enabled = false;
            this.amountOfMistakesCB.Location = new System.Drawing.Point(166, 88);
            this.amountOfMistakesCB.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.amountOfMistakesCB.Name = "amountOfMistakesCB";
            this.amountOfMistakesCB.Size = new System.Drawing.Size(52, 20);
            this.amountOfMistakesCB.TabIndex = 4;
            this.amountOfMistakesCB.ValueChanged += new System.EventHandler(this.amountOfMistakesCB_ValueChanged);
            // 
            // randomMistakesLbl
            // 
            this.randomMistakesLbl.AutoSize = true;
            this.randomMistakesLbl.Enabled = false;
            this.randomMistakesLbl.Location = new System.Drawing.Point(6, 58);
            this.randomMistakesLbl.Name = "randomMistakesLbl";
            this.randomMistakesLbl.Size = new System.Drawing.Size(162, 13);
            this.randomMistakesLbl.TabIndex = 3;
            this.randomMistakesLbl.Text = "Random amount of mistakes(0-4)";
            // 
            // randomMistakesCb
            // 
            this.randomMistakesCb.AutoSize = true;
            this.randomMistakesCb.Enabled = false;
            this.randomMistakesCb.Location = new System.Drawing.Point(203, 58);
            this.randomMistakesCb.Name = "randomMistakesCb";
            this.randomMistakesCb.Size = new System.Drawing.Size(15, 14);
            this.randomMistakesCb.TabIndex = 2;
            this.randomMistakesCb.UseVisualStyleBackColor = true;
            this.randomMistakesCb.CheckedChanged += new System.EventHandler(this.randomMistakesCb_CheckedChanged);
            // 
            // enableMistakesLbl
            // 
            this.enableMistakesLbl.AutoSize = true;
            this.enableMistakesLbl.Location = new System.Drawing.Point(6, 32);
            this.enableMistakesLbl.Name = "enableMistakesLbl";
            this.enableMistakesLbl.Size = new System.Drawing.Size(84, 13);
            this.enableMistakesLbl.TabIndex = 1;
            this.enableMistakesLbl.Text = "Enable mistakes";
            // 
            // enableMistakesCb
            // 
            this.enableMistakesCb.AutoSize = true;
            this.enableMistakesCb.Location = new System.Drawing.Point(203, 32);
            this.enableMistakesCb.Name = "enableMistakesCb";
            this.enableMistakesCb.Size = new System.Drawing.Size(15, 14);
            this.enableMistakesCb.TabIndex = 0;
            this.enableMistakesCb.UseVisualStyleBackColor = true;
            this.enableMistakesCb.CheckedChanged += new System.EventHandler(this.enableMistakesCb_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LazyCom.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 312);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Tabcontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Lazycom | Not logged in";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tabcontrol.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.accountGrp.ResumeLayout(false);
            this.accountGrp.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.BOTbOX.ResumeLayout(false);
            this.logBox.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpdrachtNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParagraafNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountOfMistakesCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabcontrol;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox accountGrp;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label enableMistakesLbl;
        private System.Windows.Forms.CheckBox enableMistakesCb;
        private System.Windows.Forms.Label randomMistakesLbl;
        private System.Windows.Forms.CheckBox randomMistakesCb;
        private System.Windows.Forms.Label amountOfErrorsLbl;
        private System.Windows.Forms.NumericUpDown amountOfMistakesCB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label hoofdstukLbl;
        private System.Windows.Forms.ComboBox hoofdstukCB;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox BOTbOX;
        private System.Windows.Forms.GroupBox logBox;
        private System.Windows.Forms.RichTextBox logRTB;
        private System.Windows.Forms.Button startBotBtn;
        private System.Windows.Forms.NumericUpDown OpdrachtNumeric;
        private System.Windows.Forms.NumericUpDown ParagraafNumeric;
        private System.Windows.Forms.Label OpdrachtLbl;
        private System.Windows.Forms.Label ParagraafLbl;
        private System.Windows.Forms.Label secondePopdracht;
        private System.Windows.Forms.NumericUpDown secondsNumeric;
    }
}

