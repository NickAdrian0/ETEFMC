int[] numInt = new int[10], Par = new int[10], Impar = new int[10];

Console.WriteLine("Bem vindo ao separador de numeros. Insira 10 números e lhe direi se são pares ou impares.");
for (int i = 0; i < numInt.Length; i++) {
    Console.WriteLine("Insira o " + (i+1) + "o número");
    numInt[i] = Convert.ToInt32(Console.ReadLine());
    if (numInt[i] % 2 == 0) Par[i] = numInt[i]; else Impar[i] = numInt[i];
}
Console.Write("Par:");
foreach(int i in Par) if(i != 0) Console.Write(" " + i);
Console.Write("\nImpar:");
foreach(int i in Impar) if(i != 0) Console.Write(" " + i); 