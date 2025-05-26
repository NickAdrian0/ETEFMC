using System.Formats.Asn1;
using System.Runtime.CompilerServices;

int returnHIS = 0,returnGAME = 0;
float PTD = 1;
double REMASTERED = 2;
bool INFO_HIS_BOOL = false, GAME_VER_BOOL = false, PTDbool = false, REMASTEREDbool = false;
char FIRSTCHOICE = 'l',GAME_VER = 'l';
string solaireCOVEMENT = "PACTO DOS GUERREIROS DO SOL",solaireSummon = "PEDRA SAGRADA BRANCA";

LOBBY();

void LOBBY () {
    INFO_HIS_BOOL = false; 
    GAME_VER_BOOL = false; 
    PTDbool = false; 
    REMASTEREDbool = false;
    returnHIS = 0;
    returnGAME = 0;
    Console.WriteLine("Ola! Seja bem vindo a WIKI do personagem SOLAIRE DE ASTORA.\nInsira a tecla 'A' para saber mais sobre a historia do personagem.\nPressione a tecla 'B' para saber mais sobre seus drops.\n");
    FIRSTCHOICE = Char.Parse(Console.ReadLine());

    if (FIRSTCHOICE != 'A' && FIRSTCHOICE != 'B') Console.WriteLine("A tecla inserida nao foi 'A' ou 'B', por favor, tente novamente.\n");

    if (FIRSTCHOICE == 'A') INFO_HIS_BOOL = true; 

       if (INFO_HIS_BOOL == true) {
        Console.WriteLine($"Solaire de ASTORA eh um personagem do jogo DARK SOULS: PREPARE TO DIE EDITION e DARK SOULS: REMASTERED, durante o jogo, ele mostra sua devocao ao sol ,sendo parte do {solaireCOVEMENT}.\nEle lhe concede o item {solaireSummon} que permite o jogador a sumonar ele quando humano, para dar assistencia em batalhas.\nDurante o jogo, Solaire procura o seu 'sol', e dependendo das acoes do jogador, pode encontra-lo ou nao.");
        Console.WriteLine("Insira a tecla '1' para RETORNAR ao comeco do programa.\nPressione qualquer outra tecla para encerrar o programa");
        returnHIS = int.Parse(Console.ReadLine());
        if (returnHIS == 1) LOBBY(); 
    }

    if (FIRSTCHOICE == 'B') GAME_VER_BOOL = true; 

    if (GAME_VER_BOOL == true) {
        Console.WriteLine($"Insira o valor '{PTD}' para ver sobre DARK SOULS:PREPARE TO DIE.\nInsira o valor '{REMASTERED}' para ver sobre DARK SOULS:REMASTERED.");
        GAME_VER = Char.Parse(Console.ReadLine());
        if (GAME_VER == '1') {
        PTDbool = true;
        } else if (GAME_VER == '2') REMASTEREDbool = true; else Console.WriteLine("A tecla inserida nao foi '1' ou '2', por favor, tente novamente.\n");
        if (PTDbool = true) {
            Console.WriteLine("Na versao PREPARE TO DIE de DARK SOULS. SOLAIRE DE ASTORA dropa 1 humanidade ao morrer");
            Console.WriteLine("Insira a tecla '1' para RETORNAR ao comeco do programa.\nPressione qualquer outra tecla para encerrar o programa");
            returnGAME = int.Parse(Console.ReadLine());
            if (returnGAME == 1) LOBBY();
        }
        if (REMASTEREDbool = true) {
            Console.WriteLine("Na versao REMASTERED de DARK SOULS. SOLAIRE DE ASTORA dropa 1 humanidade ao morrer, e seu set de armadura, 'Armadura do SOL'");
            Console.WriteLine("Insira a tecla '1' para RETORNAR ao comeco do programa.\nPressione qualquer outra tecla para encerrar o programa");
            returnGAME = int.Parse(Console.ReadLine());
            if (returnGAME == 1) LOBBY();
        }
    }
}