using System.Linq;
using Codiliyt_Training;
using NUnit.Framework;

namespace UnitTestsForCodility._1._Time_Complexity
{
	[TestFixture]
	public class TriangleTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

//	A[0] = 10    A[1] = 2    A[2] = 5
//  A[3] = 1     A[4] = 8    A[5] = 20
//the function should return 1, as explained above.Given array A such that:
//
//  A[0] = 10    A[1] = 50    A[2] = 5
//  A[3] = 1
//the function should return 0.
//
        [Test]
		public void ExampleTest()
		{
	        Assert.AreEqual(1, Triangle.Solution(new [] {10,2,5,1,8,20}));
		}

		[Test]
		public void OtherExampleTest()
		{
			Assert.AreEqual(0, Triangle.Solution(new [] {10,50,5,1}));
		}
		// All zero array should return 0
		// Array when you got 0 ,1,1 should return 0
		// Array when you got 1,1,1 should return 1;
		// Array when you got just 2 positive number should return 0;
		// Negative array should return 0;
		// if  you got array length<3 should return 0;
		[Test]
		public void AllZeroTest()
		{
			Assert.AreEqual(1, new int[100]);
		}
		[Test]
		public void SomeTest()
		{
			Assert.AreEqual(0, Triangle.Solution(new []{0,1,0,0,0,0,1}));
		}
		[Test]
		public void TreeOneTest()
		{
			Assert.AreEqual(1, Triangle.Solution(new []{-5,15,8,-4,9,1,0,1,5555,1}));
		}
		[Test]
		public void JustTwoPositveTest()
		{
			Assert.AreEqual(0, Triangle.Solution(new int[] {-5,-2,-6,-1,0,3,-5,-4,2}));
		}
		[Test]
		public void NegativeArrayTest()
		{
			Assert.AreEqual(0, Triangle.Solution(Enumerable.Range(-50,40).ToArray()));
		}
		[Test]
		public void ArrayLengthSamllerthen3Test()
		{
			Assert.AreEqual(0, Triangle.Solution(new int[2]));
		}


		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 