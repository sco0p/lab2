using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class User
    {
        private string name;
        private string surname;
        private int age;
        private string login;
        private readonly DateTime joinDate = DateTime.Today;

        public User(string name, string surname, int age, string login)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Login = login;
        }

        public DateTime JoinDate => joinDate;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        public string Login { get => login; set => login = value; }

        public override string ToString()
        {
            return $"Name: {Name,-5} Surname: {Surname,-10} Login: {Login,-15} Age: {Age,-5} Joined: {JoinDate.ToShortDateString()}";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("John", "Weak", 45, "JohnWeak111");
            Console.WriteLine(user.ToString());
        }
    }
}
