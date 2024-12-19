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
            components = new System.ComponentModel.Container();
            lblList = new Label();
            listBox = new DataGridView();
            stateFixedAssetBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fixedAssetIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stateFixedAssetBindingSource).BeginInit();
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
            listBox.AutoGenerateColumns = false;
            listBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBox.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, fixedAssetIdDataGridViewTextBoxColumn, stateDataGridViewTextBoxColumn });
            listBox.DataSource = stateFixedAssetBindingSource;
            listBox.Location = new Point(13, 47);
            listBox.Name = "listBox";
            listBox.ReadOnly = true;
            listBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listBox.Size = new Size(487, 471);
            listBox.TabIndex = 82;
            // 
            // stateFixedAssetBindingSource
            // 
            stateFixedAssetBindingSource.DataSource = typeof(StateFixedAsset);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fixedAssetIdDataGridViewTextBoxColumn
            // 
            fixedAssetIdDataGridViewTextBoxColumn.DataPropertyName = "FixedAssetId";
            fixedAssetIdDataGridViewTextBoxColumn.HeaderText = "FixedAssetId";
            fixedAssetIdDataGridViewTextBoxColumn.Name = "fixedAssetIdDataGridViewTextBoxColumn";
            fixedAssetIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            stateDataGridViewTextBoxColumn.HeaderText = "State";
            stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            stateDataGridViewTextBoxColumn.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)stateFixedAssetBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblList;
        private DataGridView listBox;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fixedAssetIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private BindingSource stateFixedAssetBindingSource;
    }
}