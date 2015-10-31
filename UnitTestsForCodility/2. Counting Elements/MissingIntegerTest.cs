using System.Linq;
using NUnit.Framework;

namespace Codiliyt_Training
{
	[TestFixture]
	public class MissingIntegerTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		[Test]
		public void ExampleTest()
		{
			Assert.AreEqual(5, MissingInteger.Solution(new []{1,3,6,4,1,3,2}));
		}

		[Test]
		public void SequenceofElementsTest()
		{
			Assert.AreEqual(6, MissingInteger.Solution(Enumerable.Range(1, 5).ToArray()));
		}

		[Test]
		public void OneIsMissingTestTest()
		{
			Assert.AreEqual(1, MissingInteger.Solution(Enumerable.Range(2, 10).ToArray()));
		}

		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 