using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<string, int> Nomes_Idades = new Dictionary<string, int>();
        Console.WriteLine("Olá, bem vindo a calculadora de idades variadas, insira idades de pessoas e te direi fatos sobre elas.\n");
        Console.WriteLine("Por favor, insira a quantidade de pessoas e então, os dados de cada uma.");
        string temp1 = "", temp3 = "";
        int temp2, somaIdades = 0, mediaIdades, b = int.Parse(Console.ReadLine());
        int[] Idades = new int[b];
        for (int i = 0; i < b; i++)
        {
            Console.WriteLine("nome da" + i + "a pessoa");
            temp1 = Console.ReadLine();
            Console.WriteLine("número da" + i + "a pessoa");
            temp2 = int.Parse(Console.ReadLine());
            Nomes_Idades.Add(temp1, temp2);
            somaIdades += temp2;
            Idades[i] = Nomes_Idades.Values[temp2];
        }
        mediaIdades = somaIdades / b;
        for (int i = 0; i < b; i++)
        {
            if (Idades[i] > mediaIdades) Console.WriteLine($"{Nomes_Idades.Keys}\n");
            for (int j = 0; j < b; j++)
            {
                if (Idades[i] > Idades[j])
                {
                    temp3 = Idades[i];
                }
            }
        }

    }
}
