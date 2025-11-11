using System.Xml;

class Node
{
    private int key;
    private int value;
    private Node left = null;
    private Node right = null;
    
    public Node(int key, int value)
    {
        this.key = key;
        this.value = value;
    }

    public void Insert(Node node, int key, int value)
    {
        if (key < node.key)
        {
            if (node.left == null)
            {
                node.left = new Node(key, value);
            }
            else
            {
                Insert(node.left, key, value);
            }
        }
    }

   public Node Search(Node node, int key)
    {
        if (node == null)
        {
            return null;
        }

        if (node.key == key)
        {
            return node;
        }

        return (key < node.key) ? Search(node.left, key) : Search(node.right, key);
    }

    public Node GetMin(Node node)
    {
        if (node == null) return null;
        
        if (node.left == null) return node;

        return GetMin(node.left);
    }

    public Node GetMax(Node node)
    {
        if (node == null) return null;
        
        if (node.right == null) return node;

        return GetMax(node.right);
    }

    public Node Delete(Node node, int key)
    {
        if (node == null)
        {
            return null;
        }else if (key < node.key)
        {
            node.left = Delete(node.left, key);
        }else if (key > node.key)
        {
            node.right = Delete(node.right, key);
        }
        else
        {
            if (node.left == null || node.right == null)
            {
                node = (node.left == null) ? node.right : node.left;
            }
            else
            {
                Node maxInLeft = GetMax(node.left);
                node.key = maxInLeft.key;
                node.value = maxInLeft.value;
                node.right = Delete(node.right, maxInLeft.key);
            }
        }
        return node;
    }


    public void PrintTree(Node node)
    {
        if (node == null) return;
        
        PrintTree(node.left);
        Console.WriteLine(node.value);
        PrintTree(node.right);
        
    }

    public void DeleteTree(Node node)
    {
        if (node == null) return;
        
        DeleteTree(node.left);
        DeleteTree(node.right);
        Console.WriteLine(node.value);
    }

    public void CopyTree(Node node)
    {
        if (node == null) return;
        
        CopyTree(node.left);
        CopyTree(node.right);
        Console.WriteLine(node.value);
    }
}

class Program
{
    static void Main(string[] args)
    {
    }
    }