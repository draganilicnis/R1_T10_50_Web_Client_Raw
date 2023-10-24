# R1_T10_50_Web_Client_Raw
R1_T10_50_Web_Client_Raw

// https://www.google.com/search?q=c%23+console+app+read+raw+data+from+public+web+address&rlz=1C1MSIM_enRS784RS784&oq=c%23+console+app+read+raw+data+from+public+web+address&gs_lcrp=EgZjaHJvbWUyBggAEEUYOTIGCAEQRRg60gEKNDc2MzZqMGoxNagCALACAA&sourceid=chrome&ie=UTF-8
// https://stackoverflow.com/questions/22226359/how-to-get-input-from-website-to-net-console-application

using System;
// using System.IO;

class Zadatak
{
    static void Main()
    {
        string myUrl = "https://raw.githubusercontent.com/draganilicnis/ConsoleApp15/master/ConsoleApp15/Program.cs";
        // myUrl = "https://raw.githubusercontent.com/draganilicnis/ConsoleApp15/master/ConsoleApp15/Program.cs";
        // myUrl = "https://petlja.org/biblioteka/r/Zbirka/trening";
        // myUrl = "https://raw.githubusercontent.com/draganilicnis/ConsoleApp14/master/%C5%A0kole%2020230921%201017.csv?token=GHSAT0AAAAAACITXVCSIDBKKSXHWCIVXKQOZJTOPDQ";
        // myUrl = "https://raw.githubusercontent.com/draganilicnis/Privatno/main/Neki.txt?token=GHSAT0AAAAAACITXVCS6B7FVNBA6UQNOXXEZJTOX7Q";
        // myUrl = "https://petlja.org/kurs/11162/1/6371";
        // myUrl = "https://www.mojasrednjaskola.gov.rs/Students";


        var a = new System.Net.WebClient().DownloadString(myUrl);
        
        Console.WriteLine(a);

        // string putanja = "Neki.txt";
        // StreamWriter sw = new StreamWriter(putanja);  
        // sw.Write(a);            
        // sw.Close();
    }
}
