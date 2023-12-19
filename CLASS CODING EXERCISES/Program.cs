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
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
/*
// opgaver 
{
Console.WriteLine("Write your name here: \t");
Console.WriteLine( "Hello " + Console.ReadLine());
System.Threading.Thread.Sleep(1200); 
Console.Clear();
}{
// opgave 2 og 3
Console.WriteLine("Write your first number here: \t");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("your number added together with itself " + (x + x));
// will only give you one unless you divide with zero
Console.WriteLine("Your number divided with itself: " + x / x);
System.Threading.Thread.Sleep(1200); 
Console.Clear();
}
{
// opgave 4 
Console.WriteLine("result of -1+4*6: " + (-1 + 4 * 6));
Console.WriteLine("result of (35+5)%7: " + ((35 + 5) % 7));
Console.WriteLine("result of 14+-4*6/11: " + (14 + -4 * 6 / 11));
Console.WriteLine("result of 2+15/6*1-7%2: " + (2 + 15 / 6 * 1 - 7 % 2));
System.Threading.Thread.Sleep(2200); 
Console.Clear();
}{
// opgave 5
int b, c, temp;
Console.WriteLine("Write your first number here: \t");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write your second number here: \t");
c = Convert.ToInt32(Console.ReadLine());
}{
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
}{
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
}{
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
}{
//opgave 8
Console.WriteLine("Multiplication table of a specific number");
Console.WriteLine("Write your number here: \t");
int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The table is : {0} * {1} = {2}", num, 1, num * 1);
    Console.WriteLine("The table is : {0} * {1} = {2}", num, 2, num * 2);
    Console.WriteLine("The table is : {0} * {1} = {2}", num, 3, num * 3);
    Console.WriteLine("The table is : {0} * {1} = {2}", num, 4, num * 4);
    Console.WriteLine("The table is : {0} * {1} = {2}", num, 5, num * 5);
    Console.WriteLine("The table is : {0} * {1} = {2}", num, 6, num * 6);
    Console.WriteLine("The table is : {0} * {1} = {2}", num, 7, num * 7);
    Console.WriteLine("The table is : {0} * {1} = {2}", num, 8, num * 8);
    Console.WriteLine("The table is : {0} * {1} = {2}", num, 9, num * 9);
    Console.WriteLine("The table is : {0} * {1} = {2}", num, 10, num * 10);
    Console.WriteLine("\n\nInput any key to close");
    Console.ReadLine();
Console.Clear();
{
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
}

{
//opgave 10
//Two numbers added toghether and third one multyplying the two numbers
Console.WriteLine("Input first number");
double nu1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second number");
double nu2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input third number");
double nu3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Result of these numbers ({0} + {1})*{2} = {3} and ({0}*{1}) + ({1}*{2}) = {4}  ", nu1, nu2, nu3, (nu1 + nu2)*nu3, (nu1 * nu2) + (nu2 *nu3));
}{
//opgave 11
Console.WriteLine("How old are you");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You look older than {0}", age);
}{
//opgave 12
Console.WriteLine("Input a number");
int repeat = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(repeat + " " + repeat, " " + repeat, " ", repeat, "\t");
Console.WriteLine("",repeat, repeat, repeat, repeat, "\n");
Console.WriteLine("{0} {0} {0} {0}", repeat);
Console.WriteLine("{0}{0}{0}{0}", repeat);
}{
//opgave 13
Console.WriteLine("Input a number");
int collum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0}{0}{0}",collum);
Console.WriteLine("{0} {0}",collum);
Console.WriteLine("{0} {0}", collum);
Console.WriteLine("{0}{0}{0}",collum);
}{
//opgave 14
Console.WriteLine("Input degree celsius");
double celsius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Celsius in ferenheit {0}", (celsius *18/10+32));
Console.WriteLine("celsius in kelvin {0}", (celsius +273));
char letter, letter1, letter2; 
Console.WriteLine("Input letter: ");
letter = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Input second letter: ");
letter1 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Input third letter: ");
letter2 = Convert.ToChar(Console.ReadLine());
//char opgaver
}



//opgave 1 
Console.WriteLine("Your first letter {0} your second letter {1} your third letter {2}",letter, letter1, letter2);
System.Threading.Thread.Sleep(2200); 
Console.Clear();
Console.WriteLine("Now your first letter is {0} and your second letter is {1} and your third letter is {2}", letter2 ,letter1 ,letter);
// opgave 5
double pi = 3.14;
Console.WriteLine("Type in your radius of a circle");
double r = Convert.ToDouble(Console.ReadLine());
double circleperimeter = pi * 2 * r; 
Console.WriteLine("The perimeter of your circle is {0} ", circleperimeter );
// opgave 7 
double hour, sec, min;
Console.WriteLine("Input your distance in metres");
double distance = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Hours");
hour = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Minutes");
min = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Seconds");
sec = Convert.ToDouble(Console.ReadLine());
double mps, kph, mph;
double timeSec = (hour * 3600) +(min*60) + sec;
mps = distance/timeSec;
kph = (distance/1000.0f)/(timeSec/3600.0f);
mph = kph /1.609f;
Console.WriteLine("Your speed in metres/sec is {0}", mps);
Console.WriteLine("Your speed in km/h is {0}", kph);
Console.WriteLine("Your speed in miles/h is {0}", mph);
// opgave 10
double oe, eo;
bool bothEven;
Console.WriteLine("Input a number");
oe = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input a second number");
eo = Convert.ToDouble(Console.ReadLine());
bothEven = ((oe % 2 == 0) 
&& (eo % 2 == 0))? true : false; 
Console.WriteLine(bothEven ? 
    "both numbers are even" : 
    "there's an odd number"); 
// statements 
// opgave 1 
Console.WriteLine("Input first number");
double enum1, enum2;
enum1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input your second number");
enum2 = Convert.ToDouble(Console.ReadLine());
if (enum1 == enum2){
    Console.WriteLine("{0} and {1} are equal", enum1,enum2);
}
else {
    Console.WriteLine("{0} and {1} are not equal", enum1, enum2);
}
//opgave 2
double ode; 
Console.WriteLine("Input a number");
ode = Convert.ToDouble(Console.ReadLine());
if (ode % 2 == 0){
    Console.WriteLine("The number is even");
}else {
    Console.WriteLine("The number is odd");
}
//opgave 3
Console.WriteLine("Input a negativ or positiv number");
double mem = Convert.ToDouble(Console.ReadLine());
if (mem >= 0){
    Console.WriteLine("The number is positiv {0}", mem);
}else {
    Console.WriteLine("The number is negativ");
}
//opgave 4 
Console.WriteLine("Check wheter a given year is a leap year or not\n");
Console.WriteLine("Input a year");
int year = Convert.ToInt32(Console.ReadLine());
if (year % 400 == 0){
Console.WriteLine("{0} is a leap year",year);
}
else if (year % 100 == 0){
    Console.WriteLine("{0} is not a leap year",year);
}
else if(year % 4 == 0){ 
    Console.WriteLine("{0} is a leap year",year);
    }
else {
        Console.WriteLine("{0} is not a leap year.",year);
}
// opgave 5
Console.WriteLine("Input your age");
int age = Convert.ToInt32(Console.ReadLine());
if(age >= 18) {
    Console.WriteLine("Congratulations you can vote");
} else {
    Console.WriteLine("You are to young to vote");
}
// opgave 6
int m, n; 
Console.WriteLine("Display the value of n is 1,0 and -1 for the value of m:");
Console.WriteLine("Input the value of m :");
m= Convert.ToInt32(Console.ReadLine());
if (m!=0)
    if(m>0)
        n=1;
    else 
        n =-1;
    else 
        n=0;
    Console.Write("The value of m = {0}\n", m);
    Console.Write("The value of n = {0}\n", n);
    //opgave 7
    Console.WriteLine("What is your height in centimeters");
    float size = Convert.ToInt64(Console.ReadLine());
    if (size < 150.0f){
        Console.WriteLine("You are a dwarf");
     }
    if (size >=150.0f)
        if (size < 165.0f){ 
            Console.WriteLine("You are avarge in height");
    }
    if (size >= 165.0)
        if (size <195.0f){
        Console.WriteLine("You are tall");
    }
        if (size >= 195.0f){
        Console.Write("You are humongus");
    }
    
    // opgave 8
    //not done 
    Console.WriteLine("input three numbers to find out which numbers are biggest");
    Console.WriteLine("Input first number");
    float big1 = 
    */