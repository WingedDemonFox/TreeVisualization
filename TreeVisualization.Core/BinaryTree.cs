using System;
using System.Collections.Generic;

namespace TreeVisualization.Core
{
    public class BinaryTree
    {
        public BinaryTreeNode Root { get; set; } = null;

        public int Size { get; set; }

        public void Insert(int key)
        {
            throw new NotImplementedException();
        }

        public void Remove(int key)
        {
            throw new NotImplementedException();
        }

        //This method is needed to draw the tree in the blazor project
        public List<BinaryTreeNode> PreOrderAllNodes()
        {
            var preOrder = this.WritePreorder();
            var allNodesInPreorder = new List<BinaryTreeNode>();

            BinaryTreeNode[] nodes = new BinaryTreeNode[preOrder.Length];
            for (int i = 0; i < preOrder.Length; i++)
            {
                allNodesInPreorder.Add(FindTreeNode(preOrder[i]));
            }
            return allNodesInPreorder;
        }

        private BinaryTreeNode FindSymmetricPredecessor(BinaryTreeNode startNode)
        {
            throw new NotImplementedException();
        }

        private BinaryTreeNode FindTreeNode(int key)
        {
            throw new NotImplementedException();
        }

        public int[] WritePreorder()
        {
            throw new NotImplementedException();
        }

        public int[] WritePostorder()
        {
            throw new NotImplementedException();
        }
        public int[] WriteInOrder()
        {
            throw new NotImplementedException();
        }

        public string WriteBFSorder()
        {
            throw new NotImplementedException();
        }
    }
}
