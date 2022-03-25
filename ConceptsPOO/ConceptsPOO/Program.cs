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
    Salary= 2500.45M
};
Console.WriteLine(employee1);
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
Console.WriteLine(employee2);