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

public partial class ListCategoryForm : Form
{
    UserDbContext db;
    public ListCategoryForm()
    {
        InitializeComponent();
        db = new UserDbContext();
    }

    private void ListCategoryForm_Load(object sender, EventArgs e)
    {
        db.Categories.Load();
        listBox.DataSource = db.Categories.Local.ToBindingList();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;

        var category = new Category(name);

        db.Categories.Add(category);

        db.SaveChanges();

        db.Categories.Load();
        listBox.DataSource = db.Categories.Local.ToBindingList();
        listBox.Refresh();
    }

    private void btnRedact_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;

        if (listBox.SelectedRows.Count == 0) return;

        int id = int.Parse(listBox[0, listBox.SelectedRows[0].Index].Value.ToString());

        var category = db.Categories.Where(x => x.Id == id).First();

        category.Name = name;

        db.Categories.Update(category);

        db.SaveChanges();

        db.Categories.Load();
        listBox.DataSource = db.Categories.Local.ToBindingList();
        listBox.Refresh();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (listBox.SelectedRows.Count == 0) return;

        int id = int.Parse(listBox[0, listBox.SelectedRows[0].Index].Value.ToString());

        db.Categories.Remove(db.Categories.Where(x => x.Id == id).First());

        db.SaveChanges();

        db.Categories.Load();
        listBox.DataSource = db.Categories.Local.ToBindingList();
        listBox.Refresh();
    }
}
