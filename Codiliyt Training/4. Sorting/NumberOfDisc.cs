using System;
using System.Linq;

namespace Codiliyt_Training
{
	public class NumberOfDisc
	{
		public class Circel
		{
			 public int first { get; private set; }

			public uint last { get; private set; }

			public Circel(int first, int last)
			{
				this.first = first;
				this.last = (uint)last;
			}
		}

		public static int Solution(int[] A)
		{
			if (A == null)
				return 0;
			if (A.Length < 2)
				return 0;
			Circel[] circels = new Circel[A.Length];
			for (int i = 0; i < A.Length; i++)
			{
				circels[i] = new Circel(i-A[i],i+A[i]);
			}
			circels = circels.OrderBy(c => c.first).ToArray();
			int [] openings = new int[circels.Length];
			for (int i = 0; i < circels.Length; i++)
			{
				Circel circel = circels[i];
				openings[i] = circel.first;
			}
			int maxOpenning = openings[openings.Length - 1];
			int count = 0;
			for (int i = 0; i < circels.Length; i++)
			{
				Circel circel = circels[i];
				int indexOfOpening = Array.BinarySearch(openings,(int)circel.last+1 );
				if (indexOfOpening < 0)
				{
					for (int j = (int)circel.last+2; j <= maxOpenning; j++)
					{
						indexOfOpening = Array.BinarySearch(openings,j);
						if(indexOfOpening>0)
						{ break;}
					}
					
				}
				if (indexOfOpening < 0)
					count += circels.Length - (i+1);
				else
					count += indexOfOpening- (i+1);
			}
			return count;
		}
	}
}