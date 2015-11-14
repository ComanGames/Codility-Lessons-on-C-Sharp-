using System.Linq;
using Codiliyt_Training;
using NUnit.Framework;

namespace UnitTestsForCodility._1._Time_Complexity
{
	[TestFixture]
	public class DistinctTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}
//		A[0] = 2    A[1] = 1    A[2] = 1
//		A[3] = 2    A[4] = 3    A[5] = 1
		[Test]
		public void ExampleTest()
		{
			Assert.AreEqual(3, Distinct.Solution(new []{2,1,1,2,3,1}));
		}

		[Test]
		public void AllZeroTest()
		{
			Assert.AreEqual(1, Distinct.Solution(new int[1000]));
		}

		[Test]
		public void EnumberableTest()
		{
			Assert.AreEqual(50, Distinct.Solution(Enumerable.Range(-25,50).ToArray()));
		}

		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 