using System;

namespace Codiliyt_Training
{
	public class Distinct
	{
		public static int Solution(int[] A)
		{
			Array.Sort(A);
			if (A.Length == 0)
				return 0;
			if (A.Length == 1)
				return 1;
			int value = 0;
			int result = 0;
			value = A[0];
			result++;
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] != value)
				{
					value = A[i];
					result++;
				}
			}
			return result;
		} 
	}
}