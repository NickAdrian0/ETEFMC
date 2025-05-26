#include <iostream>
#include <cstdlib>

using namespace std;

void returntoLobby ();

void sillypeopleProof () {
    if (cin.fail()) {
        cout << "O caracter inserido eh invalido. Insira um numero e tente novamente";
        exit(0);
    }
}

void Aritmetica () {
    int qnum = 0, num = 0, sumnum = 0, total = 0;
    cout << ("Bem vindo a calculadora de media aritimetica de numeros pares.\nPor favor, insira a quantidade de numeros que deseja.\n");
    cin >> qnum;
    sillypeopleProof();
    if (qnum != 0 || qnum > 0) {
        cout << "Agora, digite os numeros que deseja fazer a media.\n";
        for (int i = 0; i < qnum; i++)
        {
            cin >> num;
            if (num % 2 == 0) {
                total += num;
                sumnum++;
            }
        } 
        if (sumnum == 0) cout << "Apenas numeros impares foram digitados, reinicie o programa e tente novamente.\n";
        cout << "A media da soma total dos numeros pares inseridos equivale a " << (total /= sumnum) << ".\n";
    } else cout << "Os numeros digitados sao invalidos, reinicie o programa e tente novamente.\n";
    returntoLobby();
}

void ImparesMultiplos () {
    int sum = 0;
    string confirm = "";
    cout << ("Bem vindo a calculdora de numeros impares multiplos de 3 entre 50 a 500\nPara confirmar o uso do programa, pressione a tecla 'Y' e confirme.\n");
    cin >> confirm;
    if (confirm == "Y") {
        for (int i = 50; i <= 500; i++) if (i % 3 == 0 && i % 2 != 0) sum += i;
        cout << ("A soma dos numeros impares multiplos de 3 entre 50 a 500 equivale a: ") << sum << ".\n";
    } else cout << "A tecla 'Y' nao foi inserida corretamete. Tente novamente ou feche o aplicativo se este resultado era esperado.\n";
    returntoLobby();
}

void QuadradoNumerico () {
    int num = 0, soma = 0;
    string sNum = "";
    cout << "Ola, seja bem vindo a calculadora de soma de digitos de um quadradro numerico\nIrei elevar o numero inserido, e somar seus caractres\nPor favor, insira o numero desejado: \n";
    cin >> num;
    sillypeopleProof();
        num *= num;
        sNum = to_string(num);
        for (char digit : sNum) soma += digit - '0';
        cout << "A soma dos digitos de elevado ao quadrado equivale a " << soma << ".\n";
    returntoLobby();
}   

void Lobby () {
    int calc = 0;
    cout << "Ola, bem vindo ao programa de calculadoras gerais, existem tres tipo de calculadora neste programa, sao elas:\n1 - Calculadora de media aritmetica\n2 - Calculadora de soma de digitos de um quadradro numerico.\n3 - Calculadora de numeros impares multiplos de 3 entre 50 a 500.\nPor favor, digite o numero da calculadora que deseja usar:\n";
    cin >> calc;
    sillypeopleProof();
    if (calc <= 0 && calc > 3) cout << "O numero inserido eh invalido, reinicie o programa e tente novamente"; else {
    switch (calc)
        {
    case 1:
        Aritmetica();
        break;
    case 2:
        QuadradoNumerico();
        break;
    case 3:
        ImparesMultiplos();
        break;
        }
    }
}

void returntoLobby () {
    int returntoLobby = 0;
    cout << "Pressione '1' para voltar para a tela inicial, pressione qualquer outra tecla e confirme para fechar o programa\n";
    cin >> returntoLobby;
    if (returntoLobby == 1) Lobby(); else exit(0);
}

int main () {
    Lobby();
}