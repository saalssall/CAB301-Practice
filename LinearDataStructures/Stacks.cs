namespace Data_Structures;

public class Stacks
{
    //Learning about stacks
    static int CAPACITY = 10;
    private int capacity;
    private int numElements;
    private int[] data;


    /// constructor initializes stack
    public Stacks() {
        capacity = CAPACITY;
        numElements = 0;
        data = new int[CAPACITY];
    }


    /// returns number of elements in the stack
    public int size()
    {
        return numElements;
    }

    /// return true if the stack is empty
    public bool empty()
    {
        if (data.Length == 0)
        {
            return true;
        }
        else
        {
            Console.WriteLine("The stack is now empty");
        }
        return false;
    }

    /// adds an element to the top of the stack
    public void push(int value)
    { 
        //ensure to check if stack is full
        if (numElements == capacity)
        {
            Console.WriteLine("Cannot push to the stack because it's full.");
        }
        data[numElements] = value;
        numElements++;
    }

    /// returns the element from the top of the stack and removes it
    public int pop()
    {
        if (numElements > 0)
        {
            numElements--;
        }
        return data[numElements];
    }

    /// returns the element from the top of the stack
    public int peek()
    {
        return numElements;
    }
}