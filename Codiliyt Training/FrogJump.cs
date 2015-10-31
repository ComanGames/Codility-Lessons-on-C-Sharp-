using System;

namespace Codiliyt_Training
{
	public class FrogJump
	{
		public static int solution(int X, int Y, int D)
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