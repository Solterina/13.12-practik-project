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

public partial class AdminFunder : Form
{
    UserDbContext db;
    public AdminFunder()
    {
        InitializeComponent();
        db = new UserDbContext();
    }

    private void AdminFunder_Load(object sender, EventArgs e)
    {
        db.FixedAssets.Load();
        listBox.DataSource = db.FixedAssets.Local.ToBindingList();
        listBox.Refresh();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        int sum;
        if (!int.TryParse(txtSum.Text, out sum))
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string name = txtName.Text;

        int categoryId;
        if (!int.TryParse(txtCategur.Text, out categoryId))
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrEmpty(name))
        {
            MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var fixedAsset = new FixedAsset(name, sum, categoryId);

        db.FixedAssets.Add(fixedAsset);

        db.SaveChanges();

        db.FixedAssets.Load();
        listBox.DataSource = db.FixedAssets.Local.ToBindingList();
        listBox.Refresh();
    }

    private void btnRedact_Click(object sender, EventArgs e)
    {
        int sum;
        if (!int.TryParse(txtSum.Text, out sum))
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string name = txtName.Text;

        int categoryId;
        if (!int.TryParse(txtCategur.Text, out categoryId))
        {
            MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrEmpty(name))
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

        var fixedAsset = db.FixedAssets.Where(x => x.Id == id).First();

        fixedAsset.Sum = sum;
        fixedAsset.CategoryId = categoryId;
        fixedAsset.Name = name;

        db.FixedAssets.Update(fixedAsset);

        db.SaveChanges();

        db.FixedAssets.Load();
        listBox.DataSource = db.FixedAssets.Local.ToBindingList();
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

        db.FixedAssets.Remove(db.FixedAssets.Where(x => x.Id == id).First());

        db.SaveChanges();

        db.FixedAssets.Load();
        listBox.DataSource = db.FixedAssets.Local.ToBindingList();
        listBox.Refresh();
    }
}
