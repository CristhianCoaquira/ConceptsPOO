// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO Concepts!");
Console.WriteLine("=============");

try
{
    Date date1 = new Date(2024, 02, 29);
    Date date2 = new Date(2022, 12, 31);
    Date date3 = new Date(2022, 11, 30);
    Console.WriteLine(date1);
    Console.WriteLine(date2);
    Console.WriteLine(date3);
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}