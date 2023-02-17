using System;

public class Node
{
    public int data;
    public Node left, right;

    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

public class BinaryTree
{
    public Node root;

    public BinaryTree()
    {
        root = null;
    }

    public void PrintInorder(Node node)
    {
        if (node == null)
        {
            return;
        }

        PrintInorder(node.left);
        Console.Write(node.data + " ");
        PrintInorder(node.right);
    }

    public void PrintPreorder(Node node)
    {
        if (node == null)
        {
            return;
        }

        Console.Write(node.data + " ");
        PrintPreorder(node.left);
        PrintPreorder(node.right);
    }

    public void PrintPostorder(Node node)
    {
        if (node == null)
        {
            return;
        }

        PrintPostorder(node.left);
        PrintPostorder(node.right);
        Console.Write(node.data + " ");
    }

    public static void Main()
    {
        BinaryTree tree = new BinaryTree();

        // create the tree manually
        tree.root = new Node(1);
        tree.root.left = new Node(2);
        tree.root.right = new Node(3);
        tree.root.left.left = new Node(4);
        tree.root.left.right = new Node(5);

        // print the tree in different orders
        Console.Write("Inorder traversal: ");
        tree.PrintInorder(tree.root);
        Console.WriteLine();

        Console.Write("Preorder traversal: ");
        tree.PrintPreorder(tree.root);
        Console.WriteLine();

        Console.Write("Postorder traversal: ");
        tree.PrintPostorder(tree.root);
        Console.WriteLine();
    }
}
