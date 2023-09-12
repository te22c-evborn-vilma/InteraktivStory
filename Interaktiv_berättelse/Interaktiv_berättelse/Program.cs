// See https://aka.ms/new-console-template for more information
using System;
string choice = "";

Console.WriteLine("Vill du gå åt höger eller vänster?");

choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "höger")
{
  Console.WriteLine("Du kommer till en gruva. Vill du gå in i gruvan?");
  
    choice = Console.ReadLine();
    choice = choice.ToLower();

    if (choice == "ja")
{
    Console.WriteLine("Hoppsan! Du blev attackerad av fladdermöss. Slut");
}
else if (choice == "nej")
{
    Console.WriteLine("Du går förbi gruvan och kommer fram till en mur. Vill du stanna vid muren?");

    choice = Console.ReadLine();
    choice = choice.ToLower();

    if (choice == "ja")
{
    Console.WriteLine("Någon kastar dig över muren och du slår i huvudet mot en sten. Slut");
}
else if (choice == "nej")
{
    Console.WriteLine("Du är tillbaka där du började. Slut");
}
 else
  {
    Console.WriteLine("Hoppsan! Du skrev något som jag inte förstod");
  }

}
else if (choice == "vänster")
{
  Console.WriteLine("Vägen tog slut. Vill du gå tillbaka?");

  choice = Console.ReadLine();
  choice = choice.ToLower();

  if (choice == "ja")
  {
    Console.WriteLine("Du är tillbaka vid korsningen.Slut");
    
  }
  else if (choice == "nej")
  {
    Console.WriteLine("Du har inget val. Slut");

  }
  else
  {
    Console.WriteLine("Hoppsan! Du skrev något som jag inte förstod");
  }
}
else
{
  Console.WriteLine("Hoppsan! Du skrev något som jag inte förstod");
}
}
Console.WriteLine("Tryck ENTER för att avsluta.");
Console.ReadLine();