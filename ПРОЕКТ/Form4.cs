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
