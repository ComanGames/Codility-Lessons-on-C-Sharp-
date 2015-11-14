using System;

namespace Codiliyt_Training
{
	public class PassingCars
	{
		public static int Solution(int[] A)
		{
			ulong count = 0;
			ulong add = 0;
			if (A.Length == 0)
				return 0;
			for (int i = 0; i < A.Length; i++)
			{
				if (count > 1000000000)
					return -1;
					if (A[i] == 0)
						add++;
					else
						count += add;
			}
			return (int)count;

		}

	}
}