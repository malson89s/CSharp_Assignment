using System.Text.RegularExpressions;
using Business.Models;

namespace Business.Helpers;

public static class ValidationHelper
{
    public static bool ValidateContact(ContactModel contact, out string errorMessage)
    {

        if (string.IsNullOrEmpty(contact.Email)) 
        {
            errorMessage = "A valid Email adress is required";
            return false;
        }
        if (!string.IsNullOrEmpty(contact.Phone)) 
        {
            errorMessage = "Phone number must contain at least 10 digits";
            return false;   
        }
        errorMessage = string.Empty;
        return true;

    
    }
    //validering epost
    public static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        return false;

        string emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, emailRegex);
    }
    public static bool IsValidPhone(string Phone)
    {
        if (string.IsNullOrEmpty(Phone))
            return false;

        string phoneRegex = @"^\d{10,}$";
        return Regex.IsMatch(Phone, phoneRegex);
    }

}


