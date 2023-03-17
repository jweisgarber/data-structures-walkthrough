# I. Queues
Think about every time you go to the grocery store and stand in the checkout line. The first
person in line is the first person to be helped. This is exactly what the queue data structure
does in programming. The first thing to enter the queue will be the first thing to leave the
queue. Just like the car lifts below, the first to leave will be the first to arrive. There is
an order that is followed with queues, and they maintain that order
![Gondolas](/Pictures/pexels-max-mishin-10025723.jpg)

## i. Using the structure in C#
In C#, there is a built in queue data structure. We can instantiate the structure
as follows:

`var shoppingLine = new Queue<string>();`

This would provide us with a brand new queue that stores string values.

## ii. Example
Let's get started by observing the queue at work. In [Queues-Example.cs](Queues-Example.cs),
a todo list is created to help someone stay on track of the things they need
to get done. As each item is finished the item is crossed off the list and removed
from the queue. Two functions are used quite frequently to add and remove items
from the queue. They are: 

`myqueue.Enqueue(item);` and `myqueue.Dequeue();`

To see how this all, open [Data-Structures-Hub.cs](Data-Structures-Hub.cs) and run
the program. Select Queues and the Example when prompted.

## iii. Problem
Phone Operators can receive thousands of calls a day, and there isn't always a line
open to connect directly with an employee. In order to account for this a queue is
created to add callers to a queue to be serviced when a line opens up. The operator
automatically adds and removes people from the queue in the order that they called.
We can create a program that this operator might use in order to accomplish this task.

Open the [Queues-Problem.cs](Queues-Problem.cs) file and begin completing the
`AddCaller()` and `ServiceCaller()` modules. If you need help or just want to check
your solution, then you can feel free to look at the [Queues-Solutions.cs](Queues-Solution.cs)
file. You can also uncomment the instantiation of the `OperatorSol()` class in
the [Data-Structures-Hub.cs](Data-Structures-Hub.cs) file.