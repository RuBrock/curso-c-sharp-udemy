using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListsFixacaoExercicise {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered? ");
            int numEmp = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 0; i < numEmp; i++) {

                Console.WriteLine("\nEmployee #"+(i+1)+":");

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employee(id, name, salary));

            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int idFind = int.Parse(Console.ReadLine());

            int pos = list.FindIndex(x => x.ID == idFind);
            if(pos != -1) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list[pos].increaseSalary(percentage);
            } else {
                Console.WriteLine("This id does not exist!");
            }


            Console.WriteLine("\nUpdated list of employees:");
            foreach(Employee obj in list) {
                Console.WriteLine(obj.ToString());
            }

        }
    }
}
