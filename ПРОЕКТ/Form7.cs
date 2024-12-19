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
        listBox.Items.Add("Id\tName\t");
        foreach (var i in db.Categories)
        {
            listBox.Items.Add($"{i.Id}\t{i.Name}");
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;

        var category = new Category(name);

        db.Categories.Add(category);

        db.SaveChanges();

        listBox.Items.Add($"{category.Id}\t{category.Name}");
    }

    private void btnRedact_Click(object sender, EventArgs e)
    {
        if (listBox.SelectedIndex < 1) return;

        string name = txtName.Text;

        var id = int.Parse(listBox.SelectedItem.ToString().Split("\t")[0]);
        var category = db.Categories.Where(x => x.Id == id).First();

        category.Name = name;

        db.Categories.Update(category);

        db.SaveChanges();

        listBox.Items[listBox.SelectedIndex] = $"{category.Id}\t{category.Name}";
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (listBox.SelectedIndex < 1) return;

        var id = int.Parse(listBox.SelectedItem.ToString().Split("\t")[0]);

        db.Categories.Remove(db.Categories.Where(x => x.Id == id).First());

        db.SaveChanges();

        listBox.Items.Remove(listBox.SelectedItem);
    }
}
