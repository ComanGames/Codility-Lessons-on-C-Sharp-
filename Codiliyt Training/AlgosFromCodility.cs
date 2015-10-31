using System;
using System.Linq;
using System.Security.Cryptography;

namespace Codiliyt_Training
{
	public static class AlgosFromCodility
	{
		/// <summary>
		///	Algorithms that return true if we have opportunity
		/// to change one element from array A to one element
		/// from Array B to have them equluals . Or false
		/// If it is impossible to made such operation
		/// </summary>
		/// <param name="a"> Array A</param>
		/// <param name="b"> Array B</param>
		/// <returns>IsPossibleToSwipeToElements</returns>
		public static bool SwapElements(int[]a,int[]b)
		{
			if (a == null || b == null)
				throw new ArgumentNullException();
			long SumA = a.Sum(i=>(long)i);
			long SumB = b.Sum(i=>(long)i);
			long difrance = SumB-SumA;
			if (Math.Abs(difrance)%2 == 1)
				return false;
			difrance /= 2;
			int[] Positive, Negative;
			//Throwing possible exceptions
			if (a == null) 
				throw new ArgumentNullException();
			if(a.Length==0)
				throw new ArgumentException();

			int maxValue = a.Max();
			int minValue = a.Min();

			//Creating those arrays
			if (maxValue < 0)
				Positive = null;
			else 
				Positive = new int[maxValue + 1];

			if (minValue >= 0)
				Negative = null;
			else 
				Negative = new int[minValue*-1];

			foreach (int i1 in a)
			{
				if (i1 >= 0)
				{
					if (Positive != null) Positive[i1]++;
				}
				else if (Negative != null) Negative[(i1*-1) - 1]++;
			}
			foreach (int i in b)
			{
				if ( i - difrance>=0 && Positive != null &&i - difrance < Positive.Length && Positive[i - difrance] > 0)
					return true;
				else if (i - difrance < 0 && Negative != null && ((i - difrance)*-1) <= Negative.Length && Negative[((i - difrance)*-1) - 1] > 0)
					return true;
			}
			return false;
		}

		public static int[] CountingPositiveElements(int[] a)
		{
			if (a == null)
				throw new ArgumentNullException();
			if (a.Min() < 0)
				throw new ArgumentOutOfRangeException();
			if (a.Length == 0)
				throw new ArgumentException();

			//Looking for max value and create array
			int maxValue = a.Max();
			int[] result = new int[maxValue + 1];

			// And now the counting operation
			foreach (int i1 in a)
				result[i1]++;
			return result;
		}

		public static void CountingNegativePositiveElements(int[] a,out int[]Positive, out int[] Negative)
		{
			if (a == null)
				throw new ArgumentNullException();
			if (a.Length == 0)
				throw new ArgumentException();

			int maxValue = a.Max();
			int minValue = a.Min();

			//Creating those arrays
			if (maxValue < 0)
				Positive = null;
			else
				Positive = new int[maxValue + 1];

			if (minValue >= 0)
				Negative = null;
			else
				Negative = new int[minValue*-1];

			foreach (int i1 in a)
			{
				if (i1 >= 0)
				{
					if (Positive != null) Positive[i1]++;
				}
				else if (Negative != null) Negative[(i1*-1) - 1]++;
			}
		}
	}
}