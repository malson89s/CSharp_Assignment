namespace Business.Models;

public class ContactModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public int IdNumber { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string StreetAdress { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
}
