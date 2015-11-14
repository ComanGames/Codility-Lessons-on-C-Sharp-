using System;
using NUnit.Framework;

namespace Codiliyt_Training
{
	[TestFixture]
	public class FrogRiverOneTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		[Test]
		public void EmptyArrayTest()
		{
			bool catchException = false;
			try
			{
				FrogRiverOne.Solution(5, null);
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
		public void ArgumentOutOfRangeXTest()
		{
			bool catchException = false;
			try
			{
				FrogRiverOne.Solution(0, new int[5]);
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
		public void ArrayIsOutOfRangeTest()
		{
			bool catchException = false;
			try
			{
				FrogRiverOne.Solution(5, new int[100001]);
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
		//Example test X = 5 {1,3,1,4,2,5,4}	6
		//Straight test X = 3 {1,2,3,1,1,3,2}	2
		//Negative test x =3  {1,1,3,1,3}       -1
		//Oposite straight test X=3 {3,2,1,3,3,2}
		//ONe element test X=1 {1}				0;
		// We have not enough element X = 6 { 1,3,5,} 
		[Test]
		public void ExampleTest()
		{
			Assert.AreEqual(6, FrogRiverOne.Solution(5,new [] {1,3,1,4,2,3,5,4}));
		}

		[Test]
		public void StraightTest()
		{
			Assert.AreEqual(2, FrogRiverOne.Solution(3,new[] {1, 2, 3, 1, 1, 3, 2}));
		}

		[Test]
		public void NegativeTest()
		{
			Assert.AreEqual(-1, FrogRiverOne.Solution(3,new [] {1,1,3,1,3}));
		}

		[Test]
		public void OpositeTest()
		{
			Assert.AreEqual(2, FrogRiverOne.Solution(3,new[] {3,2,1, 1, 1, 3, 2}));
		}

		[Test]
		public void OneElementTest()
		{
			Assert.AreEqual(0, FrogRiverOne.Solution(1,new[] {1}));
		}

		[Test]
		public void NotEnoughElementsTest()
		{
			Assert.AreEqual(-1, FrogRiverOne.Solution(6,new [] {1,3,5}));
		}

		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 