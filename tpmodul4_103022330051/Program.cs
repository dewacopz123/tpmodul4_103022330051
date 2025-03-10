// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class KodePos
{
    private static readonly Dictionary<string, string> kodePosMap = new Dictionary<string, string>
    {
        { "Batununggal", "40266" },
        { "Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijaura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekejati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" },
        { "Samoja", "40273" }
    };

    public static string GetKodePos(string kelurahan)
    {
        return kodePosMap.TryGetValue(kelurahan, out string kodePos) ? kodePos : "Kode pos tidak ditemukan";
    }
}