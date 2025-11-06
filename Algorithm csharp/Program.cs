
using System.Collections;

public class Node<T>
{

    public T Data { get; set; }
    public Node<T>? Next { get; set; }
    
    
    public Node(T data)
    {
        Data = data;
    }
}

public class LinkedList<T> : IEnumerable<T>
{
    private Node<T> head;
    private Node<T> tail;
    private int count;

    public LinkedList(Node<T> head, Node<T> tail)
    {
        this.head = head;
        this.tail = tail;
    }

    public void Add(T data)
    {
        Node<T> node = new Node<T>(data);

        if (head == null)
        {
            head = node;
        }
        else
        {
            tail!.Next = node;
        }
        tail = node;
        count++;
    }

    public bool Remove(T data)
    {
        Node<T>? current = head;
        Node<T>? previous = null;

        while (current != null && current.Data != null)
        {
            if (current.Data.Equals(data))
            {
                if (previous == null)
                {
                    head = current.Next;
                }
                else
                {
                    previous.Next = current.Next;
                }

                count--;
                return true;
            } 
            previous = current;
             current = current.Next;
        } 
       
        return false;
    }


    public void PrintList()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
        }

        Node<T>? current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
    }

    public Node<T>? Find(T data)
    {
        if (head == null)
        {
            return null;
        }

        Node<T>? current = head;
        while (current != null)
        {
            if (current.Data != null && current.Data.Equals(data))
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public bool Contains(T data)
    {
        Node<T>? current = head;
        while (current != null)
        {
            if (current.Data != null && current.Data.Equals(data))
            {
                return true;
            }

            current = current.Next;
        }

        return false;
    }


    public void AppendFirst(T data)
    {
        Node<T> node = new Node<T>(data);
        node.Next = head;
        head = node;
        if (count == 0)
        {
            tail = head;
        }
        count++;
    }
    

    public int Count {get { return count; }}

    public bool isEmpty{get { return count == 0; }}
    

    public IEnumerator<T> GetEnumerator()
    {
        Node<T>? current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<T>)this).GetEnumerator();
    }
}

class Program
{
    static void Main(string[] args)
    {
        
    }
}