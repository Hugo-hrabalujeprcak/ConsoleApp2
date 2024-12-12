// See https://aka.ms/new-console-template for more information
Console.WriteLine("halo");

Random generator = new Random();
int nahodneCislo = generator.Next(1, 8);
Console.WriteLine(nahodneCislo);

if (nahodneCislo == 1)
{ 
    Console.WriteLine("Pon");
}

if (nahodneCislo == 2)
{
    Console.WriteLine("Út");
}

if (nahodneCislo == 3)
    Console.WriteLine("St");

if (nahodneCislo == 4)
{
    Console.WriteLine("Čt");
}

 if (nahodneCislo == 5)
    {
    Console.WriteLine("Pá");
}

if (nahodneCislo == 6)
    {
    Console.WriteLine("So");
}

if (nahodneCislo == 7)
{
    Console.WriteLine("Ne");
}

string[] pondeli = { "TV", "ČJ", "VV", "IKT" };
string[] utery = { "ČJ", "ČJ", "ČJ", "ČJ" };
string[] streda = { "AJ", "NJ", "AJL", "ČJ" };
string[] ctvrtek = { "SPD", "VKZ", "SVZ", "HV" };
string[] patek = { "BI", "CHE", "TV", "ZE" };


if (nahodneCislo == 1)
{
    Console.WriteLine("Pondělí");
    foreach (string hodina in pondeli)
    {

        Console.WriteLine(hodina + "-");
    }
}

if (nahodneCislo == 2)
{
    Console.WriteLine("Úterý");
    foreach (string hodina in utery)
    {

        Console.WriteLine(hodina + "-");
    }
}

if (nahodneCislo == 3)
{
    Console.WriteLine("Středa");
    foreach (string hodina in streda)
    {

        Console.WriteLine(hodina + "-");
    }
}

if (nahodneCislo == 4)
{
    Console.WriteLine("Čtvrtek");
    foreach (string hodina in ctvrtek)
    {

        Console.WriteLine(hodina + "-");
    }
}

if (nahodneCislo == 5)
{
    Console.WriteLine("Pátek");
    foreach (string hodina in patek)
    {

        Console.WriteLine(hodina + "-");
    }
}


    
