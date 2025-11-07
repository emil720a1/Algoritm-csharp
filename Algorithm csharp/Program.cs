
class Algortihm
{
    public static int GCD_Iteration(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        
        return a;
    }


    public static int GCD_Recursion(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return GCD_Recursion(b, a % b);
        }
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        
    }
}