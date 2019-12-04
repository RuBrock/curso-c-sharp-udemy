using System;

namespace VetListasExercicios2 {
    class Program {
        static void Main(string[] args) {

            Rent[] vect = new Rent[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++ ) {
                Console.WriteLine("\nRent #"+(i+1));
                Console.Write("Name: ");
                string name = Console.ReadLine();
                
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Rent {
                    Name = name, Email = email, Room = room
                };

            }

            Console.WriteLine("\nBusy rooms: ");
            for(int i = 0; i < 10; i++) {
                if(vect[i] != null)
                    Console.WriteLine(vect[i]);

            }

        }
    }
}
