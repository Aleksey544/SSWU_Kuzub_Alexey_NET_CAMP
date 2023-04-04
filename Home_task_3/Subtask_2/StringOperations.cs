namespace Subtask_2
{
	public class StringOperations
	{
		public string Str { get; private set; }
		private string[] _subStrings;

		public StringOperations(string str)
		{
			SetString(str);
		}

		public void SetString(string str)
		{
			Str = str;
			_subStrings = Str.Split();
		}

		public int? IndexOfSecondOccurrence()
		{
			int? index;

			if (_subStrings.Length > 1)
			{
				if (_subStrings[0] == _subStrings[1])
				{
					index = _subStrings[0].Length + 1;
				}
				else
				{
					index = null;
				}
			}
			else
			{
				index = null;
			}

			return index;
		}

		public int CapitalizedWordsAmount()
		{
			int amount = 0;

			for (int i = 0; i < _subStrings.Length; i++)
			{
				if (char.IsUpper(_subStrings[i][0]))
				{
					amount++;
				}
			}

			return amount;
		}

		public string ReplacingWordWithDoubledLetters(string strToReplace)
		{
			string[] replacedSubStrings = _subStrings;
			string replacedString = "";

			for (int i = 0; i < replacedSubStrings.Length; i++)
			{
				for (int j = 1; j < replacedSubStrings[i].Length; j++)
				{
					if (_subStrings[i][j - 1] == _subStrings[i][j])
					{
						replacedSubStrings[i] = _subStrings[i].Replace(_subStrings[i], strToReplace);
					}
				}

				replacedString += replacedSubStrings[i] + " ";
			}

			return replacedString;
		}
	}
}
