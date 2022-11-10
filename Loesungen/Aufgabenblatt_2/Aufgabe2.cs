//Aufgabe 2
//a)
Console.Write("Waehlen Sie ein Passwort: ");
string passwort = Console.ReadLine();
Console.Clear();
Console.Write("Geben Sie ihr Passwort ein: ");
string eingabe = Console.ReadLine();
bool passwortRichtig = passwort == eingabe;

if (passwortRichtig)
{
    Console.WriteLine("Willkommen! Sie haben sich erfolgreich eingeloggt.");
}
else
{
    Console.WriteLine("Passwort wurde falsch eingegeben!"
);
}

//b)
Console.WriteLine("Aufgabe b aktivieren?(Press Enter):");
Console.ReadLine();
Console.Clear();

Console.Write("Waehlen Sie ein Passwort: ");
passwort = Console.ReadLine();
Console.Clear();
Console.Write("Geben Sie ihr Passwort ein: ");
eingabe = Console.ReadLine();
passwortRichtig = passwort == eingabe;

do
{
    if (passwortRichtig)
    {
        Console.WriteLine("Willkommen! Sie haben sich erfolgreich eingeloggt.");
    }
    else
    {
        Console.WriteLine("Passwort wurde falsch eingegeben!");
        Console.Write("geben Sie Ihr Passwort bitte erneut ein: ");
        eingabe = Console.ReadLine();
        passwortRichtig = passwort == eingabe;
    }
} while (!passwortRichtig);
Console.WriteLine("Willkommen! Sie haben sich erfolgreich eingeloggt.");

//c)
Console.WriteLine("Aufgabe c aktivieren?(Press Enter):");
Console.ReadLine();
Console.Clear();

Console.Write("Waehlen Sie ein Passwort: ");
passwort = Console.ReadLine();
Console.Clear();
Console.WriteLine($"Versuche übrig: 3");
Console.Write("Geben Sie ihr Passwort ein: ");
eingabe = Console.ReadLine();
passwortRichtig = passwort == eingabe;
int versuche = 3;
do
{
    if (passwortRichtig)
    {
        Console.WriteLine("Willkommen! Sie haben sich erfolgreich eingeloggt.");
    }
    else
    {
        Console.WriteLine("Passwort wurde falsch eingegeben!");
        --versuche;
        Console.WriteLine($"Versuche übrig: {versuche}");
        Console.Write("geben Sie Ihr Passwort bitte erneut ein: ");
        eingabe = Console.ReadLine();
        passwortRichtig = passwort == eingabe;
    }
} while (!passwortRichtig && versuche != 0);
if (versuche == 0)
{
    Console.WriteLine("keine weiteren Versuche mehr. Login gesperrt");
}
else
{
    Console.WriteLine("Willkommen! Sie haben sich erfolgreich eingeloggt.");
}
