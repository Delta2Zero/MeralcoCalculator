using System;
using System.Threading;

public static class GlobalMembers
{
	static int Main()
	{
	//	double baseW = 0;
	//	double hour = 0;
        Console.Write("***Meralco electricity***\n***consumption Calculator***\n**CONSOLE Version 1.0.05**\n*Written by: DeltaTwoZero*");
		Console.Write("\n\nInput device wattage \n:");
		double baseW = Double.Parse(Console.ReadLine())
		;
		Console.Write("\nInput device usage time \n:");
		double hour = Double.Parse(Console.ReadLine())
		;

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

	//    cout << "\nTotal without tax: " << GTSDS << "\nTotal tax: " << tax << "\nTotal UC and FITA: " << UCT << "\n" << endl;

		Console.Write("\nuser input review:\n");
		Console.Write(baseW);
		Console.Write("watts\n");
		Console.Write(hour);
		Console.Write("hour\n");
		Console.Write("Total kilowatt hour per day: ");
		Console.Write(UserW);
		Console.Write("kWh/day");
		Console.Write("\nTotal amount: ");
		Console.Write("{0}PHP",AllC);
		Console.Write("\n");
		
		
		Console.Write("How many seconds before closing app\n");
		double x = Double.Parse(Console.ReadLine())
		;
		do
		{
			Thread.Sleep(1000);
			Console.WriteLine("{0} seconds to close", x);
			x--;
		}
		while(x!=0);
		Console.Write("\nApplication done processing please exit the app...");
		return 0;
	}
}