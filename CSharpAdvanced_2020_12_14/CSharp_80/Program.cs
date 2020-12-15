using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp_80
{

    public class TestClass : IDisposable
    {
        public string Title { get; set; } = "Hallo";

        public TestClass()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }


    public interface ITest
    {
        public void Hallo()
        {
            Console.WriteLine("Hallo Welt");
        }

        public virtual void GutenAbend()
        {
            Console.WriteLine("Hallo Welt");
        }

        public abstract void GutenMorgen();

        public void Wiederschauen();
        
    }

    public class TestWithInterface : ITest
    {
        public void Wiederschauen()
        {
            Console.WriteLine("Wiederschauen");
        }

        public void GutenMorgen()
        {
            throw new NotImplementedException();
        }

        // In einer Instanz von TestWithInterface fehlt die Methode Hallo. 
        // Allerdings kann man Hallo (Interface-Default Methode) mithilfe folgenden Quellcode aufrufen 

        public void TestMe()
        {
            ITest myInterface = (ITest)this;
            myInterface.Hallo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestWithInterface test1 = new TestWithInterface(); //Klasseninstanz 
            test1.TestMe();

            ITest test = new TestWithInterface();
            test.Hallo(); //Hier wird die Hallo - Methode aus dem Interface aufgerufen

            #region Index-Ranges
            string[] stringArray = { "Franz", "fährt", "in", "einem", "verwahlosten", "Taxi", "durch", "Bayern" };

            Console.WriteLine($"{stringArray[^0]}");
            Console.ReadKey();
            #endregion
            #region yield - Beispiel
            GebeZahlenAus();
            #endregion
            #region Using 
            for (int i = 0; i < 10; i++)
            {
                using TestClass test2 = new TestClass();
            } //Dispo

            //Hier kann nicht mehr auf test.Title zugegriffen werden

            #endregion



            #region VerbatinString

            string consolenAusgabe = "Hallo Regina \n ich hoffe der Kurs bereitet Dir Freude"; //Text mit Escapezeichen
            string filePath1 = "C:\\Temp\\anyDirectory";
            string filePath2 = @"C:\Temp\anyDirectory";
            string stringMitVariable = $"{filePath1} {filePath2}";
            #endregion
        }

        public static async IAsyncEnumerable<int> GeneriereZahlen()
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                yield return i; 
                // Gebe pro Schleifendurchlauf einen Wert nach dem Anderen heraus, bis die Schleife durchgelaufen ist. 
                // yield return sagt nicht, dass man eine Methode verlässt, wie bei einem einfachen Retun
            }
                
        }

        public static async void GebeZahlenAus()
        {
            await foreach (var zahl in GeneriereZahlen())
            {
                Console.WriteLine(zahl);
            }
        }
    }
}
