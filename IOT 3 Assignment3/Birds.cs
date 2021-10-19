using System;

using IOT_3_Assignment3.Eggs;
namespace IOT_3_Assignment3.Birds
{
	class Bird
	{
		public static Random Rand = new Random(1);
		public virtual Egg[] LayEggs(int numEggs)
		{
			Console.Error.WriteLine("Bird.LayEggs should not be called!");
			return new Egg[0];
		}
	}

	class Chicken : Bird
	{
		// TODO: Implement this class
		public override Egg[] LayEggs(int numEggs)
		{
			Egg[] chicken = new Egg[numEggs];
			for (int c = 0; c < numEggs; c++)
			{
				chicken[c] = new Egg(Rand.Next(2,4), Egg.Colors.brown);
			}
			return chicken;
		}
	}

	class Ostrich : Bird
	{
		// TODO: Implement this class
		public override Egg[] LayEggs(int numEggs)
		{
			Egg[] ostrich = new Egg[numEggs];
			for (int o = 0; o < numEggs; o++)
			{
				ostrich[o] = new Egg(Rand.Next(10, 15), Egg.Colors.speckled);			
			}
			return ostrich;
		}

	}
}
