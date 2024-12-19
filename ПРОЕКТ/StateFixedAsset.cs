using System.ComponentModel.DataAnnotations;

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
