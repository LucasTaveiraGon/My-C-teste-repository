using System;
using System.Globalization;
using WorkerContract.Entities;
using WorkerContract.Entities.Enums;

namespace WorkerContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();
            Console.Write("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level: (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);
            Console.WriteLine("How Many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++) 
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Durantion (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract= new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            String monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Department: " + worker.Departament.Name);
            Console.WriteLine("Income for " +monthAndYear+ ": "+worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
