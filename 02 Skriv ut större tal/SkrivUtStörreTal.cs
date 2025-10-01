/*
 *  2   Skriv en metod GetMax() med två parametrar som ger det större av två heltal. 
 *      Skriv ett program som läser 3 heltal från konsolen och skriver ut det största av dem 
 *      med hjälp av metoden GetMax()
 */

Console.Write("Ange första talet: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Ange andra talet: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Ange tredje talet: ");
int c = int.Parse(Console.ReadLine());

int max = GetMax(GetMax(a, b), c);
Console.WriteLine("\nStörsta talet är: {0}", max);







Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

int GetMax(int x,  int y)
{
    return Math.Max(x, y);
}