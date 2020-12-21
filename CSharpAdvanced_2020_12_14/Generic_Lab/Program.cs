using System;

namespace Generic_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    /* Aufgabenstellung:
     * Wir sehen die Klassen EmployeeStatistics und FreelancerStatistics. 
     * Bei beiden Klassen wurde vergessen, eine gemeinsame Basisklasse anzulegen. 
     * 
     * Die Basisklasse soll einen genrischen Ansatz verfolgen. 
     * Zusätzlich kann die Basisklasse mit einem Interface flankiert werden. 
     * 
     */
    public class EmployeeStatistics
    {
        public void ShowStatistik(Employee employee)
        {
            Console.WriteLine(employee.Gehalt);
        }

        public DateTime EmployeeSeit(Employee employee)
        {
            return employee.AngestelltSeit;
        }
    }
    public class FreelancerStatistics
    {
        public void ShowStatistik(Freelancer freelancer)
        {
            Console.WriteLine(freelancer.Stundensatz);
        }

        public void AktuellesProjekt(Freelancer freelancer)
        {
            Console.WriteLine(freelancer.Projektbezeichnung);
        }
    }
}
