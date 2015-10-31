using System;

namespace Codiliyt_Training
{
	public class MissingElement
	{

		public static int solution(int[]A)
		{
			if(A==null)
				throw new ArgumentNullException();
			if(A.Length>100000)
				throw new ArgumentOutOfRangeException();
			for (int i = 0; i < A.Length; i++)
			{
				int i1 = A[i];
				if(i1>A.Length+1)
					throw new ArgumentOutOfRangeException();
			}
			long sum = ((long) A.Length + 2)*((long) A.Length + 1)/2;
			for (int i = 0; i < A.Length; i++)
			{
				int i1 = A[i];
				sum -= i1;
			}

			return (int) sum;

		}
	}
}