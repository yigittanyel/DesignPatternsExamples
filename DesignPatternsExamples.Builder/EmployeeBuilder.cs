using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExamples.Builder
{
    public interface IEmployeeBuilder
    {
        Employee BuildEmployee();
        void SetEmailAddress(string emailAddress);
        void SetFullName(string fullName);
        void SetUserName(string userName);
    }

    public abstract class EmployeeBuilder : IEmployeeBuilder
    {
        protected Employee Employee { get; set; }

        public EmployeeBuilder()
        {
            Employee = new Employee();
        }

        public abstract void SetFullName(string fullName);
        public abstract void SetEmailAddress(string emailAddress);
        public abstract void SetUserName(string userName);

        public Employee BuildEmployee() => Employee;

    }
}
