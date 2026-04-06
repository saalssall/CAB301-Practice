using System;


namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        { 
           
           //Stacks 
            Stacks stack = new Stacks();
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("pushing " + i);
                
                stack.push(i);
                Console.WriteLine("Top of stack holds " + stack.peek());
            }
            Console.WriteLine("Stack size = " + stack.size());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("popping " + stack.pop());
            }

            Console.WriteLine("Stack size = " + stack.size());

            if (stack.empty())
            {
                Console.WriteLine("The stack is now empty");
            }

            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("pushing " + i);
                stack.push(i);
            }

            Console.WriteLine("Peeking at the top of the stack the element is "+stack.peek());
            
            Queue<int> queue = new Queue<int>();
            
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue();
            foreach (int i in queue)
            {
                Console.WriteLine("Elements in the queue: " + i);
            }
            
            Arrays newArr = new Arrays();
            
            Node node1 = new Node("once");
            Node node2 = new Node("upon");
            Node node3 = new Node("a");
            Node node4 = new Node("time");

            node1.NextNode = node2;
            node2.NextNode = node3;
            node3.NextNode = node4;
            
            Console.WriteLine(node1);
            Console.WriteLine(node2);
            Console.WriteLine(node3);
            Console.WriteLine(node4);

            LinkedList list = new LinkedList(node1);
            Console.WriteLine("-------------");
            Console.WriteLine(list.Head.Data); // once
            Console.WriteLine(list.Tail.Data); 
            
            //Reading through the linked_list
            Console.WriteLine("-------------");
            Console.WriteLine(list.Read(1));
            Console.WriteLine(list.Read(3));
            
            //Reading through the linked_list
            Console.WriteLine("-------------");
            Console.WriteLine(list.IndexOf("time"));
            Console.WriteLine(list.IndexOf("once"));
            
            //Reading through the linked_list
            Console.WriteLine("-------------");
            list.InsertAtIndex(2, "long");
            Console.WriteLine(list.Read(2));
            
            DoublyLinkedList list2 = new DoublyLinkedList();
            
            list2.InsertAtEnd("2");
            Console.WriteLine(list2.Tail.Data);
            
        }
    }
}
