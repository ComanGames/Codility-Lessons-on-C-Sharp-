using System;
using System.Net.NetworkInformation;

namespace Codiliyt_Training
{
	public class TwoSlice
	{
		public static int Solution(int[] A)
		{
			long[] Prefix = AlgosFromCodility.PrefixSum(A);
			long min = long.MaxValue;
			int index;
			//Looking for 
			int x=0, y=0;
			for (int i = A.Length - 1; i >= 1; i--)
			{
				long sliceCount = AlgosFromCodility.TotalOfSlice(Prefix, (uint) i - 1, (uint) i);
				if (sliceCount <= min)
				{
					min = sliceCount;
					x = i - 1;
					y = i;
				}
			}
			for (int i = y; i < A.Length; i++)
			{
				long sliceCount = AlgosFromCodility.TotalOfSlice(Prefix, (uint) x, (uint) i);
				if (sliceCount <= min)
					min = sliceCount;
			}
			for (int i = x; i >= 0; i--)
			{
				long sliceCount = AlgosFromCodility.TotalOfSlice(Prefix, (uint) i, (uint) y);
				if (sliceCount <= min)
					x = i ;
			}
			return x;
		}
	}
}