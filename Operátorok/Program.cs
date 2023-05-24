using Operátorok;
using System.Collections.Generic;

List<OperatorClass> operatorok = new List<OperatorClass>();

StreamReader sr = new StreamReader("kifejezesek.txt");

while (!sr.EndOfStream)
{
    string[] adatok = sr.ReadLine().Split();
    operatorok.Add(new OperatorClass(int.Parse(adatok[0]), adatok[1], int.Parse(adatok[2])));
}
sr.Close();

Console.WriteLine($"2.feladat: Kifejezések száma: {operatorok.Count()}");

Console.WriteLine($"3.feladat: Kifejezések maradékos osztással: {operatorok.Count(o => o.Operatorhatorozo.Contains("mod"))}");

Console.WriteLine(operatorok.Any(o => o.Operandus1 % 10 == 0 && o.Operandus2 % 10 == 0) ? "4.feladat: Van ilyen kifejezés!" : "4.feladat: Nincs ilyen kifejezés!");

string[] osszesoperatortipus = {"+","-","*","/","div","mod"};
Console.WriteLine($"5.feladat: Statisztika");
operatorok.Where(o => osszesoperatortipus.Contains(o.Operatorhatorozo)).GroupBy(o => o.Operatorhatorozo).ToList().ForEach(o => Console.WriteLine($"\t{o.Key} -> {o.Count()} db"));

Console.Write($"7.feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
string megadottertekek = Console.ReadLine();
string[] megadottertekektomb;
while (megadottertekek != "vége")
{
    megadottertekektomb = megadottertekek.Split();
    try
    {
        Console.WriteLine($"{megadottertekek} = {OperatorClass.Meghatarozas(int.Parse(megadottertekektomb[0]), megadottertekektomb[1], int.Parse(megadottertekektomb[2]))}");
    }
    catch (FormatException)
    {
        Console.Write($"7.feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
        megadottertekek = Console.ReadLine();
        continue;
    }
    Console.Write($"7.feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
    megadottertekek = Console.ReadLine();
}

StreamWriter sw = new StreamWriter("eredmenyek.txt", append: true);
operatorok.ForEach(o => sw.WriteLine($"{o.Operandus1} {o.Operatorhatorozo} {o.Operandus2} = {OperatorClass.Meghatarozas(o.Operandus1, o.Operatorhatorozo, o.Operandus1)}"));
sw.Close();
Console.Write($"8.feladat: eredmenyek.txt");