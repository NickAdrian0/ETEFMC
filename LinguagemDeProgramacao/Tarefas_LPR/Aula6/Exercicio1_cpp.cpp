#include <iostream>

using namespace std;
int num;
 
int numReverse(int& number) {
    int reversenum = 0;
    while (number > 0) {
        int numlast = number % 10;
        reversenum = reversenum * 10 + numlast;
        number /= 10;
    }  return reversenum;
}

int main () {
    cout << "Ola, seja bem vindo ao algoritmo reversor de numeros.\nDigite um numero e indicarei seu reverso:\n";
    cin >> num;
    num = numReverse(num);
    cout << "Seu numero invertido equivale a " <<  num << ".\n";
    system("pause");
}