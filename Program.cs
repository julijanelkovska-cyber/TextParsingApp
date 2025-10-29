using System.Globalization;

namespace Parsiranje_teksta
{

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthPlace { get; set; }

        public Person(string firstName, string lastName, string birthPlace)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthPlace = birthPlace;
        }

       
    }
         internal class Program
        {
            static void Main(string[] args)
            {
                string text = "John.Davidson/Belgrade Michael.Barton/Krakow Ivan.Perkinson/Moscow";
                string[] peopleData = text.Split(' ');

                Person[] people = new Person[peopleData.Length]; 

                for (int i = 0; i < peopleData.Length; i++)
                {
                string[] parts = peopleData[i].Split(new char[] { '.', '/' });
                string firstName = parts[0];
                string lastName = parts[1];
                string birthPlace = parts[2];

                    people[i] = new Person(firstName, lastName, birthPlace);
                }

                foreach (var person in people)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName} - {person.BirthPlace}");
                }
            }
        }
    }
