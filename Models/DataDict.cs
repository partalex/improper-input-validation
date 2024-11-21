namespace WebApplication1.Models;

public class DataDict
{
    public Dictionary<string, string> Data = new Dictionary<string, string>();

    public string this[string key]
    {
        get => Data.ContainsKey(key) ? Data[key] : null;
        set => Data[key] = value;
    }

    public string FirstName
    {
        get => this["FirstName"];
        set => this["FirstName"] = value;
    }

    public string LastName
    {
        get => this["LastName"];
        set => this["LastName"] = value;
    }

    public string City
    {
        get => this["City"];
        set => this["City"] = value;
    }

    public string BirthDate
    {
        get => this["BirthDate"];
        set => this["BirthDate"] = value;
    }

    public string Password
    {
        get => this["Password"];
        set => this["Password"] = value;
    }

    public static List<DataDict> GetSampleData()
    {
        return new List<DataDict>
        {
            new()
            {
                Data = new Dictionary<string, string>
                {
                    { "FirstName", "Aleksandar" },
                    { "LastName", "Vasilic" },
                    { "City", "Novi Beograd" },
                    { "BirthDate", "1990-01-01" },
                    { "Password", "password-1" }
                }
            },
            new()
            {
                Data = new Dictionary<string, string>
                {
                    { "FirstName", "Milena" },
                    { "LastName", "Jovanovic" },
                    { "City", "Novi Beograd" },
                    { "BirthDate", "1990-01-01" },
                    { "Password", "password-2" }
                }
            },
            new()
            {
                Data = new Dictionary<string, string>
                {
                    { "FirstName", "John" },
                    { "LastName", "Doe" },
                    { "City", "Springfield" },
                    { "BirthDate", "1990-01-01" },
                    { "Password", "password-3" }
                }
            },
            new()
            {
                Data = new Dictionary<string, string>
                {
                    { "FirstName", "Jane" },
                    { "LastName", "Smith" },
                    { "City", "Springfield" },
                    { "BirthDate", "1990-01-01" },
                    { "Password", "password-4" }
                }
            },
            new()
            {
                Data = new Dictionary<string, string>
                {
                    { "FirstName", "Bob" },
                    { "LastName", "Jones" },
                    { "City", "Springfield" },
                    { "BirthDate", "1990-01-01" },
                    { "Password", "password-5" }
                }
            }
        };
    }
}