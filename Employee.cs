using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Employee
    {
        int id;
        public string name;
        public string reportingManagerName;
        public Employee() {}
        public Employee(/*int id,*/
        string name,
        string reportingManagerName)
        {
            //this.id = id;
            this.name = name;
            this.reportingManagerName= reportingManagerName;

        }
        public void GetDetails()
        {
            //Console.WriteLine("Enter ID");
            //id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter reportingManagerName");
            reportingManagerName = Console.ReadLine();

        }
        public void DisplayDetails()
        {
            Console.WriteLine("ID is " + id);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("reportingManagerName is " + reportingManagerName);
        }
    }
}
