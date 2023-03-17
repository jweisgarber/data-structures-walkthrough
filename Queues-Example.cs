namespace final_project_cse_212;

public class ToDoList
{
    private static Queue<string>? ItemsToDo { get; set; }
    
    public ToDoList(Queue<string> itemsTodo) {
        ItemsToDo = itemsTodo;
    }

    
    /*
     * Adds an item to the end of the list
     */
    public void AddItem(string item) {
        ItemsToDo ??= new Queue<string>();
        ItemsToDo.Enqueue(item);
    }

    /*
     * Summary:
     *     Displays the current list of items in order.
     */
    public void DisplayList() {
        Console.WriteLine("Your ToDo List:");
        var itemNum = 1;
        if (ItemsToDo is not null) {
            foreach (var item in ItemsToDo) {
                Console.WriteLine($"{itemNum}. {item}");
                itemNum++;
            }
        }
    }
    
    /*
     * Summary:
     *     Removes the first item from the ToDo list
     */
    public void CrossOffItem() {
        if (ItemsToDo is null)
            return;
        ItemsToDo.Dequeue();
    }

    public static void Test()
    {
        // Add items to the queue
        Console.WriteLine("Test 1: Adding items to the Queue");
        ToDoList toDoList = new ToDoList(new Queue<string>());
        toDoList.AddItem("Eat Breakfast");
        toDoList.AddItem("Take Shower");
        toDoList.AddItem("Finish Homework");
        toDoList.AddItem("Go To Store");
        toDoList.AddItem("Play Video Games");
        toDoList.DisplayList();
        Console.WriteLine();
        
        // Cross off some items in the list
        Console.WriteLine("Test 2: Removing items from the Queue");
        toDoList.CrossOffItem();
        toDoList.CrossOffItem();
        toDoList.DisplayList();
        Console.WriteLine();
    }
}