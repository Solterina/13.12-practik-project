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
    }
}
