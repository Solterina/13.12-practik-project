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
            components = new System.ComponentModel.Container();
            lblList = new Label();
            listBox = new DataGridView();
            responsPersonBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)responsPersonBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblList
            // 
            lblList.BackColor = Color.Transparent;
            lblList.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold);
            lblList.ForeColor = Color.White;
            lblList.Location = new Point(44, 9);
            lblList.Name = "lblList";
            lblList.Size = new Size(494, 40);
            lblList.TabIndex = 18;
            lblList.Text = "Список материально ответственных лиц";
            // 
            // listBox
            // 
            listBox.AllowUserToAddRows = false;
            listBox.AllowUserToDeleteRows = false;
            listBox.AutoGenerateColumns = false;
            listBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBox.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, postDataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn });
            listBox.DataSource = responsPersonBindingSource;
            listBox.Location = new Point(12, 47);
            listBox.Name = "listBox";
            listBox.ReadOnly = true;
            listBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listBox.Size = new Size(561, 471);
            listBox.TabIndex = 82;
            // 
            // responsPersonBindingSource
            // 
            responsPersonBindingSource.DataSource = typeof(ResponsPerson);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // postDataGridViewTextBoxColumn
            // 
            postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            postDataGridViewTextBoxColumn.HeaderText = "Post";
            postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            postDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListNameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(585, 530);
            Controls.Add(listBox);
            Controls.Add(lblList);
            Name = "ListNameForm";
            Text = "Список, режим: просмотра";
            Load += ListNameForm_Load;
            ((System.ComponentModel.ISupportInitialize)listBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)responsPersonBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblList;
        private DataGridView listBox;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private BindingSource responsPersonBindingSource;
    }
}