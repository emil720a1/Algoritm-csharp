
class Algorithm
{
    public int BinarySearch(int[] array, int item)
    {
        int min = 0;
        int max = array.Length - 1;

        while (min <= max)
        {
            int mid = (min + max) / 2;
            int guess = array[mid];

            if (guess == item)
            {
                return mid;
            }
            else if (guess > item)
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        return min;
    }
    
    
}

class Program
{
    static void Main(string[] args)
    {
        int[] arr = [1, 2, 3, 4, 5];
        Algorithm algo = new Algorithm();
        Console.WriteLine(algo.BinarySearch(arr, 5));
    }
}