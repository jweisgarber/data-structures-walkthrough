namespace final_project_cse_212;

public class KMap {
    private string Expression { get; }
    private HashSet<char> Inputs { get; set; }

    public KMap (string expression) {
        Expression = expression;
        Inputs = new HashSet<char>();
    }
    public void FindInputs()
    {
        string validInputs = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        Inputs = new HashSet<char>();
        foreach (char input in Expression)
        {
            if (validInputs.Contains(input))
                Inputs.Add(input);
        }
    }

    public static void DisplayKMap(List<List<string>> kmap) {
        foreach (var line in kmap) {
            string row = "";
            foreach (var value in line) {
                row = "| " + value + " |";
            }
            Console.WriteLine(row);
        }
    }

    public void DisplayInputs()
    {
        Console.WriteLine(string.Join(",", Inputs));
    }
}
