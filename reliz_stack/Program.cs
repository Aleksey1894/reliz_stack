using System;

class StackNode<T>
{
    public T Data { get; set; }
    public StackNode<T> Next { get; set; }
}
class Stack<T>
{
    public StackNode<T> top;
    public int nodeCount;

    public Stack()
    {
        this.top = null;
        this.nodeCount = 0;
    }

    public void Push(T x)
    {
        StackNode<T> frame = new StackNode<T>
        {
            Data = x,
            Next = top
        };

        top = frame;
        nodeCount++;
    }

    public bool IsEmpty()
    {
        return top == null;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("The stack is empty");
        }
        return top.Data;
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack underflow");
        }

        T topData = Peek();
        top = top.Next;
        nodeCount--;
        return topData;
    }

    public int Size()
    {
        return nodeCount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);

        Console.WriteLine("The top element is " + stack.Peek());

        stack.Pop();
        stack.Pop();
        stack.Pop();
        stack.Pop();


        if (stack.IsEmpty())
        {
            Console.WriteLine("The stack is empty");
        }
        else
        {
            Console.WriteLine("The stack is not empty");
        }
    }
}


