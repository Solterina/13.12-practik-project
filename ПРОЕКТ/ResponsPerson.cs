using System.ComponentModel.DataAnnotations;

namespace ПРОЕКТ;

public class ResponsPerson
{
    public int Id { get; set; }
    [MaxLength(100)]

    public string Post { get; set; }

    public int CategoryId { get; set; }

    [MaxLength(50)]
    public string FirstName { get; set; }

    [MaxLength(50)]
    public string LastName { get; set; }

    public ResponsPerson(string firstName, string lastName, string post, int categoryId)
    {
        FirstName = firstName;
        LastName = lastName;
        Post = post;
        CategoryId = categoryId;
    }

    public ResponsPerson()
    {
        FirstName = "test";
        LastName = "test";
        Post = "test";
        CategoryId = 0;
    }
}
