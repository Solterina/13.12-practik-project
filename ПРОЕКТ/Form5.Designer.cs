namespace ПРОЕКТ
{
    partial class ListLog
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
            listBox = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)listBox).BeginInit();
            SuspendLayout();
            // 
            // lblList
            // 
            lblList.BackColor = Color.Transparent;
            lblList.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold);
            lblList.ForeColor = SystemColors.Control;
            lblList.Location = new Point(10, 15);
            lblList.Name = "lblList";
            lblList.Size = new Size(514, 40);
            lblList.TabIndex = 24;
            lblList.Text = "Журнал учета состояния основных средств";
            // 
            // listBox
            // 
            listBox.AllowUserToAddRows = false;
            listBox.AllowUserToDeleteRows = false;
            listBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBox.Location = new Point(13, 47);
            listBox.Name = "listBox";
            listBox.ReadOnly = true;
            listBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listBox.Size = new Size(487, 471);
            listBox.TabIndex = 82;
            // 
            // ListLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(512, 530);
            Controls.Add(listBox);
            Controls.Add(lblList);
            Name = "ListLog";
            Text = "Список, режим: просмотра";
            Load += ListLog_Load;
            ((System.ComponentModel.ISupportInitialize)listBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblList;
        private DataGridView listBox;
    }
}