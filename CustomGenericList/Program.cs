using CustomGenericList.Models;

namespace CustomGenericList;

class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        list.Add(3);
        list.Add(5);
        list.Add(7);
        list.Add(9);
        list.Add(11);
        Console.WriteLine(list.Find(y => y == 7));
        Console.WriteLine("List Capacity: " + list.Capacity);

        CustomList<int> customList = new CustomList<int>();
        customList.Add(3);
        customList.Add(5);
        customList.Add(7);
        customList.Add(9);
        customList.Add(11);
        Console.WriteLine("Count: " + customList.Count);
        Console.WriteLine("Capacity: " + customList.Capacity);

        customList.ShowItems();
        Console.WriteLine();
        
        Console.WriteLine(customList.Find(x => x == 7));
        
        Console.WriteLine("===============================");
        
        List<string> strList = new List<string>();
        strList.Add("Test1");
        strList.Add("Test2");
        strList.Add("Test3");
        strList.Add("Test4");
        strList.Add("Test5");
        
        Console.WriteLine(strList.Find(x => x == "Test3"));
        
        CustomList<string> customList2 = new CustomList<string>();
        customList2.Add("Test1");
        customList2.Add("Test2");
        customList2.Add("Test3");
        customList2.Add("Test4");
        customList2.Add("Test5");
        
        customList2.ShowItems();
        Console.WriteLine();
        
        Console.WriteLine(customList2.Find(x => x == "Test2"));
        


    }
}