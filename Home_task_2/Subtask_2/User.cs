using System;

namespace Subtask_2
{
	public class User
	{
		public readonly int Id;
		public readonly int MaxConsumption;
		private Random _randomConsumption;
		public int necessaryConsumption { get; private set; }
		public int Consumed { get; private set; }
		public bool IsConsumption { get; private set; }

		public User(int id, int maxConsumption)
		{
			Id = id;

			if (Validator.IsPositive(maxConsumption))
				MaxConsumption = maxConsumption;

			_randomConsumption = new Random();
			necessaryConsumption = _randomConsumption.Next(1, MaxConsumption);
			Consumed = 0;
			IsConsumption = false;
		}

		public void StartConsumption()
		{

		}

		public void StopConsumption()
		{

		}

		public void ChangePeferences(int newNecessaryConsumption)
		{

		}

		public override string ToString()
		{
			return $"\nКористувач пiд номером: {Id}, " +
				$"який вже спожив {Consumed} лiтрiв води iз необхiдних йому " +
				$"{necessaryConsumption} лiтрiв,\nйого активний статус споживання {IsConsumption}!\n";
		}
	}
}
