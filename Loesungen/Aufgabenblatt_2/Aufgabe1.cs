//Aufgabe 1
//b)
Console.Write("Geben Sie die Anzahl der Studenten im Raum ein: ");
int anzahl = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= anzahl; i++)
{
    Console.WriteLine($"Rechner Nr.{i} wird hochgefahren");
    if (i % 15 == 0)
    {
        Console.WriteLine("Neue CPU hinzugefügt!");
    }
}
Console.WriteLine();
Console.WriteLine("Rechner herunterfahren?(Press Key)");
Console.ReadLine();
//b)
while (anzahl > 0)
{
    if (anzahl % 8 == 0) {
        Console.WriteLine($"Rechner Nr.{anzahl}: Alle Rechner werden heruntergefahren");
        anzahl = 0;
    }
    else
    {
        Console.WriteLine($"Rechner Nr.{anzahl} wird heruntergefahren");
        --anzahl;
    }
}
