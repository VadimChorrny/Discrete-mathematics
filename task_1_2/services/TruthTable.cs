namespace Discrete_mathematics.services;

public class TruthTable
{
    private string values;
    private string ddnf;
    private string dknf;

    public TruthTable(string input)
    {
        values = input.Substring(0, 8);
        ddnf = "";
        dknf = "";
    }

    public void GenerateTable()
    {
        Logger.Log("--------------");
        Logger.Log("A | B | C | F");
        Logger.Log("--------------");

        for (int i = 0; i < 8; i++)
        {
            int a = (i & 4) >> 2;
            int b = (i & 2) >> 1;
            int c = (i & 1);

            if (values[i] == '1')
            {
                ddnf += " v ";
                ddnf += $"{(a == 1 ? "" : "!")}a^{(b == 1 ? "" : "!")}b^{(c == 1 ? "" : "!")}c";
            }
            else
            {
                dknf += " ^ ";
                dknf += $"({(a == 0 ? "" : "!")}av{(b == 0 ? "" : "!")}bv{(c == 0 ? "" : "!")}c)";
            }

            Logger.Log($"{a} | {b} | {c} | {values[i]}");
            Logger.Log("--------------");
        }
    }

    public void PrintResults()
    {
        Logger.Log($"DDNF: {ddnf}");
        Logger.Log($"DKNF: {dknf}");
    }
}