using System;

class MainClass
{
	//создаём перечисление дней недели, явным образом задавая числа по порядку,
	//хотя по умолчанию у первого всегда 0 и последующие увеличиваются на 1
	enum Day_of_week : byte
	{
		sunday		= 0,
		monday		= 1,
		tuesday		= 2,
		wednesday	= 3,
		thursday		= 4,
		friday		= 5,
		saturday		= 6
	}
	enum Semaphore : short
	{
		red		= 100, 
		yellow	= 200, 
		green		= 300
	}
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

		//Вариант вывода интерполяцией (способ так называется, когда добавляют $ перед строкой,
		//а переменные заключают в {}
		Console.WriteLine($"My name is {MyName}");
		Console.WriteLine($"MyAge {MyAge}");
		Console.WriteLine($"Do I have a pet? {HaveIApet}");
		Console.WriteLine($"My shoe size is {MyShoeSize}");

		//Вариант вывода когда зарезервированы места для переменных,
		//а переменные указвают потом, перечисляя через запятую
		Console.WriteLine("My name is {0}\nMyAge {1}", MyName, MyAge);
		Console.WriteLine("Do I have a pet? {0}", HaveIApet);
		Console.WriteLine("My shoe size is {0}", MyShoeSize);

		//пример получения инфы о диапазоне значений от типа данных
		Console.WriteLine("byteMin {0} ", byte.MinValue);
		Console.WriteLine("byteMax {0} ", byte.MaxValue);
		Console.WriteLine("IntMin {0} ", int.MinValue);
		Console.WriteLine("IntMax {0} ", int.MaxValue);
		Console.WriteLine("floatMin {0} ", float.MinValue);
		Console.WriteLine("floatMax {0} ", float.MaxValue);
		Console.WriteLine("doubleMin {0} ", double.MinValue);
		Console.WriteLine("doubleMax {0} ", double.MaxValue);

		//пример использования перечислений
		Day_of_week my_favorite_day;
		my_favorite_day = Day_of_week.friday;
		Console.WriteLine(my_favorite_day);

		Console.WriteLine("\t Привет,\n мир!");

		Console.ReadKey();
	}
}
