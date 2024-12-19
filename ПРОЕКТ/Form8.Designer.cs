namespace ПРОЕКТ
{
    partial class AdminLog
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
            txtMeans = new TextBox();
            txtDate = new TextBox();
            lblMeans = new Label();
            lblDate = new Label();
            btnAdd = new Button();
            btnRedact = new Button();
            btnDelete = new Button();
            label1 = new Label();
            txtState = new TextBox();
            lblState = new Label();
            listBox = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)listBox).BeginInit();
            SuspendLayout();
            // 
            // txtMeans
            // 
            txtMeans.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtMeans.ForeColor = SystemColors.MenuText;
            txtMeans.Location = new Point(527, 175);
            txtMeans.Margin = new Padding(4, 3, 4, 3);
            txtMeans.Name = "txtMeans";
            txtMeans.Size = new Size(273, 35);
            txtMeans.TabIndex = 65;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtDate.ForeColor = SystemColors.MenuText;
            txtDate.Location = new Point(527, 92);
            txtDate.Margin = new Padding(4, 3, 4, 3);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(273, 35);
            txtDate.TabIndex = 63;
            // 
            // lblMeans
            // 
            lblMeans.AutoSize = true;
            lblMeans.BackColor = Color.Transparent;
            lblMeans.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblMeans.ForeColor = Color.White;
            lblMeans.Location = new Point(527, 151);
            lblMeans.Name = "lblMeans";
            lblMeans.Size = new Size(82, 21);
            lblMeans.TabIndex = 62;
            lblMeans.Text = "Средство";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(527, 68);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(46, 21);
            lblDate.TabIndex = 60;
            lblDate.Text = "Дата";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(507, 463);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 48);
            btnAdd.TabIndex = 59;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRedact
            // 
            btnRedact.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnRedact.Location = new Point(687, 463);
            btnRedact.Name = "btnRedact";
            btnRedact.Size = new Size(151, 48);
            btnRedact.TabIndex = 58;
            btnRedact.Text = "Редактировать";
            btnRedact.UseVisualStyleBackColor = true;
            btnRedact.Click += btnRedact_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(867, 463);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 48);
            btnDelete.TabIndex = 57;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 21);
            label1.Name = "label1";
            label1.Size = new Size(516, 40);
            label1.TabIndex = 56;
            label1.Text = "Журнал учета состояния основных средств";
            // 
            // txtState
            // 
            txtState.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtState.ForeColor = SystemColors.MenuText;
            txtState.Location = new Point(527, 248);
            txtState.Margin = new Padding(4, 3, 4, 3);
            txtState.Name = "txtState";
            txtState.Size = new Size(273, 35);
            txtState.TabIndex = 67;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.BackColor = Color.Transparent;
            lblState.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblState.ForeColor = Color.White;
            lblState.Location = new Point(527, 224);
            lblState.Name = "lblState";
            lblState.Size = new Size(91, 21);
            lblState.TabIndex = 66;
            lblState.Text = "Состояние";
            // 
            // listBox
            // 
            listBox.AllowUserToAddRows = false;
            listBox.AllowUserToDeleteRows = false;
            listBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBox.Location = new Point(12, 64);
            listBox.Name = "listBox";
            listBox.ReadOnly = true;
            listBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listBox.Size = new Size(487, 471);
            listBox.TabIndex = 82;
            // 
            // AdminLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(1025, 557);
            Controls.Add(listBox);
            Controls.Add(txtState);
            Controls.Add(lblState);
            Controls.Add(txtMeans);
            Controls.Add(txtDate);
            Controls.Add(lblMeans);
            Controls.Add(lblDate);
            Controls.Add(btnAdd);
            Controls.Add(btnRedact);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Name = "AdminLog";
            Text = "Список, режим: админ";
            Load += AdminLog_Load;
            ((System.ComponentModel.ISupportInitialize)listBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMeans;
        private TextBox txtDate;
        private Label lblMeans;
        private Label lblDate;
        private Button btnAdd;
        private Button btnRedact;
        private Button btnDelete;
        private Label label1;
        private TextBox txtState;
        private Label lblState;
        private DataGridView listBox;
    }
}