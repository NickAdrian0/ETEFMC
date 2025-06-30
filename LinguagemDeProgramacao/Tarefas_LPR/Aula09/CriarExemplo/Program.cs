using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

string output = "";
List<int> num = new List<int> { 1, 2, 3, 4, 5 };
Output2();

num.Add(4);
Output2();

num.Insert(2, 7);
Output2();

bool Has_ate = num.Contains(8);
Console.WriteLine(Has_ate);
Console.WriteLine("\n");

int four_count = 0;
List<int> num4 = new List<int>();
foreach (int i in num) if (i > 4) {
    four_count++;
    num4.Add(i);
} Console.WriteLine(four_count);
Output2();

int three_count = 0;
foreach (int i in num) if (i == 3)  three_count++;
Console.WriteLine(three_count);
Output2();

num.Remove(2);
Output2();

while (num.Contains(4)) num.Remove(4);
Output2();

void Output2 ()
{
    foreach (int i in num) output += (i + " ");
    Console.WriteLine(output);
    output = "";
    Console.WriteLine("\n");
}