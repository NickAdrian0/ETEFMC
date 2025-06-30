        int sum = 0;
        Console.WriteLine("Bem vindo a calculdora de numeros impares multiplos de 3 entre 50 a 500\nPara confirmar o uso do programa, pressione a tecla 'Y' e confirme");
        string confirm = Console.ReadLine();
        if (confirm == "Y") {
            for (int i = 50; i <= 500; i++) if (i % 3 == 0 && i % 2 != 0) sum += i;
            Console.WriteLine($"A soma dos números impares multiplos de 3 entre 50 a 500 equivale a: {sum}\n");
        } else Console.WriteLine("A tecla 'Y' nao foi inserida corretamete. Tente novamente\n");
        Console.ReadLine();