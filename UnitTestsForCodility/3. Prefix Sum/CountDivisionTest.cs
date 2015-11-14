using Codiliyt_Training;
using NUnit.Framework;

namespace UnitTestsForCodility._1._Time_Complexity
{
	[TestFixture]
	public class CountDivisionTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		[Test]
		public void ExampleTest()
		{
			Assert.AreEqual(3, CountDiv.Solution(6, 11, 2));
		}

		//	7, 11, 2		reurn 2;
		//Start from 0 8 10 return 0;
		//Start from 0 8 2	return 4;
		//Start from 6 10 5	return 1;
		//Start from 4 10 1 return 6
		[Test]
		public void OtherExampeTest()
		{
			Assert.AreEqual(2, CountDiv.Solution(7,11,2));
		}

		[Test]
		public void FromZeroGotZeroTest()
		{
			Assert.AreEqual(1, CountDiv.Solution(0,8,10));
		}

		[Test]
		public void DevidingBy2Test()
		{
			Assert.AreEqual(5, CountDiv.Solution(0,8,2));
		}

		[Test]
		public void JustOneTest()
		{
			Assert.AreEqual(1, CountDiv.Solution(6,10,5));
		}

		[Test]
		public void DevidingByOneTest()
		{
			Assert.AreEqual(7, CountDiv.Solution(4,10,1));
		}

		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 