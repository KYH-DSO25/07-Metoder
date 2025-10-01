/*
 * 5    Skriv en metod som kontrollerar om ett element på en given position i en given array 
 *      av heltal är större än sina två grannar (om de finns)
 */

Console.Write("Ange storleken på din array: ");
int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];
Console.WriteLine("\nAnge {0} tal att stoppa in i arrayen:", n);
for (int i = 0; i < n; i++)
{
    Console.Write("   {0}: ", i + 1);
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.Write("Ange en position (index) i arrayen att kolla: ");
int index = int.Parse(Console.ReadLine());

Console.WriteLine("\nTalet {0} (på plats {1} är större än sina grannar -> {2}",
    numbers[index], index, IsBiggerThanItsNeighbours(numbers, index));




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();



static bool IsBiggerThanItsNeighbours(int[] numbers, int index)
{
    // OBS! Om det bara finns en granne (dvs om vi kollar första eller sista elementet)
    // så tittar vi på den ensamma grannen och returnerar resultatet av jämförelsen

    if (index <0 || index >= numbers.Length)
    {
        throw new IndexOutOfRangeException();
    }

    else if (index == numbers.Length - 1 && numbers.Length > 1)
    {
        return numbers[index - 1] < numbers[index];
    }
    else if (index == 0 && numbers.Length > 1)
    {
        return numbers[index] > numbers[index + 1];
    }
    else
    {
        // Talet har två grannar
        return numbers[index - 1] < numbers[index] && numbers[index] > numbers[index + 1];
    }
}