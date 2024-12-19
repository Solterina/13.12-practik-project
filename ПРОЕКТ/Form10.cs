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
        dataGridView1.DataSource = db.Users.Local.ToBindingList();
        //listBox.Items.Add("Id\tirstName\tLastName\tPost\tCategoryId");
        //foreach (var i in db.ResponsePersoms)
        //{
        //    listBox.Items.Add($"{i.Id}\t{i.FirstName}\t{i.LastName}\t{i.Post}\t{i.CategoryId}");
        //}
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        string firstName = txtName.Text;

        string lastName = txtSurName.Text;

        string post =txtTitle.Text;

        int categoryId;
        if (!int.TryParse(txtCategur.Text, out categoryId)) return;

        var responsPerson = new ResponsPerson(firstName, lastName, post, categoryId);

        db.ResponsePersoms.Add(responsPerson);

        db.SaveChanges();

        //listBox.Items.Add($"{responsPerson.Id}\t{responsPerson.FirstName}\t{responsPerson.LastName}\t{responsPerson.Post}\t{responsPerson.CategoryId}");
    }

    private void btnRedact_Click(object sender, EventArgs e)
    {
        string firstName = txtName.Text;

        string lastName = txtSurName.Text;

        string post = txtTitle.Text;

        int categoryId;
        if (!int.TryParse(txtCategur.Text, out categoryId)) return;

        //var id = int.Parse(listBox.SelectedItem.ToString().Split("\t")[0]);
        //var responsPerson = db.ResponsePersoms.Where(x => x.Id == id).First();

        //responsPerson.FirstName = firstName;
        //responsPerson.LastName = lastName;
        //responsPerson.Post = post;
        //responsPerson.CategoryId = categoryId;

        //db.ResponsePersoms.Update(responsPerson);

        db.SaveChanges();

        //listBox.Items[listBox.SelectedIndex] = $"{responsPerson.Id}\t{responsPerson.FirstName}\t{responsPerson.LastName}\t{responsPerson.Post}\t{responsPerson.CategoryId}";
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        //if (listBox.SelectedIndex < 1) return;

        //var id = int.Parse(listBox.SelectedItem.ToString().Split("\t")[0]);

        db.ResponsePersoms.Remove(db.ResponsePersoms.Where(x => x.Id == id).First());

        db.SaveChanges();

        //listBox.Items.RemoveAt(listBox.SelectedIndex);
    }
}
