﻿// See https://aka.ms/new-console-template for more information
using EmployeePayRoll_ADO.Net;

Console.WriteLine("Welcome To Employee_Payroll ADO.NET !");

EmployeeRepo employeeRepo = new EmployeeRepo();
Employee_details employeeDetails = new Employee_details();


while (true)
{
    Console.WriteLine("Choose the option :\n1)Create and retrieve values from Database\n2)Add Employeee Details to DataBase\n3)Update salary\n5)Get Employee Details from a DateRange\n6)Aggregate Operations");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            employeeRepo.GetEmployeedetails();
            break;
        case 2:
            employeeDetails.FirstName = "Radha";
            employeeDetails.LastName = "Krishna";
            employeeDetails.Gender = "Male";
            employeeDetails.StartDate = DateTime.Now;
            employeeDetails.Company = "Amazon";
            employeeDetails.Departent = "Marketing";
            employeeDetails.Address = "Mumbai";
            employeeDetails.BasicPay = 25000;
            employeeDetails.Deductions = 1000;
            employeeDetails.TaxablePay = 600;
            employeeDetails.IncomeTax = 1200;
            employeeDetails.NetPay = 35000;

            employeeRepo.AddEmployee(employeeDetails);
            Console.WriteLine("Details Inserted Successfully");
            break;
        case 3:
            employeeRepo.updateSalary();
            int salary = employeeRepo.updateSalary();
            Console.WriteLine(salary);
            break;
        case 5:
            employeeRepo.GetEmployeedetails_with_StartDate();
            break;
        case 6:
            int count = employeeRepo.CountOfRows();
            Console.WriteLine("Count of Records :" + count);
            int AverageSalary = employeeRepo.AverageOfSalary();
            Console.WriteLine("Average salary is :" + AverageSalary);
            int SumOfTheSalary = employeeRepo.SumOfSalary();
            Console.WriteLine("Sum of salaries is :" + SumOfTheSalary);
            int minimum = employeeRepo.MinimumOfSalary();
            Console.WriteLine("Minimum of salaries is :" + minimum);
            int maximum = employeeRepo.MaximumOfSalary();
            Console.WriteLine("Maximum of salaries is :" + maximum);
            break;
        default:
            Console.WriteLine("Please choose the correct option");
            break;
    }
}
