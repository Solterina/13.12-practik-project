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

public partial class ListWorcer : Form
{
    UserDbContext db;
    public ListWorcer()
    {
        InitializeComponent();
        db = new UserDbContext();
    }

    private void ListWorcer_Load(object sender, EventArgs e)
    {
        listBox.Items.Add("Id\tFirstName\tLastName\ti.Username\ti.Email\ti.Phone\ti.Password\t");
        foreach (var i in db.Users)
        {
            listBox.Items.Add($"{i.Id}\t{i.FirstName}\t{i.LastName}\t{i.Username}\t{i.Email}\t{i.Phone}\t{i.Password}\t");
        }
    }
}
