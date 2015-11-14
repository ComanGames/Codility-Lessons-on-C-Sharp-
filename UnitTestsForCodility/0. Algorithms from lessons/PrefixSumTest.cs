using System;
using System.Linq;
using Codiliyt_Training;
using NUnit.Framework;

namespace UnitTestsForCodility._0._Algorithms_from_lessons
{
	[TestFixture]
	public class PrefixSumTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		[Test]
		public void NullArrayTest()
		{
			bool catchException = false;
			try
			{
				AlgosFromCodility.PrefixSum(null);
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

		//Example test		{1,2,3,4,5,6}	return {1,3,6,10,15,21}
		//Empty array test	{0,0,0,0,0}		return {0,0,0,0,0}
		//One elemtn test	{10}			return {10}
		//Two elements test {5,8}			return {5,13}
		//Empty array test	{}				return {}
		//Negative test		{-5,10,3}		return {-5,5,8}
		[Test]
		public void ExampleTest()
		{
			Assert.AreEqual(new long [] {0,1,3,6,10,15,21}, AlgosFromCodility.PrefixSum(Enumerable.Range(1,6).ToArray()));
		}

		[Test]
		public void EmptyArryTest()
		{
			Assert.AreEqual(new long[6], AlgosFromCodility.PrefixSum(new int[5]));
		}

		[Test]
		public void OneElementTest()
		{
			Assert.AreEqual(new long [] {0,10}, AlgosFromCodility.PrefixSum(new [] {10}));
		}

		[Test]
		public void TwoElementsTest()
		{
			int[] A = new[] {5, 8};
			Assert.AreEqual(new long[] {0,5,13}, AlgosFromCodility.PrefixSum(A));
		}

		[Test]
		public void EmptyArrayTest()
		{
			Assert.AreEqual(new long[1], AlgosFromCodility.PrefixSum(new int[0]));
		}

		[Test]
		public void NegativeArrayTest()
		{
			Assert.AreEqual(new long[] {0,-5,5,8}, AlgosFromCodility.PrefixSum(new int[] {-5,10,3}));
		}
		//Slice tests
		//Null array exception 
		// Y<X argument exception 
		// X>N or Y<N argument Out of Range Exception
		// X>=0 and Y>=0  argument out of range Exception
		//Example test		{1,2,3,4,5,6}	return {1,3,6,10,15,21} SliceOf(P,2,4) = 12
		//One Element test	{1,2,3,4,5,6}	return {1,3,6,10,15,21} SliceOf(P,3,3) = 4
		//Negative test		{-5,10,3}		return {0,-5,5,8}			SliceOf(P,0,1) = 5;
		[Test]
		public void SliceNullArrayTest()
		{
			bool catchException = false;
			try
			{
				AlgosFromCodility.TotalOfSlice(null, 1, 5);
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
		public void XBiggerThenYTest()
		{
			bool catchException = false;
			try
			{
				AlgosFromCodility.TotalOfSlice(new long[3], 2, 1);
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
		public void YBiggerThenArrayLengthTest()
		{

			bool catchException = false;
			try
			{
				AlgosFromCodility.TotalOfSlice(new long[3], 0, 5);
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
		public void ExampleSliceTest()
		{
			Assert.AreEqual(12, AlgosFromCodility.TotalOfSlice(new long[] { 0, 1, 3, 6, 10, 15, 21 },2,4));	
		}

		[Test]
		public void OneElementSliceTest()
		{
			Assert.AreEqual(4, AlgosFromCodility.TotalOfSlice(new long[] { 0, 1, 3, 6, 10, 15, 21 },3,3));
		}

		[Test]
		public void NegativeSliceTest()
		{
			Assert.AreEqual(5, AlgosFromCodility.TotalOfSlice(new long[] {0,-5,5,8},0,1 ));
		}
		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 