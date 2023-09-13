var name = "Ewa";
bool Kobieta = true; //czy bezpieczniej użyć String?
var age = 30;

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
    if (age == 33 && name == "Ewa") //dodatkowo sprawdzamy czy Ewa jest kobietą
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
}

