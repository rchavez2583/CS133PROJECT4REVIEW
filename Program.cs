using System;

namespace CS133PROJECT4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.MyCake<string>(" Vanilla ", " Wedding cake ");
            myClass.MyCake2<string>(" Chocolate ", " Party cake ");

        }
    }
}

public class MyClass
{
    public void MyCake<C>(C myFlavor, string myType)
    
    {
        Console.WriteLine("The Flavor of my cake is:" + myFlavor);
        Console.WriteLine("The Type of my cake is for:" + myType);

        Console.WriteLine("");
    }

    public void MyCake2<W>(W myFlavor, string myType)
    {
        Console.WriteLine("The Flavor of my second cake is:" + myFlavor);
        Console.WriteLine("The Type of my  secondcake is for:" + myType);

    }



}