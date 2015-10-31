using System;
using System.Linq;
using NUnit.Framework;

namespace Codiliyt_Training
{
	[TestFixture]
	public class AlgoCountingNegativeElementsTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		//Null array
		// NO positive elements
		// No negative elements
		// Array with all 0
		// Array with all possible elements

		[Test]
		public void NullArgumentExceptionTest()
		{
			bool catchException = false;
			try
			{

				int[] A, B;
				//Throwing possible exceptions
				if (null == null) 
					throw new ArgumentNullException();
				if(((int[]) null).Length==0)
					throw new ArgumentException();

				int maxValue = ((int[]) null).Max();
				int minValue = ((int[]) null).Min();

				//Creating those arrays
				if (maxValue < 0)
					A = null;
				else 
					A = new int[maxValue + 1];

				if (minValue >= 0)
					B = null;
				else 
					B = new int[minValue*-1];

			}
			catch (ArgumentNullException)
			{
				catchException = true;
			}

			if (catchException)
				Assert.Pass();
			else
				Assert.Fail();

		}

		//Example:
		// {0,-5,3,3,-3,8,6,-1}
		// Positive {1,0,0,2,0,5,1,0,1}
		// Negative {1,0,1,0,5}
		[Test]
		public void ExampleTest()
		{

			int[] A = new[] {1, 0, 0, 2, 0, 0, 1, 0, 1};
			int[] B = new[] {1, 0, 1, 0, 1};
			int[] A1, B1;
			int[] a = new int [] {0, -5, 3, 3, -3, 8, 6, -1};
			//Throwing possible exceptions
			if (a == null) 
				throw new ArgumentNullException();
			if(a.Length==0)
				throw new ArgumentException();

			int maxValue = a.Max();
			int minValue = a.Min();

			//Creating those arrays
			if (maxValue < 0)
				A1 = null;
			else 
				A1 = new int[maxValue + 1];

			if (minValue >= 0)
				B1 = null;
			else 
				B1 = new int[minValue*-1];

			foreach (int i1 in a)
			{
				if (i1 >= 0)
				{
					if (A1 != null) A1[i1]++;
				}
				else if (B1 != null) B1[(i1*-1) - 1]++;
			}
			Assert.AreEqual(A, A1);
			Assert.AreEqual(B, B1);

		}

		[Test]
		public void ExampleNegativeTestTest()
		{
			
			int[] A = null;
			int[] B = new[] {1, 0, 1, 0, 1};
			int[] A1, B1;
			int[] a = new int [] { -5, -3, -1};
			//Throwing possible exceptions
			if (a == null) 
				throw new ArgumentNullException();
			if(a.Length==0)
				throw new ArgumentException();

			int maxValue = a.Max();
			int minValue = a.Min();

			//Creating those arrays
			if (maxValue < 0)
				A1 = null;
			else 
				A1 = new int[maxValue + 1];

			if (minValue >= 0)
				B1 = null;
			else 
				B1 = new int[minValue*-1];

			foreach (int i1 in a)
			{
				if (i1 >= 0)
				{
					if (A1 != null) A1[i1]++;
				}
				else if (B1 != null) B1[(i1*-1) - 1]++;
			}
			Assert.AreEqual(A, A1);
			Assert.AreEqual(B, B1);
		}

		[Test]
		public void ExamplePositiveTest()
		{
			
			int[] A = new[] {1, 0, 0, 2, 0, 0, 1, 0, 1};
			int[] B = null;
			int[] A1, B1;
			int[] a = new int [] {0, 3, 3,  8, 6};
			//Throwing possible exceptions
			if (a == null) 
				throw new ArgumentNullException();
			if(a.Length==0)
				throw new ArgumentException();

			int maxValue = a.Max();
			int minValue = a.Min();

			//Creating those arrays
			if (maxValue < 0)
				A1 = null;
			else 
				A1 = new int[maxValue + 1];

			if (minValue >= 0)
				B1 = null;
			else 
				B1 = new int[minValue*-1];

			foreach (int i1 in a)
			{
				if (i1 >= 0)
				{
					if (A1 != null) A1[i1]++;
				}
				else if (B1 != null) B1[(i1*-1) - 1]++;
			}
			Assert.AreEqual(A, A1);
			Assert.AreEqual(B, B1);
		}

		[Test]
		public void ArrayWithAllZeroTest()
		{
			int[] A, B;
			int[] a = new int[50];
			//Throwing possible exceptions
			AlgosFromCodility.CountingNegativePositiveElements(a,out A, out B);
			Assert.AreEqual(new [] {50}, A);
			Assert.AreEqual(null, B);
		}

		[Test]
		public void ArrayWithSequenceOfElementsTest()
		{
			int[] test = Enumerable.Range(-10, 21).ToArray();
			int[] A, B;
			//Throwing possible exceptions
			if (test == null) 
				throw new ArgumentNullException();
			if(test.Length==0)
				throw new ArgumentException();

			int maxValue = test.Max();
			int minValue = test.Min();

			//Creating those arrays
			if (maxValue < 0)
				A = null;
			else 
				A = new int[maxValue + 1];

			if (minValue >= 0)
				B = null;
			else 
				B = new int[minValue*-1];

			foreach (int i1 in test)
			{
				if (i1 >= 0)
				{
					if (A != null) A[i1]++;
				}
				else if (B != null) B[(i1*-1) - 1]++;
			}
			int[] A1 = Enumerable.Repeat(1, 11).ToArray();
			int[] B1 = Enumerable.Repeat(1, 10).ToArray();

			Assert.AreEqual(A1, A);
			Assert.AreEqual(B1, B);
		}

		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 