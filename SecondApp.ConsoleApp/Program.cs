using System;

class MainClass
{	//создаём перечисление дней недели, явным образом задавая числа по порядку,
	//хотя по умолчанию у первого всегда 0 и последующие увеличиваются на 1
	enum Day_of_week : byte
	{
		sunday = 0,
		monday = 1,
		tuesday = 2,
		wednesday = 3,
		thursday = 4,
		friday = 5,
		saturday = 6
	}
	enum Semaphore : short
	{
		red = 100,
		yellow = 200,
		green = 300
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

		//имитация диалога с компутером
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
		int intdata = (int)bytdata;
		string strdata = intdata.ToString();
		Console.WriteLine(intdata);
		Console.WriteLine(strdata);

		//пример кода с преобразование целых строк в целые числа
		int int_age; //рабочая переменная для экспериментов с возрастом

		//вариант с конвертером Convert, может завершиться с ошибкой преобразования типов данных
		//если, например, попытаемся конвертировать строку (string) "77 лет" в целое число (int)
		Console.Write("Enter your age: ");
		int_age = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Your age is {0}.", int_age);

		//вариант с разобрателем Parse (от слова "разобраться")
		//сгенерить ошибку как и Convert в аналогичной ситуации
		Console.Write("Enter your age: ");
		int_age = int.Parse(Console.ReadLine());
		Console.WriteLine("Your age is {0}.", int_age);

		//вариант с безопасным разобрателем TryParse
		//если не нормально прошло, то останется прежнее значение int_age = 0
		bool is_norm; int_age = 0;
		Console.Write("Enter your age: ");
		is_norm = int.TryParse(Console.ReadLine(), out int_age);
		Console.WriteLine("Your age is {0}.", int_age);

		//ещё один диалог с компутером
		//проверка через checked конвертации int в byte (вдруг произошло "обрезание"?)
		//если не нормально прошло, то генирится ошибка, которую в последствии надо будет
		//обработать в обработчике ошибок (тут этого пока нет)
		Console.Write("Enter your name: ");
		string str_name = Console.ReadLine();
		Console.Write("Enter your age: ");
		byte byt_age = checked((byte)int.Parse(Console.ReadLine()));
		Console.WriteLine("Your name: {0}. Your age: {1}.", str_name, byt_age);

		//пример конвертации целого числа в перечисление (без проверки диапазона)
		Console.Write("Enter your favorite day of week: ");
		my_favorite_day = (Day_of_week)int.Parse(Console.ReadLine());
		Console.WriteLine("Your favorite day of week: {0}", my_favorite_day);

		//пример кода с var и неявной типизацией,
		//когда тип определяется присваиваемым значением при инициализации
		Console.Write("Enter your name: ");
		var var_name = Console.ReadLine();
		Console.Write("Enter your age: ");
		var var_age = int.Parse(Console.ReadLine());
		Console.WriteLine("Your name: {0}. Your age: {1}.", var_name, var_age);
		Console.Write("Enter your favorite day of week: ");
		var var_favor_day = (Day_of_week)int.Parse(Console.ReadLine());
		Console.WriteLine("Your favorite day of week: {0}", var_favor_day);


		//Финальная практика модуля: «Анкетируем пользователей» для ментора
		Console.Write("Enter your name: ");
		var name = Console.ReadLine();
		Console.Write("Enter your age: ");
		var age = int.Parse(Console.ReadLine());
		Console.WriteLine("Your name is {0} and age is {1}", name, age);
		Console.Write("Enter your birthdate: ");
		var birthdate = Console.ReadLine();
		Console.WriteLine("Your birthdate: {0}", birthdate);

		Console.ReadKey();
	}
}
