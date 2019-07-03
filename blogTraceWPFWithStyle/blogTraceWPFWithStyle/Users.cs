using System.Collections.Generic;

namespace blogTraceWPFWithStyle
{ 
    public class Users
    {
        public List<User> items;

        public Users()
        {
            items = new List<User>();
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Age { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        
        public User()
        {

        }

        public User(string name, string surname, string city, string age, string login, string pswd, bool admin)
        {
            Name = name;
            Surname = surname;
            City = city;
            Age = age;
            Login = login;
            Password = pswd;
            Admin = admin;
        }
    }
}