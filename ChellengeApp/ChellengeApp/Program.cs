var name = "Ewa";
bool Woman = true; //czy bezpieczniej użyć String?
var age = 33;

if (Woman == true)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (age == 33 && name == "Ewa") //dodatkowo sprawdzamy czy Ewa jest kobietą
    {
        Console.WriteLine("Ewa, lat 33");
    }
}
else if (age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna");
    }
    else 
    {
        Console.WriteLine("Mężczyzna pełnoletni");
    }

