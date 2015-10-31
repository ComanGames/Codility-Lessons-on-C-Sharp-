using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Codiliyt_Training
{
	class Program
	{
		static void Main(string[] args)
		{
			PermCheck.Solution(Enumerable.Range(1, 10).ToArray());
		}

		private static void WriteResult(int[] result)
		{
			Console.Write("{");
			for (int i = 0; i < result.Length; i++)
			{
				int i1 = result[i];
				if(i<result.Length-1)
					Console.Write($"{i1}, ");
				else
					Console.Write($"{i1}"+" }");
			}
		}
	}
}
