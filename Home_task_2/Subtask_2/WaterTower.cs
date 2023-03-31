using System;

namespace Subtask_2
{
	public class WaterTower
	{
		public readonly int MaxWaterLevel;
		public int CurrentWaterLevel { get; private set; }
		private Pump _pump;
		private Random _randomWaterLevel;
		public int Power { get; private set; }
		public bool IsGivingWater { get; private set; }
		public bool IsGettingWater { get; private set; }

		public WaterTower(int maxWaterLevel, int power, Pump pump)
		{
			_pump = pump;
			_randomWaterLevel = new Random();

			if (Validator.IsPositive(maxWaterLevel))
			{
				MaxWaterLevel = maxWaterLevel;
				CurrentWaterLevel = _randomWaterLevel.Next(0, maxWaterLevel);
			}

			if (Validator.IsPositive(power))
				Power = power;

			IsGivingWater = false;
			IsGettingWater = false;
		}

		public void StartGivingWater()
		{

		}

		public void StopGivingWater() 
		{

		}

		public void StartGettingWater()
		{

		}

		public void StopGettingWater()
		{

		}

		public override string ToString()
		{
			return 
				$"\nПоточний рiвень води у водонапiрнiй вежi: {CurrentWaterLevel} лiтрiв " +
				$"iз {MaxWaterLevel} можливих,\nїї спроможнiсть вiддавати воду одному " +
				$"користувачевi {Power} лiтрiв в секунду,\n" +
				$"активний статус вiддачi води користувачам {IsGivingWater}, " +
				$"активний статус наповнення водою завдяки насосу {IsGettingWater}!\n";
		}
	}
}
