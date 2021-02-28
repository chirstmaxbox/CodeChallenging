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

		public static object TESTModule(object input)
		{
			object ret = input;
			switch (Type.GetTypeCode(input.GetType()))
			{
				case TypeCode.Int32:
					int iNumber = (int)input;
					switch (iNumber)
					{
						case 1:
						case 2:
						case 3:
						case 4:
							ret = iNumber * 2;
							break;
						case int n when (n < 1):
							throw new Exception("Value is smaller than 1");
						case int n when (n > 4):
							ret = iNumber * 3;
							break;
						default:
							break;
					}
					break;
				case TypeCode.Single:
					float fNumber = (float)input;
					switch (fNumber)
					{
						case float n when (n == 1.0f || n == 2.0f):
							ret = 3.0f;
							break;
						default:
							break;
					}
					break;

				case TypeCode.String:
					string s = (string)input;
					ret = s.ToUpper();
					break;

				default:
					break;

			}

			return ret;
		}

		static void Main(string[] args)
		{
			//Console.WriteLine("Value of NamesList");
			//Console.WriteLine(string.Join(Environment.NewLine, NamesList));
			Console.WriteLine(TESTModule('k'));
		}
	}
}
