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

public partial class AdminNameForm : Form
{
    UserDbContext db;
    public AdminNameForm()
    {
        InitializeComponent();
        db = new UserDbContext();
    }

    private void AdminNameForm_Load(object sender, EventArgs e)
    {
        listBox.Items.Add("Id\tirstName\tLastName\tPost\tCategoryId");
        foreach (var i in db.ResponsePersoms)
        {
            listBox.Items.Add($"{i.Id}\t{i.FirstName}\t{i.LastName}\t{i.Post}\t{i.CategoryId}");
        }
    }
}
