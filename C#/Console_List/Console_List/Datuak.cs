﻿internal class Datuak
{
    public string Izena { get; set; }
    public Datuak(string izena)
    { this.Izena = izena; }
    public static String DatuenZerrenda(List<Datuak> datuak)
    {
        string mezua = "";
        foreach(Datuak datua in datuak)
        {
            mezua += datua.Izena;
        }
        return mezua;
    }
}

