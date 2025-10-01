/*
 * 8    Skriv en metod som adderar två positiva heltal, representerade av arrayer 
 *      av siffror (varje element array[i] innehåller en siffra, och sista siffran hålls i array[0]). 
 *      Varje tal som skall adderas kan innehålla upp till 10 000 siffror.
 */

string fordonsTyp = "CAR";
string skiljetecken = "#";
string regNummer = "ABC123";
int platsNummer = 3;

string[] PHus = new string[101];

ParkeraFordon(fordonsTyp, skiljetecken, regNummer, platsNummer);
Console.WriteLine($"Plats nummer {platsNummer}: {PHus[platsNummer]}");
Console.WriteLine(HämtaPRuta(PHus, platsNummer));


Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();


void ParkeraFordon(string fordonsTyp, string skiljetecken, string regNummer, int platsNummer)
{
    // Stoppa in fordonet på angiven plats
    PHus[platsNummer] = fordonsTyp + skiljetecken + regNummer;
}

string HämtaPRuta(string[] PHus, int platsNummer)
{
    string[] temp = PHus[platsNummer].Split('#');
    return String.Format("Plats nummer: {0}, Fordonstyp: {1}, Regnummer: {2}",
        platsNummer, temp[0], temp[1]);
}