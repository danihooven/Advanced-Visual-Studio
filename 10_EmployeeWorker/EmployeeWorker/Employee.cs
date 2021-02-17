using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWorker
{
    public class Employee
    {
        public Employee(string name, int id)
        {
            EmpName = name;
            EmpId = id;
        }

        public string EmpName { get; set; }
        public int EmpId { get; set; }

        public override string ToString()
        {
            return "Employee Name: " + EmpName + "\r\n" +
                "Employee Id" + EmpId + "\r\n";
        }
    }
}
