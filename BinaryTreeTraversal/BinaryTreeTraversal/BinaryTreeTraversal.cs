using System;
using System.Windows.Forms;

namespace BinaryTreeTraversal
{
    public partial class BinaryTreeTraversal : Form
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BinaryTreeTraversal());
        }

        private BinaryTree tree;

        public BinaryTreeTraversal()
        {
            InitializeComponent();
            tree = new BinaryTree();
        }

        private void InfixBtn_Click(object sender, EventArgs e)
        {
            SetBinaryTree();
            InfixOutput.Text = "Inorder traversal: " + tree.GetInorder();
        }

        private void PrefixBtn_Click(object sender, EventArgs e)
        {
            SetBinaryTree();
            PrefixOutput.Text = "Preorder traversal: " + tree.GetPreorder();
        }

        private void PostfixBtn_Click(object sender, EventArgs e)
        {
            SetBinaryTree();
            PostfixOutput.Text = "Postorder traversal: " + tree.GetPostorder();

        }

        private void SetBinaryTree()
        {
            //Root node of the binary tree
            tree.root = new Node(RootNodeTxtbx.Text);
            
            //Right side of the binary tree
            tree.root.right = new Node(RightNodetxtbx.Text);

            tree.root.right.left = new Node(RLNodeTxtbx.Text);
            tree.root.right.left.left = new Node(RLLNodeTxtbx.Text);
            tree.root.right.left.right = new Node(RLRNodeTxtbx.Text);

            tree.root.right.right = new Node(RRNodeTxtbx.Text);
            tree.root.right.right.left = new Node(RRLNodeTxtbx.Text);
            tree.root.right.right.right = new Node(RRRNodeTxtbx.Text);

            //Left side of the binary tree
            tree.root.left = new Node(LeftNodeTxtbx.Text);

            tree.root.left.left = new Node(LLNodeTxtbx.Text);
            tree.root.left.left.left = new Node(LLLNodeTxtbx.Text);
            tree.root.left.left.right = new Node(LLRNodeTxtbx.Text);

            tree.root.left.right = new Node(LRNodeTxtbx.Text);
            tree.root.left.right.left = new Node(LRLNodeTxtbx.Text);
            tree.root.left.right.right = new Node(LRRNodeTxtbx.Text);

        }

        private class Node
        {
            public string data;
            public Node left, right;

            public Node(string item)
            {
                data = item;
                left = right = null;
            }
        }

        private class BinaryTree
        {
            public Node root;

            public BinaryTree()
            {
                root = null;
            }

            public string GetInorder()
            {
                return TraverseInorder(root);
            }

            private string TraverseInorder(Node node)
            {
                if (node == null)
                {
                    return "";
                }

                string result = "";
                result += TraverseInorder(node.left);
                result += node.data + " ";
                result += TraverseInorder(node.right);
                return result;
            }

            public string GetPreorder()
            {
                return TraversePreorder(root);
            }

            private string TraversePreorder(Node node)
            {
                if (node == null)
                {
                    return "";
                }

                string result = "";
                result += node.data + " ";
                result += TraversePreorder(node.left);
                result += TraversePreorder(node.right);
                return result;
            }

            public string GetPostorder()
            {
                return TraversePostorder(root);
            }

            private string TraversePostorder(Node node)
            {
                if (node == null)
                {
                    return "";
                }

                string result = "";
                result += TraversePostorder(node.left);
                result += TraversePostorder(node.right);
                result += node.data + " ";
                return result;
            }
        }
    }
}
