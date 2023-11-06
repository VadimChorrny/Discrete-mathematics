// See https://aka.ms/new-console-template for more information

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Проект 1 - Дискретна математика");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Завдання номер 1.1");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Варіант 19");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Виконав студент групи ІПЗ-22, Чорний Вадим Олександрович\n");
Console.ResetColor();

// Хардкодим мою формулу
Console.WriteLine("a | b | (a → b)∧(a∧b)∨b");
Console.WriteLine("--|---|-------------------");

bool[] values = { true, false };

foreach (bool a in values)
{
    foreach (bool b in values)
    {
        bool result = (!a || b) && (a && b) || b;
        Console.WriteLine($"{a} | {b} | {result}");
    }
}