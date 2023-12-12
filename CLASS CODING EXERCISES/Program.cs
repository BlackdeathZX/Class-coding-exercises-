// See https://aka.ms/new-console-templatea for more information
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Xml.XPath;
using System.Linq.Expressions;
/*
// opgaver 
Console.WriteLine("Write your name here: \t");
Console.WriteLine( "Hello " + Console.ReadLine());
System.Threading.Thread.Sleep(1200); 
Console.Clear();
// opgave 2 og 3
Console.WriteLine("Write your first number here: \t");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("your number added together with itself " + (x + x));
// will only give you one unless you divide with zero
Console.WriteLine("Your number divided with itself: " + x / x);
System.Threading.Thread.Sleep(1200); 
Console.Clear();
// opgave 4 
Console.WriteLine("result of -1+4*6: " + (-1 + 4 * 6));
Console.WriteLine("result of (35+5)%7: " + ((35 + 5) % 7));
Console.WriteLine("result of 14+-4*6/11: " + (14 + -4 * 6 / 11));
Console.WriteLine("result of 2+15/6*1-7%2: " + (2 + 15 / 6 * 1 - 7 % 2));
System.Threading.Thread.Sleep(2200); 
Console.Clear();
// opgave 5
int b, c, temp;
Console.WriteLine("Write your first number here: \t");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your second number here: \t");
c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Before swapping: ");
Console.WriteLine("First number = " + b);
Console.WriteLine("Second number = " + c);
System.Threading.Thread.Sleep(2200); 
Console.Clear();
temp = b; 
b = c;
c = temp;
Console.WriteLine("your numbers after swapping:");
Console.WriteLine("Your first number now is = " + b);
Console.WriteLine("Your second number now is = " + c);
System.Threading.Thread.Sleep(2200); 
Console.Clear();
// opgave 6
Console.WriteLine("Multiplication with 3 numbers");
Console.WriteLine("Write your first number here: \t");
int mula = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your second number here: \t");
int mulb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your third number here: \t");
int mulc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Multiplication of your numbers:" +(mula * mulb * mulc));
System.Threading.Thread.Sleep(2200); 
Console.Clear();
//opgave 7
Console.WriteLine("adding, subtracting, multiplying, modulus and dividing two numbers");
Console.WriteLine("Write your first number here: \t");
float a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your second number here: \t");
float b2 = Convert.ToInt32(Console.ReadLine());
System.Threading.Thread.Sleep(1000); 
Console.Clear();
Console.WriteLine("adding your numbers togheter results in:" + (a1 + b2));
Console.WriteLine("subtracting your numbers togheter results in:" + (a1 - b2));
Console.WriteLine("multiplying your numbers togheter results in:" + (a1 * b2));
Console.WriteLine("dividing your numbers togheter results in:" + (a1 / b2));
Console.WriteLine("modulus of your numbers togheter results in:" + (a1 % b2));
System.Threading.Thread.Sleep(2200);
Console.Clear();
//opgave 8
Console.WriteLine("Multiplication table of a specific number");
Console.WriteLine("Write your number here: \t");
int num = Convert.ToInt32(Console.ReadLine());
int result;
for (int j = 0; j < 11; j++){
    result = num * j;
    Console.WriteLine("The table is : {0} * {1} = {2}", num, j, num * j);
}
System.Threading.Thread.Sleep(2200);
Console.Clear();
//opgave 9
Console.WriteLine("Avarge of four numbers");
Console.WriteLine("Input first number");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second number");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input third number");
double num3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input four number");
double num4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("The average of {0}, {1}, {3} is : {4} ",num1, num2, num3, num4, (num1 + num2 + num3 + num4)/4);


//opgave 10
//Two numbers added toghether and third one multyplying the two numbers
Console.WriteLine("Input first number");
double nu1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second number");
double nu2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input third number");
double nu3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Result of these numbers ({0} + {1})*{2} = {3} and ({0}*{1}) + ({1}*{2}) = {4}  ", nu1, nu2, nu3, (nu1 + nu2)*nu3, (nu1 * nu2) + (nu2 *nu3));
//opgave 11
Console.WriteLine("How old are you");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You look older than {0}", age);
//opgave 12
Console.WriteLine("Input a number");
int repeat = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(repeat + " " + repeat, " " + repeat, " ", repeat, "\t");
Console.WriteLine("",repeat, repeat, repeat, repeat, "\n");
Console.WriteLine("{0} {0} {0} {0}", repeat);
Console.WriteLine("{0}{0}{0}{0}", repeat);
//opgave 13
Console.WriteLine("Input a number");
int collum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0}{0}{0}",collum);
Console.WriteLine("{0} {0}",collum);
Console.WriteLine("{0} {0}", collum);
Console.WriteLine("{0}{0}{0}",collum);
*/
//opgave 14
Console.WriteLine("Input degree celsius");
double celsius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Celsius in ferenheit {0}", (celsius *18/10+32));
Console.WriteLine("celsius in kelvin {0}", (celsius +273));