using System;

namespace Subtask_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Simulator simulator = new Simulator(2000, 20, 150, 4, 500);

			simulator.StartSimulation();
			Console.WriteLine(simulator.ToString());

			Console.ReadKey();
		}
	}
}
