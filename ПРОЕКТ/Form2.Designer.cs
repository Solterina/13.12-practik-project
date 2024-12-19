namespace ПРОЕКТ
{
    partial class ListFunder
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
            lblNameList = new Label();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(23, 61);
            listBox.Name = "listBox";
            listBox.Size = new Size(463, 454);
            listBox.TabIndex = 5;
            // 
            // lblNameList
            // 
            lblNameList.BackColor = Color.Transparent;
            lblNameList.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold);
            lblNameList.ForeColor = Color.White;
            lblNameList.Location = new Point(95, 18);
            lblNameList.Name = "lblNameList";
            lblNameList.Size = new Size(364, 40);
            lblNameList.TabIndex = 6;
            lblNameList.Text = "Список основных средств";
            // 
            // ListFunder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(504, 530);
            Controls.Add(lblNameList);
            Controls.Add(listBox);
            Name = "ListFunder";
            Text = "Список, режим: просмотра";
            Load += ListFunder_Load;
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox;
        private Label lblNameList;
    }
}