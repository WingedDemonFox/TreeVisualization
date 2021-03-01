using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeVisualization.Core
{
    public class BinaryTreeNode
    {
        public int Key { get; set; }
        public BinaryTreeNode Parent { get; set; } = null;
        public BinaryTreeNode LeftChild { get; set; } = null;
        public BinaryTreeNode RightChild { get; set; } = null;

        public BinaryTreeNode(int key)
        {
            Key = key;
        }

    }
}
