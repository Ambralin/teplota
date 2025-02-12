string C = "Celsius / C";
string F = "Fahrenheit / F";

Console.WriteLine(C);
Console.WriteLine(F);


string Chosen = Console.ReadLine();

Console.Write("zadej hodnotu teploty: ");



string Celsius = Console.ReadLine();
int CelsiusImp = Convert.ToInt32(Celsius);
int Fahrenheit = CelsiusImp * 9 / 5 + 32;
int Fahr2 = (CelsiusImp - 32) * 5 / 9;


if (Chosen != null)
{
    Console.WriteLine("Dobře");
}

if (Chosen == "Celsius")
{
    Console.WriteLine($"Dnes je {Fahrenheit} Fahrenheit");
}
if (Chosen == "Fahrenheit")
{
    Console.WriteLine($"Dnes je {Fahr2} Celsius");
}