﻿using System;
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
		Console.WriteLine((char)35);
		Console.ReadKey();
	}
}
