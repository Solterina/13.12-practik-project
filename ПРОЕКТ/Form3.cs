using Microsoft.EntityFrameworkCore;

namespace ПРОЕКТ;

public partial class ListCategory : Form
{
    UserDbContext db;
    public ListCategory()
    {
        InitializeComponent();
        db = new UserDbContext();
    }

    private void ListCategory_Load(object sender, EventArgs e)
    {
        db.Categories.Load();
        listBox.DataSource = db.Categories.Local.ToBindingList();
        listBox.Refresh();
    }
}
