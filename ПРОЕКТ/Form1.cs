namespace ПРОЕКТ;

public partial class Authorization : Form
{
    UserDbContext db;
    public Authorization()
    {
        InitializeComponent();
        db = new UserDbContext();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string login = txtLogin.Text;
        string password = txtPassword.Text;

        if (login == "" || password == "")
        {
            //lblResult.Text = "Введите логин и пароль, пожалуйста";
            //lblResult.ForeColor = Color.White;
            //lblResult.Font = new Font("Time new roman", 20, FontStyle.Regular);
        }
        else if (login == "admin" && password == "admin")
        {
            btnReductList.Visible = true;
            btnRegister.Visible = true;
        }
        else if (db.Users.Any(user => user.Username == login && user.Password == password))
        {
            btnReductList.Visible = true;
        }
        else
        {
            btnReductList.Visible = false;
            btnRegister.Visible = false;
        }
    }

    private void btnList_Click(object sender, EventArgs e)
    {
        var list = new Chupter();

        list.Show();
    }

    private void btnReductList_Click(object sender, EventArgs e)
    {
        var reductList = new AdminListForm();

        reductList.Show();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        var register = new Register();

        register.Show();
    }
}
