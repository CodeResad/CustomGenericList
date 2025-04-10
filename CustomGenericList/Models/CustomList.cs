namespace CustomGenericList.Models;

public class CustomList<T>
{
    T[] items;
    private int count;
    
    public int Count => count;


    public int Capacity
    {
        get
        {
            return items.Length;
        }
        set
        {
            if (value < items.Length)
            {
                Console.WriteLine("Capacity cannot be less than current size");
            }

            if (value > items.Length)
            {
                T[] newArray = new T[value];
                Array.Copy(items, newArray, count);
                items = newArray;
            }
        }
    }

    public CustomList()
    {
        items = new T[0];
    }

    public CustomList(int capacity)
    {
        if (capacity == 0)
            items = new T[0];
        else
            items = new T[capacity];
    }

    public T this[int index]
    {
        get {  return items[index]; }
        set
        {
            items[index] = value;
        }
    }

    public void Add(T item)
    {
        if (count < items.Length)
        {
            count++;
            items[count-1] = item;
        }
        else
        {
            Capacity = items.Length == 0 ? 4 : items.Length * 2;
            Array.Resize(ref items, Capacity);
            count++;
            items[count-1] = item;
        }
    }

    public T? Find(Predicate<T> match)
    {
        for (int i = 0; i < count; i++)
        {
            if (match(items[i]))
            {
                return items[i];
            }
        }
        
        return default;
    }

    public void ShowItems()
    {
        foreach (T i in items)
        {
            Console.Write(i + " ");
        }
    }

    

    
}