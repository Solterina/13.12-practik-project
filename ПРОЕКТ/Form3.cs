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
        listBox.Items.Add("Id\tName\t");
        foreach (var i in db.Categories)
        {
            listBox.Items.Add($"{i.Id}\t{i.Name}");
        }
    }
}
