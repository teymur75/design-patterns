using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method2
{
    public abstract class EmployeeBuilderM2
    {
        protected EmployeeM2? Employee { get; set; }

        public EmployeeBuilderM2()
        {
            Employee = new EmployeeM2();
        }

        public abstract void SetFullname(string fullname);

        public abstract void SetEMailAddress(string email);

        public abstract void SetFirstName(string firstName);

        public EmployeeM2 BuildEmployee() => Employee;
    }
}
