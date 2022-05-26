using StacksAndQueues;

Console.WriteLine("\t\tStacks and Queues program");
int flag = 0;
while (flag == 0)
{
    Stacks stacks = new Stacks();
    Queues queues = new Queues();
    Console.WriteLine("\n1 - Creating stack using linked list");
    Console.WriteLine("2 - Peek and pop operations on stack");
    Console.WriteLine("3 - Creating Queue using linked list");

    Console.Write("\nYour Pick : ");
    int pick = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    switch (pick)
    {
        case 1:
            stacks.Add(70);
            stacks.Add(30);
            stacks.Add(56);
            stacks.Display();
            break;
        case 2:
            stacks.Add(70);
            stacks.Add(30);
            stacks.Add(56);
            stacks.Display();
            stacks.Peek();
            stacks.Pop();
            stacks.Display();
            stacks.Peek();
            stacks.Pop();
            stacks.Display();
            stacks.Peek();
            stacks.Pop();
            stacks.Display();
            break;
        case 3:
            queues.Enqueue(56);
            queues.Enqueue(30);
            queues.Enqueue(70);
            queues.Display();
            break;
        default:
            flag = 1;
            Console.WriteLine("Enter valid number");
            break;

    }
}