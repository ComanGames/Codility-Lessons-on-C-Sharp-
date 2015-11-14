using System.Linq;
using Codiliyt_Training;
using NUnit.Framework;

namespace UnitTestsForCodility._1._Time_Complexity
{
	[TestFixture]
	public class TwoSliceTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		[Test]
		public void ExampleTest()
		{
			Assert.AreEqual(1, TwoSlice.Solution(new [] {4,2,2,5,1,8}));
		}
		//Two elements test
		//Array with all 0 test
		// Test with negative
		//  Example 2 with [5,10,-3,0,0,0] return 2;
		// Test with two slices [5,6,0,0,8,3,0,0,5,3] should return 2;
		// Enumerable rverse Enumerable(1,20).Reverse.ToArray() should return 18

		[Test]
		public void ReverseOrderTest()
		{
			Assert.AreEqual(18, TwoSlice.Solution(Enumerable.Range(1,20).Reverse().ToArray()));
		}

		[Test]
		public void TwoSliceExampleTest()
		{
			Assert.AreEqual(2, TwoSlice.Solution(new []{5,6,0,0,8,3,0,0,5,3}));
		}
		[Test]
		public void Example2Test()
		{
			Assert.AreEqual(2, TwoSlice.Solution(new []{5,10,-3,0,0,0}));
		}
		[Test]
		public void NegativeTest()
		{
			int[] A = new[] {3, 6, -5, 4, -8, 2, 5};
			Assert.AreEqual(2, TwoSlice.Solution(A));
		}
		[Test]
		public void ArraywithZeroTest()
		{
			Assert.AreEqual(0, TwoSlice.Solution(new int[10]));
		}
		[Test]
		public void TwoElementsTest()
		{
			Assert.AreEqual(0, TwoSlice.Solution(new [] {2,3}));
		}


		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 