string name = ("Ewa");
char sex = 'K';
int age = 33;

if (sex == 'K' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age == 33 && name == ("Ewa"))
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == 'M' && age <18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
