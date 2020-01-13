using System;

namespace FuncoesString {
    class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();

            string s3 = original.Trim();

            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(5,15);

            string s6 = original.Replace('a','x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original); //se é nula ou vazia
            bool b2 = String.IsNullOrWhiteSpace(original); //se é nula ou com espaços em branco

            //Split : recortar uma string com base me um caracter

            Console.WriteLine("Original: -" + original + "-");

            Console.WriteLine("-----------------------");

            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");

            Console.WriteLine("Trim: -" + s3 + "-");

            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);

            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(5,15): -" + s5 + "-");

            Console.WriteLine("Replace('a','x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");

            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}
