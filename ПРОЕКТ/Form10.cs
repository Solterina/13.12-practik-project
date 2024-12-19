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
        db.ResponsePersoms.Load();
        listBox.DataSource = db.ResponsePersoms.Local.ToBindingList();
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

        db.ResponsePersoms.Load();
        listBox.DataSource = db.ResponsePersoms.Local.ToBindingList();
        listBox.Refresh();
    }

    private void btnRedact_Click(object sender, EventArgs e)
    {
        string firstName = txtName.Text;

        string lastName = txtSurName.Text;

        string post = txtTitle.Text;

        int categoryId;
        if (!int.TryParse(txtCategur.Text, out categoryId)) return;

        if (listBox.SelectedRows.Count == 0) return;

        int id = int.Parse(listBox[0, listBox.SelectedRows[0].Index].Value.ToString());

        var responsPerson = db.ResponsePersoms.Where(x => x.Id == id).First();

        responsPerson.FirstName = firstName;
        responsPerson.LastName = lastName;
        responsPerson.Post = post;
        responsPerson.CategoryId = categoryId;

        db.ResponsePersoms.Update(responsPerson);

        db.SaveChanges();

        db.ResponsePersoms.Load();
        listBox.DataSource = db.ResponsePersoms.Local.ToBindingList();
        listBox.Refresh();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (listBox.SelectedRows.Count == 0) return;

        int id = int.Parse(listBox[0, listBox.SelectedRows[0].Index].Value.ToString());

        db.ResponsePersoms.Remove(db.ResponsePersoms.Where(x => x.Id == id).First());

        db.SaveChanges();

        db.ResponsePersoms.Load();
        listBox.DataSource = db.ResponsePersoms.Local.ToBindingList();
        listBox.Refresh();
    }
}
