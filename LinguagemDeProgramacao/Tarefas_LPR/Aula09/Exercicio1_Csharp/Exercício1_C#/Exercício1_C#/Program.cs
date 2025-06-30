using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Olá, seja bem vindo ao organizador crescente de nomes. \nPor favor, insira a quantidade de nomes que deseja listar");
string output1 = "", input1;
int name_qant;
List<string> name_list = new();
input1 = Console.ReadLine();
Int32.TryParse(input1, out name_qant);
string[] names = new string[name_qant];
for (int i = 0; i < name_qant; i++)
{
    Console.WriteLine("Insira o " + (i + 1) + "o nome");
    names[i] = Console.ReadLine();
    name_list.Add(names[i]);
}

List<string> name_final = name_list.OrderBy(name_list => name_list.Length).ToList();
int[] name_found = new int[name_final.Count];
for (int i = 0; i < name_list.Count; i++)
{
    for (int j = 0; j < name_list.Count; j++)
    {
        if (names[i].Length == names[j].Length)
        {
            name_final.Remove(names[i]);
            name_final.Add(names[i]);
            name_found[i]++;
        }
    }
    int temp = name_final.Count - name_found[i];
    for (int k = 0; k < temp; k++){
        output1 += (name_final[k+temp] + " ");
        Console.WriteLine(output1);
        output1 = "";
        Console.WriteLine("\n");
    }
}




