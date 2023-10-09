using System.CodeDom;

namespace Anketa;

public enum Gender { Male, Female }
public class Person
{
    string _name;
    string _surname;
    string _fatherName;
    string _country;
    string _city;
    string _email;
    string _phone;
    Gender _gender;
    DateTime _birthDay;
    public string Name
    {
        get => _name;
        set
        {
            if (value.Length > 3)
                _name = value;
            else
                throw new ArgumentException("Name minimum symbols count = 3");
        }
    }
    public string Surname
    {
        get => _surname;
        set
        {
            if (value.Length > 5)
                _surname = value;
            else
                throw new ArgumentException("Surname minimum symbols count = 5");
        }
    }
    public string FatherName
    {
        get => _fatherName;
        set
        {
            if (value.Length > 3)
                _fatherName = value;
            else
                throw new ArgumentException("Father name minimum symbols count = 3");
        }
    }
    public string Country
    {
        get => _country;
        set
        {
            if (value.Length > 4)
                _country = value;
            else
                throw new ArgumentException("Country minimum symbols count = 4");
        }
    }
    public string City
    {
        get => _city;
        set
        {
            if (value.Length > 3)
                _city = value;
            else
                throw new ArgumentException("City minimum symbols count = 3");
        }
    }
    public string Email
    {
        get => _email;
        set
        {
            if (value.Length > 11 && value.Contains("@gmail.com"))
                _email = value;
            else
                throw new ArgumentException("Email will be find '@gmail.com' and minimum symbols count = 11");
        }
    }
    public string Phone
    {
        get => _phone;
        set
        {
            if (value.Length == 11 && value.StartsWith("+994"))
                _phone = value;
            else
                throw new ArgumentException("Phone will be start '+994' and minimum symbols count = 11");
        }
    }
    public Gender gender
    {
        get => _gender;
        set
        {
            if (value != null)
                _gender = value;
            else
                throw new ArgumentException("Gender null error");
        }
    }
    public DateTime BirthDay
    {
        get => _birthDay;
        set
        {
            if (value != null)
                _birthDay = value;
            else
                throw new ArgumentException("DateTime null error");
        }
    }

    public Person() { }
    public Person(string name, string surname, string fatherName, string country, string city, string email, string phone, Gender gender, DateTime birthDay)
    {
        Name = name;
        Surname = surname;
        FatherName = fatherName;
        Country = country;
        City = city;
        Email = email;
        Phone = phone;
        this.gender = gender;
        BirthDay = birthDay;
    }

    public override string ToString()
    {
        string result = $"Name: {Name}\nSurname: {Surname}\nFatherName: {FatherName}\nCountry: {Country}\nCity: {City}" +
            $"\nEmail: {Email}\nPhone: {Phone}\nGender: {gender}\nBirthDay: {BirthDay}";
        return result;
    }
}
