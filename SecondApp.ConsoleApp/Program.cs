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
		Console.WriteLine();

		//Вариант вывода интерполяцией (способ так называется, когда добавляют $ перед строкой,
		//а переменные заключают в {}
		Console.WriteLine($"My name is {MyName}");
		Console.WriteLine($"MyAge {MyAge}");
		Console.WriteLine($"Do I have a pet? {HaveIApet}");
		Console.WriteLine($"My shoe size is {MyShoeSize}");
		Console.WriteLine();

		//Вариант вывода когда зарезервированы места для переменных,
		//а переменные указвают потом, перечисляя через запятую
		Console.WriteLine("My name is {0}\nMyAge {1}", MyName, MyAge);
		Console.WriteLine("Do I have a pet? {0}", HaveIApet);
		Console.WriteLine("My shoe size is {0}", MyShoeSize);
		Console.WriteLine();

		//пример получения инфы о диапазоне значений от типа данных
		Console.WriteLine("byteMin {0} ", byte.MinValue);
		Console.WriteLine("byteMax {0} ", byte.MaxValue);
		Console.WriteLine("IntMin {0} ", int.MinValue);
		Console.WriteLine("IntMax {0} ", int.MaxValue);
		Console.WriteLine("floatMin {0} ", float.MinValue);
		Console.WriteLine("floatMax {0} ", float.MaxValue);
		Console.WriteLine("doubleMin {0} ", double.MinValue);
		Console.WriteLine("doubleMax {0} ", double.MaxValue);
		Console.WriteLine();

		//пример использования перечислений
		Day_of_week my_favorite_day;
		my_favorite_day = Day_of_week.friday;
		Console.WriteLine(my_favorite_day);

		//имитация диалого с компутером
		string CompName = "Computer";
		Console.WriteLine("\t Привет,\n мир!");
		Console.WriteLine("Привет, человек!");
		Console.WriteLine("Меня зовут {0}.", CompName);
		Console.Write("А как тебя зовут? ");
		MyName = Console.ReadLine();
		Console.WriteLine("Рад встрече, {0}!", MyName);

		//Выражения с оперециями умножения, деления и целочисленного деления
		double result = 5d / 2d * 3d;
		Console.WriteLine("Результат 5 / 2 * 3 = {0}", result);
		result = 10 % 3;
		Console.WriteLine("Результат 10 % 3 = {0}", result);

		//пример кода явного преобразования типов, и преобразования в строки
		byte bytdata = 6;
		int intdata = (int) bytdata;
		string strdata = intdata.ToString();
		Console.WriteLine(intdata);
		Console.WriteLine(strdata);

		Console.ReadKey();
	}
}
