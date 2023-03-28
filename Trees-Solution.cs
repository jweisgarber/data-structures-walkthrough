using System.Collections;

namespace final_project_cse_212;

public class RacersTreeSol : IEnumerable<Tuple<string, double>> {
    private RacerSol? _root;

    /*
     * Summary:
     *     Insert a new node at the front (i.e. the head) of the linked list.
     * 
     * Parameters:
     *     name (string) - The name of the racer
     *     time (double) - The finishing time for the racer
     */
    public void Insert(string name, double time) {
        // Create new node
        RacerSol newNode = new RacerSol(name, time);
        // If the list is empty, then point both head and tail to the new node.
        if (_root is null)
            _root = newNode;
        // If the list is not empty, then only head will be affected.
        else
            _root.Insert(name, time);
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
    private void TraverseForward(RacerSol? node, List<Tuple<string, double>> values) {
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

public class RacerSol
{
    public string Name { get; set; }
    public double Time { get; set; }
    public RacerSol? Left { get; private set; }
    public RacerSol? Right { get; private set; }

    public RacerSol(string name, double time)
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
        if (time < Time) {
            if (Left is null)
                Left = new RacerSol(name, time);
            else
                Left.Insert(name, time);
        }
        else {
            if (Right is null)
                Right = new RacerSol(name, time);
            else
                Right.Insert(name, time);
        }
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
        var comparison = time.CompareTo(Time);
        if (comparison == 0)
            return Name;
        if (comparison == 1 && Right is not null)
            return Right.GetName(time);
        if (Left is not null)
            return Left.GetName(time);
        
        return "No racer";
    }
}