﻿List<Datuak> datuak = new List<Datuak>();
datuak.Add(new Datuak("Aulkia"));
datuak.Add(new Datuak("Laranja"));

Datuak berria = new Datuak("Sagarra");
datuak.Add(berria);

for (int i = 0; i < datuak.Count; i++)
{
    Console.WriteLine(datuak[i].Izena);
}
Console.ReadLine();

foreach (Datuak datua in datuak)
{
    Console.WriteLine(datua.Izena);
}
Console.ReadLine();

Console.WriteLine(Datuak.DatuenZerrenda(datuak));