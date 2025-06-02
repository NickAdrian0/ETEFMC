#include <iostream>
#include <vector>
#include <string>
#include <stdlib.h>
using namespace std;

vector<int>numInt(10);
int data_Frequency = 0, numFind;
string data_Position, tempData;

int main() {
    cout << "Bem vindo ao localizador de números.\nInsira 10 números inteiros, depois, cheque a existencia de um número no bando de dados.\nSe existir, lhe informarei sua frequencia e posição." << endl;
    for (int i = 0; i < numInt.size(); i++){
        cout << "Insira o " << i + 1 << "o número." << endl;
        cin >> numInt[i];
    }
    cout << "Insira o número que deseja procurar" << endl;  
    cin >> numFind;
    for (int i = 0; i < numInt.size(); i++){
        if (numFind == numInt[i]) {
            data_Frequency++;
            tempData = to_string(i + 1);
            data_Position = data_Position + " " + tempData;
        }
    }if (data_Frequency != 0) { 
        if (data_Frequency != 1) cout << "O número está presente no banco de dados. Ele aparece " << data_Frequency << " vezez, nas posições:" << data_Position;
        else cout << "O número está presente no banco de dados. Ele aparece "<< data_Frequency << " vez, na posição" << data_Position;      
    } else cout << "O número não está presente no banco de dados"; 
    exit(0);   
}