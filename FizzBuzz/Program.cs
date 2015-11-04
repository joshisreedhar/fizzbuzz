using System;

namespace FizzBuzz
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			FizzBuzzGenerator fizzbizz = new FizzBuzzGenerator ();
			InputParser parser = new InputParser ();
			for (int i = 1; i < 100; i++) {
				int value = parser.Parse (i.ToString ());
				Console.Write(fizzbizz.GetToken (value));
				Console.Write (", ");
			}
			Console.Read ();
		}
	}
}
