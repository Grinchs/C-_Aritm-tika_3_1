Console.WriteLine("Ievadi skaitli x ");
int x = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 5; i++)
{
    x++;
    Console.WriteLine("Inkramentēšanas rezultāts: " + x);
}

Console.WriteLine();

Console.WriteLine("Ievadi otru skaitli");
x = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 5; i++)
{
    x--;
    Console.WriteLine("Dekrementēšanas rezultāts: " + x);
}

Console.ReadLine();

