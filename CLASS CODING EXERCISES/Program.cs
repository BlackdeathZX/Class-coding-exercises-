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
using System.Security.Cryptography;
using System.Xml;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
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

// opgave 8 
double Pi = 3.1415926535;
Console.Write("Insert radius of a circle: ");
double radius = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Volume of your spehere {0} ", 4*Pi*(radius*radius));

Console.WriteLine("Area of a Sphere {0}", 4f/3f * Pi *(radius*radius*radius));
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
    Console.WriteLine("input three numbers to find out which numbers are biggest");
    double nur1 = Convert.ToDouble(Console.ReadLine());
    double nur2 = Convert.ToDouble(Console.ReadLine());
    double nur3 = Convert.ToDouble(Console.ReadLine());
    if (nur1 > nur2)
    {
        if (nur1 > nur3)
        {
            Console.WriteLine("The number {0} is the greatest among the other two", nur1);
        }
        else 
        { 
             Console.WriteLine("The number {0} is the greatest among the other two", nur3);
        }
    }
    else if (nur2 > nur3){
            Console.WriteLine("The number {0} is the greatest among the other two", nur2);
        }
   // opgave 9
   Console.WriteLine("Input cordinates of a point to determine if the point is in first, second, third or fourth quadrant");
   Console.WriteLine("Input x coordinate");
float xpoint = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Input y coordinate");
float ypoint = Convert.ToInt64(Console.ReadLine());
if (xpoint >= 0)
    if (ypoint >= 0){
        Console.WriteLine("The coordinate point ({0} {1}) is in the first quadrant", xpoint,ypoint);
    }
if (xpoint >= 0)
    if (ypoint <= 0){
        Console.WriteLine("The coordinate point ({0} {1}) is in the second quadrant", xpoint,ypoint);
    }
if (xpoint <= 0)
 if(ypoint <= 0){
    Console.WriteLine("The coordinate point ({0} {1}) is in the third quadrant", xpoint,ypoint);
 }
 else {
    Console.WriteLine("The coordinate point ({0} {1}) is in the fourth quadrant", xpoint,ypoint);
 }
// opgave 10
int math, Phy, Chem;

Console.WriteLine("Find eligibility for admission :");
Console.WriteLine("\n\n Eligibility Criteria :");
Console.Write("Marks in Maths >=65\n");
Console.Write("and Marks in Phy >=55\n");
Console.Write("and Marks in Chem>=50\n");
Console.Write("and Total in all three subject >=180\n");
Console.Write("or Total in Maths and Physics >=140\n");
Console.Write("Input your optained Mathematics marks\n");
math = Convert.ToInt16(Console.ReadLine());
Console.Write("Input your obtained Physics marks\n");
Phy = Convert.ToInt16(Console.ReadLine());
Console.Write("Input your obtained Chemistry marks\n");
Chem = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Total marks of Maths, physics, and Chemistry {0}\n", math+Phy+Chem);
Console.Write("Total marks of Physics and Maths\n",math+Phy);

if (math >= 65)
    if(Phy>=55)
        if(Chem >= 50)
        if ((math+Phy+Chem) >=)

//opgave 11
Console.WriteLine("Calculate root of Quadratic Equation :\n");

double dq, xq1, xq2;

Console.WriteLine("Input the value of a :");
int aq = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Input the value of b :");
int bq = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Input the value of c :");
int cq = Convert.ToInt16(Console.ReadLine());

dq = bq*bq-4*aq*cq;
if(dq == 0)
{
    Console.WriteLine("Both roots are equal.");
    xq1=bq/(2.0*aq);
    xq2 =xq1;
    Console.WriteLine("First Root Root1 = {0}", xq1 );
    Console.WriteLine("Second Root Root2 = {0}",xq2 );
}
else if (dq>0){
Console.WriteLine("Both roots are diffrent from each other");

xq1=(-bq+Math.Sqrt(dq))/(2*aq);
xq2=(-bq-Math.Sqrt(dq))/(2*aq);

Console.WriteLine("First Root Root1= {0}\n", xq1);
Console.WriteLine("Second Root Root2= {0}\n", xq2);
}
else Console.WriteLine("There is no solution");
//opgave 12
double rl, phy, che, ca, total, per;
string nm, div=null;

Console.WriteLine("Calculate the total, percentage and division to take marks of three subjects:");

Console.WriteLine("Input the Roll number of the student");
rl = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input the Name of the Student :");
nm = Console.ReadLine();

Console.WriteLine("Input The marks of physics");
phy = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input The marks of Chemistry");
che = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input the marks of computer application");
ca = Convert.ToDouble(Console.ReadLine());

total = phy+che+ca;
per = total/3.0;
if (per > 60)
div = "First";
else if (per <= 60)
    if (per >48)
    div= "Second";
else if (per <= 48)
    if(per >= 36)
    div = "Pass";
    else 
    div ="Fail";

Console.WriteLine("\nRoll No : {0}\nName of Student : {1}\n", rl,nm);
Console.WriteLine("marks in Physcis : {0}\nMarks in Chemistry : {1}\n Makrs in Computer Application : {2}\n",phy, che,ca);
 Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n",total,per,div);
 //opgave 13
 
  float temperature;
  Console.WriteLine("Input the temperature in degress celsius");
  temperature = Convert.ToInt64(Console.ReadLine());

  switch(temperature){
    case <0:
        Console.WriteLine("The weater is freezing");
    break;
    case > 0 and < 10:
       Console.WriteLine("The weater is very cold");
    break;
    case >= 10 and < 20:
       Console.WriteLine("The weater is normal Temp");
    break;
    case >= 20 and < 30:
       Console.WriteLine("The weater is hot");
    break;
    case >= 40:
       Console.WriteLine("The weater is very hot");
    break;
  }
// opgave 14 
double sidea, sideb, sidec;

Console.WriteLine("Check whether a triangle is Equilateral, Isosceles or Scalene:");
Console.WriteLine("Input side 1 of triangle");
sidea = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input side 2 of triangle");
sideb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input side 3 of triangle");
sidec = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(""+sidea + sideb + sidec);
if (sidea==sideb){
    if (sideb == sidec){
        Console.WriteLine("This is an equilateral triangle");
    }
}
else if (sidea == sideb  || sidea == sidec || sideb == sidec)
{
    Console.WriteLine("This is a isosceles triangle");
}
else 
{
    Console.WriteLine("This is a sclene triangle");
}
// opgave 15
Console.WriteLine("Input 3 diffrent angles");
double cornera, cornerb, cornerc;
Console.WriteLine("Input corner a");
cornera = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input corner b");
cornerb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input corner c ");
cornerc = Convert.ToDouble(Console.ReadLine());

switch(cornera + cornerb + cornerc){

case 180:
Console.WriteLine("The triangle is valid");
break;

case < 180:
Console.WriteLine("The triangle is invalid");
break;

case > 180:
Console.WriteLine("The triangle is invalid");
break;
}
*/
//opgave 16 
char alph;
Console.WriteLine("check whether the input alphabet is a vowel or not:");
Console.WriteLine("Input an Alphabet (A-Z or a-z) :");
alph = Convert.ToChar(Console.ReadLine().ToLower());
int le = alph;
if (le>= 48)
    if (le <= 57){
        Console.WriteLine("You entered a number, Please enter an alphabet.");
    }
else if (alph == 'a' || alph == 'i' || alph == 'o' || alph == 'u' || alph == 'e')
{
    Console.WriteLine("The alphabet is a vowel");
}
else 
{
Console.WriteLine("The alphabet is not a vowel");
}
 
