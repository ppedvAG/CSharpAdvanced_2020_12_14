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



    #region Solution Variante
    public interface IPersonStatistik<T> where T : Person
    {
        void ShowStatistk(T Person);
    }

    //public abstract class RepositoryBase<TEntity, TKey> : IRepositoryBase<TEntity, TKey> where TEntity : class
    public abstract class PersonStatistics<T> : IPersonStatistik<T> where T : Person
    {
        public abstract void ShowStatistk(T Person);
    }
    public class FinishEmployeeStatistics : PersonStatistics<Employee>
    {
        public override void ShowStatistk(Employee Person)
        {
        }
    }
    public class FinishFreelancerStatistics : PersonStatistics<Freelancer>
    {
        public override void ShowStatistk(Freelancer Person)
        {

        }
    }
    #endregion

}
