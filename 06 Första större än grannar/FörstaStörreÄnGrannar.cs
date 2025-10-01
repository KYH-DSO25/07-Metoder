/*
 * 6    Skriv en metod som ger indexet för det första elementet i en array som är större än 
 *      sina grannar, eller -1 om något sådant inte finns
 *      Utgå från metoden i föregående uppgift
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

int index = FindFirstBiggerThanNeighbours(numbers);

if (index != -1)
{
    Console.WriteLine("\nFörsta talet som är större än sina grannar -> number: {0} vid index: {1}",
        numbers[index], index);
}
else
{
    Console.WriteLine("\nDet finns inga tal som är större än sina grannar");
}



Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();



static int FindFirstBiggerThanNeighbours(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (IsBiggerThanItsNeighbours(numbers, i))
        {
            return i;
        }
    }

    return -1;
}

static bool IsBiggerThanItsNeighbours(int[] numbers, int index)
{
    // OBS! Om det bara finns en granne (dvs om vi kollar första eller sista elementet)
    // så tittar vi på den ensamma grannen och returnerar resultatet av jämförelsen

    if (index < 0 || index >= numbers.Length)
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