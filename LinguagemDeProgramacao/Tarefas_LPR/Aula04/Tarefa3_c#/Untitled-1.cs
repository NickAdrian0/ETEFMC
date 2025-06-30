Console.WriteLine("Escolha uma classe de personagem:\n1 - Guerreira\n2 - Mago\n3 - Arqueira");
string choice = Console.ReadLine();
switch (choice) 
{
    case "1":
        Console.WriteLine("Voce escolheu a classe Guerreira;\nHabilidades: Ataque Pesado, Defesa Total.");
        break;
    case "2":
        Console.WriteLine("Voce escolheu a classe Mago;\nHabilidades: Bola de Fogo, Escudo de Gelo.");
        break;
    case "3":
        Console.WriteLine("Voce escolheu a classe Arqueira;\nHabilidades: Flecha Precisa, Disparo Triplo.");
        break;
    default:
        Console.WriteLine("Um erro ocorreu, escolha um número entre 1 e 3 e tente novamente.");
        break;
}