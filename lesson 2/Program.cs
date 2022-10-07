
using System;
using System.Security.Cryptography.X509Certificates;

var x =2;
byte a = (byte)Math.Pow(x, 3);
sbyte b = (sbyte)(a* (-6)); 

short c = (short)Math.Pow(x, 2);
ushort d = (ushort) (c*5);

var f =(int) (x*-10);

long g=b+d+f+15;
Console.WriteLine(g);

double doublex = -25;
doublex=Math.Abs(doublex);
double z= Math.Sin(doublex);
Console.WriteLine(z*doublex);

double q=Math.PI*2*x;
Console.WriteLine(q);


int m = 7;
int n = Math.Max (x, m);
Console.WriteLine(n);


//var dt1 = DateOnly.FromDateTime(DateTime.Now);
//DateOnly dt1 = new DateOnly.FromDateTime(DateTime.Now);
//DateTime dt2 = new DateTime(2023,1,1);
//DateOnly do1 = new DateOnly(2023,1,1);
//DateOnly dt3=dt1-do1;
//Console.WriteLine($"До нового года, {dt3}");
//Console.WriteLine(DateOnly.FromDateTime(do1-dt1));

var dt1 = DateOnly.FromDateTime(DateTime.Now);
var dt2 = new DateOnly(2022,1,1);
//Console.WriteLine(dt1-dt2);
DateTime dt3 = new DateTime(2022, 10, 7) ;
DateTime dt4 = new DateTime(2023,1,1);
DateTime dt5 = new DateTime(2022, 1, 1);
//DateOnly someDate = FromDateTime(d4);
//DateTime dt5 = dt3 - dt4;
Console.WriteLine($"До нового года осталось, {dt4-dt3}") ;
Console.WriteLine($"С нового года прошло, {dt3-dt5}");
//Console.WriteLine(dt5.DayOfWeek);