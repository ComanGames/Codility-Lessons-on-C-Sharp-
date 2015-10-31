using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Codiliyt_Training
{
	[TestFixture]
	public class PermCheckTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		[Test]
		public void ArrayIsNulTest()
		{
			bool catchException = false;
			try
			{
				PermCheck.Solution(null);
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
		public void ArrayOutOfRangeTest()
		{
			bool catchException = false;
			try
			{
				PermCheck.Solution(new int[100001]);
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

		//Example positive result test {4,1,3,2,}	return 1;
		//Example negative result test {4,1,3}		return 0;
		//Example positive result test Enumerable.Range(1,100000) return 1;
		//Example positive result test Enumerable.Range(1,100000) return 1;
		//Example negative result test Enumerable.Range(1,100000).Remove(85635) return 0;
		//One element test {1} test return 1;
		//all big numbers test Enumberable.Repeat(1000, 1000); return 0;
		//all small numbers Enumerable.Repeat(1,10)		return 0;
		// A lot of big elemnts Enumerable.Range(int.MaxValue-200,100)	reuturn 1;
		[Test]
		public void ExamplePositiveTest()
		{
			Assert.AreEqual(1, PermCheck.Solution(new []{4,1,3,2}));
		}

		[Test]
		public void ExampleNegativeTest()
		{
			Assert.AreEqual(0, PermCheck.Solution(new []{4,1,3}));
		}

		[Test]
		public void LongSequencePositiveTest()
		{
			List<int> A = Enumerable.Range(1, 100000).ToList();
			Assert.AreEqual(1, PermCheck.Solution(A.ToArray()));
		}
		[Test]
		public void LongSequencePositiveReverseTest()
		{
			List<int> A = Enumerable.Range(1, 100000).ToList();
			A.Reverse();
			Assert.AreEqual(1, PermCheck.Solution(A.ToArray()));
		}

		[Test]
		public void LongSequenceNegativeTest()
		{
			
			List<int> A = Enumerable.Range(1, 100000).ToList();
			A.Remove(85635);
			Assert.AreEqual(0, PermCheck.Solution(A.ToArray()));
		}
		[Test]
		public void LongSequenceNegativeReverseTest()
		{
			
			List<int> A = Enumerable.Range(1, 100000).ToList();
			A.Remove(85635);
			A.Reverse();
			Assert.AreEqual(0, PermCheck.Solution(A.ToArray()));
		}

		[Test]
		public void OneElementTest()
		{
			Assert.AreEqual(1, PermCheck.Solution(new[] { 1 }));
		}
		[Test]
		public void OneElementNegativeTest()
		{
			Assert.AreEqual(0, PermCheck.Solution(new[] { 4 }));
		}
		[Test]
		public void TwoElementNegativeTest()
		{
			Assert.AreEqual(0, PermCheck.Solution(new[] { 5,8 }));
		}
		[Test]
		public void TwoElementPositiveTest()
		{
			Assert.AreEqual(1, PermCheck.Solution(new[] { 5,6 }));
		}

		[Test]
		public void RepeatBigNumberTest()
		{
			Assert.AreEqual(0, PermCheck.Solution(Enumerable.Repeat(50, 25).ToArray()));
		}

		[Test]
		public void RepeatSmallNumberTest()
		{
			Assert.AreEqual(0, PermCheck.Solution(Enumerable.Repeat(1, 10).ToArray()));
		}

		[Test]
		public void BigNumbersTest()
		{
			Assert.AreEqual(1, PermCheck.Solution(Enumerable.Range(999999000,100).ToArray()));
		}

		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 