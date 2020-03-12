#include <iostream>
#include <unistd.h>

using namespace std;

int main()
{
    double baseW;
    double hour;
    
    cout << "Input device wattage \n:";
    cin >> baseW;
    cout << "\nInput device usage time \n:";
    cin >> hour;
    
    double UserW = baseW * hour / 1000;
    
    double GenC = UserW * 4.9039;
    double ACRMR = UserW * 0.0146;
    double ICERA = UserW * -0.0018;
    double TransC = UserW * 0.6656;
    double SysLos = UserW * 0.4147;
    double DisChar = UserW * 1.0012;
    double FMC = 5.00;
    double MC = UserW * 0.3377;
    double FSC = 16.73;
    double SC = UserW * 0.5085;
    
    double GTSD = GenC + ACRMR + ICERA + TransC + SysLos + DisChar + FMC + MC + FSC + SC;
    double LD = GTSD * -0.2;
    double GTSDS = GTSD + LD;
    double distri = DisChar + FMC + MC + FSC + SC;
  //  cout << "Total without subsidies: " << GTSD << "\nTotal with subsidies: " << GTSDS << endl;
    
 //   cout << "Generation: \n" << GenC << " " << " " << ACRMR << " " << ICERA << " " << TransC << " " << SysLos << " " << DisChar << " " << FMC << " " << MC << " " << FSC << " " << SC << endl;
    
    double LFtax = GTSDS * 0.0075;
    double GCtax = GenC * 0.1094;
    double ACRMtax = ACRMR * 0.078;
    double ICERAtax = ICERA * -0.1733;
    double TransCtax = TransC * 0.1011;
    double SysLostax = SysLos * 0.1084;
    double DisChartax = distri * 0.12;
    double Subo = -15.30;
    double tax = LFtax + GCtax + ACRMtax + ICERAtax + TransCtax + SysLostax + DisChartax + Subo;
    
  //  cout << "\ntax 1: " << LFtax << "\ntax 2:  " << GCtax << "\ntax 3: " << ACRMtax << "\ntax 4: " << ICERAtax << "\ntax 5: " << TransCtax << "\ntax 6: " << SysLostax << "\ntax 7: " << DisChartax << "\ntax 8: " << Subo << endl;
    
  //  cout << "\nTotal tax: " << tax << endl;
    
    double Miss = UserW * 0.1561;
    double EF = UserW * 0.0025;
    double NPCSCC = UserW * 0.0543;
    double NPCSD = UserW * 0.0428;
    double FITA = UserW * 0.2226;
    double UCT = Miss + EF + NPCSCC + NPCSD + FITA;
    
 //   cout << "\nTotal UC and FiT-ALL: " << UCT << endl;
    
    double bp = 1 * 16.5392;
    
    double AllC = GTSDS + tax + UCT + bp;
    
//    cout << "\nTotal without tax: " << GTSDS << "\nTotal tax: " << tax << "\nTotal UC and FITA: " << UCT << "\n" << endl;;
    
    cout << "\nuser input " << baseW << "watts " << hour << "hour " << "= " << UserW << "kWh" << "\n total so far :" << AllC << endl;

    int x = 0;

    cout << "\n\nType how may seconds before closing..." << endl; 
    cin >> x;
    cout << "\n" << x << " seconds before closing\n" << endl;

do
{
sleep(1);
cout << x << " seconds to close" << endl;
x--;
}
while(x!=0);
return 0;
}