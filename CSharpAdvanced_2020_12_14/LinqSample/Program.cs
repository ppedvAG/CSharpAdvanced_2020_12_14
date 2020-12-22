using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSample
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Person> persons = new List<Person>()
            {
                new Person { Id=1, Age=40, Vorname="Kevin", Nachname="Winter"},
                new Person { Id=2, Age=43, Vorname="Petra", Nachname="Musterfrau"},
                new Person { Id=3, Age=19, Vorname="Pascal", Nachname="Neugierig"},
                new Person { Id=4, Age=53, Vorname="Matthias", Nachname="Trump"},
                new Person { Id=4, Age=53, Vorname="Matthias2", Nachname="Trump2"},
                new Person { Id=5, Age=23, Vorname="Denise", Nachname="Muster"},
                new Person { Id=6, Age=39, Vorname="Steffi", Nachname="Schuhmacher"},
                new Person { Id=7, Age=41, Vorname="Heike", Nachname="Müller"},
                new Person { Id=8, Age=29, Vorname="Peter", Nachname="Mustermann"}
            };

            //Linq-Expression
            IList<Person> result1 = (from p in persons
                                     where p.Age < 40 && p.Age >= 30
                                     orderby p.Nachname
                                     select p).ToList();
            

            //Linq Functions with Lambda Expressions
            IList<Person> result2 = persons.Where(p => p.Age > 20)
                                            .OrderBy(o => o.Nachname)
                                            .ToList();

            //Frage ob die Liste befüllt ist
            if (result2.Any())
            {
                Person firstPerson = result2.FirstOrDefault();
            }

            Person defaultResult = result2.SingleOrDefault(p => p.Age == 244);


            //We take more sample 

            IList<Person> result3 = (from p in persons
                       where p.Age < 40 && p.Age >= 30
                       orderby p.Nachname
                       select p).Take(20).ToList();

            //Abfragen von "einen" Datensatz
            Person person1 = result2.FirstOrDefault(p => p.Age == 53); //Funktioniert
            Person person2 = result2.SingleOrDefault(p => p.Age == 53); //Exception


            //IQueryable<Person> = 

            foreach (Person person in result1)
            {
                Console.WriteLine($"{person.Id} {person.Vorname} {person.Nachname} {person.Age}");
            }



            //Join
            Sample_Join_Lambda();


            Console.ReadLine();
        }



        static void Sample_Join_Lambda()
        {
            string[] warmCountries = { "Turkey", "Italy", "Spain", "Saudi Arabia", "Etiobia" };
            string[] europeanCountries = { "Denmark", "Germany", "Italy", "Portugal", "Spain" };

            var result = warmCountries.Join(europeanCountries, warm => warm, european => european, (warm, european) => warm);

            Console.WriteLine("Joined countries which are both warm and Europan:");
            foreach (var country in result) // Note: result is an anomymous type, thus must use a var to iterate.
                Console.WriteLine(country);
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }

    }
}
