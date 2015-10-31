using System;

namespace Codiliyt_Training
{
	public class MaxCounters
	{
		public static int[] Solutin(int N,int[]A)
		{
			int ToAdd = 0;
			int maxValue = 0;
			int [] result = new int[N];
			for (int i = 0; i < A.Length; i++)
			{
				int i1 = A[i]-1;
				if (i1 < N )
				{
					if (result[i1] < ToAdd)
						result[i1] = ToAdd + 1;
					else
						result[i1]++;
					if (result[i1] > maxValue)
						maxValue = result[i1];

				}
				//Making operation of max counter
				else if (i1 == N)
					ToAdd = maxValue;
			}
			for (int i = 0; i < result.Length; i++)
			{
				if (result[i] < ToAdd)
					result[i] = ToAdd;
			}
			return result;

		}
	}
}