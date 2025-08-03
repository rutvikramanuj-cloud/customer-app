// See https://aka.ms/new-console-template for more information
using ConsoleApp.Services;

Console.WriteLine("Hello, World!");
CustomerService customer = new();
customer.GetCustomerName();
