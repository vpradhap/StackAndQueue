using StacksAndQueues;

Console.WriteLine("\t\tStacks and Queues program");
int flag = 0;
while (flag == 0)
{
    Stacks stacks = new Stacks();
    Console.WriteLine("\n1 - Creating stack using linked list");

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
        default :
            flag = 1;
            Console.WriteLine("Enter valid number");
            break;

    }
}