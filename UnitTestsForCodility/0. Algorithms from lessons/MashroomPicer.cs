using System;
using Codiliyt_Training;
using NUnit.Framework;

namespace UnitTestsForCodility._0._Algorithms_from_lessons
{
	[TestFixture]
	public class MashroomPicer
	{

		private int[] A;
		[SetUp]
		public void SetUp()
		{
			A = new[] {2, 3, 7, 5, 1, 3, 9};
		}

		[Test]
		public void NullArayExceptionTest()
		{
			bool catchException = false;
			try
			{
				AlgosFromCodility.MashroomPicker(null, 5, 10);
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
		// if we got k<0 or bigger then n K>=N
		[Test]
		public void WrongStartPositionTest()
		{
			bool catchException = false;
			try
			{
				AlgosFromCodility.MashroomPicker(new int[] {2, 3, 7, 5, 1, 3, 9}, 8, 10);
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

		//Example test		(A,4,6)		return 25
		//One step test		(A,6,1)		return 12
		//One step test		(A,6,0)		return 9
		//Two steps test	(A,4,2)		return 13
		//Two places to go	({2,3},0,10}return 5
		//One place to go	({5},0,10)	return 5
		[Test]
		public void ExampleTest()
		{
			Assert.AreEqual(25, AlgosFromCodility.MashroomPicker(A,4,6));
		}

		[Test]
		public void OneStepTest()
		{
			Assert.AreEqual(12, AlgosFromCodility.MashroomPicker(A,6,1));
		}

		[Test]
		public void ZeroStepsTest()
		{
			Assert.AreEqual(9, AlgosFromCodility.MashroomPicker(A,6,0));
		}

		[Test]
		public void TwoStepsTest()
		{
			Assert.AreEqual(13, AlgosFromCodility.MashroomPicker(A,4,2));
		}

		[Test]
		public void TwoPlaceTest()
		{
			Assert.AreEqual(5, AlgosFromCodility.MashroomPicker(new []{2,3},0,10));
		}

		[Test]
		public void OnePlaceTest()
		{
			Assert.AreEqual(5, AlgosFromCodility.MashroomPicker(new []{5},0,10));
		}

		[TearDown]
		public void TearDown()
		{
			A = null;
		}


	}
} 