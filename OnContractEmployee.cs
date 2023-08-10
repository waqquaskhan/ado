using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment6
{
    internal class OnContractEmployee : Employee
    {
        public DateTime contractDate;
        public byte duration;
        public float chargesPerDay;
        public float totalCharges;
        public OnContractEmployee() : base() { }
        public OnContractEmployee(
        string name,
        string reportingManagerName, DateTime contractDate,
        byte duration,
        float chargesPerDay) 
            : base(name,reportingManagerName)
        { this.contractDate = contractDate;
            this.duration = duration;
            this.chargesPerDay = chargesPerDay;
        }
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter contractDate");
            contractDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter duration in days");
            duration = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter chargesPerDay");
            chargesPerDay = float.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("contractDate" + contractDate);
            Console.WriteLine("duration in days" + duration);
            Console.WriteLine("chargesPerDay" + chargesPerDay);
            Console.WriteLine("totalCharges" + totalCharges);
        }
        public void CalculateTotalCharges()
        {
            totalCharges = duration * chargesPerDay;
        }

    }
}
