using System;
using System.Linq;

namespace By_3_or_not_by_3_That_is_the_question
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DivisibleByThree("123"));
            Console.ReadKey();
        }
        public static bool DivisibleByThree(string n)
        {
            var lista = n.ToList().Sum(x => int.Parse(x.ToString())) % 3 == 0;
            return lista;

        }
    }
}
