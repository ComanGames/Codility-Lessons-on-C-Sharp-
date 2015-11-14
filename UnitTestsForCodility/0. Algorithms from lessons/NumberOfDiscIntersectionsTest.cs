using System.Linq;
using Codiliyt_Training;
using NUnit.Framework;

namespace UnitTestsForCodility._0._Algorithms_from_lessons
{
	[TestFixture]
	public class NumberOfDiscIntersectionsTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}
		//3
		//3
		//2
		//2
		//1
		[Test]
		public void ExampleTest()
		{
			Assert.AreEqual(11, NumberOfDisc.Solution(new int[] {11,5,2,1,4,0}));
			
		}
		//5 Problems 
		//To much interection return -1 Enumerable Repeat.(int.MaxValue,100,000) 
		//Simple zero test {1,0,1,0} return 5
		// {0,1,2,3,4}		return 10
		// {1,1,1,1,1} return 4
		// {0,0,0,0}	return 0;
		[Test]
		public void AllZeroTest()
		{
			
			int[] A = new int[5];
			Assert.AreEqual(0, NumberOfDisc.Solution(A));
		}
		[Test]
		public void AllOneTest()
		{
			int[] A = new int[] {1,1,1,1,1};
			Assert.AreEqual(4, NumberOfDisc.Solution(A));
		}
		[Test]
		public void EnumeratorTest()
		{
			int[] A = new int[] {0,1,2,3,4};
			Assert.AreEqual(10, NumberOfDisc.Solution(A));
		}
		[Test]
		public void OverflowTestTest()
		{
			int[] A = Enumerable.Repeat(int.MaxValue, 100000).ToArray();
			Assert.AreEqual(-1, NumberOfDisc.Solution(A));
		}

		[Test]
		public void OneAndZeroTest()
		{
			
			int[] A = new int[] {1,0,1,0};
			Assert.AreEqual(5, NumberOfDisc.Solution(A));
		}

		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 