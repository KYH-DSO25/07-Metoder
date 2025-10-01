/*
 * 3    Skriv en metod som ger den sista siffran av ett givet heltal som ett ord på svenska. 
 *      Exempel: 512 -> "två", 1024 -> "fyra", 12309 -> "nio"
 */

Console.Write("Ange ett heltal: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("\nNamnet på sista siffran: {0}",GetNameOfLastDigit(number));




Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
Console.ReadKey();

string GetNameOfLastDigit(int number){
	switch (number % 10)		// % 10 ger oss sista siffran
	{
		case 0: return "Noll";
		case 1: return "Ett"; 
		case 2: return "Två"; 
		case 3: return "Tre"; 
		case 4: return "Fyra";
		case 5: return "Fem";
		case 6: return "Sex";
		case 7: return "Sju";
		case 8: return "Åtta";
		case 9: return "Nio";
		default: return "Okänd siffra!";
	}
}