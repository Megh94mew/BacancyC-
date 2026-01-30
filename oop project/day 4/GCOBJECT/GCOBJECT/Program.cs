using System;

public class GCOBJECT
{
    private int _id;

    public GCOBJECT(int id)
    {
        _id = id;
        Console.WriteLine($"Constructor called for object {_id}");
    }

    ~GCOBJECT()
    {
        Console.WriteLine($"Finalizer called for object {_id}");
    }
}