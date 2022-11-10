//Aufgabe 3
int zahl = Convert.ToInt32(Console.ReadLine());
int stelle = 0;
while(zahl > 0)
{
    int hintersteStelle = zahl % 10;
    Console.WriteLine(hintersteStelle * Math.Pow(10, stelle));
    zahl = zahl / 10;
    ++stelle;
}
