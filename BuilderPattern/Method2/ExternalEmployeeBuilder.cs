using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Method2
{
    public class ExternalEmployeeBuilder : EmployeeBuilderM2
    {
        public override void SetEMailAddress(string email)
        {
            throw new NotImplementedException();
        }

        public override void SetFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public override void SetFullname(string fullname)
        {
            throw new NotImplementedException();
        }
    }
}
