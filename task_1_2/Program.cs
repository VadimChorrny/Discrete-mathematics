using Discrete_mathematics.services;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Проект 1 - Дискретна математика");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Завдання номер 1.2");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Виконав студент групи ІПЗ-22, Чорний Вадим Олександрович\n");
Console.ResetColor();

Logger.Log("Напишіть 8-значний рядок:");
var input = Console.ReadLine();

if (input is { Length: < 8 })
{
    Logger.Log("Input should be at least 8 characters long.");
    return;
}

if (input != null)
{
    var truthTable = new TruthTable(input);
    truthTable.GenerateTable();
    truthTable.PrintResults();
}

// BooleanFunctions.BuildTableDdnf(0, 0, 1);
// Console.WriteLine();
// BooleanFunctions.BuildTableDknf(1, 0, 1);