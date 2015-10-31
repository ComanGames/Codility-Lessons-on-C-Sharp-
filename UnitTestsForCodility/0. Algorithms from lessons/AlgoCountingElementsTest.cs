using System;
using System.Linq;
using NUnit.Framework;

namespace Codiliyt_Training
{
	[TestFixture]
	public class AlgoCountingElementsTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		//Empty array as parameter
		//Too big array
		//Array with all 0
		//Array with all possible elements
		[Test]
		public void ExampleTest()
		{
			int[] a = new[] {0, 0, 4, 2, 4, 5};
			//Throwing possible exceptions
			if (a == null) 
				throw new ArgumentNullException();
			if(a.Min()<0)
				throw new ArgumentOutOfRangeException();
			if(a.Length==0)
				throw new ArgumentException();

			//Looking for max value and create array
			int maxValue = a.Max();
			int[] result = new int[maxValue + 1];

			// And now the counting operation
			foreach (int i1 in a)
			{
				result[i1]++;
			}
			Assert.AreEqual(new[] {2, 0, 1, 0, 2, 1}, result);
			int[] a1 = new[] {5, 0, 2, 4, 0, 4};
			//Throwing possible exceptions
			if (a1 == null) 
				throw new ArgumentNullException();
			if(a1.Min()<0)
				throw new ArgumentOutOfRangeException();
			if(a1.Length==0)
				throw new ArgumentException();

			//Looking for max value and create array
			int maxValue1 = a1.Max();
			int[] result1 = new int[maxValue1 + 1];

			// And now the counting operation
			foreach (int i2 in a1)
			{
				result1[i2]++;
			}
			Assert.AreEqual(new[] {2, 0, 1, 0, 2, 1}, result1);
		}

		[Test]
		public void NullArrayTest()
		{
				Assert.Fail();
		}

		[Test]
		public void NegativeNumberExceptionTest()
		{
			bool catchException = false;
			try
			{
				int[] a = new[] {5, -5, 6};
				//Throwing possible exceptions
				if (a == null) 
					throw new ArgumentNullException();
				if(a.Min()<0)
					throw new ArgumentOutOfRangeException();
				if(a.Length==0)
					throw new ArgumentException();

				//Looking for max value and create array
				int maxValue = a.Max();
				int[] result = new int[maxValue + 1];

				// And now the counting operation
				foreach (int i1 in a)
				{
					result[i1]++;
				}
				int[] temp = result;
			}
			catch (ArgumentOutOfRangeException)
			{
				catchException = true;
			}

			if (catchException)
				Assert.Pass();
			else
				Assert.Fail();

		}

		[Test]
		public void LotOfZeroTest()
		{
			int[] a = new int[500];
			//Throwing possible exceptions
			int[] result = AlgosFromCodility.CountingPositiveElements(a);
			Assert.AreEqual(new int[] {500}, result);
		}

		[Test]
		public void ArrayWithSeparateTest()
		{
			int[] A = Enumerable.Range(0, 1000).ToArray();
			int[] resutl = new int[1000];
			for (int i = 0; i < resutl.Length; i++)
			{
				resutl[i]++;

			}
			//Throwing possible exceptions
			if (A == null) 
				throw new ArgumentNullException();
			if(A.Min()<0)
				throw new ArgumentOutOfRangeException();
			if(A.Length==0)
				throw new ArgumentException();

			//Looking for max value and create array
			int maxValue = A.Max();
			int[] result = new int[maxValue + 1];

			// And now the counting operation
			foreach (int i1 in A)
			{
				result[i1]++;
			}
			Assert.AreEqual(resutl, result);
		}

		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 