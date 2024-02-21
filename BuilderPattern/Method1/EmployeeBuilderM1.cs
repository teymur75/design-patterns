using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method1
{
    public class EmployeeBuilderM1
    {
        private EmployeeM1? employee { get; set; }

        public EmployeeBuilderM1()
        {
            employee = new EmployeeM1();
        }


        public EmployeeBuilderM1 SetUsername(string username)
        {
            employee.UserName=username;
            return this;
        }

        public EmployeeBuilderM1 SetEmailAdress(string emailAdress)
        {
            employee.EmailAdress = emailAdress;
            return this;
        }


        public EmployeeM1 BuildEmployee()
        {
            return employee;
        }
    }
}
