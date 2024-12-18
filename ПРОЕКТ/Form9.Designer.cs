namespace ПРОЕКТ
{
    partial class Chupter
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
            btnListFunder = new Button();
            btnListName = new Button();
            btnListNameForm = new Button();
            btnListLog = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnListFunder
            // 
            btnListFunder.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnListFunder.Location = new Point(12, 158);
            btnListFunder.Name = "btnListFunder";
            btnListFunder.Size = new Size(377, 48);
            btnListFunder.TabIndex = 58;
            btnListFunder.Text = "Cписок основных средств ";
            btnListFunder.UseVisualStyleBackColor = true;
            btnListFunder.Click += btnListFunder_Click;
            // 
            // btnListName
            // 
            btnListName.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnListName.Location = new Point(12, 84);
            btnListName.Name = "btnListName";
            btnListName.Size = new Size(377, 48);
            btnListName.TabIndex = 59;
            btnListName.Text = "Список материально ответственных лиц";
            btnListName.UseVisualStyleBackColor = true;
            btnListName.Click += btnListName_Click;
            // 
            // btnListNameForm
            // 
            btnListNameForm.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnListNameForm.Location = new Point(12, 231);
            btnListNameForm.Name = "btnListNameForm";
            btnListNameForm.Size = new Size(377, 48);
            btnListNameForm.TabIndex = 60;
            btnListNameForm.Text = "Cписок категорий основных средств";
            btnListNameForm.UseVisualStyleBackColor = true;
            btnListNameForm.Click += btnListNameForm_Click;
            // 
            // btnListLog
            // 
            btnListLog.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnListLog.Location = new Point(12, 303);
            btnListLog.Name = "btnListLog";
            btnListLog.Size = new Size(377, 48);
            btnListLog.TabIndex = 61;
            btnListLog.Text = "журнал учета состояния основных средств";
            btnListLog.UseVisualStyleBackColor = true;
            btnListLog.Click += btnListLog_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(98, 32);
            label1.Name = "label1";
            label1.Size = new Size(207, 27);
            label1.TabIndex = 62;
            label1.Text = "Выберите раздел";
            // 
            // Chupter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.photo;
            ClientSize = new Size(401, 367);
            Controls.Add(label1);
            Controls.Add(btnListLog);
            Controls.Add(btnListNameForm);
            Controls.Add(btnListName);
            Controls.Add(btnListFunder);
            Name = "Chupter";
            Text = "Списки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListFunder;
        private Button btnListName;
        private Button btnListNameForm;
        private Button btnListLog;
        private Label label1;
    }
}