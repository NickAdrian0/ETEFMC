#include <iostream>
using namespace std;

float tHours,hours,days,weeks,months;

int main (){
    cout << "Ola, jovem Jedi. Sua calculadora de treinamento, bem vindo seja, hmmm.\nQuantas horas por dia treinas, dizer-me deve. Finais de semana, contar nao devemos.\nNo total, ja treinaste quantas horas, hmmm?\n";
    cin >> tHours;
    cout << "Por dia, quantas horas treinas, hmmm?\n";
    cin >> hours;  
    hours = hours * 5;
    tHours = 1000 - tHours;
    for (int i = 0; i < tHours; weeks++) i += hours;
    days = weeks * 5; 
    months = weeks / 4.5;
    cout << "Treinas, tu, " << hours << " horas por semana.\n";
    cout << "Mil horas alcancar, precisars. Tempo necessario, dizer eu posso:\n" << days << " dias, treinar sem descanso, deves.\nou " << weeks << " semanas, foco manter.\nou " << months << " meses, paciente ser, deves, hmmm.\nBoa sorte, jovem Padawan, em tua jornada, desejo eu.\n";
    system("pause");
}