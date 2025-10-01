/*
 *  1   Skriv en metod som frågar användaren efter namn och skriver ut "Hej, <namn>" 
 *      (till exempel "Hej, Katarina"). Skriv ett program som testar metoden
 */

public class PrintName
{
    public static string RegardsUser(string userName)
    {
        return string.Format("Hej {0}!", userName);
    }
    private static void Main(string[] args)
    {
        Console.Write("Ange ditt namn: ");
        string usertName = Console.ReadLine();

        Console.WriteLine(RegardsUser(usertName));






        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}