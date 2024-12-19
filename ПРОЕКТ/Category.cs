using System.ComponentModel.DataAnnotations;

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
