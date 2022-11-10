//Aufgabe 2
//a)
//Die Eingaben der Nutzer sind Strings also Texte. Sie werden deshalb konkateniert statt addiert

//b)
Console.Write("Wieviele Schrauben liegen im Lager: ");
int lagerSchrauben = Convert.ToInt32(Console.ReadLine());
Console.Write("Gebe an Wie viele Schrauben du kaufen möchtest: ");
int kaufSchrauben = Convert.ToInt32(Console.ReadLine());
int schraubenGesamt = lagerSchrauben + kaufSchrauben;
Console.WriteLine("Anzahl der Schrauben nach dem Kauf: " + schraubenGesamt);

//c)
Console.WriteLine("Aufgabe b) aktivieren? (Press key)");
Console.ReadLine();
Console.Clear();
Console.Write("Wieviele Schrauben liegen im Lager: ");
lagerSchrauben = Convert.ToInt32(Console.ReadLine());
Console.Write("Gebe an Wie viele Schrauben du kaufen möchtest: ");
kaufSchrauben = Convert.ToInt32(Console.ReadLine());
schraubenGesamt = lagerSchrauben + kaufSchrauben;
Console.WriteLine("Anzahl der Schrauben nach dem Kauf: " + schraubenGesamt);
Console.WriteLine("Anzahl der Stabmixer: " + schraubenGesamt/10);
Console.WriteLine("Rest an Schrauben: " + schraubenGesamt % 10);
