using System;
					
public class Program
{
	public static void Main()
	{
		// TOKEN
		int one = 1;
		// 토큰 5개: int / one / = / 1 / ;
		
		// LITERAL
		int two = 2;
		// 리터럴은 2
		
		double pointOne = 0.1;
		// 64bit
		
		float pointTwo = 0.2f;
		// 32bit
		
		bool isStudent = false;
		bool isGwangyu = true;
		
		string name = "Gwangyu";
		// 문장
		
		string empty = " ";
		
		char initial = 'G';
		// 글자
		
		int three = 3;
		// int는 정수 선언용 단어, 키워드
		
		double pointThree = 0.3;
		// 여기서 키워드는 double
		
		int four = 4;
		Console.WriteLine(four);
		
		int _int5 = 5;
		Console.WriteLine(_int5);
		
		int myNumberIsFour = 4;
		// 정수를 myNumberIsFour라는 식별자에 대입(집어넣는다) 뭐를? 4(리터럴)를! 할말끝. ;
		// myNumberIsFour라는 변수에 정수만 집어넣을수있고, 4를 일단 집어넣는다.
		
		double myDouble = 1.1;
		//myDouble에 소수 1.1을 집어넣는다.
		Console.WriteLine(myDouble);
		// 1.1
		
		myDouble = 2.2;
		// myDouble에 2.2를 집어넣는다!
		// 이순간부터 myDouble은 2.2!
		Console.WriteLine(myDouble);
		// 출력을 2.2
		
	}
}