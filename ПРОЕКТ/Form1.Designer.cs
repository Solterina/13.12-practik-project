namespace ПРОЕКТ
{
    partial class Authorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegister = new Button();
            txtawt = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtLogin = new TextBox();
            lblLogin = new Label();
            btnList = new Button();
            btnReductList = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnRegister.Location = new Point(776, 12);
            btnRegister.Margin = new Padding(4, 3, 4, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(188, 48);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "Зарегистрировать сотрудника";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // txtawt
            // 
            txtawt.AutoSize = true;
            txtawt.BackColor = Color.Transparent;
            txtawt.Font = new Font("Microsoft Tai Le", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtawt.ForeColor = SystemColors.ButtonHighlight;
            txtawt.Location = new Point(373, 133);
            txtawt.Margin = new Padding(4, 0, 4, 0);
            txtawt.Name = "txtawt";
            txtawt.Size = new Size(236, 41);
            txtawt.TabIndex = 13;
            txtawt.Text = "Авторизация";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Transparent;
            lblPassword.Location = new Point(326, 275);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(95, 27);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Пароль";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(522, 375);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(128, 48);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtPassword.ForeColor = SystemColors.ScrollBar;
            txtPassword.Location = new Point(332, 309);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(318, 35);
            txtPassword.TabIndex = 10;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLogin.ForeColor = SystemColors.ScrollBar;
            txtLogin.Location = new Point(332, 218);
            txtLogin.Margin = new Padding(4, 3, 4, 3);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(318, 35);
            txtLogin.TabIndex = 9;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.Location = new Point(326, 184);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(77, 27);
            lblLogin.TabIndex = 8;
            lblLogin.Text = "Логин";
            // 
            // btnList
            // 
            btnList.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnList.Location = new Point(830, 497);
            btnList.Margin = new Padding(4, 3, 4, 3);
            btnList.Name = "btnList";
            btnList.Size = new Size(134, 48);
            btnList.TabIndex = 15;
            btnList.Text = "Списки";
            btnList.UseVisualStyleBackColor = true;
            // 
            // btnReductList
            // 
            btnReductList.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnReductList.Location = new Point(568, 12);
            btnReductList.Margin = new Padding(4, 3, 4, 3);
            btnReductList.Name = "btnReductList";
            btnReductList.Size = new Size(188, 48);
            btnReductList.TabIndex = 16;
            btnReductList.Text = "Редактировать списки";
            btnReductList.UseVisualStyleBackColor = true;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(977, 557);
            Controls.Add(btnReductList);
            Controls.Add(btnList);
            Controls.Add(btnRegister);
            Controls.Add(txtawt);
            Controls.Add(lblPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Name = "Authorization";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label txtawt;
        private Label lblPassword;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtLogin;
        private Label lblLogin;
        private Button btnList;
        private Button btnReductList;
    }
}
