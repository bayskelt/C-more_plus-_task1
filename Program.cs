using System.Reflection.PortableExecutable;

namespace C__more_plus__task1
{
    internal class Program
    {
        static int gcd1(int a, int b) 
        {
            if (b == 0)
            {
                return Math.Abs(a);
            }
            return gcd1(b, a % b); 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть три цiлих числа, для яких хочете знайти НСД:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            int divider1 = gcd1(x, y);
            int divider2 = gcd1(divider1, z);

            Console.Write($"\nНСД({x},{y},{z}) = {divider2}");
        }
    }
}
