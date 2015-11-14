using System;
using System.Linq;

namespace Codiliyt_Training
{
	public class FrogRiverOne
	{


		/// <summary>
		/// Task was find in what moment of time
		/// The frog will be able to get to other side
		/// So we looking is frog able to get to other side at all
		/// Then we getting array with moments when frog can get to 
		/// other side and then we saving moments in reverse order
		/// So max moment will be the moment when frog can get to other side
		/// </summary>
		/// <param name="X"></param>
		/// <param name="A"></param>
		/// <returns></returns>
		public static int Solution(int X, int[] A)
		{
			if(A==null)
				throw new ArgumentNullException();
			if(A.Length<1||A.Length>100000||X<1||X>100000)
				throw new ArgumentOutOfRangeException();
			if(A.Max()>X)
				throw new ArgumentOutOfRangeException();
			//Throwing possible exceptions
			if (A == null) 
				throw new ArgumentNullException();
			if(A.Min()<0)
				throw new ArgumentOutOfRangeException();
			if(A.Length==0)
				throw new ArgumentException();

			//Looking for max value and create array
			int maxValue = A.Max();
			int[] result1 = new int[maxValue + 1];

			// And now the counting operation
			foreach (int i2 in A)
			{
				result1[i2]++;
			}
			int[] Positive = result1;
			for (int i = 1; i < Positive.Length; i++)
			{
				int i1 = Positive[i];
				if (i1 == 0)
					return -1;
			}
			int[] steps = new int[X+1];
			for (int i = A.Length - 1; i >= 0; i--)
			{
				steps[A[i] ] = i;
			}

			int result = steps.Max();
			return result;
		}
	}
}