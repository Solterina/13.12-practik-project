using Microsoft.EntityFrameworkCore;

namespace ПРОЕКТ;

public partial class ListFunder : Form
{
    UserDbContext db;
    public ListFunder()
    {
        InitializeComponent();
        db = new UserDbContext();
    }

    private void ListFunder_Load(object sender, EventArgs e)
    {
        db.FixedAssets.Load();
        listBox.DataSource = db.FixedAssets.Local.ToBindingList();
        listBox.Refresh();
    }
}
