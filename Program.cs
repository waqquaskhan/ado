using System.Data.SqlClient;

namespace Assignment6
{
    internal class Program
    {

        static SqlConnection connection = null;
        static SqlCommand  command = null;
        static string GetConnectionString()
        {
            return @"data source=ANAMIKA\SQLSERVER;initial catalog=practiceDb;integrated security= true";

        }
        static SqlConnection GetConnection()
        {
            connection = new SqlConnection(GetConnectionString());
            return connection;
        }
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            
            string c = "y";
            while (c == "y")
            {
                Console.WriteLine("ENter what type of Employee you want to add");
                int ch = Byte.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    //Employee employee = new OnContractEmployee();
                    //if (employee is OnContractEmployee)
                    //{

                    Console.WriteLine("DO you know all the values for Employee");
                    string flag = Console.ReadLine();
                    OnContractEmployee onContractEmployee;
                    if (flag == "y")
                    {

                        onContractEmployee = new OnContractEmployee
                            ( name: "lalit", reportingManagerName: "Chetan", contractDate: DateTime.Now, duration: 20, chargesPerDay: 8500);

                    }
                    else
                    {

                          onContractEmployee = new OnContractEmployee();

                        onContractEmployee.GetDetails();
                    }
                    onContractEmployee.CalculateTotalCharges();
                    connection = GetConnection();
                    command = new SqlCommand();
                    command.CommandText = "insert into employee " +
                        " (name,reportingManager,charges_perDay " +
                        ",duration,totalCharges,contractDate,emplType)  values " +
                        "(@name, @reportingManagerName, @chargesPerDay," +
                        " @duration, @totalCharges, @contractDate, @emplType)";
                    command.Connection = connection;

                    command.Parameters.AddWithValue("@name", onContractEmployee.name);
                    command.Parameters.AddWithValue("@reportingManagerName", onContractEmployee.reportingManagerName);
                    command.Parameters.AddWithValue("@chargesPerDay", onContractEmployee.chargesPerDay);
                    command.Parameters.AddWithValue("@duration", onContractEmployee.duration);
                    command.Parameters.AddWithValue("@totalCharges", onContractEmployee.totalCharges);

                    command.Parameters.AddWithValue("@contractDate",  onContractEmployee.contractDate);
                    command.Parameters.AddWithValue("@emplType", 1);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    command.Dispose();
                    connection.Dispose();

                    onContractEmployee.DisplayDetails();
                    employees.Add((Employee)onContractEmployee);
                }

                else if (ch == 2)
                {
                    //Employee employee = new Employee();
                    //if (employee is OnPayrollEmployee)
                    //{
                    OnPayrollEmployee onPayrollEmployee = new OnPayrollEmployee();
                     onPayrollEmployee.GetDetails();
                    onPayrollEmployee.CalculateSalary();
                    onPayrollEmployee.DisplayDetails();
                    employees.Add((Employee)onPayrollEmployee);
                }


                Console.WriteLine("Do you want to add more employees");
                c = Console.ReadLine();
            }     
                Console.WriteLine("Total Employees are " + employees.Count);
            }
        }
    }
