using task_1_3.services;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Проект 1 - Дискретна математика");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Завдання номер 1.3");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Виконав студент групи ІПЗ-22, Чорний Вадим Олександрович\n");
Console.ResetColor();

Expression expr1 = new Expression("Вислів 1", "A + B");
Expression expr2 = new Expression("Вислів 2", "C * D");

// Створення контактної схеми
ContactScheme scheme = new ContactScheme("Схема 1");
scheme.AddExpression(expr1);
scheme.AddExpression(expr2);

// Відображення контактної схеми
scheme.Display();