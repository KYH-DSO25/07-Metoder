/*
 * 14   Skriv metoder som beräknar minsta, största, genomsnitt, summa och produkt 
 *      av en given mängd heltal. 
 *      Låt antalet tal i mängden variera
 */
int GetMin(params int[] numbers)
{
    int min = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
        if (numbers[i] < min) min = numbers[i];

    return min;
}

int GetMax(params int[] numbers)
{
    int max = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
        if (numbers[i] > max) max = numbers[i];

    return max;
}

int GetSum(params int[] numbers)
{
    int sum = 0;

    for (int i = 0; i < numbers.Length; i++) sum += numbers[i];

    return sum;
}

float GetAverageSum(params int[] numbers)
{
    return GetSum(numbers) / numbers.Length;
}

int GetProduct(params int[] numbers)
{
    int product = 1;

    for (int i = 0; i < numbers.Length; i++) product *= numbers[i];

    return product;
}

Console.WriteLine("The Minimum of set integers: {0}", GetMin(1, 2, 3, 4, 5, 6, 7, 8, 9));
Console.WriteLine("The Maximum of set integers: {0}", GetMax(1, 2, 3, 4, 5, 6, 7, 8, 9));
Console.WriteLine("The Average Sum of set integers: {0}", GetAverageSum(1, 2, 3, 4, 5, 6, 7, 8, 9));
Console.WriteLine("The Sum of set integers: {0}", GetSum(1, 2, 3, 4, 5, 6, 7, 8, 9));
Console.WriteLine("The Product of set integers: {0}\n", GetProduct(1, 2, 3, 4, 5, 6, 7, 8, 9));
