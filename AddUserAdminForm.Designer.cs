namespace LibrarySQLApp
{
    partial class AddUserAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserAdminForm));
            this.profilePageButton = new System.Windows.Forms.Button();
            this.exitLable = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.roleLabel = new System.Windows.Forms.Label();
            this.booksPageButton = new System.Windows.Forms.Button();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.reportPageButton = new System.Windows.Forms.Button();
            this.issuancePageButton = new System.Windows.Forms.Button();
            this.booksAdminPageButton = new System.Windows.Forms.Button();
            this.usersAdminPageButton = new System.Windows.Forms.Button();
            this.userStoryPageButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.getBack = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getBack)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePageButton
            // 
            this.profilePageButton.AutoSize = true;
            this.profilePageButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.profilePageButton.Enabled = false;
            this.profilePageButton.FlatAppearance.BorderSize = 0;
            this.profilePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilePageButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.profilePageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.profilePageButton.Location = new System.Drawing.Point(12, 17);
            this.profilePageButton.Name = "profilePageButton";
            this.profilePageButton.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.profilePageButton.Size = new System.Drawing.Size(300, 60);
            this.profilePageButton.TabIndex = 2;
            this.profilePageButton.Text = "Профиль";
            this.profilePageButton.UseVisualStyleBackColor = false;
            this.profilePageButton.Click += new System.EventHandler(this.profilePageButton_Click);
            // 
            // exitLable
            // 
            this.exitLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitLable.AutoSize = true;
            this.exitLable.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitLable.ForeColor = System.Drawing.Color.DimGray;
            this.exitLable.Location = new System.Drawing.Point(809, 31);
            this.exitLable.Name = "exitLable";
            this.exitLable.Size = new System.Drawing.Size(72, 24);
            this.exitLable.TabIndex = 2;
            this.exitLable.Text = "Выйти";
            this.exitLable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitLable.Click += new System.EventHandler(this.exitLable_Click);
            this.exitLable.MouseEnter += new System.EventHandler(this.exitLable_MouseEnter);
            this.exitLable.MouseLeave += new System.EventHandler(this.exitLable_MouseLeave);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(279, 34);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Имя пользователя";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.exitLable);
            this.panel1.Location = new System.Drawing.Point(318, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 81);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Controls.Add(this.nameLabel);
            this.flowLayoutPanel1.Controls.Add(this.roleLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(752, 32);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // roleLabel
            // 
            this.roleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.roleLabel.Location = new System.Drawing.Point(288, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(55, 34);
            this.roleLabel.TabIndex = 3;
            this.roleLabel.Text = "роль";
            this.roleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booksPageButton
            // 
            this.booksPageButton.AutoSize = true;
            this.booksPageButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.booksPageButton.Enabled = false;
            this.booksPageButton.FlatAppearance.BorderSize = 0;
            this.booksPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksPageButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booksPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.booksPageButton.Location = new System.Drawing.Point(12, 106);
            this.booksPageButton.Name = "booksPageButton";
            this.booksPageButton.Size = new System.Drawing.Size(300, 60);
            this.booksPageButton.TabIndex = 2;
            this.booksPageButton.Text = "Библиотека";
            this.booksPageButton.UseVisualStyleBackColor = false;
            this.booksPageButton.Click += new System.EventHandler(this.booksPageButton_Click);
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.AutoScroll = true;
            this.NavigationPanel.AutoScrollMinSize = new System.Drawing.Size(0, 100);
            this.NavigationPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NavigationPanel.Controls.Add(this.adminPanel);
            this.NavigationPanel.Controls.Add(this.userStoryPageButton);
            this.NavigationPanel.Controls.Add(this.profilePageButton);
            this.NavigationPanel.Controls.Add(this.booksPageButton);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(322, 624);
            this.NavigationPanel.TabIndex = 1;
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.adminPanel.Controls.Add(this.reportPageButton);
            this.adminPanel.Controls.Add(this.issuancePageButton);
            this.adminPanel.Controls.Add(this.booksAdminPageButton);
            this.adminPanel.Controls.Add(this.usersAdminPageButton);
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminPanel.Location = new System.Drawing.Point(0, 264);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(322, 360);
            this.adminPanel.TabIndex = 5;
            // 
            // reportPageButton
            // 
            this.reportPageButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reportPageButton.AutoSize = true;
            this.reportPageButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.reportPageButton.Enabled = false;
            this.reportPageButton.FlatAppearance.BorderSize = 0;
            this.reportPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportPageButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportPageButton.Location = new System.Drawing.Point(12, 282);
            this.reportPageButton.Name = "reportPageButton";
            this.reportPageButton.Size = new System.Drawing.Size(300, 60);
            this.reportPageButton.TabIndex = 7;
            this.reportPageButton.Text = "Отчёты";
            this.reportPageButton.UseVisualStyleBackColor = false;
            this.reportPageButton.Click += new System.EventHandler(this.reportPageButton_Click);
            // 
            // issuancePageButton
            // 
            this.issuancePageButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.issuancePageButton.AutoSize = true;
            this.issuancePageButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.issuancePageButton.Enabled = false;
            this.issuancePageButton.FlatAppearance.BorderSize = 0;
            this.issuancePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issuancePageButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.issuancePageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.issuancePageButton.Location = new System.Drawing.Point(12, 194);
            this.issuancePageButton.Name = "issuancePageButton";
            this.issuancePageButton.Size = new System.Drawing.Size(300, 60);
            this.issuancePageButton.TabIndex = 6;
            this.issuancePageButton.Text = "Выдачи";
            this.issuancePageButton.UseVisualStyleBackColor = false;
            this.issuancePageButton.Click += new System.EventHandler(this.issuancePageButton_Click);
            // 
            // booksAdminPageButton
            // 
            this.booksAdminPageButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.booksAdminPageButton.AutoSize = true;
            this.booksAdminPageButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.booksAdminPageButton.Enabled = false;
            this.booksAdminPageButton.FlatAppearance.BorderSize = 0;
            this.booksAdminPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booksAdminPageButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booksAdminPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.booksAdminPageButton.Location = new System.Drawing.Point(12, 104);
            this.booksAdminPageButton.Name = "booksAdminPageButton";
            this.booksAdminPageButton.Size = new System.Drawing.Size(300, 60);
            this.booksAdminPageButton.TabIndex = 5;
            this.booksAdminPageButton.Text = "Книги";
            this.booksAdminPageButton.UseVisualStyleBackColor = false;
            this.booksAdminPageButton.Click += new System.EventHandler(this.booksAdminPageButton_Click);
            // 
            // usersAdminPageButton
            // 
            this.usersAdminPageButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usersAdminPageButton.AutoSize = true;
            this.usersAdminPageButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.usersAdminPageButton.Enabled = false;
            this.usersAdminPageButton.FlatAppearance.BorderSize = 0;
            this.usersAdminPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersAdminPageButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersAdminPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usersAdminPageButton.Location = new System.Drawing.Point(12, 16);
            this.usersAdminPageButton.Name = "usersAdminPageButton";
            this.usersAdminPageButton.Size = new System.Drawing.Size(300, 60);
            this.usersAdminPageButton.TabIndex = 4;
            this.usersAdminPageButton.Text = "Пользователи";
            this.usersAdminPageButton.UseVisualStyleBackColor = false;
            this.usersAdminPageButton.Click += new System.EventHandler(this.usersAdminPageButton_Click);
            // 
            // userStoryPageButton
            // 
            this.userStoryPageButton.AutoSize = true;
            this.userStoryPageButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.userStoryPageButton.Enabled = false;
            this.userStoryPageButton.FlatAppearance.BorderSize = 0;
            this.userStoryPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userStoryPageButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userStoryPageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userStoryPageButton.Location = new System.Drawing.Point(12, 193);
            this.userStoryPageButton.Name = "userStoryPageButton";
            this.userStoryPageButton.Size = new System.Drawing.Size(300, 60);
            this.userStoryPageButton.TabIndex = 3;
            this.userStoryPageButton.Text = "Формуляр";
            this.userStoryPageButton.UseVisualStyleBackColor = false;
            this.userStoryPageButton.Click += new System.EventHandler(this.userStoryPageButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SaveButton.AutoSize = true;
            this.SaveButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveButton.Location = new System.Drawing.Point(946, 546);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(253, 60);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(389, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Имя: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(389, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фамилия: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(389, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Группа: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(389, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Роль: ";
            // 
            // roleComboBox
            // 
            this.roleComboBox.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.roleComboBox.Location = new System.Drawing.Point(552, 358);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(206, 32);
            this.roleComboBox.TabIndex = 13;
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fnameTextBox.Location = new System.Drawing.Point(552, 109);
            this.fnameTextBox.MaxLength = 20;
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(206, 32);
            this.fnameTextBox.TabIndex = 14;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnameTextBox.Location = new System.Drawing.Point(552, 190);
            this.lnameTextBox.MaxLength = 20;
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(206, 32);
            this.lnameTextBox.TabIndex = 15;
            // 
            // groupTextBox
            // 
            this.groupTextBox.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupTextBox.Location = new System.Drawing.Point(552, 274);
            this.groupTextBox.MaxLength = 12;
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(206, 32);
            this.groupTextBox.TabIndex = 16;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(552, 438);
            this.loginTextBox.MaxLength = 20;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(206, 32);
            this.loginTextBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(389, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Логин: ";
            // 
            // getBack
            // 
            this.getBack.BackColor = System.Drawing.SystemColors.Control;
            this.getBack.Image = ((System.Drawing.Image)(resources.GetObject("getBack.Image")));
            this.getBack.Location = new System.Drawing.Point(1153, 106);
            this.getBack.Name = "getBack";
            this.getBack.Size = new System.Drawing.Size(46, 35);
            this.getBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.getBack.TabIndex = 19;
            this.getBack.TabStop = false;
            this.getBack.Click += new System.EventHandler(this.getBack_Click);
            this.getBack.MouseEnter += new System.EventHandler(this.getBack_MouseEnter);
            this.getBack.MouseLeave += new System.EventHandler(this.getBack_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(420, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "если есть";
            // 
            // passTextBox
            // 
            this.passTextBox.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTextBox.Location = new System.Drawing.Point(552, 530);
            this.passTextBox.MaxLength = 20;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(206, 32);
            this.passTextBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(389, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 29);
            this.label7.TabIndex = 21;
            this.label7.Text = "Пароль: ";
            // 
            // AddUserAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1222, 624);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.getBack);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "AddUserAdminForm";
            this.Text = "Управление пользователями";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.getBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exitLable;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button profilePageButton;
        private System.Windows.Forms.Button booksPageButton;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button usersAdminPageButton;
        private System.Windows.Forms.Button userStoryPageButton;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button booksAdminPageButton;
        private System.Windows.Forms.Button issuancePageButton;
        private System.Windows.Forms.Button reportPageButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox getBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label7;
    }
}