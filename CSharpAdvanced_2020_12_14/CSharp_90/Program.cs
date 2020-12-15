using System;

namespace CSharp_90
{

    public class MyClass
    {
        public string Titel { get; set; } //Auto Property
        public DateTime Date { get; set; }
       

        public MyClass()
        {
            Titel = string.Empty;
            Date = DateTime.Now;
        }

        public MyClass (string titel, DateTime date)
        {
            Titel = titel;
            Date = date;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            MyClass myClass2 = new MyClass("Hallo", DateTime.Now);

            MyClass myClass3 = new(); // MyClass myClass1 = new MyClass();
            MyClass myClass4 = new("ABC", DateTime.Now);



            PersonClass personenClass1 = new PersonClass("Max", "Musterfrau");
            PersonClass personenClass2 = new PersonClass("Max", "Musterfrau");

            // Referenzen werden geprüft 
            if (personenClass1 == personenClass2)
            {
                Console.WriteLine("gleich!");
            }
            else
            {
                Console.WriteLine("ungleich!");
            }

            if (personenClass1.Equals(personenClass2))
            {

            }
            else
            {
                //lande bei der Prüfung mit Equals
            }

           
            
            Person myFirstRecord1 = new("Kevin","Winter");
            Person myFirstRecord2 = new("Kevin", "Winter");

            //Werteprüfung
            if (myFirstRecord1 == myFirstRecord2)
            {
                Console.WriteLine("gleich!");
            }
            else
            {
                Console.WriteLine("ungleich!");
            }

            if (myFirstRecord1.Equals(myFirstRecord2))
            {
                //lande nach der PRüfung hier. Bei Equals in Record = Werteprüfung
            }

            Console.WriteLine($"##### HashCodes class vs. records");
            Console.WriteLine($"HashCode von PersonenClass1: {personenClass1.GetHashCode()}");
            Console.WriteLine($"HashCode von PersonenClass2: {personenClass2.GetHashCode()}");
            Console.WriteLine($"HashCode von myFirstRecord1: {myFirstRecord1.GetHashCode()}");
            Console.WriteLine($"HashCode von myFirstRecord2: {myFirstRecord2.GetHashCode()}");


            Console.WriteLine($"##### ToString class vs. records");
            Console.WriteLine($"Class.ToString() -> {personenClass1.ToString()}");
            Console.WriteLine($"Record.ToString() -> {myFirstRecord1.ToString()}");



            var blog1 = new Blog("C# 9", "{ State of .NET 5 } rockt!",
                new[]
                {
                    "Hat spaß gemacht!",
                    "Konnte vom HomeOffice teilnehmen :-)"
                });

            var blog2 = new Blog("C# 9", "{ State of .NET 5 } rockt!",
                new[]
                {
                    "Hat spaß gemacht!",
                    "Konnte vom HomeOffice teilnehmen :-)"
                });

            Console.WriteLine($"{blog1.ToString()}");

            Console.ReadLine();



        }
    }




    #region Records
    public record Blog(string Title, string Content, string[] Comments);
    public record Person(string Vorname, string Nachname);
    public record Employee(string Firmennamen, string Vorname, string Nachname) : Person(Vorname, Nachname);
    public record Haus(Person person);
    public record PersonenListe(string Veranstaltung, string[] Namen);

    public record Artikel
    {
        public string Titel { get; init; } //Artikel muss Konstruktor zugewiesen
        public string Content { get; set; }
    }
    public class PersonClass
    {
        public string Vorname { get; init; }
        public string Nachname { get; init; }

        public PersonClass(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }

        public void Deconstruct(out string vorname, out string nachname)
        {
            nachname = Nachname;
            vorname = Vorname;
        }
    }

    #endregion
}
