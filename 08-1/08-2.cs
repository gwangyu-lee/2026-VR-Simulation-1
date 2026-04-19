using System;
					
public class Program
{
	public class Enemy
	{
		public string name;
		
		public Enemy(string name)
		{
			this.name = name;
		}
		public void Attack()
		{
			Console.WriteLine($"{name}이 공격!");
		}
	}
	public static void Main()
	{
		int hp = 40;
		bool hasPotion = true;
		
		if (hp < 50 && hasPotion)
		{
			hp += 30;
		}
		Console.WriteLine(hp);
		
		Enemy enemy = new Enemy("Goblin");
		enemy.Attack();
		
		int[] scores = {80, 90, 70};
		
		int total = 0;
		foreach (int score in scores)
		{
			total += score;
		}
		Console.WriteLine(total); // total: 240
		double average = total / (double)scores.Length;
		Console.WriteLine(average);
		
		static int Sum(int[] numbers)
		{
			int total = 0;
			
			foreach (int n in numbers)
			{
				total += n;
			}
			return total;
		}
		total = Sum(scores);
		average = total / (double)scores.Length;
		Console.WriteLine(average);
	}
}