        int num, soma = 0;
        Console.Write("Ola, seja bem vindo a calculadora de soma de digitos de um quadradro numerico\nIrei elevar o numero inserido, e somar seus caractres\nPor favor, insira o numero desejado:\n");
        num = int.Parse(Console.ReadLine());
        num *= num;
        string sNum = num.ToString();
        foreach (char digit in sNum) soma += int.Parse(digit.ToString());
        Console.WriteLine($"A soma dos dígitos de {num} elevado ao quadrado equivale a {soma}");
        Console.ReadLine();