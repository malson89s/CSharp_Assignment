using Business.Models;

namespace Business.Interfaces;

public interface IContactService
{
    bool Save(ContactModel form);
    IEnumerable<ContactModel> GetAll();
}
