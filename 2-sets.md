# II. Sets
A set is a type of data structure similar to that of an array or a list.
What sets them apart is that they can contain only one of each unique value
within the array. They are great for eliminating duplicate values and
ensuring that you only have unique values. Sets store data by creating
unique hash values for each bit of data that you put in them. These hash
values are unique to the value they are assigned to and make finding a
specific item extremely efficient. Searching for items and storing items in
a set takes O(1) time.

![Library](/Pictures/pexels-ivo-rainha-1290141.jpg)

## i. Using Sets in C#
There are a couple different ways to use a set in C#. The first is to use
the built in `HashSet<value>` structure. The HashSet uses hashes to mark a unique
value much like a key. Each value you store in the set will be given a hash
value to make it unique.

Another type of set is the `Dictionary<key,value>`. It uses a key value pair
to store unique values. The key can be defined by the programmer and when a
new value is added to the Dictionary, it must be given a key as well.

## ii. Example Problem
Logic expressions can use many different inputs, and can get pretty complicated.
It helps when you have a program to automatically simplify the expression.
In order to create the larger program that would solve this problem, perhaps
you might need to know what inputs were used in the original expression.
So you could create a function to get the inputs. A set could be used to
help solve this problem.

For example if the input is: `A'BCD' + ABC + AC'D`

The output will be: `ABCD`

You can go to the [Queues-Example.cs](Queues-Example.cs) file to look into this
example some more.

## iii. Problem
If you were running a library, you might want a way to keep track of what books
are contained in your library and how many of each you have. You could create
a program to start storing all of the names of your books and keep track of the
amount you have of each in inventory. A rather simple execution of this could be
done using the Dictionary structure included in C#.

To get started on solving this problem go to the [Queues-Problem.cs](Queues-Problem.cs)
file. Start completing each of the different modules and if you get stuck,
feel free to check out the [solution](Sets-Solution.cs) file.

