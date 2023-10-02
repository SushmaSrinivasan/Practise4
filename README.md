# Practise4
Exercise 4 - Memory Management
NOTE - The result of the exercise must be shown to teachers and approved before it can be considered completed.
Instructions:
All code for the exercises is written in the accompanying project "SkalProj_Datastrukturer_
Memory" on the class's GitHub. The code also contains supplementary instructions.
The questions asked are answered as comments in the Code.
Exercises 1-4 are prioritized. 5-6 is extra if time is available.
Theory and facts
Much of the memory management in .NET takes care of itself, but as a programmer it is
Good to have some insight into how it works under the hood when the code is executed. The memory is then
divided into a stack (stack/stack, later called: stacken) and a heap (a tree structure,
later titled: heapen), but before we get into what these two parts deal with, let's take a
look at how they work.

The stack, as the name suggests, can be seen as a multitude of boxes stacked on top of each other. Where we
use the contents of the top box and to access the bottom one it must:
The above box is first lifted off. To exemplify this further, the stack can be seen
like shoe boxes in a shoe store, where to access the lower drawers you have to move them away
upper.

The heap, on the other hand, is not as simple to explain in words. The heap is a form of structure in which everything
is available at once with easy access. To also anchor this in reality
The data structure can be likened to a pile of clean laundry scattered across
One bed: Everything can be reached quickly and easily as long as we know what we want.

The stack keeps track of which calls and methods are executed, when the method is executed, it is discarded from
stack and the next one runs. The stack is thus self-sustaining and needs no help with
Memory. The heap, on the other hand, holds much of the information (but has no track of
execution order) need to worry about Garbage Collection. So: the shoeboxes
takes care of itself while the laundry pile has to be cleared of dirty laundry occasionally.
So what distinguishes what is stored in the stack and the heap? To understand it, let's learn more about
the four types in C#, Value Types, Reference Types, Pointers, and Instructions.

TABLE

Reference Types are types that inherit from System.Object (or are System.Object.object)
•.class
•Interface
•Object
• delegate
• String
The next type is pointers. These are not something that we need to think about but are dealt with by Common
Language Runtime (CLR). A pointer differs from reference types, in that when
Something is of a reference type, then we access it via a pointer. A pointer is thus something
that takes up space in memory and points to either another location in memory or null.
Instructions will not be covered in this exercise, but you should know that there are.
So how do we know what is stored where?
A reference type is always stored on the heap. While Value types, they are stored where they are declared.
Thus, value types can be stored on both the stack or the heap. The following examples can provide more
clarity:

PIC

This method (see image above) will all run on the stack. This is because all value types
declared in a method, which is put on the stack.
In the example on the left, however, MyValue
to lie on the heap, when declared in a
class that is a reference type.
The main difference between these two,
is that all the information in the first example will be deleted when it is finished running then
the stack cleans itself, while the MyInt from
Example two will continue to take up space on
The heap even after the stack is finished with it. It
will lie there until GC (Garbage Collector)
takes care of it.

Questions:
1. How does the stack and heap work? Please explain with an example or sketch of its
Basic function
2. What are Value Types and Reference Types and what differentiates them?
3. The following methods (see image below) generate different responses. The first returns 3, the
others return 4, why?

Data structures and memory efficiency
To facilitate memory management and write more memory-efficient functionality, it is helpful to:
have an idea of different data structures and when they can be used. You will now practice this, partly
on paper and partly by code. Remember to comment on all code.
As mentioned earlier, these exercises are carried out in the attached shell project and questions
be answered in the relevant place with comments in the code

Exercise 1: ExamineList()
A list is an abstract data structure that can be implemented in several different ways. Unlike
From arrays, lists do not have a predetermined size, but the size increases as
The number of items in the list increases. However, the list class has an underlying array that you will now
examine. To see the size of the list underlying array, use the Capacity method in
List class.

1. Complete the implementation of the ExamineList method so that the survey becomes
feasible.
2. When does the capacity of the list increase? (That is, the size of the underlying array)
3. By how much does the capacity increase?
4. Why doesn't the capacity of the list increase at the same rate as elements are added?
5. Does removing items from the list reduce capacity?
6. When is it advantageous to use a custom array instead of a list?

Exercise 2: ExamineQueue()
The queue data structure (implemented in the Queue class) works according to First In First Out
(FIFO) principle. That is, the element that is added first will be the one that is removed
first.
1. Simulate the following queue on paper:
a. ICA opens and the queue to the checkout is empty
b. Kalle joins the queue
c. Greta joins the queue
d. Kalle gets dispatched and leaves the queue
e. Stina joins the queue
f. Greta is dispatched and leaves the queue
g. Olle joins the queue
h....
2. Implement the ExamineQueue method. The method should simulate how a queue works
by allowing the user to set elements in the queue (enqueue) and delete elements
out of the queue (dequeue). Use the Queue class to help you implement the method.
Then simulate the ICA queue using your application.
g. Olle joins the queue

Exercise 3: ExamineStack()
Stacks are similar to queues, but a big difference is that stacks use First In Last
Out (FILO) principle. Thus, the element that is inserted first (push) is the one that
will be removed last (pop).
1. Once again, simulate the ICA queue on paper. This time with a stack. Why is that
Not so smart to use a stack in this case?
2. Implement a ReverseText method that loads a string from the user and
Using a stack, reverse the order of characters and then print it
reverse the string to the user.


Exercise 4: CheckParenthesis()
You should now have sufficient knowledge of the above-mentioned data structures to solve the following
problem.
We say that a string is well formed if all the brackets that are opened are also closed correctly. That
A parenthesis opens and closes correctly is dictated by the following rules:

• ), }, ] may appear only after the respective (, {, [
• Each parenthesis that is opened must be closed i.e. "(" is followed by ")"
For example, ([{}]({})) is well formed but not ({)}. Furthermore, a string can contain others
characters, such as "List<int> list = new List<int>(){2, 3, 4};" are well-formed. So we only care
about brackets!

1. Create with the help of your new knowledge functionality to control a well-formed
string on paper. You must use one or more of the data structures we
just passed through. What data structure do you use?
2. Implement the functionality of the CheckParentheses method. Let the program read
enter a string from the user and return a response reflecting whether
the string is well formed or not.

Recursion and Iteration (Extra if time is available)
To find out more about how important it is to think about how much is put on the stack
There is also this chapter on recursion and iteration. For one who is not versed, recursion can
and iteration look very similar, this because a recursion can be seen as an iteration of itself
self.

Recursion is a function that calls itself, down to a base case, and then everyone does
calculations up to the call that initiated the recursion. Below is an example of how
A recursive method can calculate the n-th odd number.



PIC

What the method does is to see if n is 1, if so it returns the first odd number 1.
Otherwise, it calls itself for a smaller n and adds two.
Exercise 5: Recursion
1. Illustrate the progress of RecursiveOdd(1), RecursiveOdd(3), and RecursiveOdd(5) on
paper to understand the recursive loop.
2. Write a RecursiveEven(int n) method that recursively calculates the n-th even number.
3. Implement a recursive function to calculate numbers in the Fibonacci sequence: (f(n) =
f(n-1) + f(n-2))

Exercise 6: Iteration
Now that you're familiar with recursion, it's time to look at iteration. Iteration is a
function that repeats the same thing until the goal is achieved. So an iterative function for
to make the previous calculation if the n-th odd number would look like:

PIC

This method starts from 1 and adds 2 until the result is the nth odd number.
1. Illustrate on paper the processes of IterativeOdd(1), IterativeOdd(3) and
IterativeOdd(5) to understand the iteration.
2. Create an IterativeEven(int n) function to iteratively calculate the n-th even number.
3. Implement an iterative version of the Fibonacci calculator.

Question:
Start with your newfound knowledge of iteration, recursion and memory management. Which of
The above features are most memory friendly and why?

	













