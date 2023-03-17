namespace final_project_cse_212;

public class Operator
{
    private static List<Tuple<string,string>>? CallLine { get; set; }
    public Operator() {
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
        // TODO Problem 1
        // Write your code here
    }
    
    /*
     * Summary:
     *     Removes a customer from the queue when there is an employee available
     *     to take the call. Display the caller to the console to show that they
     *     have been helped. If the queue is empty, a message should be sent to
     *     the console.
     */
    public void ServiceCaller() {
        // TODO Problem 2
        // Write your code here
    }
}