namespace LibrarySQLApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.passField = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.header.Font = new System.Drawing.Font("Roboto", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.ForeColor = System.Drawing.SystemColors.ControlText;
            this.header.Location = new System.Drawing.Point(1, 36);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1194, 92);
            this.header.TabIndex = 0;
            this.header.Text = "Авторизация";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.loginField.Location = new System.Drawing.Point(364, 189);
            this.loginField.MaxLength = 20;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(441, 46);
            this.loginField.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(359, 157);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(67, 24);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLabel.Location = new System.Drawing.Point(359, 266);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(80, 24);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Пароль";
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.passField.Location = new System.Drawing.Point(364, 298);
            this.passField.MaxLength = 20;
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(441, 44);
            this.passField.TabIndex = 3;
            this.passField.UseSystemPasswordChar = true;
            // 
            // enterButton
            // 
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.enterButton.Location = new System.Drawing.Point(455, 401);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(262, 85);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1196, 574);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.header);
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button enterButton;
    }
}

