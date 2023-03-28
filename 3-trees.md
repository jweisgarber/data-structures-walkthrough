# III. Trees
![Animal Tree](/Pictures/animal-tree.jpg)
A tree data structure is a lot like the picture above. There is a root where
everything begins, and other subsystems branch out from the root. One major
example of the Tree data structure is the file system that your computer uses.
You have a root file to which all of your other files can trace back to.

## i. Example - Binary Search Tree
The binary search tree is a data structure in which all the data is placed into
a tree data structure, and each node of the tree branches off to the left and right.
on the left you might find values that are less than the value stored in the current
node, and on the right you might find values that are greater than the value stored 
in the current node.

![BST](/Pictures/binary-search-tree.png)

One of the greatest benefits of the Tree is that if it is properly balanced, it only
takes O(log n) time to find a given value. When compared to a list which retrieves a
value in O(n) time that is much faster.

The [Trees-Example.cs](Trees-Example.cs) file contains an example structure for the
Binary Search tree, and shows a few of the different functions you can implement into
it to use in your program. Open the file and examine the code to learn more about the
structure.

## ii. Problem - Racers and Race Times
You can use a tree structure to store the names and times of different racers for quick
access to the data. Your goal is to be able to implement the missing functions in
[Trees-Problem.cs](Trees-Problem.cs) and test them.

If you get stuck, feel free to look at the [Solution](Trees-Solution.cs) file and make
sure to uncomment out the test code in the [Data-Structures-Hub.cs](Data-Structures-Hub.cs)
file.