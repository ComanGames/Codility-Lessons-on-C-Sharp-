using System;

namespace Codiliyt_Training
{
	public class CountDiv
	{
		/// <summary>
		/// The task is super simple
		/// Just we need to find the 
		/// Haw many numbers devided
		/// by that one is able to find
		/// </summary>
		/// <param name="A"></param>
		/// <param name="B"></param>
		/// <param name="K"></param>
		/// <returns></returns>
		public static int Solution(int A, int B, int K)
		{
			int result = (B/K) -(A/K);
			result += A%K == 0 ? 1 : 0;
			return result;
		}
		 
	}
}