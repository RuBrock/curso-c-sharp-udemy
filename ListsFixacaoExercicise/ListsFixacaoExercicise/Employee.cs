using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ListsFixacaoExercicise {
    class Employee {

        public int ID { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee( int id, string name, double salary ) {
            ID = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage) {

            Salary = Salary + ((percentage / 100) * Salary);

        }

        public override string ToString() {
            return ID
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
