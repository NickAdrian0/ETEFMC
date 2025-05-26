#include <iostream>
#include <random>

using namespace std;
int inputValue, cont, rNum;

int main (){
    random_device numAleatorio ;
    uniform_int_distribution<> distribuicao(1,100);
    int valorInteiro = distribuicao(numAleatorio);
    cout << "Ola, seja bem vindo ao algoritmo de advinhaçao de numeros.\nDigite um numero entre 1 a 100 e eu lhe indicarei quando voce acertar e quantas tentativas foram necessarias." << endl;
    do {
        cout << "Digite seu palpite:" << endl;
        cin >> inputValue;
        cont++;

        if (inputValue > valorInteiro) cout << "Chutou alto! Tente um valor menor.\n";
        else if (inputValue < valorInteiro) cout << "Chutou baixo! Tente um valor maior.\n";
        else cout << "Voce acertou! O numero era " << inputValue << " e foram necessarias " << cont << " tentativas.\n";
    } while (inputValue != valorInteiro);
    system("pause");
}