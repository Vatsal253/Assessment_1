using System;
	class average
	{
	static void Main()
	{
	Console.WriteLine("Enter the first number: ");
	double num1 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Enter the second number: ");
	double num2 = Convert.ToDouble(Console.ReadLine());
	Console.WriteLine("Enter the third number: ");
	double num3 = Convert.ToDouble(Console.ReadLine());
	double Average = (num1+num2+num3)/3;
	Console.WriteLine("The average of three numbers is: "+Average);
	}
	}