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
}
