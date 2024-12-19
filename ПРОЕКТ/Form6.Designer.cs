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
            txtCategur = new TextBox();
            txtName = new TextBox();
            lblCategur = new Label();
            lblName = new Label();
            btnAdd = new Button();
            btnRedact = new Button();
            button3 = new Button();
            label1 = new Label();
            listBox = new ListBox();
            lblSum = new Label();
            txtSum = new TextBox();
            SuspendLayout();
            // 
            // txtCategur
            // 
            txtCategur.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtCategur.ForeColor = SystemColors.MenuText;
            txtCategur.Location = new Point(479, 240);
            txtCategur.Margin = new Padding(4, 3, 4, 3);
            txtCategur.Name = "txtCategur";
            txtCategur.Size = new Size(273, 35);
            txtCategur.TabIndex = 76;
            // 
            // txtName
            // 
            txtName.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtName.ForeColor = SystemColors.MenuText;
            txtName.Location = new Point(479, 167);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 35);
            txtName.TabIndex = 75;
            // 
            // lblCategur
            // 
            lblCategur.AutoSize = true;
            lblCategur.BackColor = Color.Transparent;
            lblCategur.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblCategur.ForeColor = Color.White;
            lblCategur.Location = new Point(479, 216);
            lblCategur.Name = "lblCategur";
            lblCategur.Size = new Size(91, 21);
            lblCategur.TabIndex = 73;
            lblCategur.Text = "Категория";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(479, 143);
            lblName.Name = "lblName";
            lblName.Size = new Size(82, 21);
            lblName.TabIndex = 72;
            lblName.Text = "Название";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(459, 470);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 48);
            btnAdd.TabIndex = 70;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRedact
            // 
            btnRedact.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            btnRedact.ForeColor = Color.Black;
            btnRedact.Location = new Point(639, 470);
            btnRedact.Name = "btnRedact";
            btnRedact.Size = new Size(151, 48);
            btnRedact.TabIndex = 69;
            btnRedact.Text = "Редактировать";
            btnRedact.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(819, 470);
            button3.Name = "button3";
            button3.Size = new Size(151, 48);
            button3.TabIndex = 68;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
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
            label1.Text = "Список основных средств";
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(17, 76);
            listBox.Name = "listBox";
            listBox.Size = new Size(422, 454);
            listBox.TabIndex = 66;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.BackColor = Color.Transparent;
            lblSum.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold);
            lblSum.ForeColor = Color.White;
            lblSum.Location = new Point(479, 75);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(55, 21);
            lblSum.TabIndex = 71;
            lblSum.Text = "Сумма";
            // 
            // txtSum
            // 
            txtSum.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtSum.ForeColor = SystemColors.MenuText;
            txtSum.Location = new Point(479, 99);
            txtSum.Margin = new Padding(4, 3, 4, 3);
            txtSum.Name = "txtSum";
            txtSum.Size = new Size(273, 35);
            txtSum.TabIndex = 74;
            // 
            // AdminFunder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.photo_2024_12_18_14_40_46;
            ClientSize = new Size(977, 557);
            Controls.Add(txtCategur);
            Controls.Add(txtName);
            Controls.Add(txtSum);
            Controls.Add(lblCategur);
            Controls.Add(lblName);
            Controls.Add(lblSum);
            Controls.Add(btnAdd);
            Controls.Add(btnRedact);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(listBox);
            ForeColor = Color.White;
            Name = "AdminFunder";
            Text = "Список, режим: админ";
            Load += AdminFunder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategur;
        private TextBox txtName;
        private Label lblCategur;
        private Label lblName;
        private Button btnAdd;
        private Button btnRedact;
        private Button button3;
        private Label label1;
        private ListBox listBox;
        private Label lblSum;
        private TextBox txtSum;
    }
}