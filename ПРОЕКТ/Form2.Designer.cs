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
            components = new System.ComponentModel.Container();
            lblNameList = new Label();
            listBox = new DataGridView();
            fixedAssetBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fixedAssetBindingSource).BeginInit();
            SuspendLayout();
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
            // listBox
            // 
            listBox.AllowUserToAddRows = false;
            listBox.AllowUserToDeleteRows = false;
            listBox.AutoGenerateColumns = false;
            listBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBox.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, sumDataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            listBox.DataSource = fixedAssetBindingSource;
            listBox.Location = new Point(5, 47);
            listBox.Name = "listBox";
            listBox.ReadOnly = true;
            listBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listBox.Size = new Size(487, 471);
            listBox.TabIndex = 82;
            // 
            // fixedAssetBindingSource
            // 
            fixedAssetBindingSource.DataSource = typeof(FixedAsset);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            sumDataGridViewTextBoxColumn.HeaderText = "Sum";
            sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            sumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            categoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ListFunder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(504, 530);
            Controls.Add(listBox);
            Controls.Add(lblNameList);
            Name = "ListFunder";
            Text = "Список, режим: просмотра";
            Load += ListFunder_Load;
            ((System.ComponentModel.ISupportInitialize)listBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fixedAssetBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblNameList;
        private DataGridView listBox;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource fixedAssetBindingSource;
    }
}