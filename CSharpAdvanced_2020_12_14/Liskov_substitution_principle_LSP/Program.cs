using System;

namespace Liskov_substitution_principle_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    #region BadCode

    public abstract class BadEmployee
    {
        public virtual string GetProjectDetails(int employeeId)
        {
            return "Base Project";
        }
        public virtual string GetEmployeeDetails(int employeeId)
        {
            return "Base Employee";
        }
    }

    public class CasualEmployee : BadEmployee
    {
        public override string GetProjectDetails(int employeeId)
        {
            base.GetProjectDetails(employeeId);
            return "Child Project";
        }
        // May be for contractual employee we do not need to store the details into database.
        public override string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee";
        }
    }
    public class ContractualEmployee : BadEmployee
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        // May be for contractual employee we do not need to store the details into database.
        public override string GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();
        }
    }

    #endregion


    #region BEssereVariante


    public interface IEmployee
    {
        string GetEmployeeDetails(int employeeId);
    }

    public interface IPoject
    {
        string GetProjectDetails(int employee);
    }


    public class NextGenEmployee : IEmployee, IPoject
    {
        public string GetEmployeeDetails(int employeeId)
        {
            return "Employee Details";
        }

        public string GetProjectDetails(int employee)
        {
            return "Project Details";
        }
    }
    #endregion
}
