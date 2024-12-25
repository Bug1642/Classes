using System;
namespace Exercise
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public Person()
        {
            this.FirstName = "";
            this.LastName = "";
        }
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
    public class Greeter
    {
        public static string[] Greet(Person[] people)
        {
            string[] greetings = new string[people.Length];
            for (int i = 0; i < people.Length; i++)
            {
                greetings[i] = $"Hello {people[i].FirstName} {people[i].LastName}!";
            }

            return greetings;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bill", "Barnes");
            Person p2 = new Person("Sally", "Smith");
            Person[] people = new Person[] { p1, p2 };
            string[] greetings = Greeter.Greet(people);
            foreach (string greeting in greetings)
            {
                Console.WriteLine(greeting);
            }
        }
    }
}
