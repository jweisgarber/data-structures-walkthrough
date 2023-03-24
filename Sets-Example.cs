namespace final_project_cse_212;

public class KMap {
    private string Expression { get; }
    private HashSet<char> Inputs { get; set; }

    public KMap (string expression) {
        Expression = expression.ToUpper();
        Inputs = new HashSet<char>();
    }
    public void FindInputs()
    {
        string validInputs = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Inputs = new HashSet<char>();
        foreach (char input in Expression)
        {
            if (validInputs.Contains(input))
                Inputs.Add(input);
        }
    }
    public void DisplayInputs()
    {
        Console.WriteLine(string.Join(",", Inputs));
    }

    public static void Test()
    {
        Console.WriteLine("Test 1");
        var kmap1 = new KMap("ABC + ABD + AB'CD");
        kmap1.FindInputs();
        kmap1.DisplayInputs();
        Console.WriteLine();
        
        Console.WriteLine("Test 2");
        kmap1 = new KMap("ABcD + AcD + bC + Bd");
        kmap1.FindInputs();
        kmap1.DisplayInputs();
    }
}