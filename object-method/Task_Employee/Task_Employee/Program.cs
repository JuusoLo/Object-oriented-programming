using System;

namespace Task_Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Juuso Lonka", 2889943, "Toimitusjohtaja", 9800);
            employees[1] = new Employee("Mikko Turppo", 22324554, "Markkinointijohtaja", 6800);
            employees[2] = new Employee("Atte Peltonen", 35325634, "Siivousvastaava", 2500);

            for (int i = 0; i < 3; i++)
            {
                employees[i].PrintEmployeeInfo();
            }
            employees[1].CompareSalary(employees[2]);
            employees[0].CompareSalary(employees[1]);
            employees[2].CompareSalary(employees[1]);

            Console.ReadKey();

        }
    }
}
