using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ПРОЕКТ;

public partial class AdminLog : Form
{
    UserDbContext db;
    public AdminLog()
    {
        InitializeComponent();
        db = new UserDbContext();
    }

    private void AdminLog_Load(object sender, EventArgs e)
    {
        listBox.Items.Add("Id\tDate\tState\tFixedAssetId");
        foreach (var i in db.StateFixedAssets)
        {
            listBox.Items.Add($"{i.Id}\t{i.Date}\t{i.State}\t{i.FixedAssetId}");
        }
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
        DateTime date = DateTime.Parse(txtDate.Text);

        string state = txtState.Text;

        int fixedAssetId;
        if (!int.TryParse(txtMeans.Text, out fixedAssetId)) return;

        var stateFixedAsset = new StateFixedAsset(date, fixedAssetId, state);

        db.StateFixedAssets.Add(stateFixedAsset);

        db.SaveChanges();

        listBox.Items.Add($"{stateFixedAsset.Id}\t{stateFixedAsset.Date}\t{stateFixedAsset.State}\t{stateFixedAsset.FixedAssetId}");
    }

    private void btnRedact_Click(object sender, EventArgs e)
    {
        if (listBox.SelectedIndex < 1) return;

        DateTime date = DateTime.Parse(txtDate.Text);

        string state = txtState.Text;

        int fixedAssetId;
        if (!int.TryParse(txtMeans.Text, out fixedAssetId)) return;

        var id = int.Parse(listBox.SelectedItem.ToString().Split("\t")[0]);
        var stateFixedAsset = db.StateFixedAssets.Where(x => x.Id == id).First();

        stateFixedAsset.State = state;
        stateFixedAsset.Date = date;
        stateFixedAsset.FixedAssetId = fixedAssetId;

        db.StateFixedAssets.Update(stateFixedAsset);

        db.SaveChanges();

        listBox.Items[listBox.SelectedIndex] = $"{stateFixedAsset.Id}\t{stateFixedAsset.Date.Day}.{stateFixedAsset.Date.Month}.{stateFixedAsset.Date.Year}\t{stateFixedAsset.State}\t{stateFixedAsset.FixedAssetId}";
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (listBox.SelectedIndex < 1) return;

        var id = int.Parse(listBox.SelectedItem.ToString().Split("\t")[0]);

        db.StateFixedAssets.Remove(db.StateFixedAssets.Where(x => x.Id == id).First());

        db.SaveChanges();

        listBox.Items.RemoveAt(listBox.SelectedIndex);
    }
}
