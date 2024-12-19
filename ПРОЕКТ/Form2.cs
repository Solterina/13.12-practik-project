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
    }
}
