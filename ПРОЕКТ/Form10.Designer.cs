namespace ПРОЕКТ
{
    partial class AdminNameForm
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
            txtTitle = new TextBox();
            txtSurName = new TextBox();
            txtName = new TextBox();
            lblTitle = new Label();
            lblSurName = new Label();
            lblName = new Label();
            btnAdd = new Button();
            btnRedact = new Button();
            btnDelete = new Button();
            label1 = new Label();
            txtCategur = new TextBox();
            lblCategur = new Label();
            listBox = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)listBox).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtTitle.ForeColor = SystemColors.MenuText;
            txtTitle.Location = new Point(678, 172);
            txtTitle.Margin = new Padding(4, 3, 4, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(275, 35);
            txtTitle.TabIndex = 76;
            // 
            // txtSurName
            // 
            txtSurName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSurName.ForeColor = SystemColors.MenuText;
            txtSurName.Location = new Point(678, 99);
            txtSurName.Margin = new Padding(4, 3, 4, 3);
            txtSurName.Name = "txtSurName";
            txtSurName.Size = new Size(275, 35);
            txtSurName.TabIndex = 75;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtName.ForeColor = SystemColors.MenuText;
            txtName.Location = new Point(678, 31);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(275, 35);
            txtName.TabIndex = 74;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(678, 148);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 21);
            lblTitle.TabIndex = 73;
            lblTitle.Text = "Должность ";
            // 
            // lblSurName
            // 
            lblSurName.AutoSize = true;
            lblSurName.BackColor = Color.Transparent;
            lblSurName.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblSurName.ForeColor = Color.White;
            lblSurName.Location = new Point(678, 75);
            lblSurName.Name = "lblSurName";
            lblSurName.Size = new Size(73, 21);
            lblSurName.TabIndex = 72;
            lblSurName.Text = "Фамилия";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(678, 7);
            lblName.Name = "lblName";
            lblName.Size = new Size(37, 21);
            lblName.TabIndex = 71;
            lblName.Text = "Имя";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(556, 470);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 48);
            btnAdd.TabIndex = 70;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRedact
            // 
            btnRedact.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnRedact.Location = new Point(694, 470);
            btnRedact.Name = "btnRedact";
            btnRedact.Size = new Size(139, 48);
            btnRedact.TabIndex = 69;
            btnRedact.Text = "Редактировать";
            btnRedact.UseVisualStyleBackColor = true;
            btnRedact.Click += btnRedact_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(838, 470);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 48);
            btnDelete.TabIndex = 68;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Tai Le", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 26);
            label1.Name = "label1";
            label1.Size = new Size(516, 40);
            label1.TabIndex = 67;
            label1.Text = "Список материально ответственных лиц";
            // 
            // txtCategur
            // 
            txtCategur.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtCategur.ForeColor = SystemColors.MenuText;
            txtCategur.Location = new Point(678, 246);
            txtCategur.Margin = new Padding(4, 3, 4, 3);
            txtCategur.Name = "txtCategur";
            txtCategur.Size = new Size(275, 35);
            txtCategur.TabIndex = 78;
            // 
            // lblCategur
            // 
            lblCategur.AutoSize = true;
            lblCategur.BackColor = Color.Transparent;
            lblCategur.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblCategur.ForeColor = Color.White;
            lblCategur.Location = new Point(678, 222);
            lblCategur.Name = "lblCategur";
            lblCategur.Size = new Size(91, 21);
            lblCategur.TabIndex = 77;
            lblCategur.Text = "Категория";
            // 
            // listBox
            // 
            listBox.AllowUserToAddRows = false;
            listBox.AllowUserToDeleteRows = false;
            listBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listBox.Location = new Point(7, 57);
            listBox.Name = "listBox";
            listBox.ReadOnly = true;
            listBox.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listBox.Size = new Size(543, 488);
            listBox.TabIndex = 80;
            // 
            // AdminNameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(977, 557);
            Controls.Add(listBox);
            Controls.Add(txtCategur);
            Controls.Add(lblCategur);
            Controls.Add(txtTitle);
            Controls.Add(txtSurName);
            Controls.Add(txtName);
            Controls.Add(lblTitle);
            Controls.Add(lblSurName);
            Controls.Add(lblName);
            Controls.Add(btnAdd);
            Controls.Add(btnRedact);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Name = "AdminNameForm";
            Text = "Список, режим: админ";
            Load += AdminNameForm_Load;
            ((System.ComponentModel.ISupportInitialize)listBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtSurName;
        private TextBox txtName;
        private Label lblTitle;
        private Label lblSurName;
        private Label lblName;
        private Button btnAdd;
        private Button btnRedact;
        private Button btnDelete;
        private Label label1;
        private TextBox txtCategur;
        private Label lblCategur;
        private DataGridView listBox;
    }
}