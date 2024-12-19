using Microsoft.EntityFrameworkCore;
using System.Data;

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
        listBox.Refresh();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        string firstName = txtName.Text;

        string lastName = txtSurName.Text;

        string post = txtTitle.Text;

        int categoryId;
        if (!int.TryParse(txtCategur.Text, out categoryId))
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(post))
        {
            MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

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
        if (!int.TryParse(txtCategur.Text, out categoryId))
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(post))
        {
            MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (listBox.SelectedRows.Count == 0)
        {
            MessageBox.Show("Не выбрана строка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

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
        if (listBox.SelectedRows.Count == 0)
        {
            MessageBox.Show("Не выбрана строка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        int id = int.Parse(listBox[0, listBox.SelectedRows[0].Index].Value.ToString());

        db.ResponsePersoms.Remove(db.ResponsePersoms.Where(x => x.Id == id).First());

        db.SaveChanges();

        db.ResponsePersoms.Load();
        listBox.DataSource = db.ResponsePersoms.Local.ToBindingList();
        listBox.Refresh();
    }
}
