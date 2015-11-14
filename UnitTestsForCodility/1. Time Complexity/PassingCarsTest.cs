using System.Linq;
using Codiliyt_Training;
using NUnit.Framework;

namespace UnitTestsForCodility._1._Time_Complexity
{
	[TestFixture]
	public class PassingCarsTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		[Test]
		public void ExampleTest()
		{
			Assert.AreEqual(5, PassingCars.Solution(new int[] {0,1,0,1,1}));
		}

		//The same as example but starts from 1 so revers 
		//Just two cars {0,1}		reurn 1;
		//Just one car {1}			return 0;
		//One direction {1,1,1,1,1,1}return 0;
		//OneDirection0 {0,0,0,0,0} return 0;
		//One car with {1,0,0,0,0,0} return 5;
		//one  car in mid{0,0,1,0,0} return 2;
		//two much cars new int[1500000] A[0]=1		return -1;
		[Test]
		public void ExtremeTest()
		{
			
			int[]A = new int[1500000];
			A[999999] = 1;
			Assert.AreEqual(500000, PassingCars.Solution(A));
		}
		[Test]
		public void TwoMuchTest()
		{
			int[]A = new int[1500000];
			A[0] = 1;
			Assert.AreEqual(-1, PassingCars.Solution(A));
		}
		[Test]
		public void OneCarSouthTest()
		{
			int[]A = new int[6];
			A[0] = 1;
			Assert.AreEqual(5, PassingCars.Solution(A));
		}

		[Test]
		public void OneCarMiddleTest()
		{
			int[]A = new int[5];
			A[2] = 1;
			Assert.AreEqual(2, PassingCars.Solution(A));
			
		}
		[Test]
		public void EmptyArrayTest()
		{
			Assert.AreEqual(0, PassingCars.Solution(new int[0]));
		}
		[Test]
		public void ExampleReversTest()
		{
			Assert.AreEqual(5, PassingCars.Solution(new [] {1,0,1,0,0}));
		}

		[Test]
		public void ReverseCarsTest()
		{
			Assert.AreEqual(5, PassingCars.Solution(new [] {0,1,0,1,1}));
		}

		[Test]
		public void TwoCarsTest()
		{
			Assert.AreEqual(1, PassingCars.Solution(new [] {0,1}));
		}

		[Test]
		public void OneDirectionTest()
		{
			Assert.AreEqual(0, PassingCars.Solution(Enumerable.Repeat(1,5).ToArray()));
		}

		[Test]
		public void OneDirectionReverseTest()
		{
			Assert.AreEqual(0, PassingCars.Solution(new int[5]));
		}

		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 