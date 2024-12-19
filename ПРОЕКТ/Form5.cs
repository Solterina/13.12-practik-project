using Microsoft.EntityFrameworkCore;

namespace ПРОЕКТ;

public partial class ListLog : Form
{
    UserDbContext db;
    public ListLog()
    {
        InitializeComponent();
        db = new UserDbContext();
    }

    private void ListLog_Load(object sender, EventArgs e)
    {
        db.StateFixedAssets.Load();
        listBox.DataSource = db.StateFixedAssets.Local.ToBindingList();
        listBox.Refresh();
    }
}
