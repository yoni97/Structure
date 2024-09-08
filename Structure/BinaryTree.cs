using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Structure
{
    public class BinaryTree
    {
        public TreeNode root;

        public BinaryTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            root = InsertRecursive(root, value);
        }

        private TreeNode InsertRecursive(TreeNode node, int value)
        {
            if (node == null)
            {
                node = new TreeNode(value);
                return node;
            }
            if (value < node.Value)
                node.Left = InsertRecursive(node.Left, value);
            else
                node.Right = InsertRecursive(node.Right, value);
            return node;
        }

        public bool Find(int value)
        {
            return FindRecursive(root, value);
        }

        public bool FindRecursive(TreeNode node, int value)
        {
            if (root == null)return false;
            if (root.Value == value) return true;
            if (value < node.Value)
                return FindRecursive(node.Left, value);
            else
                return FindRecursive(node.Right, value);
            //return FindRecursive(value < node.Value? node.Left : node.Right, value);
        }

        public int? GetMin()
        {
            return GetMin(root);
        }

        private int? GetMin(TreeNode node)
        {
            if (node == null)
                return null;
            int min = node.Value;
            while (node.Left != null)
            {
                min = node.Left.Value;
                node = node.Left;
            }

            return min;
        }

        public int? GetMax()
        {
            return GetMax(root);
        }

        private int? GetMax(TreeNode node)
        {
            if (node == null)
                return null;
            int min = node.Value;
            while (node.Right != null)
            {
                min = node.Right.Value;
                node = node.Right;
            }
            return min;
        }





        public void Delete(int value)
        {
            
                root = DeleteNode(root, value);
            
            
        }

        private TreeNode DeleteNode(TreeNode root, int value)
        {
            if (root == null)
                return null;

            if (value < root.Value)
            {
                root.Left = DeleteNode(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = DeleteNode(root.Right, value);
            }
            else
            {
                // Node with no children
                if (root.Left == null && root.Right == null)
                {
                    return null;
                }

                // Node with one child
                if (root.Left == null)
                {
                    return root.Right;
                }
                if (root.Right == null)
                {
                    return root.Left;
                }

                // Node with two children
                TreeNode minNode = GetMinValueNode(root.Right);
                root.Value = minNode.Value;
                root.Right = DeleteNode(root.Right, minNode.Value);
            }

            return root;
        }

        private TreeNode GetMinValueNode(TreeNode node)
        {
            TreeNode current = node;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }

        public TreeNode FindNodeByValue(int value)
        {
            return FindNode(root, value);
        }

        private TreeNode FindNode(TreeNode root, int value)
        {
            if (root == null)
                return null;

            if (value < root.Value)
            {
                return FindNode(root.Left, value);
            }
            else if (value > root.Value)
            {
                return FindNode(root.Right, value);
            }
            else
            {
                return root; 
            }
        }
        public void InOrder()
        {
            PrintInOrder(root);
        }
        public void PrintInOrder(TreeNode node)
        {
            if (node != null)
            {
                PrintInOrder(node.Left);
                Console.Write(node.Value + " ");
                PrintInOrder(node.Right);
            }
        }

        public void PreOrder()
        {
            PrintPreOrder(root);
        }

        public void PrintPreOrder(TreeNode node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " ");
                PrintPreOrder(node.Left);
                PrintPreOrder(node.Right);
            }
        }


        public void PostOrder()
        {
            PrintPostOrder(root);
        }

        public void PrintPostOrder(TreeNode node)
        {
            if (node != null)
            {
                PrintPostOrder(node.Left);
                PrintPostOrder(node.Right);
                Console.Write(node.Value + " ");
            }
        }

        
    }

}

