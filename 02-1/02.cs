using System;
					
public class Program
{
	public static void Main()
	{
		//OPERATOR
		//산술연산자
		double pi = 3.14;
		double twoPi = pi * 2;
		Console.WriteLine(pi);
		Console.WriteLine(twoPi);  
		
		double twoPiAddThree = twoPi + 3;
		Console.WriteLine(twoPiAddThree);
		
		int tenMinusFive = 10 - 5;
		Console.WriteLine(tenMinusFive);
		
		double ten = 10;
		double tenDivideSix = ten/6;
		Console.WriteLine(tenDivideSix);
		
		int tenDivideSixInt = 10/6;
		Console.WriteLine(tenDivideSixInt);
		
		//관계연산자
		bool boolean1 = 8 > 5;
		Console.WriteLine(boolean1);
		bool boolean2 = 8 > 9;
		Console.WriteLine(boolean2);
		bool boolean3 = 8 == 9;
		Console.WriteLine(boolean3);
		
		//논리연산자
		bool myLogic1 = (10 > 5)  && (20 > 10);
		Console.WriteLine(myLogic1);
		bool myLogic2 = (10 > 15) || (20 > 10);
		Console.WriteLine(myLogic2);
		
		//비트연산자
		byte bitOne = 0b0000_0001;
		Console.WriteLine(bitOne);
		byte myBit = 0b0000_0100;
		Console.WriteLine("MY BIT");
		Console.WriteLine(myBit);
		
		//CONSTANT
		const int myNumber = 10;
		Console.WriteLine(myNumber);
		//myNumber = 5; 에러!!
		Console.WriteLine(myNumber);
		
		//부동소수점 주의사항
		double a = 0.1;
		double b = 0.2;
		double c = 0.3;
		Console.WriteLine(c == 0.3);
		Console.WriteLine(c == a+b);
		Console.WriteLine(a+b);
	}
}








