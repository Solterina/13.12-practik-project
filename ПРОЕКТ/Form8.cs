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
        db.StateFixedAssets.Load();
        listBox.DataSource = db.StateFixedAssets.Local.ToBindingList();
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

        db.StateFixedAssets.Load();
        listBox.DataSource = db.StateFixedAssets.Local.ToBindingList();
        listBox.Refresh();
    }

    private void btnRedact_Click(object sender, EventArgs e)
    {
        DateTime date = DateTime.Parse(txtDate.Text);

        string state = txtState.Text;

        int fixedAssetId;
        if (!int.TryParse(txtMeans.Text, out fixedAssetId)) return;

        if (listBox.SelectedRows.Count == 0) return;

        int id = int.Parse(listBox[0, listBox.SelectedRows[0].Index].Value.ToString());

        var stateFixedAsset = db.StateFixedAssets.Where(x => x.Id == id).First();

        stateFixedAsset.State = state;
        stateFixedAsset.Date = date;
        stateFixedAsset.FixedAssetId = fixedAssetId;

        db.StateFixedAssets.Update(stateFixedAsset);

        db.SaveChanges();

        db.StateFixedAssets.Load();
        listBox.DataSource = db.StateFixedAssets.Local.ToBindingList();
        listBox.Refresh();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (listBox.SelectedRows.Count == 0) return;

        int id = int.Parse(listBox[0, listBox.SelectedRows[0].Index].Value.ToString());

        db.StateFixedAssets.Remove(db.StateFixedAssets.Where(x => x.Id == id).First());

        db.SaveChanges();

        db.StateFixedAssets.Load();
        listBox.DataSource = db.StateFixedAssets.Local.ToBindingList();
        listBox.Refresh();
    }
}
