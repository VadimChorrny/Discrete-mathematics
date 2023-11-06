namespace task_1_3.services;

public class Expression
{
    private string Name { get; set; }
    private string Formula { get; set; }

    public Expression(string name, string formula)
    {
        Name = name;
        Formula = formula;
    }

    public void Display()
    {
        Console.WriteLine($"Expression: {Name}");
        Console.WriteLine($"Formula: {Formula}");
    }
}