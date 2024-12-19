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
            components = new System.ComponentModel.Container();
            lblList = new Label();
            listBox = new DataGridView();
            categoryBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblList
            // 
            lblList.BackColor = Color.Transparent;
            lblList.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold);
            lblList.ForeColor = Color.White;
            lblList.Location = new Point(41, 9);
            lblList.Name = "lblList";
            lblList.Size = new Size(429, 40);
            lblList.TabIndex = 12;
            lblList.Text = "Список категорий основных средств";
            // 
            // listBox
            // 
            listBox.AllowUserToAddRows = false;
            listBox.AllowUserToDeleteRows = false;
            listBox.AutoGenerateColumns = false;
            listBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBox.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            listBox.DataSource = categoryBindingSource;
            listBox.Location = new Point(3, 47);
            listBox.Name = "listBox";
            listBox.ReadOnly = true;
            listBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listBox.Size = new Size(487, 471);
            listBox.TabIndex = 82;
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Category);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(502, 530);
            Controls.Add(listBox);
            Controls.Add(lblList);
            Name = "ListCategory";
            Text = "Список, режим: просмотра";
            Load += ListCategory_Load;
            ((System.ComponentModel.ISupportInitialize)listBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblList;
        private DataGridView listBox;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource categoryBindingSource;
    }
}