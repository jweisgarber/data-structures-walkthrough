using final_project_cse_212;

Main.Run();

public class Main{
    public static void Run() {
        Console.WriteLine("Welcome to Data Structures 101!");
        bool finished = false;

        while (!finished)
        {
            Console.WriteLine("Data Structures available:");
            Console.WriteLine("1. Queues");
            Console.WriteLine("2. Sets");
            Console.WriteLine("3. Trees");
            Console.WriteLine();
            Console.WriteLine("Which Data Structure would you like to explore? (1-3)");
            var choice = Console.ReadLine();
            Console.WriteLine("==================================================");

            if (choice == "1")
            {
                int select = SelectProgram();
                if (select == 1)
                    ToDoList.Test();
                else {
                    Console.WriteLine("Now Testing Queues-Problem.cs");
                    Console.WriteLine("==================================================");
                    Console.WriteLine();
                    TestQueues();
                }

                finished = true;
            }
            else if (choice == "2")
            {
                Console.WriteLine("Now Testing Sets.cs");
                Console.WriteLine("==================================================");
                Console.WriteLine();
                TestSets();
                finished = true;
            }
            else if (choice == "3")
            {
                Console.WriteLine("Now Testing Trees.cs");
                Console.WriteLine("==================================================");
                Console.WriteLine();
                TestTrees();
                finished = true;
            }
            else
            {
                Console.WriteLine("Please Select a Valid option");
            }
        }
    }

    private static void TestQueues()
    { 
        var callLine = new Operator();
        // var callLine = new OperatorSol();
        
        // Test 1: The queue is empty and ServiceCaller() is called.
        Console.WriteLine("Test 1:");
        callLine.ServiceCaller();
        Console.WriteLine();
        
        // Test 2: Add a caller to the queue and provide service to them.
        Console.WriteLine("Test 2:");
        callLine.AddCaller("Bruce Wayne", "843-228-2283");
        callLine.ServiceCaller();
        Console.WriteLine();
        
        // Test 3: The queue is full and another caller rings in.
        // The caller should not be added to the queue due to there not being
        // enough room.
        Console.WriteLine("Test 3:");
        callLine.AddCaller("Kent Clark", "843-175-8737");
        callLine.AddCaller("Bruce Wayne", "843-228-2283");
        callLine.AddCaller("Harley Quinn", "863-231-8739");
        callLine.AddCaller("The Joker", "867-213-3566");
        callLine.AddCaller("The Riddler","834-123-4572");
        callLine.AddCaller("Bane","459-902-3472");
        callLine.AddCaller("Crocodile","897-1234-9876");
        callLine.AddCaller("Oswald Cobblepot","798-391-0439");
        callLine.AddCaller("Dick Grayson","891-342-9730");
        callLine.AddCaller("Vic Stone","928-293-9343");
        callLine.AddCaller("Tony Stark","334-247-9033");
        Console.WriteLine();
        
        // Test 4: Remove multiple callers from the queue
        Console.WriteLine("Test 4:");
        callLine.ServiceCaller();
        callLine.ServiceCaller();
        callLine.ServiceCaller();
    }

    private static void TestSets()
    {
        Console.WriteLine("Test 1");
        var kmap1 = new KMap("ABC + ABD + AB'CD");
        kmap1.FindInputs();
        kmap1.DisplayInputs();
    }

    private static void TestTrees()
    {
        
    }

    private static int SelectProgram()
    {
        Console.WriteLine("What would you like to see? (1-2)");
        Console.WriteLine("1. Example");
        Console.WriteLine("2. Problem Tests");
        var choice = Console.ReadLine();
        Console.WriteLine();

        if (choice == "2")
            return 2;
        
        return 1;
        
    }
}