int X;

Console.WriteLine("Bem vindo a calculadora de numeros pares. \nInsira o seu numero e eu lhe direi se ele é par ou impar");
X = int.Parse(Console.ReadLine());
if (X % 2 == 0) Console.WriteLine("Seu numero eh par");
else Console.WriteLine("Seu numero eh impar");
