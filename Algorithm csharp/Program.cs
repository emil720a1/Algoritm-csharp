
class Algortihm
{
    private static int FindSmallest(int[] array)
    {
        int smallest = array[0];
        int smallestIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < smallest)
            {
                smallest = array[i];
                smallestIndex = i;
            }
        }
        return smallestIndex;
    }

    public static List<int> SelectionSort(int[] array)
    {
        List<int> newArray = new List<int>();
        
        
        List<int> listToProcess = new List<int>(array);
        for (int i = 0; i < array.Length; i++)
        {
            int smallestIndex = FindSmallest(array);
            int smallestValue = array[smallestIndex];
            
            newArray.Add(smallestValue);
            
            listToProcess.RemoveAt(smallestValue);
        }
        return newArray;
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        
    }
}