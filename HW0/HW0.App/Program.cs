
using System.Runtime.InteropServices;
using HW0.App;

Console.WriteLine("=------------- SENG 116 - HW0 ---------");
Console.WriteLine($".NET runtime : {RuntimeInformation.FrameworkDescription}");
Console.WriteLine($"Operating sys. : {RuntimeInformation.OSDescription}");

Console.Write("Full name   : ");
string name = Console.ReadLine() ?? "";

Console.Write("Student number : ");
long number = long.Parse(Console.ReadLine() ?? "");//.PARSE UMGING TO TRANSFER STRINGS TO INT YO USING IT IN CALCULATION

var card = new StudentCard(name, number); //OBJECT OF STUDENTCARD 
Console.WriteLine(card.Summary());//USING METHOD

int digitSum = NumberTools.DigitSum(number);
Console.WriteLine($"Digit sum of the student number : {digitSum}");
Console.WriteLine($"Is the digit sum prime? : {NumberTools.IsPrime(digitSum)}");
Console.WriteLine($"Primes up to the digit sum : {NumberTools.CountPrimes(digitSum)}");
