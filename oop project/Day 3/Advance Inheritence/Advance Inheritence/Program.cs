using System;

#region Base Class
public class BaseCLass
{
    public virtual void Show()
    {
        Console.WriteLine("Base Show()");  
    }

    public virtual void Display()
    {
        Console.WriteLine("Base Display()");
    }
}
#endregion

#region Derived Class
public class Derived : BaseCLass
{
 public override void Show ()
    {
        Console.WriteLine("Derived Show() - override");
    }
    public new void Display()
    {
        Console.WriteLine("Derived Display() - new");
    }
}
#endregion 

class Program
{
    static void Main()
    {
        //BaseCLass baseRef = new DerivedClass();
        //DerivedClass derivedRef = new DerivedCLass();

        //Console.WriteLine("---- Base reference ----");
        //baseRef.Show();
        //baseRef.Display();

        //Console.WriteLine("\n---- Derived reference ----");
        //derivedRef.Show();
        //derivedRef.Display();
    }
}