using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ПРОЕКТ;

public class FixedAsset
{
    public int Id { get; set; }

    public int Sum { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }

    public Category Category { get; set; }

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
