using System;
					
public class Program
{
	// 부모
	public class Character
	{
		public string name;
		protected int hp;
		
		public Character(string name, int hp)
		{
			this.name = name;
			this.hp = hp;
		}
		public virtual void PrintStatus()
		{
			Console.WriteLine($"{name} / HP: {hp}");
		}
		
		public virtual void Attack()
		{
			Console.WriteLine($"{name}이 공격한다!");
		}
			
	}
	
	// 자식
	public class Warrior : Character
	{
		public int attackPower;
		
		public Warrior(string name, int hp, int attackPower) : base(name, hp)
		{
			this.attackPower = attackPower;
		}
		
		public override void PrintStatus()
		{
			base.PrintStatus();
			Console.WriteLine($"Attack Power: {attackPower}");
			Console.WriteLine($"Protected: HP: {hp}");
		}
		
		public override void Attack()
		{
			Console.WriteLine($"{name}이 검으로 공격한다! / Attack Power: {attackPower}");
		}
	}
	
	// 자식의 자식
	public class BerserkerWarrior : Warrior
	{
		public bool isRaging;
		
		public BerserkerWarrior(string name, int hp, int attackPower, bool isRaging) : base(name, hp, attackPower)
		{
			this.isRaging = isRaging;
		}
		
		public override void PrintStatus()
		{
			base.PrintStatus();
			Console.WriteLine($"Raging: {isRaging}");
		}
		
		public override void Attack()
		{
			Console.WriteLine($"{name}이 검으로 공격한다! / Attack Power: {attackPower} / Raging: {isRaging}");
		}
	}
	
	public static void Main()
	{
		// 상속
		// Warrior w = new Warrior();
		// w.name = "Knight";
		// w.hp = 150;
		// w.attackPower = 30;
		// w.PrintStatus();
	 	// w.Attack();
		
		// BerserkerWarrior b = new BerserkerWarrior();
		// b.name = "Ragnar";
		// b.hp = 200;
		// b.attackPower = 50;
		// b.isRaging = true;
		// b.Attack();
		
		// 생성
		Warrior w = new Warrior("Knight", 150, 30);
		w.PrintStatus();
		w.Attack();
		
		BerserkerWarrior b = new BerserkerWarrior("Ragnar", 200, 50, true);
		b.PrintStatus();
		b.Attack();
		
	}
}