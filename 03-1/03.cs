using System;
					
public class Program
{
	public static void Main()
	{
		
		//들여쓰기(tab),console.write, if문 순서
		
		// if
		int score1 = 85;
		
		if (score1 >= 50)
		{
			// score1 >= 50 조건이 True면 아래 코드 실행
			Console.WriteLine("A");
		}
		
		
		// if-else
		
		int score2 = 95;
		
		if (score2 >= 90)
		{
			// score2 >= 90 조건이 True면 아래 코드 실행
			Console.WriteLine("A");
		}
		else
		{
			// score2 >= 90 조건이 False면 아래 코드 실행
			Console.WriteLine("A가 아님");
		}
		
		string name = "gwangyu";
		
		if (name == "gwangyu")
		{
			Console.WriteLine("관규맞음!");
			Console.Write("Write");
			Console.WriteLine("관규맞음!");
			Console.WriteLine("관규맞음!");
		}
		else
		{
			Console.WriteLine("관규가 아님!");
		}
		
		
		// else if
		
		int score3 = 75;
		Console.WriteLine("else if문 시작");
		if (score3 >= 90)
		{
			Console.WriteLine("A");
		}
		else if (score3 >= 80)
		{
			Console.WriteLine("B");
		}
		else if (score3 >= 70)
		{
			Console.WriteLine("C");
		}
		else
		{
			Console.WriteLine("F");
		}
		Console.WriteLine("else if문 끝");
		
		
		// Nested if
		
		int score4 = 85;
		bool isSubmitted4 = true;
		
		if (isSubmitted4)
		{
			if (score4 >= 90)
			{
				Console.WriteLine("제출했고 A");
			}
			else if (score4 >= 80)
			{
				Console.WriteLine("제출했고 B");
			}
			else
			{
				Console.WriteLine("제출했지만 80점 미만");
			}
		}
		else
		{
			Console.WriteLine("미제출");
		}
		
		
		// Logic & if
		
		int score5 = 85;
		bool isSubmitted5 = true;
		
		if (isSubmitted5 && score5 >= 90)
		{
			Console.WriteLine("A");
		}
		else if (isSubmitted5 && score5 >= 80)
		{
			Console.WriteLine("B");
		}
		else
		{
			Console.WriteLine("기타");
		}
		
		int score6 = 5;
		bool isSubmitted6 = false;
		
		if (!isSubmitted6 || score6 >= 90)
		{
			Console.WriteLine("OR: A");
		}
		else if (isSubmitted6 || score6 >= 80)
		{
			Console.WriteLine("OR: B");
		}
		
		// switch
		
		string grade = "B";
		
		switch (grade)
		{
			case "A":
				Console.WriteLine("우수");
				break;
			case "B":
				Console.WriteLine("양호");
				break;
			case "C":
				Console.WriteLine("보통");
				break;
			default:
				Console.WriteLine("기타");
				break;
		}
		
		// 삼항 연산자
		int score7 = 95;
		string result = score7 >= 90 ? "A" : "A가 아님";
		Console.WriteLine(result);
		
		int score8 = 8500;
		
		if (score8 >= 60)
		{
			Console.WriteLine("D");
		}
		else if (score8 >= 70)
		{
			Console.WriteLine("C");
		}
		
	}
}


