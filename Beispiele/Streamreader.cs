
static void Main(string[] args)
{
    BestFit();
}
public static void BestFit()//Diese Funktion liest raeume aus einer Datei ein und gibt den Typen des Raums auf der Konsole aus.
{
    StreamReader s = new StreamReader("raeume.txt");//hier den Pfad zur Datei einsetzen
    String zeile = s.ReadLine();
    while(zeile != null)
    {

        String[] teileZeile = zeile.Split(';');
        String typ = teileZeile[1];
        Console.WriteLine(typ);
        zeile = s.ReadLine();
    }
    s.Close();
}
