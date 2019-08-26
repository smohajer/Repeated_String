using System;
using System.Linq;

namespace Repeated_String
{
	class Program
	{

		/*
		 * https://www.hackerrank.com/challenges/repeated-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
		*/

		static long repeatedString(string s, long n)
		{
			// counts all letter a's from string s via linq
			int a = s.Count(x => x == 'a');

			//divides n by s.Length to give repeat factor, the mulitples by a (but in decimal so we can round up/down if needed)
			//returns in long (Int64)
			return Convert.ToInt64(Math.Round(a * (n / (decimal)s.Length)));

		}
		static void Main(string[] args)
		{
			long test = Program.repeatedString("aba", 10);
			Console.WriteLine(test);
			Console.ReadKey();
		}
	}
}
