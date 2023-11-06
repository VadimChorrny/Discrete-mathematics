namespace Discrete_mathematics.services;

public class BooleanFunctions
{
    private static bool Ddnf(int a, int b, int c)
    {
        return (a == 0 && b == 0 && c == 1) || // (¬A ∧ ¬B ∧ C)
               (a == 0 && b == 1 && c == 0) || // (¬A ∧ B ∧ ¬C)
               (a == 1 && b == 0 && c == 0) || // (A ∧ ¬B ∧ ¬C)
               (a == 1 && b == 1 && c == 1); // (A ∧ B ∧ C)
    }

    private static bool Dknf(int a, int b, int c)
    {
        return (a == 0 || b == 1 || c == 0) && // (¬A ∨ B ∨ ¬C)
               (a == 0 || b == 1 || c == 1) && // (¬A ∨ B ∨ C)
               (a == 0 || b == 0 || c == 0) && // (¬A ∨ ¬B ∨ ¬C)
               (a == 1 || b == 0 || c == 0); // (A ∨ ¬B ∨ ¬C)
    }

    public static void BuildTableDdnf(int a, int b, int c)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("ДДНФ (A, B, C) = (¬A ∧ ¬B ∧ C) ∨ (¬A ∧ B ∧ ¬C) ∨ (A ∧ ¬B ∧ ¬C) ∨ (A ∧ B ∧ C)");
        Console.ResetColor();
        Console.WriteLine("Truth Table for Boolean Function F(A, B, C):");
        Console.WriteLine("A | B | C | F");
        Console.WriteLine("--------------");

        for (int A = a; A <= 1; A++)
        {
            for (int B = b; B <= 1; B++)
            {
                for (int C = c; C <= 1; C++)
                {
                    bool result = BooleanFunctions.Ddnf(A, B, C);
                    Console.WriteLine($"{A} | {B} | {C} | {Convert.ToInt32(result)}");
                }
            }
        }
    }

    public static void BuildTableDknf(int a, int b, int c)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("ДКНФ (A, B, C) = (¬A ∨ B ∨ ¬C) ∧ (¬A ∨ B ∨ C) ∧ (¬A ∨ ¬B ∨ ¬C) ∧ (A ∨ ¬B ∨ ¬C)");
        Console.ResetColor();

        Console.WriteLine("Truth Table for Boolean Function F(A, B, C):");
        Console.WriteLine("A | B | C | F");
        Console.WriteLine("--------------");

        for (int A = a; A <= 1; A++)
        {
            for (int B = b; B <= 1; B++)
            {
                for (int C = c; C <= 1; C++)
                {
                    bool result = BooleanFunctions.Dknf(A, B, C);
                    Console.WriteLine($"{A} | {B} | {C} | {Convert.ToInt32(result)}");
                }
            }
        }
    }
}