using NUnit.Framework;
using System;
using FizzBuzz;

namespace Fizzbuzz.Tests
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void A_Number_Divisible_By_3_Should_Give_Fizz ()
		{
			FizzBuzzGenerator fz = new FizzBuzzGenerator ();
			string token = fz.GetToken (9);
			Assert.AreEqual ("Fizz", token);
		}

		[Test ()]
		public void A_Number_Divisible_By_5_Should_Give_buzz ()
		{
			FizzBuzzGenerator fz = new FizzBuzzGenerator ();
			string token = fz.GetToken (20);
			Assert.AreEqual ("Buzz", token);
		}

		[Test ()]
		public void A_Number_Not_Divisible_By_3_And_5_Should_Give_Number()
		{
			FizzBuzzGenerator fz = new FizzBuzzGenerator ();
			string token = fz.GetToken (17);
			Assert.AreEqual ("17", token);
		}

		[Test ()]
		public void A_Number_Is_Divisible_By_3_And_5_Should_Give_FizzBuzz()
		{
			FizzBuzzGenerator fz = new FizzBuzzGenerator ();
			string token = fz.GetToken (15);
			Assert.AreEqual ("FizzBuzz", token);
		}


		[Test ()]
		public void InputParser_Shoud_Parse_Valid_Input()
		{
			InputParser inputParser = new InputParser ();
			int token = inputParser.Parse ("9");
			Assert.AreEqual (9, token);
		}

		[Test ()]
		public void InputParser_Shoud_Handle_Invalid_Input()
		{
			InputParser inputParser = new InputParser ();
			int token = inputParser.Parse ("ABC");
			Assert.AreEqual (0, token);
		}

		[Test ()]
		public void Number_Should_Identify_If_Its_FizzBizz()
		{
			Assert.IsTrue(new Number(3).IsFizzBuzz());
			Assert.IsTrue(new Number(5).IsFizzBuzz());
			Assert.IsTrue(new Number(15).IsFizzBuzz());
			Assert.IsFalse(new Number(8).IsFizzBuzz());
		}

		[Test ()]
		public void Number_Should_Have_String_Representation()
		{
			Assert.AreEqual("3",new Number(3).ToString());
		}


	}
}

