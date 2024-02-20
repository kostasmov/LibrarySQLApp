namespace LibrarySQLApp
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
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
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.publisherBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.getBack = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
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
            // 
            // exitLable
            // 
            this.exitLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitLable.AutoSize = true;
            this.exitLable.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitLable.ForeColor = System.Drawing.Color.DimGray;
            this.exitLable.Location = new System.Drawing.Point(855, 31);
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
            this.panel1.Size = new System.Drawing.Size(950, 81);
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
            this.SaveButton.Location = new System.Drawing.Point(984, 517);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(250, 70);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(390, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(390, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Издатель: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(390, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Год: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(865, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Тип: ";
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "fiction",
            "technic"});
            this.typeBox.Location = new System.Drawing.Point(968, 344);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(206, 37);
            this.typeBox.TabIndex = 13;
            // 
            // titleBox
            // 
            this.titleBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleBox.Location = new System.Drawing.Point(573, 136);
            this.titleBox.MaxLength = 20;
            this.titleBox.Multiline = true;
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(608, 77);
            this.titleBox.TabIndex = 14;
            // 
            // publisherBox
            // 
            this.publisherBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publisherBox.Location = new System.Drawing.Point(573, 258);
            this.publisherBox.MaxLength = 20;
            this.publisherBox.Name = "publisherBox";
            this.publisherBox.Size = new System.Drawing.Size(608, 36);
            this.publisherBox.TabIndex = 15;
            // 
            // yearBox
            // 
            this.yearBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearBox.Location = new System.Drawing.Point(573, 345);
            this.yearBox.MaxLength = 12;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(206, 36);
            this.yearBox.TabIndex = 16;
            // 
            // amountBox
            // 
            this.amountBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountBox.Location = new System.Drawing.Point(573, 435);
            this.amountBox.MaxLength = 20;
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(206, 36);
            this.amountBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(390, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Количество:";
            // 
            // getBack
            // 
            this.getBack.BackColor = System.Drawing.SystemColors.Control;
            this.getBack.Image = ((System.Drawing.Image)(resources.GetObject("getBack.Image")));
            this.getBack.Location = new System.Drawing.Point(1199, 106);
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
            this.label6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(341, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(515, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Авторов можно указать через окно изменения книги";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1268, 624);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.getBack);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.publisherBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "AddBookForm";
            this.Text = "Добавление книги";
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
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox publisherBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox getBack;
        private System.Windows.Forms.Label label6;
    }
}