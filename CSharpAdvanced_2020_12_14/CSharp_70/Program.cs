using System;

namespace CSharp_70
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Out-Variable
            int count = 0;
            ChangeNumberNormal(count);
            Console.WriteLine($"Die Ausgabe von ChangeNumberNormal ist: {count}"); //0

            //Bein Aufruf muss expliziet out mit in den Aufruf geschreiben werden. 
            ChangeNumberWithOut (out count);
            Console.WriteLine($"Die Ausgabe von ChangeNumberWithOut ist: {count}"); //222
            Console.ReadKey();
            #endregion

            #region Defensives Programmieren mit TryParse
            //TryParse verwendet out - Parameter
            if (int.TryParse("123", out count))
                Console.WriteLine($"Ausgabe von TryParse {count}");
            else
                Console.WriteLine("Fehler beim Parsen");
            #endregion


            #region Pattern Mtching
            PatternMatchingSample(123);
            #endregion

            #region Tupel
            Person p = new Person("Kevin", "Winter");
            
            //Allgemein gehalten mit var (typen werden zur Laufzeit zugeordnet
            var name = p.VolleNamensAusgabe();
            Console.WriteLine($"{name.Item1} {name.Item2}");

            //var -> (string, string) typisierte Rückgabe mit Tupel
            (string, string) str = p.VolleNamensAusgabe();
            Console.WriteLine($"{str.Item1} {str.Item2}");


            //Tupel mit Deconstruct
            var (firstname, lastname) = p; //Deconstruct ist keine eigene Methode. Wird dem typ zugeordnet. Daher kann ich auch nur Variable p bei der Zuweisung verwenden.


            //manuell ausprogrammier = viel code :-) 
            string vorname = string.Empty;
            string nachname = string.Empty;
            p.Deconstruct(out vorname, out nachname);

            Console.WriteLine($"{firstname}{lastname}");
            #endregion


            #region Geldbeträge in .NET 
            decimal moneyValue = 1234m;
            Console.WriteLine(moneyValue);
            #endregion

            #region Rückgabe per Referenz 
            //aus 777 wird 1000000! 
            int[] zahlen = { 5, 7, 444, 555, 666, 777, 888, 999 };
            ref int position = ref Zahlensuche(777, zahlen);

            position = 1000000;
            Console.WriteLine(zahlen[5]);

            foreach(int current in zahlen)
            {
                Console.WriteLine($"{current}");
            }
            Console.ReadKey();
            #endregion



        }

        public static void PatternMatchingSample(object anyObj)
        {
            if (anyObj is null)
                throw new ArgumentException();

            //Wenn anyObj ein integer repräsentiert, wird hier gemacht und zusätzlich wird der Wert von anyObj direkt in die i gecastet
            if (anyObj is int i)
            {
                //Variable i gilt nur innerhalb des Codeblocks
                Console.WriteLine($"Variable i  wird als integer behandelt und ausgegeben{i}");
            }
            if (anyObj is string str) //geht auch mit string
                Console.WriteLine(str);
        }

        #region Out-Variablen
        static void ChangeNumberNormal(int number)
        {
            number = 111;
        }

        static void ChangeNumberWithOut(out int number)
        {
            number = 222;
        }
        #endregion


        #region Rückgabe per Referenz

        public static ref int Zahlensuche(int gesuchteZahl, int[] zahlen)
        {
            for (int i = 0; i < zahlen.Length; i++)
            {
                if (zahlen[i] == gesuchteZahl)
                    return ref zahlen[i];
            }

            throw new IndexOutOfRangeException();
        }

        #endregion
    }


    public class Person
    {

        
        public Person() => Firstname = Lastname = string.Empty;

        public Person()
        {
            Firstname = string.Empty;
            Lastname = string.Empty;
        }

        public Person(string firstName, string nachName)
        {
            this.Firstname = firstName;
            this.Lastname = nachName;
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        
        public (string, string) VolleNamensAusgabe()
        {
            return (Firstname, Lastname);
        }

        public void Deconstruct(out string firstname, out string lastname)
        {
            firstname = Firstname;
            lastname = Lastname;
        }
    }


    
}
