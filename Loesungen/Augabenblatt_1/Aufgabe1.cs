//a)
int schrauben = 5000;
int muttern = 4000;
int unterlagsScheiben = 8000;
string beschreibung1 = "Schrauben mit 7mm Schraubkopf";
string beschreibung2 = "Muttern mit 5mm Innengewinde";
string beschreibung3 = "unterlagsScheiben mit 6mm Loch";
Console.WriteLine(beschreibung1 + "; Stück: " + schrauben);
Console.WriteLine(beschreibung2 + "; Stück: " + muttern);
Console.WriteLine(beschreibung3 + "; Stück: " + unterlagsScheiben);
//b)
Console.WriteLine("Aufgabe b aktivieren?(Press key)");
Console.ReadLine();
Console.Clear();
Console.WriteLine($"{beschreibung1}; Stück: { schrauben} ");
Console.WriteLine($"{beschreibung2}; Stück: {muttern} ");
Console.WriteLine($"{beschreibung3}; Stück: {unterlagsScheiben} ");
//c)
Console.WriteLine("Aufgabe c aktivieren?(Press key)");
Console.ReadLine();
Console.Clear();
Console.WriteLine("Dateipfad: \"C:\\benutzer\\norbert\\arbeit\\unterlagen\"");
