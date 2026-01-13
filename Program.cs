string tuba = "";
Console.WriteLine("Mis on teie ruumi kuju? Kas kolmnurk, Ristkülik või Ring");
tuba = Console.ReadLine();

if (tuba == "kolmnurk")
{
    int arv1 = 0;
    int arv2 = 0;
    int arv3 = 0;
    Console.WriteLine("Mis on teie ruumi esimene külg");
    arv1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Mis on teie ruumi teine külg");
    arv2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Mis on teie ruumi kolmas külg");
    arv3 = int.Parse(Console.ReadLine());
    double p = (arv1 + arv2 + arv3) / 2;
    Console.WriteLine($"tehetulemus: {p}");

}

if (tuba == "ristkülik")
{
    int arv1 = 0;
    int arv2 = 0;
    Console.WriteLine("Mis on teie ruumi esimene külg");
    arv1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Mis on ruumi teine külg");
    arv2 = int.Parse(Console.ReadLine());
    double p = (arv1 * arv2);
    Console.WriteLine($"tehtetulemus: {p}");
}

if (tuba == "ring")
{
    int läbimõõt = 0;
    Console.WriteLine("Mis on sinu ringi läbimõõ");
    läbimõõt = int.Parse(Console.ReadLine());
    double r = läbimõõt / 2;
    double p = Math.PI * r * r;
    Console.WriteLine($"tehtetulemus: {p}");

}