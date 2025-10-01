/*
 * 4    Skriv en metod som räknar hur många gånger ett givet tal förekommer i en given array. 
 *      Skriv ett program som testar metoden och kontrollerar att den fungerar riktigt
 */

public class NumberOccursInArray
{
    public static int GetNumberOfOccurs(int[] numbers, int searchNumber)
    {
        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == searchNumber)
            {
                count++;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        Console.Write("Ange storleken på din array: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        Console.WriteLine("\nAnge {0} tal att stoppa in i arrayen:", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("   {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Ange ett tal att söka efter: ");
        int searchedNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("\nTalet {0} förekommer {1} gång(er) i arrayen.\n",
            searchedNumber, GetNumberOfOccurs(numbers, searchedNumber));


        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}