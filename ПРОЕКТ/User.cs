using System.ComponentModel.DataAnnotations;

namespace ПРОЕКТ;

public class User
{
    public int Id { get; set; }
    [MaxLength(50)]

    public string Username { get; set; }
    [MaxLength(255)]
    public string Password { get; set; }

    [MaxLength(100)]
    public string Email { get; set; }

    [MaxLength(20)]
    public string Phone { get; set; }

    [MaxLength(50)]
    public string FirstName { get; set; }

    [MaxLength(50)]
    public string LastName { get; set; }

    public User(string loggin, string ppassword, string email, string phone, string firstName, string lastName)
    {
        Username = loggin;
        Password = ppassword;
        Email = email;
        Phone = phone;
        FirstName = firstName;
        LastName = lastName;

    }

    public User()
    {
        Username = "test";
        Password = "test";
        Email = "test";
        Phone = "test";
        FirstName = "test";
        LastName = "test";
    }
}
