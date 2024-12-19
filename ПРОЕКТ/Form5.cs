using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
