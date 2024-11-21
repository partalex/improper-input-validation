using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models;

public class Data
{
    [Display(Name = "FirstName")] public string FirstName { get; set; }
    [Display(Name = "LastName")] public string LastName { get; set; }
    [Display(Name = "City")] public string City { get; set; }
    [Display(Name = "BirthDate")] public string BirthDate { get; set; }
    [Display(Name = "Password")] public string Password { get; set; }


    public static List<Data> GetSampleData()
    {
        return
        [
            new Data
            {
                FirstName = "Aleksandar", LastName = "Vasilic", City = "Novi Beograd", BirthDate = "1990-01-01",
                Password = "password-1"
            },
            new Data
            {
                FirstName = "Milena", LastName = "Jovanovic", City = "Novi Beograd", BirthDate = "1990-01-01",
                Password = "password-2"
            },
            new Data
            {
                FirstName = "John", LastName = "Doe", City = "Springfield", BirthDate = "1990-01-01",
                Password = "password-3"
            },
            new Data
            {
                FirstName = "Jane", LastName = "Smith", City = "Springfield", BirthDate = "1990-01-01",
                Password = "password-4"
            },
            new Data
            {
                FirstName = "Bob", LastName = "Jones", City = "Springfield", BirthDate = "1990-01-01",
                Password = "password-5"
            },
        ];
    }

}