using System;
					
public class Program
{
	// Class
	public class Character
	{
		public string name;
		public int hp;
		public int maxHp;
		private int countHeal;
		
		public Character(string name, int hp)
		{
			this.name = name;
			this.hp = hp;
			this.maxHp = 700;
		}
		
		public void Heal(int amount)
		{
			if (countHeal < 5)
				hp += amount;

			countHeal += 1;
			Console.WriteLine($"{name} 회복: +{amount}");
			Console.WriteLine($"countHeal: {countHeal}");
			if (hp > maxHp)
				hp = maxHp;
		}
		
		public void ResetCountHeal()
		{
			countHeal = 0;
		}
		public void PrintStatus()
		{
			Console.WriteLine($"{name} / HP: {hp}");
		}
	}
	
	public class Player
	{
		// Field
		public string name;
		public int hp;
		private int iq;
		
		// Constructor 기본값넣기
		public Player(string name, int hp)
		{
			this.name = name;
			this.hp = hp;
		}
		
		// Method
		public void TakeDamage(int damage)
		{
			// iq = iq - damage;
			iq -= damage;
		}
		
		public void PrintIQ()
		{
			Console.WriteLine(iq);
		}
		
		public void PrintStatus()
		{
			Console.WriteLine("---PrintStatus---");
			Console.WriteLine($"{name} / HP: {hp}");
		}
		
		public void PrintStatusThis()
		{
			Console.WriteLine($"This: {this.name} / HP: {this.hp}");
		}
	}
	
	// Class
	public class Monster
	{
		// Field
		public string name;
		public int hp;
		public float speed;
	}
	
	public static void Main()
	{
		Character gwangyu = new Character("gwangyu", 100);
		gwangyu.PrintStatus();
		gwangyu.Heal(100);
		gwangyu.PrintStatus();
		gwangyu.Heal(299);
		gwangyu.PrintStatus(); //499
		
		gwangyu.maxHp = 2000;
		gwangyu.Heal(599);
		gwangyu.PrintStatus();
		// gwangyu.countHeal = 0;
		gwangyu.Heal(2);
		gwangyu.Heal(100);
		gwangyu.PrintStatus();
		gwangyu.Heal(100);
		gwangyu.PrintStatus();
		gwangyu.Heal(100);
		gwangyu.PrintStatus();
		
		gwangyu.ResetCountHeal();
		gwangyu.Heal(100);
		
		Player player1 = new Player("Alice", 10);
		Console.WriteLine(player1.name);
		Console.WriteLine(player1.hp);
		// Method
		player1.PrintStatus();
		player1.PrintStatusThis();
		
		player1.PrintIQ();
		player1.TakeDamage(20);
		player1.PrintIQ();
		// player1.iq = 200; 왜? private 이니까!!
		
		player1.name = "Gwangyu";
		player1.hp = 100;
		
		Console.WriteLine(player1.name);
		Console.WriteLine(player1.hp);
		// Method
		player1.PrintStatus();
		
		Player player2 = new Player("Hero", 100);
		
		
		
		Monster slime = new Monster();
		slime.name = "Slime";
		slime.hp = 30;
		slime.speed = 2.5f;
		
		Console.WriteLine($"{slime.name} / HP: {slime.hp} / Speed: {slime.speed}");
		
		Player playerA = new Player("Bob", 20);
		Player playerB = new Player("Charlie", 30);
		
		Console.WriteLine(playerA.name); // Bob
		Console.WriteLine(playerB.name); // Charlie
		
		playerA.name = "Alice";
		playerB.name = "Bob";
		
		Console.WriteLine(playerA.name);
		Console.WriteLine(playerB.name);
		
		
		
		
	}
}