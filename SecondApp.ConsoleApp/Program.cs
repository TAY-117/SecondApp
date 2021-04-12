using System;

class MainClass
{
	public static void Main(string[] args)
	{
		string MyName = "Bob";
		byte MyAge = 27;
		bool HaveIApet = true;
		float MyShoeSize = 37.5f;

		Console.WriteLine("My name is " + MyName);
		Console.WriteLine("MyAge " + MyAge);
		Console.WriteLine("Do I have a pet? " + HaveIApet);
		Console.WriteLine("My shoe size is " + MyShoeSize);

		//пример получения инфы о диапазоне значений от типа данных
		Console.WriteLine("byteMin {0} ", byte.MinValue);
		Console.WriteLine("byteMax {0} ", byte.MaxValue);
		Console.WriteLine("IntMin {0} ", int.MinValue);
		Console.WriteLine("IntMax {0} ", int.MaxValue);
		Console.WriteLine("floatMin {0} ", float.MinValue);
		Console.WriteLine("floatMax {0} ", float.MaxValue);
		Console.WriteLine("doubleMin {0} ", double.MinValue);
		Console.WriteLine("doubleMax {0} ", double.MaxValue);

		Console.ReadKey();
	}
}
