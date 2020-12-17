using System;
using System.Collections.Generic;
using System.Text;

namespace LockSample
{
    public class Konto
    {
        public decimal Kontostand { get; set; }

        private object lockObject = new object();

        public void Einzahlen(decimal betrag)
        {
            lock (lockObject) //Der erste Thread, sperrt mithilfe von Lock andere Thread aus diesem Codebereich raus. Die anderen Threads warten solange
            {
                Console.WriteLine($"Kontostand vor dem Einzahlen: {Kontostand}");
                Kontostand += betrag; //Ressource wird bearbeitet
                Console.WriteLine($"Kontostand nach dem Einzahlen: {Kontostand}");
            }

        }

        public void Abheben(decimal betrag)
        {
            lock (lockObject)
            {
                Console.WriteLine($"Kontostand vor dem Abheben: {Kontostand}");
                Kontostand -= betrag; //Ressource wird bearbeitet
                Console.WriteLine($"Kontostand nach dem Abheben: {Kontostand}");
            }
        }
    }
}
