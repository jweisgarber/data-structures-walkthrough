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
                int select = SelectProgram();
                if (select == 1)
                    KMap.Test();
                else
                {
                    Console.WriteLine("Now Testing Sets-Problem.cs");
                    Console.WriteLine("==================================================");
                    Console.WriteLine();
                    TestSets();
                }

                finished = true;
            }
            else if (choice == "3")
            {
                int select = SelectProgram();
                if (select == 1)
                    TestTreesExample();
               
                else {
                    Console.WriteLine("Now Testing Trees-Problem.cs");
                    Console.WriteLine("==================================================");
                    Console.WriteLine();
                    TestTrees();
                }

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
        // var library = new Library();
        var library = new LibrarySol();
        
        // Test 1: Checkout a book from an empty library
        // Output: "We do not have 'The Way of Kings' here."
        Console.WriteLine("Test 1");
        library.CheckoutBook("The Way of Kings");
        Console.WriteLine();
        
        // Test 2: Add books to the library and checkout one of them.
        // Output: "Checking out: The Way of Kings"
        Console.WriteLine("Test 2");
        library.AddBook("The Way of Kings");
        library.AddBook("Cytonic");
        library.AddBook("Starsight");
        library.AddBook("The Name of the Wind");
        library.AddBook("Skyward");
        library.AddBook("Words of Radiance");
        library.AddBook("Sufficiently Advanced Magic");
        
        library.CheckoutBook("The Way of Kings");
        Console.WriteLine();
        
        // Test 3: Checkout more books than are available.
        // Output: "Checking out: The Name of the Wind"
        //         "There are no copies of 'The Name of the Wind' available."
        Console.WriteLine("Test 3");
        library.CheckoutBook("The Name of the Wind");
        library.CheckoutBook("The Name of the Wind");
        Console.WriteLine();
        
        // Test 4: Check how many copies of 'Words of Radiance' are available.
        // Output: 2 copies of 'Words of Radiance' are available.
        Console.WriteLine("Test 4");
        library.AddBook("Words of Radiance");
        int copies = library.CheckAvailability("Words of Radiance");
        Console.WriteLine($"{copies} copies of 'Words of Radiance' are available.");
    }

    private static void TestTrees()
    {
        var tree = new RacersTree();
        // var tree = new RacersTreeSol();

        List<string> sprint = new List<string>()
        {
            "Bruce Duran,10.57",
            "Amber Nelson,10.72",
            "Tamzin Peck,10.84",
            "Maisha Hewitt,10.87",
            "Nathaniel Kaufman,10.91",
            "Jack Calhoun,10.98",
            "Marnie Archer,11.01",
            "Reuben Richmond,11.12",
            "Vincent Taylor,11.13",
            "Arman Rivera,11.43",
            "Mattie Mercado,11.87",
            "Kathleen Carlson,12.23",
            "Mark Rojas,12.24",
            "Liana Ayers,12.44",
            "Mollie Lynch,12.65"
        };
        
        foreach (var line in sprint)
        {
            var elements = line.Split(",");
            tree.Insert(elements[0], Convert.ToDouble(elements[1]));
        }

        var count = 1;
        foreach (var racer in tree)
        {
            Console.WriteLine($"{count}. {racer.Item1} - {racer.Item2}s");
            count++;
        }
        
        Console.WriteLine();
        
        // Test 2: Get the racer that finished at each time.
        Console.WriteLine("Test 2");
        var name = tree.GetRacer(11.01d); //Marnie Archer
        Console.WriteLine($"{name} finished in 11.01s");
        
        Console.WriteLine();

        name = tree.GetRacer(10.93d);
        Console.WriteLine($"{name} finished in 10.93s");
    }

    public static void TestTreesExample()
    {
        var tree = new BinarySearchTree();
        int[] numbers = { 1, 15, 23, 53, 83, 98, 122, 134, 139, 151, 157, 178, 189 };
        foreach (var number in numbers)
            tree.Insert(number);
        
        Console.WriteLine("Trees Example Test");
        Console.WriteLine(tree.ToString());
        Console.WriteLine();
        Console.WriteLine($"The tree contains 122: {tree.Contains(122)}");
        Console.WriteLine($"The tree contains 127: {tree.Contains(127)}");
        Console.WriteLine();
        Console.WriteLine("The values in reverse order:");
        foreach (var item in tree.Reverse())
        {
            Console.WriteLine(item);
        }
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