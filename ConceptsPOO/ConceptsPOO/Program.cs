// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO Concepts!");
Console.WriteLine("=============");

Employee employee1 = new SalaryEmployee()
{
    Id = 1,
    FirstName = "Cristhian",
    LastName = "Coaquira",
    BirthDate = new Date(1996, 8, 28),
    HiringDate = new Date(2021, 4, 4),
    IsActive = true,
    Salary = 2500.45M
};
//Console.WriteLine(employee1);
Employee employee2 = new CommissionEmployee()
{
    Id = 1,
    FirstName = "Cristhian",
    LastName = "Coaquira",
    BirthDate = new Date(1996, 8, 28),
    HiringDate = new Date(2021, 4, 4),
    IsActive = true,
    CommissionPercetange = 0.3F,
    Sales = 4500
};
//Console.WriteLine(employee2);
Employee employee3 = new HourlyEmployee()
{
    Id = 1,
    FirstName = "Cristhian",
    LastName = "Coaquira",
    BirthDate = new Date(1996, 8, 28),
    HiringDate = new Date(2021, 4, 4),
    IsActive = true,
    Hours = 294F,
    HourValue = 3.5M
};
//Console.WriteLine(employee3);
Employee employee4 = new BaseCommissionEmployee()
{
    Id = 1,
    FirstName = "Cristhian",
    LastName = "Coaquira",
    BirthDate = new Date(1996, 8, 28),
    HiringDate = new Date(2021, 4, 4),
    IsActive = true,
    CommissionPercetange = 0.3F,
    Sales = 4500,
    Base = 1500M
};
//Console.WriteLine(employee4);
ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};
decimal payroll = 0;
foreach (Employee? employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("======================================");
Console.WriteLine($"\tTOTAL................: {$"{payroll:C2}",18}");
Invoice invoice1 = new Invoice
{
    Id = 1,
    Description = "Iphone 13",
    Price = 452324M,
    Quantity = 2
};
Console.WriteLine(invoice1);
Invoice invoice2 = new Invoice
{
    Id = 1,
    Description = "Macbook Pro",
    Price = 1520M,
    Quantity = 1
};
Console.WriteLine(invoice2);