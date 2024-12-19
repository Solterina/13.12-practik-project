using System.ComponentModel.DataAnnotations;

namespace ПРОЕКТ;

public class FixedAsset
{
    public int Id { get; set; }

    public int Sum { get; set; }

    public int CategoryId { get; set; }

    [MaxLength(100)]
    public string Name { get; set; }

    public FixedAsset(string name, int sum, int categoryId)
    {
        CategoryId = categoryId;
        Name = name;
        Sum = sum;
    }

    public FixedAsset()
    {
        CategoryId = 0;
        Name = "test";
        Sum = 0;
    }
}
