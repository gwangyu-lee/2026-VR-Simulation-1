using System;
					
public class Program
{
	// 부모
	public class Character
	{
		public string name;
		
		public Character(string name)
		{
			this.name = name;
		}
		public virtual void Attack()
		{
			Console.WriteLine($"{name}이 공격한다!");
		}
	}
	
	//자식
	public class Warrior: Character
	{
		public Warrior(string name) : base(name) { }
		
		public override void Attack()
		{
			Console.WriteLine($"{name}이 검으로 공격한다!");
		}
	}
	
	//자식
	public class Mage: Character
	{
		public Mage(string name) : base(name) { }
		
		public override void Attack()
		{
			Console.WriteLine($"{name}이 마법으로 공격한다!");
		}
	}
	
	// Sealed
	public sealed class FinalBoss : Character
	{
		public FinalBoss(string name) : base(name) { }
	}
	
	// public class Gwan : FinalBoss
	// {
	//  	public Gwan(string name) : base(name) {}
	// }
	
	public static void Main()
	{
		Character[] party = {
			new Warrior("Knight"),
			new Mage("Wizard"),
			new Character("Archer")
			};
		
		foreach (Character c in party)
		{
			c.Attack();
		}
		
		Character a = new Warrior("Knight");
		if (a is Warrior)
		{
			Console.WriteLine("이 객체는 Warrior입니다.");
		}
		
		Warrior w = a as Warrior;
		if (w != null)
		{
			Console.WriteLine("Warrior로 변환 성공!");
		}
	}
}