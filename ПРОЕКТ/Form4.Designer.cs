namespace ПРОЕКТ
{
    partial class ListNameForm
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
            listBox = new ListBox();
            lblList = new Label();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(18, 61);
            listBox.Name = "listBox";
            listBox.Size = new Size(463, 454);
            listBox.TabIndex = 17;
            // 
            // lblList
            // 
            lblList.BackColor = Color.Transparent;
            lblList.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold);
            lblList.ForeColor = Color.White;
            lblList.Location = new Point(18, 18);
            lblList.Name = "lblList";
            lblList.Size = new Size(494, 40);
            lblList.TabIndex = 18;
            lblList.Text = "Список материально ответственных лиц";
            // 
            // ListNameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(505, 530);
            Controls.Add(lblList);
            Controls.Add(listBox);
            Name = "ListNameForm";
            Text = "Список, режим: просмотра";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox;
        private Label lblList;
    }
}