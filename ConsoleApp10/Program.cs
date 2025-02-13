string C = "Celsius";
string F = "Fahrenheit";

Console.WriteLine(C);
Console.WriteLine(F);


string Chosen = Console.ReadLine();

Console.Write("zadej hodnotu teploty: ");

int celsius = 100;
int Fahrenheit = celsius * 2 + 30;
int Fahr2 = (celsius - 32) * 5 / 9;


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

if (Chosen == "")
{
    Console.WriteLine("prázdný výběr");
}