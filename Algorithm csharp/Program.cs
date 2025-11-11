using System.Xml;

class Node
{
    private int key;
    private int value;
    private Node left = null;
    private Node right = null;
    private int height = 0;
    
    public Node(int key, int value)
    {
        this.key = key;
        this.value = value;
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
    
    public void UpdateHeight(Node node)
    {
        node.height = Math.Max(GetHeight(node.left), GetHeight(node.right) + 1);
    }

    public int GetHeight(Node node)
    {
        return node == null ? -1 : node.height;
    }

    public int GetBalance(Node node)
    {
        return (node == null) ? 0 : GetHeight(node.right) - GetHeight(node.left);
    }

    public void Swap(Node a, Node b)
    {
        int a_key = a.key;
        a.key = b.key;
        b.key = a_key;
        int a_value = a.value;
        a.value = b.value;
        b.value = a_value;
    }

    public void RightRotate(Node node)
    {
        Swap(node, node.left);
        Node buffer = node.right;
        node.right = node.left;
        node.left = node.right.left;
        node.right.left = node.right.right;
        node.right.right = buffer;   
        UpdateHeight(node.right);
        UpdateHeight(node);
    }

    public void LeftRotate(Node node)
    {
        Swap(node, node.right);
        Node buffer = node.left;
        node.left = node.right;
        node.right = node.left.right;
        node.right.left = node.right.right;
        node.left.right = node.left.left;
        node.left.left = buffer;
        UpdateHeight(node.left);
        UpdateHeight(node);
    }

    public void Balance(Node node)
    {
        int balance = GetBalance(node);

        if (balance == -2)
        {
            if (GetBalance(node.left) == 1)
            {
                LeftRotate(node.left);
                RightRotate(node);
            }
            
        }else if (balance == 2)
        {
            if (GetBalance(node.right) == -1)
            {
                RightRotate(node.right);
                LeftRotate(node);
            }
        }
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
        }else if (key >= node.key)
        {
            if (node.right == null) node.right = new Node(key, value);
            else Insert(node.right, key, value);;
        }
        
        UpdateHeight(node);
        Balance(node);
    }


    public Node Delete(Node node, int key)
    {
        if (node == null)
        {
            
            return null;
        }
        else if (key < node.key)
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

        if (node != null)
        {
            UpdateHeight(node);
            Balance(node);
        }

        return node;
    }


}

class Program
{
    static void Main(string[] args)
    {
    }
    }