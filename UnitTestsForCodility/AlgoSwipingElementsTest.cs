using System;
using NUnit.Framework;

namespace Codiliyt_Training
{
	[TestFixture]
	public class AlgoSwipingElementsTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		[Test]
		public void ArrayAisNullTest()
		{
			bool catchException = false;
			try
			{
				AlgosFromCodility.SwapElements(null, new int[3]);
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
		public void ArrayBisNullTest()
		{
			bool catchException = false;
			try
			{
				AlgosFromCodility.SwapElements(new int[5], null);
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

		//Example test true
		//Example test false
		//Only negative test
		//Only positive test
		//One negative one positive test
		//Example true is A {5,0, -3 ,4}	 B{2,5,4,-1,0} = true
		//						5				10
		//Example false is A {4,0, -3 ,4}	B{2,5,4,-1,0} = true
		//						8				5
		//false				A is {5,3}		B{3,1,1} 
		//						-8				-6
		//true				A is {-5,-3}	B{-2,-1,-3}
		//						-5				3	
		//true				{-10,4,-1,2}	{-8,5,2,4,-6,6}
		[Test]
		public void OnePositiveOneNegativeTest()
		{
			Assert.AreEqual(true, AlgosFromCodility.SwapElements(new []{-10,4,-1,2},new []{-8,5,2,4,-6,6}));
		}
		[Test]
		public void OnlyNegativeTest()
		{
			Assert.AreEqual(true, AlgosFromCodility.SwapElements(new []{-5,-3},new []{-2,-1,-3}));
		}
		[Test]
		public void OnlyPositivTest()
		{
			Assert.AreEqual(false, AlgosFromCodility.SwapElements(new []{5,3},new []{3,1,1}));
		}

		[Test]
		public void ExampleTrueTest()
		{
			Assert.AreEqual(true, AlgosFromCodility.SwapElements(new [] {5,0,-3,4},new [] {2,5,4,-1,0}));
		}

		[Test]
		public void ExampleFalseTest()
		{
			Assert.AreEqual(false, AlgosFromCodility.SwapElements(new [] {4,0,-3,4},new [] {2,5,4,-1,0}));
		}
		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 