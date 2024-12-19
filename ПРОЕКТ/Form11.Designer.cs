namespace ПРОЕКТ
{
    partial class AdminFunder
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
            listBox = new DataGridView();
            txtName = new TextBox();
            lblName = new Label();
            btnAdd = new Button();
            btnRedact = new Button();
            btnDelete = new Button();
            label1 = new Label();
            txtCategur = new TextBox();
            txtSum = new TextBox();
            lblCategur = new Label();
            lblSum = new Label();
            fixedAssetBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fixedAssetBindingSource).BeginInit();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.AllowUserToAddRows = false;
            listBox.AllowUserToDeleteRows = false;
            listBox.AutoGenerateColumns = false;
            listBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBox.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, sumDataGridViewTextBoxColumn, categoryIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn });
            listBox.DataSource = fixedAssetBindingSource;
            listBox.Location = new Point(12, 35);
            listBox.Name = "listBox";
            listBox.ReadOnly = true;
            listBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listBox.Size = new Size(487, 489);
            listBox.TabIndex = 89;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtName.ForeColor = Color.Black;
            txtName.Location = new Point(681, 176);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 35);
            txtName.TabIndex = 88;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(681, 152);
            lblName.Name = "lblName";
            lblName.Size = new Size(82, 21);
            lblName.TabIndex = 87;
            lblName.Text = "Название";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(544, 446);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 48);
            btnAdd.TabIndex = 86;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRedact
            // 
            btnRedact.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnRedact.Location = new Point(724, 446);
            btnRedact.Name = "btnRedact";
            btnRedact.Size = new Size(151, 48);
            btnRedact.TabIndex = 85;
            btnRedact.Text = "Редактировать";
            btnRedact.UseVisualStyleBackColor = true;
            btnRedact.Click += btnRedact_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(904, 446);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 48);
            btnDelete.TabIndex = 84;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 3);
            label1.Name = "label1";
            label1.Size = new Size(516, 40);
            label1.TabIndex = 83;
            label1.Text = "Список основных средств";
            // 
            // txtCategur
            // 
            txtCategur.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtCategur.ForeColor = SystemColors.MenuText;
            txtCategur.Location = new Point(681, 247);
            txtCategur.Margin = new Padding(4, 3, 4, 3);
            txtCategur.Name = "txtCategur";
            txtCategur.Size = new Size(273, 35);
            txtCategur.TabIndex = 93;
            // 
            // txtSum
            // 
            txtSum.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSum.ForeColor = SystemColors.MenuText;
            txtSum.Location = new Point(681, 106);
            txtSum.Margin = new Padding(4, 3, 4, 3);
            txtSum.Name = "txtSum";
            txtSum.Size = new Size(273, 35);
            txtSum.TabIndex = 92;
            // 
            // lblCategur
            // 
            lblCategur.AutoSize = true;
            lblCategur.BackColor = Color.Transparent;
            lblCategur.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblCategur.ForeColor = Color.White;
            lblCategur.Location = new Point(681, 223);
            lblCategur.Name = "lblCategur";
            lblCategur.Size = new Size(91, 21);
            lblCategur.TabIndex = 91;
            lblCategur.Text = "Категория";
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.BackColor = Color.Transparent;
            lblSum.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblSum.ForeColor = Color.White;
            lblSum.Location = new Point(681, 82);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(55, 21);
            lblSum.TabIndex = 90;
            lblSum.Text = "Сумма";
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
            // AdminFunder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.photo;
            ClientSize = new Size(1082, 536);
            Controls.Add(txtCategur);
            Controls.Add(txtSum);
            Controls.Add(lblCategur);
            Controls.Add(lblSum);
            Controls.Add(listBox);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnAdd);
            Controls.Add(btnRedact);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Name = "AdminFunder";
            Text = "Form11";
            Load += AdminFunder_Load;
            ((System.ComponentModel.ISupportInitialize)listBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fixedAssetBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView listBox;
        private TextBox txtName;
        private Label lblName;
        private Button btnAdd;
        private Button btnRedact;
        private Button btnDelete;
        private Label label1;
        private TextBox txtCategur;
        private TextBox txtSum;
        private Label lblCategur;
        private Label lblSum;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource fixedAssetBindingSource;
    }
}