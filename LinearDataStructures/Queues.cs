namespace Data_Structures;

public class Queue
{
    
    //Fields
    private int[] data;
    private int front;
    private int rear;
    private int count;
    private int capacity;
    
    //Constructor
    public Queue(int size)
    {
        capacity = size;
        data = new int[capacity];
        front = 0;
        rear = 0;
        count = 0;
    }

    //Enqueue
    public void Enqueue(int element)
    {
        if (count == capacity)
        {
            data[rear] = element;
        }
        
        rear = (rear + 1) % capacity;
        count++;
    }
    
    /// Removes and returns the front element
    public int Dequeue()
    {
        // check if queue is empty
        if (count == 0)
            throw new InvalidOperationException("Queue is empty.");
        int value = data[front];

        // move front circularly
        front = (front + 1) % capacity;
        count--;

        return value;
    }
    

}