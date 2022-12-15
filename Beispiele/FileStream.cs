static void Main(string[] args)
  {
      BestFit();
  }
  public static void BestFit()//Diese Funktion liest raeume aus einer Datei ein und gibt den Typen des Raums auf der Konsole aus.
  {
      FileStream fs1 = new FileStream("raeume.txt", FileMode.Open);//hier den Pfad zur datei einsetzen
      StreamReader s = new StreamReader(fs1);
      String zeile = s.ReadLine();
      while (!s.EndOfStream)
      {

          String[] teileZeile = zeile.Split(';');
          String typ = teileZeile[1];
          Console.WriteLine(typ);
          zeile = s.ReadLine();
      }
      fs1.Close();
      s.Close();
  }
