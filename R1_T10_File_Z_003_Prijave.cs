using System;
using System.IO;

class Program
{
    static string putanja = "Prijave.txt";          // @"D:\Folder\Podfolder\Prijave.txt";
    static void Main()
    {
        if (!File.Exists(putanja)) 
            Console.WriteLine("Ne postoji datoteka: " + putanja);
        else
            Obrada();
    }

    static void Obrada()
    {
        int OD = ucitaj_HMS();
        int DO = ucitaj_HMS();
        string racunar = Console.ReadLine();
        StreamReader f = new StreamReader(putanja);
        string sRed = f.ReadLine();
        while(sRed != null)
        {
            string[] sLin = sRed.Split(',');
            int h = int.Parse(sLin[0]);
            int m = int.Parse(sLin[1]);
            int s = int.Parse(sLin[2]);
            string k = sLin[3];
            string r = sLin[4];
            int v = sekunde(h, m, s);
            if (v >= OD && v <= DO && r == racunar)
                Console.WriteLine(k);                   // Proveriti i eventualno dopuniti ili korigovati
            sRed = f.ReadLine();
        }
        f.Close();
    }
    static int ucitaj_HMS()
    {
        string[] sLin = Console.ReadLine().Split();
        int h = int.Parse(sLin[0]);
        int m = int.Parse(sLin[1]);
        int s = int.Parse(sLin[2]);
        return sekunde(h, m, s);
    }
    static int sekunde(int h, int m, int s) { return 3600 * h + 60 * m + s; }
}