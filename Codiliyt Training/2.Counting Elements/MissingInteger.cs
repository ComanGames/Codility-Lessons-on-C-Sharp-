using System;
using System.Linq;
using System.Text;

namespace Codiliyt_Training
{
	public class MissingInteger
	{
		public static int Solution(int[]A)
		{
			//Throwing possible exceptions
			if (A == null) 
				throw new ArgumentNullException();
			if(A.Length==0)
				throw new ArgumentException();
			int[] P;
			int maxValue = A.Max();
			if (maxValue < 1)
				return 1;
			int minPositiveValue = maxValue;
			for (int i = 0; i < A.Length; i++)
			{
				int i1 = A[i];
				if (i1 > 0 && i1 < minPositiveValue)
					minPositiveValue = i1;
			}
			if (minPositiveValue > 1)
				return minPositiveValue - 1;

			//Creating those arrays
			if (maxValue < 0)
				P = null;
			else 
				P = new int[maxValue + 1];

			foreach (int i1 in A)
			{
				if (i1 >= 0)
				{
					if (P != null) P[i1]++;
				}
			}
			for (int i = 1; i < P.Length; i++)
			{
				int i1 = P[i];
				if (i1 == 0)
					return i;
			}
			return P.Length;
		}
		 
	}
}