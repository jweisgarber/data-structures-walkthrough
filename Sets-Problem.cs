namespace final_project_cse_212;

public class Library
{ 
    private static Dictionary<string, int>? Books { get; set; }
    // ToDo Sets Problem
    // Write code for each of the modules in this class and run the tests
    // Using the Data-Structures-Hub.cs
    
    /*
     * Summary:
     *     Add a book to the available library of books. The title of the book will
     *     be stored as the key, and the number of books available in the library
     *     will be stored as the integer value for the key/value pair.
     *
     * Parameters:
     *     book (string) = The name of the book
     */
    public void AddBook(string book) {
        
    }

    /*
    * Summary:
    *     Checks to see if the library contains the given book by title.
    *
    * Parameters:
    *     book (string) = The name of the book
    *
    * Return:
    *     True = The book is in the library
    *     False = The book is not in the library
    */
    public bool CheckLibrary(string book)
    {

        return true;
    }

    /*
     * Summary:
     *     Checks the Library to see if there are any copies of a given book
     *     available (ie. there is at least 1 copy available).
     *
     * Parameters:
     *     book (string) = The name of the book
     *
     * Return:
     *     (int) = The number of copies available in the library
     */
    public int CheckAvailability(string book)
    {
      
        return 0;
    }

    /*
     * Summary:
     *     Checks a book out of the library. The book must be in the library
     *     and available to be checked out. Write a message to the console to
     *     show completion of the function. If there are no books available, give
     *     a message to alert the user. The same should be done if the book is not
     *     in the library.
     *
     * Parameters:
     *     book (string) = The name of the book
     */
    public void CheckoutBook(string book) {
        
    }
}