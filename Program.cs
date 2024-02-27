/*
 Namn: Patrik Högblom 
 Datum: 2024-02-27
 Övning LEXION: C# Övning 1 - Personalregister

 */


//Uppgift: skapa en personalresister 2 krav
//1:a kravet ta emot och lagra anställda, namn ochy lön via inmatning i konsol
//2:a kravet programmet skall skriva ut register i konsolen

//Vilka klasser bör ingå i programmet:
//Program: för köra huvudkoden
//Employee för lagra nuvarande namn och lön,
//Employeeregister för skapa en lista och lagra informationen vi lagrat i employee

//Vilka attribut och metoder bör ingå i dessa klasser?
//Employee klass
//attribut: Name,Salary
//Metoder: konstruktor för ta emot namn och lön

//EmployeeRegister klass:
//employeese: en lista som lagrar alla anställda
//Metoder:
//EmployeeRegister, konstruktor för skapa en ny instans av register och initaliserar listan av anställda
//AddEmployee: adderar en anställd till registerlistan 
//DisplayEmployees: visar listan på anställda

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_Personalregister
{

    public class Employee
    {
        public string Name { get; set; } //lagrar nuvarande namn på anställd
        public int Salary { get; set; } // lagrar nuvarande lön på anställd 

        public Employee(string name, int salary) 
        { 
            this.Name = name;
            this.Salary = salary;
        }
    }

    public class EmployeeRegister
    {
        private List<Employee> employees;

        public EmployeeRegister()
        {
            employees = new List<Employee>();
        }

        /*Addera anställda till listan employees*/
        public void AddEmployeeToList(Employee employee)
        {
            employees.Add(employee);
        }

        /*Visa lista på anställda*/
        public void DisplayEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine("Name: {0}, Salary: {1:C}" , employee.Name, employee.Salary);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRegister register = new EmployeeRegister();
            bool programRunning = true;

            //programmet körs tills vi säger åt den att avsluta
            while(programRunning == true)
            {
                Console.WriteLine("Options to choose between: ");
                Console.WriteLine("1. Add employee, i.e. insert name and salary");
                Console.WriteLine("2. Display the register");
                Console.WriteLine("3. Exit the program");
                string optionInput = Console.ReadLine();

                switch (optionInput) 
                {
                    case "1": // Addera en anställd till register
                        Console.WriteLine("Add Name: ");
                        string employeeName = Console.ReadLine();
                        Console.WriteLine("Add Salary in: ");
                        string employeeSalary = Console.ReadLine();

                        register.AddEmployeeToList(new Employee(employeeName, int.Parse(employeeSalary)));
                        break;
                    case "2"://visa register
                        register.DisplayEmployees();
                        break;
                    case "3"://avsluta programmet 
                        programRunning = false;
                        break;
                    default: //om input är annat än 1,2,3 gör detta
                        Console.WriteLine("Please choose between 1,2 and 3");
                        break;
                }
            }
        }
    }
}
