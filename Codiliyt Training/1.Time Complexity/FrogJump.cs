using System;

namespace Codiliyt_Training
{
	public class FrogJump
	{
		/// <summary>
		/// How many jumps from should done to
		/// get to other side of the road 
		/// More mathematical task then programming
		/// </summary>
		/// <param name="X"></param>
		/// <param name="Y"></param>
		/// <param name="D"></param>
		/// <returns></returns>
		public static int Solution(int X, int Y, int D)
		{
			
			if(X<1||Y<1||D<1||X>1000000000||Y>1000000000||D>1000000000)
				throw new ArgumentOutOfRangeException();
			if(X>Y)
				throw new ArgumentException();
			if (X == Y)
				return 0;
			//Here we counting destanation
			int result = (int) Math.Ceiling((((double) Y - X)/D));
			return result;

		}
	}
}