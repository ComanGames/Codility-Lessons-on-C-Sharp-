using System;

namespace Codiliyt_Training
{
	public class MaxProductOfTree
	{
		public static int Solution(int[] A)
		{
			Array.Sort(A);
			int x = 0;
			int y = A.Length - 1;
			for (int i = 0; i < A.Length; i++)
			{
				x = i;
				if (A[i] != int.MinValue)
					break;
			}
			for (int i = A.Length - 1; i >= 0; i--)
			{
				y = i;
				if (A[i] != int.MaxValue)
					break;
			}

			int result = A[y]*A[y - 1]*A[y - 2];
			if (A[x]*A[x + 1]*A[y] > result)
				result = A[x]*A[x + 1]*A[y];
			if (A[x] * A[y-1] * A[y] > result)
				result = A[x] * A[y-1] * A[y];
			if (A[x] * A[x+1] * A[x+2] > result)
				result = A[x] * A[x+1] * A[x+2];
			return result;
		}
	}
}