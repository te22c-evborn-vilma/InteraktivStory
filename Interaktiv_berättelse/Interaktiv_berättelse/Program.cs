// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vill du gå åt höger eller vänster?");

string choice1 = Console.ReadLine();

if (choice1 == "höger")                             //första frågan
{
    Console.WriteLine("Du kommer till en gruva. Vill du gå in i gruvan eller gå vidare?");
}
else if (choice1 == "vänster")
{
    Console.WriteLine("Vägen tog slut. Vill du gå tillbaka?");
}
// else
// {
    // Console.WriteLine("Försök igen");
// }


string choice2 = Console.ReadLine();
if (choice2 == "gå in i gruvan")                  //till höger - gå in i gruvan
{
    Console.WriteLine("Hoppsan! Du blev attackerad av fladdermöss. Slut");
}
else if (choice2 == "gå vidare")                  //till höger - gå vidare
{
    Console.WriteLine("Du går förbi gruvan och kommer fram till en mur. Vill du stanna vid muren eller gå vidare?");
}
else if (choice2 == "ja")                         //till vänster - ja
    {
        Console.WriteLine("Du är tillbaka vid korsningen. Slut");
    }
else if (choice2 == "nej")                        //till vänster - nej
{
    Console.WriteLine("Du har inget val. Slut");
}
// else
// {
    // Console.WriteLine("Försök igen");
// }


string choice3 = Console.ReadLine();
if (choice3 == "stanna vid muren")                 //till höger - stanna vid muren
{
    Console.WriteLine("Någon kastar dig över muren och du slår i huvudet mot en sten. Slut");
}
else if (choice3 == "gå vidare")                  //till höger - gå vidare
{
    Console.WriteLine("Du är tillbaka där du började. Slut");
}
// else
// {
    // Console.WriteLine("Försök igen");
// }

Console.ReadLine();
