string C = "Celsius";
string F = "Fahrenheit";

Console.WriteLine(C);
Console.WriteLine(F);


string Chosen = Console.ReadLine();

Console.Write("zadej hodnotu teploty: ");

string celsius = Console.ReadLine();
int celsiusImp = Convert.ToInt32(celsius);
int Fahrenheit = celsiusImp * 2 + 30;
int Fahr2 = (celsiusImp - 32) * 5 / 9;


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