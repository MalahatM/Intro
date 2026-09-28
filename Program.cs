
//about name. uppgift 1
Console.WriteLine("Vad heter du?");
string name = Console.ReadLine()!;
Console.WriteLine($"Hej {name}!");

//about birthday
Console.WriteLine("När är din födelsedag?");
string birthdayInput = Console.ReadLine()!;
Console.WriteLine($"Din födelsedag är {birthdayInput}.");
 
Console.WriteLine("Hur gammal är du?");
string ageInput = Console.ReadLine()!;
int age = Convert.ToInt32(ageInput);

Console.WriteLine($"Du är {age} år gammal.");

const int currentYear = 2026;
int birthYear = currentYear - age;
Console.WriteLine($"Du är född år {birthYear}.");

//uppgift 2
Console.WriteLine("Skriv in ett tal:");
string numberInput = Console.ReadLine()!;
int number = Convert.ToInt32(numberInput);

Console.WriteLine("Skriv in ett decimaltal:");
string decimalInput = Console.ReadLine()!;
double decimalNumber = Convert.ToDouble(decimalInput);


Console.WriteLine("Skriv true eller false:");
string booleanInput = Console.ReadLine()!;
bool booleanValue = Convert.ToBoolean(booleanInput);
Console.WriteLine($"Du skrev: {number}, {decimalNumber} och {booleanValue}");
//uppgift 4
Console.WriteLine("Skriv in ett tal:");
string numberInput2 = Console.ReadLine()!;
int number2 = Convert.ToInt32(numberInput2);
Console.WriteLine("Skriv in ett annat tal:");
string numberInput3 = Console.ReadLine()!;
int number3 = Convert.ToInt32(numberInput3);
Console.WriteLine($"Summan av {number2} och {number3} är {number2 + number3}");
Console.WriteLine($"Produkten är {number2 * number3}");


//uppgift 5
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("This text is green.");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("This text is red.");

Console.ResetColor();

//uppgift 6
Console.WriteLine("Tryck på valfri tangent för att starta spelet!");
Console.ReadKey();

Console.WriteLine("Spelet startar!");

Console.WriteLine("Tryck valfri tangent för att avsluta...");
Console.ReadKey();