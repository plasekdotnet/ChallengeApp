int youAge = 30;
string youName = "Ewa";
char youGender = 'K';

if (youAge < 33 && youGender == 'K')
{
    Console.WriteLine("Kobieta poniżej "+ youAge + " lat");
}
youAge = 33;
if (youAge == 33) 
{
    Console.WriteLine(youName + " wiek 33 lat");
}
youGender = 'M';
youAge = 15;
if (youGender == 'M' && youAge < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}