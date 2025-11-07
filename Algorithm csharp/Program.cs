
class Algortihm
{
    public static List<T> QuickSort<T>(List<T> list)
    where T : IComparable<T>
    {
        if (list.Count < 2)
        {
            return list;
        }
        T pivot = list[0];
        
        
        List<T> less = list
            .Skip(1)
            .Where(item => item.CompareTo(pivot) <= 0)
            .ToList();

        List<T> greater = list
            .Skip(1)
            .Where(item => item.CompareTo(pivot) > 0)
            .ToList();
        
        return QuickSort<T>(less)
            .Concat(new List<T> { pivot })
            .Concat(QuickSort(greater))
            .ToList();
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int> {10, 80 , 30, 90, 40, 50 , 70};
        Console.WriteLine("Список до сортировки: " + string.Join(", ", list) + "");
        
        List<int> sorted = Algortihm.QuickSort(list);
        Console.WriteLine("Отсортированный список: " + string.Join(", ", sorted));
    }
}