using System.Collections;

namespace final_project_cse_212;

public class RacersTree : IEnumerable<Tuple<string, double>> {
    private Racer? _root;

    /*
     * Summary:
     *     Insert a new node at the front (i.e. the head) of the linked list.
     * 
     * Parameters:
     *     name (string) - The name of the racer
     *     time (double) - The finishing time for the racer
     */
    public void Insert(string name, double time) {
        // TODO Implement the Insert Function
    }

    /*
     * Summary:
     *     Get the first Racer that finished with the given time.
     *
     * Parameters:
     *     time (double): The time in which the racer finished the race.
     *
     * Return:
     *     name (string): The name of the Racer
     */
    public string GetRacer(double time)
    {
        if (_root is null)
            return "";
        return _root.GetName(time);
    } 

    /*
     * Summary:
     *     Yields all values in the tree
     */
    IEnumerator IEnumerable.GetEnumerator() {
        // call the generic version of the method
        return GetEnumerator();
    }

    /*
     * Summary:
     *     Iterate forward through the RacersTree
     */
    public IEnumerator<Tuple<string, double>> GetEnumerator() {
        var numbers = new List<Tuple<string, double>>();
        TraverseForward(_root, numbers);
        foreach (var number in numbers) {
            yield return number;
        }
    }

    // Iterates forward through the RacersTree
    private void TraverseForward(Racer? node, List<Tuple<string, double>> values) {
        if (node is not null) {
            TraverseForward(node.Left, values);
            values.Add(Tuple.Create(node.Name, node.Time));
            TraverseForward(node.Right, values);
        }
    }

    public override string ToString() {
        return "<RT>{" + string.Join(", ", this) + "}";
    }
}

public class Racer
{
    public string Name { get; set; }
    public double Time { get; set; }
    public Racer? Left { get; private set; }
    public Racer? Right { get; private set; }

    public Racer(string name, double time)
    {
        Name = name;
        Time = time;
    }

    /*
     * Summary:
     *     Inserts a new racer into the tree
     *
     * Parameters:
     *     name (string): Name of the racer
     *     time (double): Time they finished in.
     */
    public void Insert(string name, double time)
    {
        // TODO Implement the Insert function.
    }

    /*
     * Summary:
     *     Get the first Racer that finished with the given time.
     *
     * Parameters:
     *     time (double): The time in which the racer finished the race.
     *
     * Return:
     *     name (string): The name of the Racer
     */
    public string GetName(double time)
    {
        // TODO Implement the GetName function.
        return "No racer";
    }
}