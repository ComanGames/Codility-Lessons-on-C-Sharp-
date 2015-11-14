using System.Linq;
using Codiliyt_Training;
using NUnit.Framework;

namespace UnitTestsForCodility._1._Time_Complexity
{
	[TestFixture]
	public class MaxProductOfTreeTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		[Test]
		public void ExampleTest()
		{
			Assert.AreEqual(60, MaxProductOfTree.Solution(new int[] {-3, 1, 2, -2, 5, 6}));
		}
		//Negative Numbers Test
		//Same Number test
		[Test]
		public void NegativeNubmmTest()
		{
			Assert.AreEqual(-6, MaxProductOfTree.Solution(new int[] {-6,-1,-5,-3,-2,-4}));
		}

		[Test]
		public void SmameNUmberTest()
		{
			Assert.AreEqual(6,MaxProductOfTree.Solution(Enumerable.Repeat(2,100).ToArray()));
		}

		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 