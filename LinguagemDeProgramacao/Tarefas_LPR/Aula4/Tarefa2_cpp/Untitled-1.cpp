#include <iostream>

using namespace std;

int A, B;

int main (){
    cout << "Ola! Seja bem vindo a calculadora de numeros multiplos, \nInsira dois valores e lhe direi se sao multiplos ou nao\n";
    cin >> A >> B;
    if (A % B == 0 || B % A == 0) cout << "O numero " << A << " eh multiplo de " << B << " assim como " << B << " eh multiplo de " << A <<endl;
    else cout << "Os numeros " << A << " e " << B << " nao sao multiplos entre si" << endl;
}