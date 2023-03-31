using System;

namespace Subtask_2
{
	public class Pump
	{
		public int Power { get; private set; }
		public int PumpedOver { get; private set; }
		public bool IsPumping { get; private set; }

		public Pump(int power)
		{
			if (Validator.IsPositive(power))
				Power = power;

			IsPumping = false;
		}

		public void StartPumping()
		{

		}

		public void StopPumping()
		{

		}

		public override string ToString()
		{
			return $"\nПерекачано води у водонапiрну вежу {PumpedOver} лiтрiв, потужнiсть насосу " +
				$"{Power} лiтрiв в секунду,\nактивний статус перекачування води {IsPumping}!\n";
		}
	}
}
