namespace LibrarySQLApp
{
    partial class UserStoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.MainGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePageButton
            // 
            this.profilePageButton.AutoSize = true;
            this.profilePageButton.BackColor = System.Drawing.SystemColors.ScrollBar;
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
            this.exitLable.Location = new System.Drawing.Point(825, 31);
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
            this.panel1.Size = new System.Drawing.Size(920, 81);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(406, 32);
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
            // MainGridView
            // 
            this.MainGridView.AllowUserToAddRows = false;
            this.MainGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.MainGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MainGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.MainGridView.Location = new System.Drawing.Point(345, 106);
            this.MainGridView.Name = "MainGridView";
            this.MainGridView.ReadOnly = true;
            this.MainGridView.RowHeadersWidth = 62;
            this.MainGridView.RowTemplate.Height = 28;
            this.MainGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainGridView.Size = new System.Drawing.Size(870, 500);
            this.MainGridView.TabIndex = 2;
            // 
            // UserStoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1238, 624);
            this.Controls.Add(this.MainGridView);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "UserStoryForm";
            this.Text = "Формуляр";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGridView)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView MainGridView;
    }
}