using System;
using System.Collections.Generic;

namespace ConsoleProject
{
	class QuestionClass
	{
		static List<string> NamesList = new List<string>()
		{
			"Jimmy",
			"Jeffrey",
			"John",
		};

		static void Main(string[] args)
		{
			Console.WriteLine("Value of NamesList");
			Console.WriteLine(string.Join(Environment.NewLine, NamesList));
		}
	}
}
