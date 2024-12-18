using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПРОЕКТ;

public class Category
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; }

    public Category(string name)
    {
        Name = name;
    }

    public Category()
    {
        Name = "test";
    }
}
