using System;
using System.Linq;
using static System.Math;

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

		public static long[] PrefixSum(int[] A)
		{
			if(A==null)
				throw new ArgumentNullException("Our array A is equal to null");
			long[]result=new long[A.Length+1];
			if (A.Length == 0)
				return result;
			for (int i = 1; i < result.Length; i++)
			{
				result[i] = result[i - 1] + A[i - 1];
				
			}
			return result;

		}

		public static long TotalOfSlice(long[] Prefix, uint x, uint y)
		{
			if(Prefix==null)
				throw new ArgumentNullException();
			if(x>y)
				throw new ArgumentOutOfRangeException("X are bigger then Y");
			if(y>=Prefix.Length)
				throw new ArgumentOutOfRangeException("Y is out of array border");
			return Prefix[y + 1] - Prefix[x];
		}

		public static long MashroomPicker(int[] A, ulong k, ulong m)
		{
			if(A==null)
				throw new ArgumentNullException();
			if((int)k>=A.Length)
				throw new ArgumentOutOfRangeException();
			ulong result = 0;
			long[] Prefix = PrefixSum(A);
			for (int i = 0; i < (int)Math.Min(m,k)+1; i++)
			{
				int leftPos = (int) k - i;
				int rightPos = Math.Min(A.Length - 1, Math.Max((int) k, (int) (k - m) - (2*i)));
				result = Math.Max(result,(ulong)TotalOfSlice(Prefix, (uint) leftPos, (uint) rightPos));
			}
			for (int i = 0; i < Math.Min((int)m,A.Length-(int)k); i++)
			{
				int rightPos = (int) k + i;
				int leftPos = Max(0, Min((int) k, (int) k - ((int)m - (2*i))));
				result = Max(result, (ulong) TotalOfSlice(Prefix, (uint) leftPos, (uint) rightPos));
			}
			return (long)result;
		}
		
	}
}