/*

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Say my name:");
// Wpisz imie
string sFirstName = Console.ReadLine();
// Wyświetl imie
Console.WriteLine("Siemano " + sFirstName);
Console.WriteLine($"Welcome, {sFirstName}");

if (sFirstName.Equals("Kebab", StringComparison.CurrentCultureIgnoreCase)
    || sFirstName.Equals("Gyros", StringComparison.CurrentCultureIgnoreCase))
{
    Console.WriteLine("You're goddamn right.");
}
else if (sFirstName.Equals("Sos", StringComparison.CurrentCultureIgnoreCase))
    Console.WriteLine("Mmmm sosiwo.");
else
    Console.WriteLine("Who are you, tf?");
*/

/////////////////////////////////////
//////////////// RPS 1.0 ////////////////
////////////////////////////////////
/*

// broń gracza 1
string sB1;
// broń gracza 2
string sB2;

//// Wynik gry
int nScore = 0;
// 0 == remis
// 1 == gracz1 wygrywa
// 2 == gracz2 wygryWA

//// Imiona graczy
// Imie Gracza 1
string sP1;
// Imie Gracza 2
string sP2;

//// UI Input
string sUI;
//////////////// GRA ////////////////

Console.WriteLine("Welcome to Rock|Paper|Scissors!");
Console.WriteLine("------------------------------------------------------------------------------");
Console.WriteLine("This game requires 2 players to play!\n-> Type in \"1\" to start!\n-> Type in \"0\" to exit the game.");
sUI = Console.ReadLine();

if (sUI.Equals("1"))
{
    Console.WriteLine("LETS PLAY!");
}
else if (sUI.Equals("0") || sUI == null)
{
    Console.WriteLine("Exiting game...");
}
else
    Console.WriteLine("Unknown error. Terminating RPS game.");

*/////////////////////////////////////
//////////////// END OF RPS 1.0 ////////////////
/////////////////////////////////////
/// 
/// 

StringComparison stringComparison = StringComparison.OrdinalIgnoreCase;
// AS == Allowed Sign
string sAS1 = "R";
string sAS2 = "P";
string sAS3 = "S";
List<string> lAllowedSigns = [sAS1, sAS2, sAS3];

Console.WriteLine("RPS Template");

Console.WriteLine($"P1, choose your option: {string.Join("/", lAllowedSigns)}");
Console.WriteLine($"P1, choose your option: {lAllowedSigns[0]}/{lAllowedSigns[1]}/{lAllowedSigns[2]}");
string sB1 = Console.ReadLine();

Console.WriteLine($"P2, choose your option: {string.Join("/", lAllowedSigns)}");
string sB2 = Console.ReadLine();

// Sprawdzenie czy użyte zostały właściwe bronie.
while (!lAllowedSigns.Contains(sB1, StringComparer.OrdinalIgnoreCase))
{
    Console.WriteLine($"P1, choose the CORRECT option: {string.Join("/", lAllowedSigns)}");
    sB1 = Console.ReadLine();
}

while (!lAllowedSigns.Contains(sB2, StringComparer.OrdinalIgnoreCase))
{
    Console.WriteLine($"P1, choose the CORRECT option: {string.Join("/", lAllowedSigns)}");
    sB2 = Console.ReadLine();
}

//// Result check

if (sB1.Equals(sB2, stringComparison))
{
    Console.WriteLine("It's a Draw!");
}
else if (sB1.Equals(lAllowedSigns[0], stringComparison) && sB2.Equals(lAllowedSigns[2], stringComparison)
    || sB1.Equals(lAllowedSigns[1], stringComparison) && sB2.Equals(lAllowedSigns[0], stringComparison)
    || sB1.Equals(lAllowedSigns[2], stringComparison) && sB2.Equals(lAllowedSigns[1], stringComparison))
{
    Console.WriteLine("P1 Wins!");
}
else
{
    Console.WriteLine("P2 Wins!");
}