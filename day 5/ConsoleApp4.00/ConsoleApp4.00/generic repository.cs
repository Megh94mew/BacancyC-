using System;
using System.Collections.Generic;

public class Repository<T>
{
    private readonly List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }
    public IEnumerable<T> GetAll()
    {
        return items;
    }

    public T GetByIndex(int index)
    {
        return items[index];
    }
}
