using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;

namespace ПРОЕКТ;

public class StateFixedAsset
{
    public int Id { get; set; }


    public DateTime Date { get; set; }

    public int FixedAssetId { get; set; }

    [MaxLength(30)]
    public string State { get; set; }

    public StateFixedAsset(DateTime date, int fixedAssetId, string state)
    {
        Date = date;
        FixedAssetId = fixedAssetId;
        State = state;
    }

    public StateFixedAsset()
    {
        Date = DateTime.UtcNow;
        FixedAssetId = 0;
        State = "test";
    }
}
