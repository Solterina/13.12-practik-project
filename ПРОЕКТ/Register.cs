using Microsoft.EntityFrameworkCore;

namespace ПРОЕКТ
{
    public partial class Register : Form
    {
        UserDbContext db;
        public Register()
        {
            InitializeComponent();
            db = new UserDbContext();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            db.Users.Load();
            listBox.DataSource = db.Users.Local.ToBindingList();
            listBox.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var firstName = txtName.Text;
            var lastName = txtSurname.Text;
            var email = txtEmail.Text;
            var phone = txtPhone.Text;
            var login = txtLogin.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Users.Any(x => x.Username == login || x.Email == email || x.Phone == phone))
            {
                MessageBox.Show("Пользователь с такими данными уже зарегестрирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new User(login, password, email, phone, firstName, lastName);

            db.Users.Add(user);

            db.SaveChanges();

            db.Users.Load();
            listBox.DataSource = db.Users.Local.ToBindingList();
            listBox.Refresh();
        }

        private void btnRedact_Click(object sender, EventArgs e)
        {
            var firstName = txtName.Text;
            var lastName = txtSurname.Text;
            var email = txtEmail.Text;
            var phone = txtPhone.Text;
            var login = txtLogin.Text;
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listBox.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(listBox[0, listBox.SelectedRows[0].Index].Value.ToString());

            if (db.Users.Any(x => x.Id != id && (x.Username == login || x.Email == email || x.Phone == phone)))
            {
                MessageBox.Show("Пользователь с такими данными уже зарегестрирован", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = db.Users.First(x => x.Id == id);

            user.FirstName = firstName;
            user.LastName = lastName;
            user.Email = email;
            user.Phone = phone;
            user.Username = login;
            user.Password = password;

            db.Users.Update(user);

            db.SaveChanges();

            db.Users.Load();
            listBox.DataSource = db.Users.Local.ToBindingList();
            listBox.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(listBox[0, listBox.SelectedRows[0].Index].Value.ToString());

            db.Users.Remove(db.Users.First(x => x.Id == id));

            db.SaveChanges();

            db.Users.Load();
            listBox.DataSource = db.Users.Local.ToBindingList();
            listBox.Refresh();
        }
    }
}
