using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnSpisokWorcer_Click(object sender, EventArgs e)
        {
            var listFunder = new ListFunder();

            listFunder.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var firstName = txtName.Text;
            var lastName = txtSurname.Text;
            var email = txtEmail.Text;
            var phone = txtPhone.Text;
            var login = txtLogin.Text;
            var password = txtPassword.Text;

            var user = new User(login, password, email, phone,firstName,lastName);

            db.Users.Add(user);

            db.SaveChanges();
        }
    }
}
