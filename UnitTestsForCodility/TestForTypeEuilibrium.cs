using System;
using NUnit.Framework;

namespace Codiliyt_Training
{
	[TestFixture]
	public class TestForTypeEuilibrium
	{

		private int[] A;
		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		[Test]
		public void OutOfRangeTest()
		{
			bool catchException = false;
			try
			{
				TypeOfEqulibrium.solution(new int[] {1});
			}
			catch (ArgumentOutOfRangeException exception)
			{
				catchException = true;
			}
			if (catchException)
				Assert.Pass();
			else
				Assert.Fail();
		}

		[Test]
		public void OutofRange2Test()
		{
			bool catchException = false;
			try
			{
				TypeOfEqulibrium.solution(new int[100001]);
			}
			catch (ArgumentOutOfRangeException exception)
			{
				catchException = true;
			}

			if (catchException)
				Assert.Pass();
			else
				Assert.Fail();
	
		}

		[Test]
		public void ElementOutOfRangeTest()
		{
			bool catchException = false;
			try
			{
				TypeOfEqulibrium.solution(new int[] {5, 6, 8, 1001, -1001});
			}
			catch (ArgumentOutOfRangeException exception)
			{
				catchException = true;
			}

			if (catchException)
				Assert.Pass();
			else
				Assert.Fail();
		
		}

		[Test]
		public void NameOfTest()
		{
			bool catchException = false;
			try
			{
				TypeOfEqulibrium.solution(null);
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
		[Test]
		public void ExampleTest()
		{
			Assert.AreEqual(1, TypeOfEqulibrium.solution(new int[] { 3,1,2,4,3}));
		}

		[Test]
		public void EmptyArrayTest()
		{
			Assert.AreEqual(0, TypeOfEqulibrium.solution(new int[4]));
		}


		[Test]
		public void TwoElementTest()
		{
			Assert.AreEqual(2, TypeOfEqulibrium.solution(new int[] {3, 5})); 
		}
		[TearDown]
		public void TearDown()
		{
			A = null;
		}


	}
} 