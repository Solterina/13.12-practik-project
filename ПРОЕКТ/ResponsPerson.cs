using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПРОЕКТ;

public class ResponsPerson
{
    public int Id { get; set; }
    [MaxLength(100)]

    public string Post { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }

    public Category Category { get; set; }

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
