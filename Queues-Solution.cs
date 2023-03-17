namespace final_project_cse_212;

public class OperatorSol
{
    private static List<Tuple<string,string>>? CallLine { get; set; }
    public OperatorSol() {
        CallLine = new List<Tuple<string, string>>();
    }

    /*
     * Summary:
     *     Adds a caller to a caller queue to await an open line to speak with
     *     a representative. The queue has a capacity of 10 waiting callers.
     *     If a new caller calls while the queue is full, then give them a
     *     courtesy message.
     *
     * Parameters:
     *     callerName (string) - The name of the caller (Ex: "Bruce Wayne").
     *     number (string) - The caller's number (Ex: "843-228-2283").
     *
     * Return:
     *     nothing
     */
    public void AddCaller(string callerName, string number)
    {
        var callerInfo = new Tuple<string, string>(callerName, number);
        
        // The CallLine has room for more in the queue.
        if (CallLine is not null && CallLine.Count <= 9)
            CallLine.Add(callerInfo);
        // The CallLine is full. Cannot add anymore.
        else 
            Console.WriteLine("Call Line is full. Please try again later.");
    }
    
    /*
     * Summary:
     *     Removes a customer from the queue when there is an employee available
     *     to take the call. Display the caller to the console to show that they
     *     have been helped. If the queue is empty, a message should be sent to
     *     the console.
     */
    public void ServiceCaller() {
        // If the queue is empty, send a message to the console saying so.
        if (CallLine!.Count == 0) {
            Console.WriteLine("Call Line is empty.");
            return;
        }
        // Otherwise provide service to the next caller
        var caller = CallLine[0];
        CallLine.Remove(caller);
        Console.WriteLine($"({caller.Item1}, {caller.Item2})");
    }
}