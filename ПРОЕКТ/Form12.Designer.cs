namespace ПРОЕКТ
{
    partial class AdminListForm
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
            label1 = new Label();
            btnListLog = new Button();
            btnListNameForm = new Button();
            btnListName = new Button();
            btnListFunder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(70, 25);
            label1.Name = "label1";
            label1.Size = new Size(440, 27);
            label1.TabIndex = 67;
            label1.Text = "Выберите раздел для редактирования";
            // 
            // btnListLog
            // 
            btnListLog.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnListLog.Location = new Point(98, 293);
            btnListLog.Name = "btnListLog";
            btnListLog.Size = new Size(377, 48);
            btnListLog.TabIndex = 66;
            btnListLog.Text = "журнал учета состояния основных средств";
            btnListLog.UseVisualStyleBackColor = true;
            // 
            // btnListNameForm
            // 
            btnListNameForm.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnListNameForm.Location = new Point(98, 221);
            btnListNameForm.Name = "btnListNameForm";
            btnListNameForm.Size = new Size(377, 48);
            btnListNameForm.TabIndex = 65;
            btnListNameForm.Text = "Cписок категорий основных средств";
            btnListNameForm.UseVisualStyleBackColor = true;
            // 
            // btnListName
            // 
            btnListName.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnListName.Location = new Point(98, 74);
            btnListName.Name = "btnListName";
            btnListName.Size = new Size(377, 48);
            btnListName.TabIndex = 64;
            btnListName.Text = "Список материально ответственных лиц";
            btnListName.UseVisualStyleBackColor = true;
            // 
            // btnListFunder
            // 
            btnListFunder.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnListFunder.Location = new Point(98, 148);
            btnListFunder.Name = "btnListFunder";
            btnListFunder.Size = new Size(377, 48);
            btnListFunder.TabIndex = 63;
            btnListFunder.Text = "Cписок основных средств ";
            btnListFunder.UseVisualStyleBackColor = true;
            // 
            // AdminListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(559, 367);
            Controls.Add(label1);
            Controls.Add(btnListLog);
            Controls.Add(btnListNameForm);
            Controls.Add(btnListName);
            Controls.Add(btnListFunder);
            Name = "AdminListForm";
            Text = "Режим Админ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnListLog;
        private Button btnListNameForm;
        private Button btnListName;
        private Button btnListFunder;
    }
}