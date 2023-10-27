// https://www.google.com/search?q=c%23+console+app+read+raw+data+from+public+web+address&rlz=1C1MSIM_enRS784RS784&oq=c%23+console+app+read+raw+data+from+public+web+address&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIGCAEQRRg60gEKNDc2MzZqMGoxNagCALACAA&sourceid=chrome&ie=UTF-8
// https://stackoverflow.com/questions/22226359/how-to-get-input-from-website-to-net-console-application
// https://petlja.org/kurs/11171/9/1332
// https://petlja.org/kurs/11171/7/1326#char
// https://learn.microsoft.com/en-us/dotnet/api/system.net.webclient.encoding?view=net-7.0
// https://stackoverflow.com/questions/7137165/webclient-downloadstring-results-in-mangled-characters-due-to-encoding-issues-b
// https://onlinegdb.com/sz7s9yyBu

using System;
using System.Net;       // zbog WebClient
// using System.IO;

class Zadatak
{
    static void Main()
    {
        // System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("sr-SP-Cyrl", false);  // using System.Globalization;
        // Console.InputEncoding = System.Text.Encoding.Unicode;
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        string myUrl = "https://raw.githubusercontent.com/draganilicnis/R4_T01_DB_SQL_Lite_dnevnik_db/main/ucenik.csv";

        using (WebClient webClient = new WebClient())
        {
            // webClient.Encoding = System.Text.Encoding.Unicode;
            webClient.Encoding = System.Text.Encoding.UTF8;
            string s = webClient.DownloadString(myUrl); 
            Console.WriteLine(s);
        }

        // var ucenik = new System.Net.WebClient().DownloadString(myUrl);
        // Console.WriteLine(ucenik);
        // System.Text.Encoding.UTF8.GetString();

        //myUrl = "https://raw.githubusercontent.com/draganilicnis/R4_T01_DB_SQL_Lite_dnevnik_db/main/ocena.csv";
        //var ocena = new System.Net.WebClient().DownloadString(myUrl);
        //Console.WriteLine(ocena);

        //myUrl = "https://raw.githubusercontent.com/draganilicnis/R4_T01_DB_SQL_Lite_dnevnik_db/main/predmet.csv";
        //var predmet = new System.Net.WebClient().DownloadString(myUrl);
        //Console.WriteLine(predmet);

        //myUrl = "https://raw.githubusercontent.com/draganilicnis/R4_T01_DB_SQL_Lite_dnevnik_db/main/izostanak.csv";
        //var izostanak = new System.Net.WebClient().DownloadString(myUrl);
        //Console.WriteLine(izostanak);

        // string myUrl = "";
        //myUrl = "https://raw.githubusercontent.com/draganilicnis/ConsoleApp15/master/ConsoleApp15/Program.cs";
        //myUrl = "https://petlja.org/biblioteka/r/Zbirka/trening";
        //myUrl = "https://raw.githubusercontent.com/draganilicnis/ConsoleApp14/master/%C5%A0kole%2020230921%201017.csv?token=GHSAT0AAAAAACITXVCSIDBKKSXHWCIVXKQOZJTOPDQ";
        //myUrl = "https://raw.githubusercontent.com/draganilicnis/Privatno/main/Neki.txt?token=GHSAT0AAAAAACITXVCS6B7FVNBA6UQNOXXEZJTOX7Q";
        //myUrl = "https://petlja.org/kurs/11162/1/6371";         // NIJE KORISNO (otvara incijalnu stranu na Petlja.org za prijavljivanje)
        //myUrl = "https://www.mojasrednjaskola.gov.rs/Students"; // NIJE KORISNO (trazi da nije robot)

        //string putanja = "Neki.txt";
        //StreamWriter sw = new StreamWriter(putanja);  
        //sw.Write(ucenik);            
        //sw.Close();
    }
}
