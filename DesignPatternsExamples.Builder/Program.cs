using DesignPatternsExamples.Builder;

var emp = GenerateEmployee("yiğit tanyel", "tanyelyigit@gmail.com", 0);
Console.WriteLine("Email Address: " + emp.EmailAddress);

Employee GenerateEmployee(string fullName, string emailAddress, int empType)
{
    IEmployeeBuilder employeeBuilder;
    if (empType == 0)
        employeeBuilder = new InternalEmployeeBuilder();
    else
        employeeBuilder = new InternalEmployeeBuilder();

    employeeBuilder.SetFullName(fullName);
    employeeBuilder.SetEmailAddress(emailAddress);

    return employeeBuilder.BuildEmployee();
}