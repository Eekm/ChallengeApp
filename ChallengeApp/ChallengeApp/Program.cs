﻿var name = "Ewa";
var sex = "kobieta";
var age = 33;

if (sex == "kobieta")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }

    else if (age == 30)
    {
        Console.WriteLine("Kobieta, lat 30");
    }

    else if (age > 30)
    {
        Console.WriteLine("Kobieta powyżej 30 lat");
    }
}


else
{
    if (age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }

}