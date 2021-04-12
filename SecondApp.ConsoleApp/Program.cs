using System;
class MainClass
{
	public static void Main(string[] args)
	{
		const string СonstName = "Constantin";
		string МyName;
		МyName = "Alisa";

		Console.WriteLine(СonstName);
		Console.WriteLine(МyName);
		Console.WriteLine("\t Привет, мир!");
		Console.WriteLine("\t Мне много лет.");
		Console.WriteLine("\t My name is \n  {0}", МyName);
		Console.WriteLine('\u0023');//символ # в Hex-коде ASCII
		Console.WriteLine('\x0035');//символ # в Dec-коде ASCII
		Console.WriteLine((char)35);//преобразование Dec-кода ASCII символ #
		Console.ReadKey();
	}
}
