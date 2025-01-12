using Business.Factories;
using Business.Models;

namespace Test.Factories;

    public class ContactFactory_Tests
    {
        [Fact]
        public void Create_ShouldReturnContactform()
        {
            // Act
            var result = ContactFactory.Create();
           

            // Assert
            Assert.NotNull(result);
            Assert.IsType<ContactModel>(result);

        }

    [Fact]
    public void Create_ShouldReturnContact_WhenContactModelIsProvided()
    {

        // Arrange
        var contactModelForm = new ContactModel()
        {
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@domain.com",
        };


        // Act
        var result = ContactFactory.Create(contactModelForm);


        // Assert
        Assert.NotNull(result);
        Assert.IsType<ContactModel>(result);
        Assert.Equal(contactModelForm.FirstName, result.FirstName);
        Assert.Equal(contactModelForm.LastName, result.LastName);
        Assert.Equal(contactModelForm.Email, result.Email);

    }
}

