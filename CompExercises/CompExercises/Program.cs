using System;
using System.Globalization;
using CompExercises.Entities;
using CompExercises.Entities.Enums;

namespace CompExercises {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter department's name: ");
            string department = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(department);
            Worker worker = new Worker(name, level, salary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) {
                Console.WriteLine($"Enter #{( i+1 )} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hour = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, value, hour);
                worker.AddContract(contract);
            }

            Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name} \nDepartment: {dept.Name} \nIncome for {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");


        }
    }
}
