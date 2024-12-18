namespace ПРОЕКТ
{
    partial class ListWorcer
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
            lblWorcer = new Label();
            ListBox = new ListBox();
            SuspendLayout();
            // 
            // lblWorcer
            // 
            lblWorcer.BackColor = Color.Transparent;
            lblWorcer.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold);
            lblWorcer.ForeColor = Color.White;
            lblWorcer.Location = new Point(123, 17);
            lblWorcer.Name = "lblWorcer";
            lblWorcer.Size = new Size(334, 40);
            lblWorcer.TabIndex = 8;
            lblWorcer.Text = "Список сотрудников";
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.Location = new Point(21, 60);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(463, 454);
            ListBox.TabIndex = 7;
            // 
            // ListWorcer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(504, 530);
            Controls.Add(lblWorcer);
            Controls.Add(ListBox);
            Name = "ListWorcer";
            Text = "Просмотр работников";
            ResumeLayout(false);
        }

        #endregion

        private Label lblWorcer;
        private ListBox ListBox;
    }
}