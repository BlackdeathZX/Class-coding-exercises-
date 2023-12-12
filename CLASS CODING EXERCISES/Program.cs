// See https://aka.ms/new-console-templatea for more information
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System;

Console.WriteLine("Write your input here:");
double x = Convert.ToDouble(Console.ReadLine() );
//sleep
System.Threading.Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Your input is: " + x);
Console.WriteLine("The square root of your input is: " + Math.Sqrt(x));
Console.WriteLine("The squared input is: " + Math.Pow(x,2));
System.Threading.Thread.Sleep(1200);
Console.Clear();
return 0; 