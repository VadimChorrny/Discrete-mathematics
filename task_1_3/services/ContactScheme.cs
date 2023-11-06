namespace task_1_3.services;

public class ContactScheme
{
    private string Name { get; set; }
    private List<Expression> Expressions { get; set; }

    public ContactScheme(string name)
    {
        Name = name;
        Expressions = new List<Expression>();
    }

    public void AddExpression(Expression expression)
    {
        Expressions.Add(expression);
    }

    public void Display()
    {
        Console.WriteLine($"Contact Scheme: {Name}");
        foreach (var expression in Expressions)
        {
            expression.Display();
        }
    }
}