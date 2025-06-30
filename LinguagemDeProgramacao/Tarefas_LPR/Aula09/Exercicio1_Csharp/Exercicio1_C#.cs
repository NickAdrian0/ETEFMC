using System;
using System.Collections.Generic;

Console.WriteLine("Olá, seja bem vindo ao organizador crescente de nomes. \nPor favor, insira a quantidade de nomes que deseja listar");
string output;
List<string> name_list = new();
int name_qant = Console.Readline();
int[] names = new int[name_qant];
for (int i = 0; i < name_qant; i++)
{
    Console.WriteLine("Insira o " + (i + 1) + "o nome");
    names[i] = Console.Readline();
    name_list.Add(names[i]);
}
name_list.Sort();
Output();

void Output()
{
    foreach (string s in names) output += (s + " ");
    Console.WriteLine(output);
    output = "";
    Console.WriteLine("\n");
}

