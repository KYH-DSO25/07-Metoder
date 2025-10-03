/*
 * 9    Skriv en metod som ger det största elementet i en del av en array av heltal med början 
 *      vid ett givet index. 
 *      
 *      Använd den i en annan metod som sorterar en array i stigande/fallande ordning.
 */
Console.Write("Enter a number N (size of array): ");
int n = int.Parse(Console.ReadLine());

int[] numbers = new int[n];
Console.WriteLine("\nEnter a {0} number(s) to array: ", n);

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("   {0}: ", i);
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.Write("\nEnter start index: ");
int start = int.Parse(Console.ReadLine());

Console.Write("Enter end index: ");
int end = int.Parse(Console.ReadLine());

Console.WriteLine("\nMax element in interval [{0}, {1}] -> {2}", start, end,
    FindMaxElementInInterval(numbers, start, end));

Console.WriteLine("\nNumbers in Ascending order: {0}",
    string.Join(" ", SortAscending(numbers)));

Console.WriteLine("Numbers in Descending order: {0}\n",
    string.Join(" ", SortDescending(numbers)));

int FindMaxElementInInterval(int[] numbers, int start, int end, int swapIndex = 0)
{
    if (start < 0 || start >= numbers.Length || end < 0 || end >= numbers.Length)
        throw new IndexOutOfRangeException();

    int maxIndex = start;

    for (int i = start; i <= end; i++)
        if (numbers[maxIndex] < numbers[i])
            maxIndex = i;

    int temp = numbers[swapIndex];
    numbers[swapIndex] = numbers[maxIndex];
    numbers[maxIndex] = temp;

    return numbers[swapIndex];
}

int[] SortAscending(int[] numbers)
{
    int size = numbers.Length;
    int[] sorted = new int[size];

    for (int i = size - 1; i >= 0; i--)
        sorted[i] = FindMaxElementInInterval(numbers, 0, i, i);

    return sorted;
}

int[] SortDescending(int[] numbers)
{
    int size = numbers.Length;
    int[] sorted = new int[size];

    for (int i = 0; i < size; i++)
        sorted[i] = FindMaxElementInInterval(numbers, i, size - 1, i);

    return sorted;
}
