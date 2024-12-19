namespace ПРОЕКТ
{
    partial class ListCategoryForm
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
            txtName = new TextBox();
            lblName = new Label();
            btnAdd = new Button();
            btnRedact = new Button();
            btnDelete = new Button();
            label1 = new Label();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtName.ForeColor = SystemColors.ScrollBar;
            txtName.Location = new Point(476, 99);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 35);
            txtName.TabIndex = 75;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(476, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(82, 21);
            lblName.TabIndex = 72;
            lblName.Text = "Название";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(459, 470);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 48);
            btnAdd.TabIndex = 70;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRedact
            // 
            btnRedact.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnRedact.Location = new Point(639, 470);
            btnRedact.Name = "btnRedact";
            btnRedact.Size = new Size(151, 48);
            btnRedact.TabIndex = 69;
            btnRedact.Text = "Редактировать";
            btnRedact.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(819, 470);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 48);
            btnDelete.TabIndex = 68;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
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
            label1.Text = "Список категорий основных средств";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(17, 76);
            listBox.Name = "listBox";
            listBox.Size = new Size(422, 454);
            listBox.TabIndex = 66;
            // 
            // ListCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(977, 557);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnAdd);
            Controls.Add(btnRedact);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(listBox);
            Name = "ListCategoryForm";
            Text = "Список, режим: админ";
            Load += ListCategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private Label lblName;
        private Button btnAdd;
        private Button btnRedact;
        private Button btnDelete;
        private Label label1;
        private ListBox listBox;
    }
}