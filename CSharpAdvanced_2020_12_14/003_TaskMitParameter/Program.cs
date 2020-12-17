using System;
using System.Threading.Tasks;

namespace _003_TaskMitParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Katze katze = new Katze();
            
            //Mein Task hat einen string Rückgabewert und übergibt als Parameter den Wert 10.000
            //Task<string> = Rückgabetyp, der aufgerufenen Methode
            Task<string> task = Task.Factory.StartNew(GibtDatumMitInput, katze);

            //Run - Methode mit Parameter 
            Task<string> task1 =  Task.Run(() => GibtDatumMitInput(katze));

            //dritte alternative in Verwendung mit der Task.Start() - Methode
            Task easyTask = new Task(() => GibtDatumMitInput(katze));
            easyTask.Start();

            Console.Write(task.Result); //Das Ergebnis steckt dann in task.Result
            Console.ReadKey();
        }


        private static string GibtDatumMitInput(object input)
        {
            Katze katze = null;

            if (input is Katze)
                katze = (Katze)input;

            Console.WriteLine(katze.Name);

            //int dauer = (int)input;

            //Thread.Sleep(dauer);
            return DateTime.Now.ToLongDateString();
        }
    }

    public class Katze
    {
        public string Name { get; set; } = "Maya";
    }
}
