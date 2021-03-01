using NUnit.Framework;

namespace TreeVisualization.Core.Nunit
{
    [TestFixture]
    public class BinaryTreeTest_Advanced
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void HasPreorder_AsGiven()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(7);
            binaryTree.Insert(5);
            binaryTree.Insert(10);
            binaryTree.Insert(8);
            binaryTree.Insert(11);
            binaryTree.Insert(15);
            binaryTree.Insert(9);

            var preorder = binaryTree.WritePreorder();
            var preOrderExpected = new int[] { 7, 5, 10, 8, 9, 11, 15 };
            CollectionAssert.AreEqual(preOrderExpected, preorder);
        }

        [Test]
        public void HasPostorder_AsGiven()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(7);
            binaryTree.Insert(5);
            binaryTree.Insert(10);
            binaryTree.Insert(8);
            binaryTree.Insert(11);
            binaryTree.Insert(15);
            binaryTree.Insert(9);

            var postorder = binaryTree.WritePostorder();
            var postOrderExpected = new int[] { 5, 9, 8, 15, 11, 10, 7};
            CollectionAssert.AreEqual(postOrderExpected, postorder);
        }

        [Test]
        public void HasInorder_AsGiven()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(7);
            binaryTree.Insert(5);
            binaryTree.Insert(10);
            binaryTree.Insert(8);
            binaryTree.Insert(11);
            binaryTree.Insert(15);
            binaryTree.Insert(9);

            var inorder = binaryTree.WriteInOrder();
            var inOrderExpected = new int[] { 5, 7, 8, 9, 10, 11, 15 };
            CollectionAssert.AreEqual(inOrderExpected, inorder);
        }
    }
}