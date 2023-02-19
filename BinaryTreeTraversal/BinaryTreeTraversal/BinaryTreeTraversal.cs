using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryTreeTraversal
{
    public partial class BinaryTreeTraversal : Form
    {
        public BinaryTreeTraversal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Code for Form1_Load event handler
        }

        public class Node
        {
            public string data;
            public Node left, right;

            public Node(string item)
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
        }

        public static void Main()
        {
            BinaryTree tree = new BinaryTree();

            // 5 both sides (bali 11 nodes)
            tree.root = new Node("Button1"); // buttons sa form1 (pa-tree yung style)
            tree.root.left = new Node("Button2");
            tree.root.right = new Node("Button3");
            tree.root.left.left = new Node("Button4");
            tree.root.left.right = new Node("Button5");


            // output sa babang side ng forms with label (inorder(LTR), TLR, LRT)
            Console.Write("Inorder traversal: ");
            tree.PrintInorder(tree.root);
            Console.WriteLine(); //palabasin niyo ako sa forms mga pareh

            Console.Write("Preorder traversal: ");
            tree.PrintPreorder(tree.root);
            Console.WriteLine();

            Console.Write("Postorder traversal: ");
            tree.PrintPostorder(tree.root);
            Console.WriteLine();
        }

        private void labelLTR_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panelOutput_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Outputlabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void labelLRT_Click(object sender, EventArgs e)
        {

        }

        private void labelTLR_Click(object sender, EventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
