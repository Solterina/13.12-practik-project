namespace ПРОЕКТ
{
    partial class ListCategory
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
            lblList = new Label();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // lblList
            // 
            lblList.BackColor = Color.Transparent;
            lblList.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold);
            lblList.ForeColor = Color.White;
            lblList.Location = new Point(43, 20);
            lblList.Name = "lblList";
            lblList.Size = new Size(429, 40);
            lblList.TabIndex = 12;
            lblList.Text = "Список категорий основных средств";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(22, 63);
            listBox.Name = "listBox";
            listBox.Size = new Size(463, 454);
            listBox.TabIndex = 11;
            // 
            // ListCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(502, 530);
            Controls.Add(lblList);
            Controls.Add(listBox);
            Name = "ListCategory";
            Text = "Список, режим: просмотра";
            Load += ListCategory_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblList;
        private ListBox listBox;
    }
}