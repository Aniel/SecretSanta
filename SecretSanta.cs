using System;
using System.Collections.Generic;
using System.Linq;

namespace Aniel
{
	public static class SecretSanta
	{
		public static IEnumerable<(T Giver, T Receiver)> Assign<T>(IEnumerable<T> participants)
		{
			var randomParticipants = participants.Shuffle().ToArray();
			var length = randomParticipants.Count();
			var result = new(T Giver, T Receiver)[length];
			for (int i = 0; i < length; i++)
			{
				if (i < length - 1)
					result[i] = (randomParticipants[i], randomParticipants[i + 1]);
				else
					result[i] = (randomParticipants[i], randomParticipants[0]);
			}
			return result;
		}
	}
}
