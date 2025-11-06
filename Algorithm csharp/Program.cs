
using System.Reflection.PortableExecutable;

class Algortihm
{
    public void RecursionSimple(int i)
    {
        Console.WriteLine(i);
        if (i <= 1) return;
        RecursionSimple(i - 1);
    }


    public int Factorial(int x)
    {

        if (x == 1)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Algortihm a = new Algortihm();
        a.RecursionSimple(10);
        Console.WriteLine(a.Factorial(10));
    }
}