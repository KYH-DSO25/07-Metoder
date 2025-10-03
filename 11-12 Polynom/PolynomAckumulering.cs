/*
 * 11   Skriv en metod som adderar två polynom. Representera dem som en vektor av 
 *      koefficienter enligt exemplet nedan:
 *      x2 + 5 = 1x2 + 0x + 5 -> |5| |0| |1|
 *      
 * 12   Bygg ut programmet så att det även hanterar subtraktion och multiplikation av polynom
 */

Console.WriteLine("Enter first polynomial:");
decimal[] firstPolynomial = EnterPolynomial(out firstPolynomial);
Console.Write("Polynomial in normal form:");
PrintPolynomial(firstPolynomial);

Console.WriteLine();

Console.WriteLine("Enter second polynomial:");
decimal[] secondPolynomial = EnterPolynomial(out secondPolynomial);
Console.Write("Polynomial in normal form:");
PrintPolynomial(secondPolynomial);

Аccumulation(firstPolynomial, secondPolynomial);
Subtraction(firstPolynomial, secondPolynomial);
Multiplication(firstPolynomial, secondPolynomial);

decimal[] EnterPolynomial(out decimal[] polynomial)
{
    Console.Write("Enter your polynomial degree: ");
    byte degree = byte.Parse(Console.ReadLine());

    polynomial = new decimal[degree + 1];

    for (int i = polynomial.Length - 1; i >= 0; i--)
    {
        Console.Write("x^" + i + ": ");
        polynomial[i] = decimal.Parse(Console.ReadLine());
    }

    return polynomial;
}

void Аccumulation(decimal[] first, decimal[] second)
{
    Console.WriteLine("\n" + new string('-', 40) + "\n");
    PrintPolynomial(first);
    Console.WriteLine("   +");
    PrintPolynomial(second);
    Console.WriteLine("   =");

    int lengthBigger = Math.Max(first.Length, second.Length);
    bool isFirstBigger = first.Length >= second.Length ? true : false;
    bool isSecondBigger = !isFirstBigger;
    bool isPolynomialZero = true;

    decimal[] result = new decimal[lengthBigger];

    for (int i = 0; i < lengthBigger; i++)
    {
        if (i < first.Length && i < second.Length)
        {
            result[i] = first[i] + second[i];
            if (result[i] != 0)
                isPolynomialZero = false;
        }
        else if (isFirstBigger)
        {
            result[i] = first[i];
        }
        else if (isSecondBigger)
        {
            result[i] = second[i];
        }
    }

    if (isPolynomialZero) Console.Write("     0\n");
    else PrintPolynomial(result);
}

void Subtraction(decimal[] first, decimal[] second)
{
    Console.WriteLine("\n" + new string('-', 40) + "\n");
    PrintPolynomial(first);
    Console.WriteLine("   -");
    PrintPolynomial(second);
    Console.WriteLine("   =");

    int lengthBigger = Math.Max(first.Length, second.Length);
    bool isFirstBigger = first.Length >= second.Length ? true : false;
    bool isSecondBigger = !isFirstBigger;
    bool isPolynomialZero = true;

    decimal[] result = new decimal[lengthBigger];

    for (int i = 0; i < lengthBigger; i++)
    {
        if (i < first.Length && i < second.Length)
        {
            result[i] = first[i] - second[i];
            if (result[i] != 0)
                isPolynomialZero = false;
        }
        else if (isFirstBigger)
        {
            result[i] = first[i];
        }
        else if (isSecondBigger)
        {
            result[i] = -second[i];
        }
    }

    if (isPolynomialZero) Console.Write("     0\n");
    else PrintPolynomial(result);
}

void Multiplication(decimal[] first, decimal[] second)
{
    Console.WriteLine("\n" + new string('-', 40) + "\n");
    PrintPolynomial(first);
    Console.WriteLine("   *");
    PrintPolynomial(second);
    Console.WriteLine("   =");

    decimal[] result = new decimal[first.Length + second.Length - 1];

    for (int i = 0; i < first.Length; i++)
        for (int j = 0; j < second.Length; j++)
            result[i + j] += (first[i] * second[j]);

    PrintPolynomial(result);

    Console.WriteLine("\n" + new string('-', 40) + "\n");
}

// Prints polynomial in normal form -> good looking
void PrintPolynomial(decimal[] polynomial)
{
    for (int i = polynomial.Length - 1; i >= 0; i--)
    {
        if (i == polynomial.Length - 1 && polynomial[i] != 0)
        {
            Console.Write("     {0}{1}x^{2} ", polynomial[i] > 0 ? "" : "-", Math.Abs(polynomial[i]), i);
        }
        else if (i == 0)
        {
            if (polynomial[i] < 0) Console.Write("{0}{1} ", "- ", -polynomial[i]);
            else if (polynomial[i] > 0) Console.Write("{0}{1} ", "+ ", polynomial[i]);
        }
        else
        {
            if (polynomial[i] < 0) Console.Write("{0}{1}x^{2} ", "- ", -polynomial[i], i);
            else if (polynomial[i] > 0) Console.Write("{0}{1}x^{2} ", "+ ", polynomial[i], i);
        }
    }

    Console.WriteLine();
}
