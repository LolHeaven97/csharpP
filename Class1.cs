using System;

public class Class1
{
	public Class1()
	{
        Console.Write("price:");
        double price = double.Parse(Console.ReadLine());
        Console.Write("discount:");
        int discount = int.Parse(Console.ReadLine());
        price = price * (100 - discount) / 100;

        Console.WriteLine("new price=" + price);
    }
}
