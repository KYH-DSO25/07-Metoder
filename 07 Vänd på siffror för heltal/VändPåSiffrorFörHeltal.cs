/*
 * 7    Skriv en metod som vänder på siffrorna i ett givet heltal. 
 *      Exempel: 256 -> 652
 */

// Vi använder decimal, så klarar vi av att hantera flyttal också...
Console.Write("Ange ett tal: ");
decimal number = decimal.Parse(Console.ReadLine());

Console.WriteLine("\n{0} -> {1}", number, ReverseNumber(number));




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();


decimal ReverseNumber(decimal number)
{
    string temp = number.ToString();
    string result = string.Empty;

    for (int i = temp.Length - 1; i >= 0; i--)
    {
        result += temp[i];
    }

    return decimal.Parse(result);
}