// See https://aka.ms/new-console-templatea for more information
using System.Collections.Specialized;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
//asks for the name
Console.WriteLine("What is your name?");
var name = Console.ReadLine();
//clears the console 
Console.Clear();
//prints the name 
    Console.Write("Hello, " + name);
// random number generator
//var random = new Random();
//Console.WriteLine(random.Next(1,4));
Console.Clear();
// trying to loop the math part of the program 
bool retry = true;
//Loops while true 
while (retry){

retry = true;
//math 
double x;
double y;
double z;
string calc;
// first number
Console.Write("Enter a number");
x = Convert.ToDouble(Console.ReadLine());
//second number
Console.Write("Enter another number: ");
y = Convert.ToDouble(Console.ReadLine());
// decides what to do with the numbers - * / + -
Console.Write("\n Now please select a calculation");
// if not a number program will stop : (
// a true cocunut.png moment 
calc = Convert.ToString(Console.ReadLine());

if (calc== "*")
{
    z = x * y;
    Console.WriteLine("The answer is " + z);
    retry = false;

}
if (calc == "/")
{
    z = x / y;
    Console.WriteLine("The answer is " + z);
    retry = false;
}
if (calc == "+")
{
    z = x + y;
    Console.WriteLine("The answer is " + z);
    retry = false;
}
if (calc == "-")
{
    z = x - y;
    Console.WriteLine("The answer is " + z);
    retry = false;
}
Console.ReadKey();
}
//end of math