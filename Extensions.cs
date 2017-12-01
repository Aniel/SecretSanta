using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace Aniel
{
	internal static class Extensions
	{
		public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> array)
		{
			RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider();
			return array.OrderBy(x => rnd.GetNextInt32());
		}

		public static int GetNextInt32(this RNGCryptoServiceProvider rnd)
		{
			byte[] randomInt = new byte[4];
			rnd.GetBytes(randomInt);
			return Convert.ToInt32(randomInt[0]);
		}
	}
}