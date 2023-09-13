var name = "Ewa";
bool Kobieta = false;
var age = 17;

if (Kobieta == true)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Kobieta w wieku powyżej 29 lat");
    }
    if (age == 33)
    {
        if (name == "Ewa")
        {
            Console.WriteLine("Ewa, lat 33");
        }
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
}

