using Business.Models;

namespace Business.Factories;

public static class ContactFactory
{
    public static ContactModel Create() => new();

    public static ContactModel Create(ContactModel form) => new ContactModel
    {
        FirstName = form.FirstName,
        LastName = form.LastName,
        Email = form.Email,
        Phone = form.Phone,
        StreetAdress = form.StreetAdress,
        PostalCode = form.PostalCode,
        City = form.City,
        CreatedDate = DateTime.Now
    };
}
