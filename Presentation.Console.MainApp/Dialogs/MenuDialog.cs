using Business.Models;
using Business.Services;

namespace Presentation.ConsoleApp.Dialogs;

public class MenuDialog
{
    private readonly ContactService _contactService = new();

    public void ShowMenu()
    {
        var isRunning = true;

        do
        {
            Console.Clear();
            Console.WriteLine("-------- CONTACT LIST --------");
            Console.WriteLine("1. Add New Contact");
            Console.WriteLine("2. View All Contacts ");
            Console.WriteLine("3. Exit Application");
            Console.WriteLine("------- ------- ------- ------");
            Console.Write("Enter option: ");

            string option = Console.ReadLine()!;

            switch (option.ToLower())
            {
                case "1":
                    ShowAddContact();
                    break;

                case "2":
                    ShowAllContacts();
                    // vid return hamnar här
                    break;


                case "3":
                    Console.Clear();
                    OutputDialog("Press any key to exit application");
                    isRunning = false;
                    break;

                default:
                    OutputDialog("Invalid option. Please try again");
                    break;
            }

        } while (isRunning);
    }

    public void ShowAddContact()
    {
     
        var contact = new ContactModel();

        Console.Clear();
        Console.WriteLine("-------- ADD NEW CONTACT --------");
        Console.Write("Enter First Name: ");
        contact.FirstName = Console.ReadLine()!;

        Console.Write("Enter Last Name: ");
        contact.LastName = Console.ReadLine()!;

        Console.Write("Enter Email: ");
        contact.Email = Console.ReadLine()!;

        _contactService.CreateContact(contact);

    }

    public void ShowAllContacts()
    {
        bool hasError;
        var contacts = _contactService.GetAllContacts(out hasError);

        Console.Clear();
        Console.WriteLine("-------- ALL CONTACTS --------");

        if (hasError)
        {
            OutputDialog("Something went wrong. Please try again later ");
            return;
        }

        if (!contacts.Any())
        {
            OutputDialog("No Contacts Found. Press any key to go back");
            return;
        }
        foreach (var contact in contacts)
        {
            Console.WriteLine($"{contact.Id} Name: {contact.FirstName} {contact.LastName} Email: {contact.Email} Created: {contact.CreatedDate}");
        }
        Console.ReadKey();
    }

    public void OutputDialog(string message)
    {
        Console.WriteLine(message);
        Console.ReadKey();
    }
}
