using System;
using System.Runtime.InteropServices;

class ProgramaMarvel
{
    static void Main () { menuPrincipal(); } 
    static void menuPrincipal()
    {
        string name1 = "", power1 = "", name2 = "", power2 = "", name3 = "", power3 = "", name4 = "", power4 = "", name5 = "", power5 = "", opcao = "";
        int points1 = 0, points2 = 0, points3 = 0, points4 = 0, points5 = 0, escolha1 = 0, escolha2 = 0, escolha3 = 0;
        bool heroSignedUp = false, teamChoosen = false;

        while (opcao != "4") {  
            Console.WriteLine("\nMenu =============\n1 - Cadastrar Herois\n2 - Selecionar Equipe\n3 - Exibir Equipe\n4 - Sair\n");
            opcao = Console.ReadLine();

        switch (opcao) {
            case "1":
                CadastrarHerois(ref name1, ref power1, ref name2, ref power2, ref name3, ref power3, ref name4, ref power4, ref name5, ref power5, ref points1, ref points2, ref points3, ref points4, ref points5); 
                heroSignedUp = true; 
                teamChoosen = false; break;
            case "2":
            if (!heroSignedUp) Console.WriteLine("\nCadastre os herois primeiro (opcao 1) antes de selecionar uma equipe."); 
                else selecionarEquipe(name1, power1, name2, name3, name4, name5, ref escolha1, ref escolha2, ref escolha3); 
                teamChoosen = true; break;
            case "3":
             if (!heroSignedUp) Console.WriteLine("\nCadastre os herois primeiro (opcao 1) antes de selecionar uma equipe."); else if (!teamChoosen) Console.WriteLine("\nSelecione uma equipe primeiro (opcao 2) antes de exibir.");
                else calcularPontuacaoTotal(name1, power1, name2, power2, name3, power3, name4, power4, name5, power5, points1, points2, points3, points4, points5, escolha1, escolha2, escolha3); break;
            case "4": Console.ReadLine(); break;
            default: Console.WriteLine("Opcao invalida, tente novamente."); break;      
            } 
        }
    }

    static void CadastrarHerois (ref string name1, ref string power1, ref string name2, ref string power2, ref string name3, ref string power3, ref string name4, ref string power4, ref string name5, ref string power5, ref int points1, ref int points2, ref int points3, ref int points4, ref int points5) {
        
            Console.WriteLine("\nCadastro de Herois: \nHeroi 1");
            do {Console.WriteLine("\nNome: "); name1 = Console.ReadLine(); if (string.IsNullOrWhiteSpace(name1)) Console.WriteLine("O nome nao pode ficar vazio. Por favor, tente novamente."); } while (string.IsNullOrWhiteSpace(name1));
            Console.Write("Poder: ");
            power1 = Console.ReadLine();
            while (true) {
            Console.Write("Pontuacao: ");
            if (int.TryParse(Console.ReadLine(), out points1)) break; else Console.WriteLine("Entrada invalida. Digite apenas numeros e tente novamente.");
            }

            Console.Write("\nHeroi 2");
            do {Console.WriteLine("\nNome: "); name2 = Console.ReadLine(); if (string.IsNullOrWhiteSpace(name2)) Console.WriteLine("O nome nao pode ficar vazio. Por favor, tente novamente."); } while (string.IsNullOrWhiteSpace(name2));
            Console.Write("Poder: ");
            power2 = Console.ReadLine();
            while (true) {
            Console.Write("Pontuacao: ");
            if (int.TryParse(Console.ReadLine(), out points2)) break; else Console.WriteLine("Entrada invalida. Digite apenas numeros e tente novamente.");
            }

            Console.Write("\nHeroi 3");
            do {Console.WriteLine("\nNome: "); name3 = Console.ReadLine(); if (string.IsNullOrWhiteSpace(name3)) Console.WriteLine("O nome nao pode ficar vazio. Por favor, tente novamente."); } while (string.IsNullOrWhiteSpace(name3));
            Console.Write("Poder: ");
            power3 = Console.ReadLine();
            while (true) {
            Console.Write("Pontuacao: ");
            if (int.TryParse(Console.ReadLine(), out points3)) break; else Console.WriteLine("Entrada invalida. Digite apenas numeros e tente novamente.");
            }

            Console.Write("\nHeroi 4");
            do {Console.WriteLine("\nNome: "); name4 = Console.ReadLine(); if (string.IsNullOrWhiteSpace(name4)) Console.WriteLine("O nome nao pode ficar vazio. Por favor, tente novamente."); } while (string.IsNullOrWhiteSpace(name4));
            Console.Write("Poder: ");
            power4 = Console.ReadLine();
            while (true) {
            Console.Write("Pontuacao: ");
            if (int.TryParse(Console.ReadLine(), out points4)) break; else Console.WriteLine("Entrada invalida. Digite apenas numeros e tente novamente.");
            }

            Console.Write("\nHeroi 5");
            do {Console.WriteLine("\nNome: "); name5 = Console.ReadLine(); if (string.IsNullOrWhiteSpace(name5)) Console.WriteLine("O nome nao pode ficar vazio. Por favor, tente novamente."); } while (string.IsNullOrWhiteSpace(name5));
            Console.Write("Poder: ");
            power5 = Console.ReadLine();
            while (true) {
            Console.Write("Pontuacao: ");
            if (int.TryParse(Console.ReadLine(), out points5)) break; else Console.WriteLine("Entrada invalida. Digite apenas numeros e tente novamente.");
            }
    }
    static void selecionarEquipe (string name1, string power1, string name2, string name3, string name4, string name5, ref int escolha1, ref int escolha2, ref int escolha3) {
            Console.WriteLine("\nHeróis Disponíveis =========");
            Console.WriteLine("1 - " + name1);
            Console.WriteLine("2 - " + name2);
            Console.WriteLine("3 - " + name3);
            Console.WriteLine("4 - " + name4);
            Console.WriteLine("5 - " + name5);

            do {
            Console.Write("\nEscolha o numero do 1o heroi a entrar na sua equipe: ");
            escolha1 = int.Parse(Console.ReadLine());
            if (escolha1 < 1 || escolha1 > 5)
            Console.WriteLine("Entrada invalida. Digite um numero entre 1 e 5."); } while (escolha1 < 1 || escolha1 > 5);

            do {
            Console.Write("Escolha o numero do 2o heroi a entrar na sua equipe: ");
            escolha2 = int.Parse(Console.ReadLine());
            if (escolha2 < 1 || escolha2 > 5)
            Console.WriteLine("Entrada invalida. Digite um numero entre 1 e 5."); } while (escolha2 < 1 || escolha2 > 5);

            do {
            Console.Write("Escolha o numero do 3o heroi a entrar na sua equipe: ");
            escolha3 = int.Parse(Console.ReadLine());
            if (escolha3 < 1 || escolha3 > 5)
            Console.WriteLine("Entrada invalida. Digite um numero entre 1 e 5."); } while (escolha3 < 1 || escolha3 > 5);
    }

    static void calcularPontuacaoTotal (string name1, string power1, string name2, string power2, string name3, string power3, string name4, string power4, string name5, string power5, int points1, int points2, int points3, int points4, int points5, int escolha1, int escolha2, int escolha3) {
        Console.WriteLine("\nEquipe escolhida ========");
            int Pontuacao(int escolha, int points1, int points2, int points3, int points4, int points5) { if (escolha == 1) return points1; else if (escolha == 2) return points2; else if (escolha == 3) return points3; else if (escolha == 4) return points4; else return points5; }
            for (int i = 1; i <= 3; i++){
            string nome = "", poder = "";
            int pontos = 0;
            int escolha = 0;

            if (i == 1) escolha = escolha1; else if (i == 2) escolha = escolha2; else escolha = escolha3;

            switch (escolha) {
                case 1: nome = name1; poder = power1; pontos = points1; break;
                case 2: nome = name2; poder = power2; pontos = points2; break;
                case 3: nome = name3; poder = power3; pontos = points3; break;
                case 4: nome = name4; poder = power4; pontos = points4; break;
                case 5: nome = name5; poder = power5; pontos = points5; break;
            } Console.WriteLine($"{i}: {nome} | Poder: {poder} | Pontuacao: {pontos}"); }
                
            int total = 0;
            total += Pontuacao(escolha1, points1, points2, points3, points4, points5);
            total += Pontuacao(escolha2, points1, points2, points3, points4, points5);
            total += Pontuacao(escolha3, points1, points2, points3, points4, points5);

            Console.WriteLine($"Pontuacao total da equipe: {total}");
    }
}