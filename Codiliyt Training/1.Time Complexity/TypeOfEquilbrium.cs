using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace Codiliyt_Training
{
	public class TypeOfEqulibrium
	{
		public static int solution(int[]A)
		{

			if(A==null)
				throw new ArgumentNullException();
			if(A.Length<2||A.Length>100000)	
				throw new ArgumentOutOfRangeException();
			for (int i = 0; i < A.Length; i++)
			{
				int i1 = A[i];
				if(i1<-1000||i1>1000)
					throw new ArgumentOutOfRangeException("Some element of array A<-1000 or A[i]>10000");
			}
			if (A.Length == 2)
				return Math.Abs(A[0] - A[1]);
			int leftSum = A.Sum();
			int rightSum = 0;
			int result = int.MaxValue;
			for (int i = 0; i < A.Length; i++)
			{
				rightSum += A[i];
				leftSum -= A[i];
				int diffrence = Math.Abs(rightSum - leftSum);
				result = (diffrence < result) ? diffrence : result;
			}
			return result;
		}
	}
}