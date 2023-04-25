using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Builder
{
    public class InternalEmployeeBuilder : EmployeeBuilder
    {
        public override void SetEmailAddress(string emailAddress)
        {
            var arr=emailAddress.Split('@');
            Employee.EmailAddress = arr[0]+"@company.com.tr";
        }

        public override void SetFullName(string fullName)
        {
            var arr = fullName.Split(new[] { '_', ',', ' ', '.' });
            Employee.FirstName = arr[0];
            Employee.LastName = arr[1];
        }

        public override void SetUserName(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
