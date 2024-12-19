using Microsoft.EntityFrameworkCore;

namespace ПРОЕКТ;

public partial class ListNameForm : Form
{
    UserDbContext db;
    public ListNameForm()
    {
        InitializeComponent();
        db = new UserDbContext();
    }

    private void ListNameForm_Load(object sender, EventArgs e)
    {
        db.ResponsePersoms.Load();
        listBox.DataSource = db.ResponsePersoms.Local.ToBindingList();
    }
}
