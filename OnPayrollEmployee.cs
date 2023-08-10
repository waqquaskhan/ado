using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class OnPayrollEmployee : Employee
    {
        DateTime joiningDate;
        int exp;
        double basicSalary, da, hra, pf, netSalary;
        public OnPayrollEmployee()
        {

        }
        public OnPayrollEmployee(/*int id,*/
        string name,
        string reportingManagerName, DateTime joiningDate,
        int exp,double basicSalary)
            : base( name, reportingManagerName)
        {
            this.joiningDate = joiningDate;
            this.exp = exp;
            this.basicSalary = basicSalary;
        }
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter joiningDate");
            joiningDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter exp in years");
            exp = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter basicSalary");
            basicSalary = float.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("joiningDate" + joiningDate);
            Console.WriteLine("exp in years" + exp);
            Console.WriteLine("basicSalary" + basicSalary);
            Console.WriteLine("da" + da);
            Console.WriteLine("pf" + pf);
            Console.WriteLine("hra" + hra);
            Console.WriteLine("netSalary" + netSalary);
        }
        public void CalculateSalary()
        {
            if(exp>10)
            {
                da = .1 * basicSalary;
                hra = .85 * basicSalary;
                pf = 6200;
            }
            else if(exp>=7 && exp <=10)
            {
                da = .07 * basicSalary;
                hra = .065 * basicSalary;
                pf = 4100;
            }
            else if (exp >= 5 && exp <= 7)
            {
                da = .041 * basicSalary;
                hra = .038 * basicSalary;
                pf = 1800;
            }
            else
            {
                da = .019 * basicSalary;
                hra = .02 * basicSalary;
                pf = 1200;
            }
            netSalary = (basicSalary + da + hra) - pf;
        }
    }
}
