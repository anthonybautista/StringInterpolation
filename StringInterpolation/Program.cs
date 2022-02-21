// See https://aka.ms/new-console-template for more information

using System;

var date = DateTime.Now;
var pi = Math.PI;
string year = date.ToString("yyyy");
string month = date.ToString("MM");
string day = date.ToString("dd");
string hour = date.ToString("hh");
string minute = date.ToString("mm");
string second = date.ToString("ss");
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("Date Formatting");
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine($"{date.ToString("MMMM dd, yyyy"),40}");
Console.WriteLine($"{date.ToString("yyyy.MM.dd")}");
Console.WriteLine($"Day {day} of " + date.ToString("MMMM, yyyy"));
Console.WriteLine($"Year: {year}, Month: {month}, Day: {day}");
Console.WriteLine($"{date.ToString("dddd"),10}");
Console.WriteLine($"{date.ToString("hh:mm tt"),10}{date.ToString("dddd"),10}");
Console.WriteLine($"h:{hour} m:{minute} s:{second}");
Console.WriteLine($"{date.ToString("yyyy.MM.dd.hh.mm.ss")}");
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("PI Formatting");
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("{0:C}", pi);
Console.WriteLine($"{pi.ToString("F3"),10}");