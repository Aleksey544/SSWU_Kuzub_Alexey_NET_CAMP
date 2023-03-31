using System;

namespace Subtask_2
{
	public static class Validator
	{
		public static bool IsPositive(int value) 
		{
			if (value > 0)
				return true;
			else
				return false;
		}
	}
}
