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
        listBox.Items.Add("Id\tName\tSum\tCategoryId");
        foreach (var i in db.FixedAssets)
        {
            listBox.Items.Add($"{i.Id}\t{i.Name}\t{i.Sum}\t{i.CategoryId}");
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        int sum;
        if (!int.TryParse(txtSum.Text, out sum)) return;
        string name=txtName.Text;
        int categoryId;
        if (!int.TryParse(txtCategur.Text, out categoryId)) return;

        var fixedAsset = new FixedAsset(name, sum, categoryId);

        db.FixedAssets.Add(fixedAsset);

        db.SaveChanges();

        listBox.Items.Add($"{fixedAsset.Id}\t{fixedAsset.Name}\t{fixedAsset.Sum}\t{fixedAsset.CategoryId}");
    }
}
