using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Codiliyt_Training
{
	[TestFixture]
	public class MissingElementTest
	{

		[SetUp]
		public void SetUp()
		{
			//Setting up before every test 
		}

		[Test]
		public void ArgumentNullTest()
		{
			bool catchException = false;
			try
			{
				MissingElement.Solution(null);
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
		public void OutOfRangeTest()
		{
			bool catchException = false;
			try
			{
				MissingElement.Solution(new int[100001]);
			}
			catch (ArgumentOutOfRangeException)
			{
				catchException = true;
			}

			if (catchException)
				Assert.Pass();
			else
				Assert.Fail();

		}

		[Test]
		public void ElementOutOfRangeTest()
		{
			bool catchException = false;
			try
			{
				MissingElement.Solution(new []{1,4});
			}
			catch (ArgumentOutOfRangeException)
			{
				catchException = true;
			}

			if (catchException)
				Assert.Pass();
			else
				Assert.Fail();

			
		}
		// First elementi missing       2,5,4,3,6       1  
		// Lest element is missing      1,3,5,4,2       6
		// Array is sorted              1,2,3,5,6,7     4	
		[Test]
		public void FirstElemntTest()
		{
			Assert.AreEqual(1, MissingElement.Solution(new []{2,5,4,3,6}));
		}

		[Test]
		public void LastElementTest()
		{
			Assert.AreEqual(6, MissingElement.Solution(new [] {1,3,5,4,2}));
		}

		[Test]
		public void SortedArrayTest()
		{
			Assert.AreEqual(4, MissingElement.Solution(new []{1,2,3,5,6,7}));
		}
		// To big array                 public static IEnumerable<int> Range(1,100000).Remove(88555).ToArray();
		// Array of two elemens         1,3
		// Array of one element			1 
		// Array is empty               {}  1
		// Do not forget to convert into long
		[Test]
		public void ToBigTest()
		{
			int elemnt = 88555;
			List<int> list = Enumerable.Range(1, 100000).ToList();
			list.Remove(elemnt);
			int[] A = list.ToArray();
			Assert.AreEqual(elemnt, MissingElement.Solution(A));
		}

		[Test]
		public void TwoElementsTest()
		{
			Assert.AreEqual(2, MissingElement.Solution(new[] {1, 3}));
		}

		[Test]
		public void OneElementTest()
		{
			Assert.AreEqual(2, MissingElement.Solution(new[] {1}));
		}

		[Test]
		public void ZeroElementsTest()
		{
			Assert.AreEqual(1,MissingElement.Solution(new int[0]) );
		}
		[TearDown]
		public void TearDown()
		{
			//Setting up after every test 
		}


	}
} 