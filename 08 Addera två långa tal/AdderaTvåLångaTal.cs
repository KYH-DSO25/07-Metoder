/*
 * 8    Skriv en metod som adderar två positiva heltal, representerade av arrayer 
 *      av siffror (varje element array[i] innehåller en siffra, och sista siffran hålls i array[0]). 
 *      Varje tal som skall adderas kan innehålla upp till 10 000 siffror.
 */

Console.Write("Enter first non-negative number: ");
string first = Console.ReadLine();

Console.Write("Enter second non-negative number: ");
string second = Console.ReadLine();

if (IsCorrectNumber(first) && IsCorrectNumber(second))
{
    List<int> result = AccumulateTwoNumbers(first, second);

    Console.Write("\nResult: ");
    PrintResult(result);
}
else
{
    Console.WriteLine("\n-> You have entered an invalid number(s)...\n");
}


bool IsCorrectNumber(string number)
{
    for (int i = 0; i < number.Length; i++)
        if (number[i] < '0' || number[i] > '9')
            return false;

    return true;
}

List<int> AccumulateTwoNumbers(string first, string second)
{
    // Here convert string to int[] Array, because
    // according assignment we must represent numbers in Array
    var a = first.Select(ch => ch - '0').ToArray();
    var b = second.Select(ch => ch - '0').ToArray();

    Array.Reverse(a);
    Array.Reverse(b);

    List<int> result = new List<int>(Math.Max(a.Length, b.Length));

    int carry = 0;

    for (int i = 0; i < result.Capacity; i++)
    {
        int num = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0) + carry;
        carry = num / 10;
        result.Add(num % 10);
    }

    if (carry > 0) result.Add(carry);

    return result;
}

void PrintResult(List<int> result)
{
    for (int i = result.Count - 1; i >= 0; i--)
        Console.Write(result[i]);

    Console.WriteLine("\n");
}
