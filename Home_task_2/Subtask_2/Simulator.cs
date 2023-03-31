using System;
using System.Linq;

namespace Subtask_2
{
	public class Simulator
	{
		private Pump _pump;
		private WaterTower _tower;
		private User[] _users;
		public int UsersCount { get; private set; }

		public Simulator( int maxWaterLevelOfWaterTower, int waterTowerPower, 
			int pumpPower, int usersCount, int maxTotalUserConsumption)
		{
			_pump = new Pump(pumpPower);
			_tower = new WaterTower(maxWaterLevelOfWaterTower, waterTowerPower, _pump);

			if (Validator.IsPositive(usersCount))
				UsersCount = usersCount;

			_users = new User[UsersCount];

			for (int i = 0; i < usersCount; i++)
			{
				_users[i] = new User(i, maxTotalUserConsumption);
			}
		}

		public void StartSimulation()
		{

		}

		public override string ToString()
		{
			return $"\nПоточний стан системи: кiлькiсть користувачiв {_users.Length}!\n" +
				_tower.ToString() + _pump.ToString() +
				string.Join("", _users.Select(user => user.ToString()));
		}
	}
}
