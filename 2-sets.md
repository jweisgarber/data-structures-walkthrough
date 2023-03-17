# I. Sets

## What is a set?
A set is a type of data structure similar to that of an array or a list.
What sets them apart is that they can contain only one of each unique value
within the array. They are great for eliminating duplicate values and
ensuring that you only have unique values. Sets store data by creating
unique hash values for each bit of data that you put in them. These hash
values are unique to the value they are assigned to and make finding a
specific item extremely efficient. Searching for items and storing items in
a set takes O(1) time.

## Example Problem
You are trying to design a program that will take a boolean expression as
an input, and display a KMap to the user for whatever expression they enter.
You do not know how many different variables/inputs their expression will have,
and in order to build the proper KMap you need to find out what variables are
used and how many there are. The expressions will be submitted in SOP form.

For example if the input is: `A'BCD' + ABC + AC'D`

The output will be: `ABCD`

### TO DO
Open up the [Sets.cs](Sets.cs) file and complete the FindInputs module using a set.
All the other code will already be provided.

### Solution

When you finish, test your code and compare it with the [sets_solution.cs]()
file.