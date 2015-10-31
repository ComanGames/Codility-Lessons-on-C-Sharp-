using NUnit.Framework;

namespace Codiliyt_Training
{
	[TestFixture]
	public class MaxCounterTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		[Test]
		public void ExampleTest()
		{
			Assert.AreEqual(new [] {3,2,2,4,2}, MaxCounters.Solutin(5,new [] {3,4,4,6,1,4,4}));
		}
		//my test
		// N =1 , {1}				return {1}
		// N =3 , {1}				return {1,0,0}
		// N = 5, {11,11,11,11,11}	return {5,5,5,5,5}
		// N = 4, {1,2,3,4}			return {1,1,1,1}
		// N = 4, {3,4,1,2,2,3,1}	return {2,2,2,1}
		
		[Test]
		public void OneElementOneSizeTest()
		{
			Assert.AreEqual(new [] {1},MaxCounters.Solutin(1,new [] {1}));
		}

		[Test]
		public void OneElementThreeSizeTest()
		{
			Assert.AreEqual(new[] {1,0,0}, MaxCounters.Solutin(3,new [] {1}));
		}

		[Test]
		public void AllAreBiggerThanNTest()
		{
			Assert.AreEqual(new[] {5,5,5,5,5}, MaxCounters.Solutin(5,new [] {1,6,3,6,2,6,4,4,6,6}));
		}

		[Test]
		public void SequenceTest()
		{
			Assert.AreEqual(new []{1,1,1,1}, MaxCounters.Solutin(4,new []{1,2,3,4}));
		}

		[Test]
		public void RendomTest()
		{
			Assert.AreEqual(new [] {2,2,2,1}, MaxCounters.Solutin(4,new [] {3,4,1,2,2,3,1}));
		}
		// N = 4, {3,5,3,5,4,1,2,2,3,1}	return {4,4,3,3}
		[Test]
		public void SecondRendomTest()
		{
			Assert.AreEqual(new [] {4,4,3,3}, MaxCounters.Solutin(4,new [] {3,5,3,5,4,1,2,2,3,1}));
		}
		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 