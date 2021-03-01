using NUnit.Framework;

namespace TreeVisualization.Core.Nunit
{
    [TestFixture]
    public class BinaryTreeTest_Basics
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void InsertKey_IntoEmptyTree_TreeHasSize1()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(5);

            Assert.IsNotNull(binaryTree.Root);
            Assert.AreEqual(binaryTree.Root.Key, 5);
            Assert.AreEqual(binaryTree.Size, 1);
        }

        [Test]
        public void InsertKey_IntoTree_TreeHasSize2_NodeLeft()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(5);

            Assert.IsNotNull(binaryTree.Root);
            Assert.AreEqual(binaryTree.Root.Key, 5);
            Assert.AreEqual(binaryTree.Size, 1);

            binaryTree.Insert(4);

            Assert.IsNotNull(binaryTree.Root.LeftChild);
            Assert.AreEqual(binaryTree.Root.LeftChild.Key, 4);
            Assert.AreEqual(binaryTree.Root.LeftChild.Parent, binaryTree.Root);
            Assert.AreEqual(binaryTree.Size, 2);
        }

        [Test]
        public void InsertKey_IntoTree_TreeHasSize3_NodeLeftRight()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(5);

            Assert.IsNotNull(binaryTree.Root);
            Assert.AreEqual(binaryTree.Root.Key, 5);
            Assert.AreEqual(binaryTree.Size, 1);

            binaryTree.Insert(3);

            Assert.IsNotNull(binaryTree.Root.LeftChild);
            Assert.AreEqual(binaryTree.Root.LeftChild.Key, 3);
            Assert.AreEqual(binaryTree.Root.LeftChild.Parent, binaryTree.Root);
            Assert.AreEqual(binaryTree.Size, 2);

            binaryTree.Insert(4);

            Assert.IsNotNull(binaryTree.Root.LeftChild.RightChild);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.Key, 4);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.Parent, binaryTree.Root.LeftChild);
            Assert.AreEqual(binaryTree.Size, 3);
        }

        [Test]
        public void InsertDuplicateKey_IntoTree_DoNothing()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(5);

            Assert.IsNotNull(binaryTree.Root);
            Assert.AreEqual(binaryTree.Root.Key, 5);
            Assert.AreEqual(binaryTree.Size, 1);

            binaryTree.Insert(3);

            Assert.IsNotNull(binaryTree.Root.LeftChild);
            Assert.AreEqual(binaryTree.Root.LeftChild.Key, 3);
            Assert.AreEqual(binaryTree.Root.LeftChild.Parent, binaryTree.Root);
            Assert.AreEqual(binaryTree.Size, 2);

            binaryTree.Insert(4);

            Assert.IsNotNull(binaryTree.Root.LeftChild.RightChild);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.Key, 4);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.Parent, binaryTree.Root.LeftChild);
            Assert.AreEqual(binaryTree.Size, 3);

            binaryTree.Insert(4);

            Assert.IsNotNull(binaryTree.Root.LeftChild.RightChild);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.Key, 4);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.Parent, binaryTree.Root.LeftChild);
            Assert.AreEqual(binaryTree.Size, 3);
        }


        [Test]
        public void RemoveRoot_ReplaceWithSymPre()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(6);

            Assert.IsNotNull(binaryTree.Root);
            Assert.AreEqual(binaryTree.Root.Key, 6);
            Assert.AreEqual(binaryTree.Size, 1);

            binaryTree.Insert(2);

            Assert.IsNotNull(binaryTree.Root.LeftChild);
            Assert.AreEqual(binaryTree.Root.LeftChild.Key, 2);
            Assert.AreEqual(binaryTree.Root.LeftChild.Parent, binaryTree.Root);
            Assert.AreEqual(binaryTree.Size, 2);

            binaryTree.Insert(4);

            Assert.IsNotNull(binaryTree.Root.LeftChild.RightChild);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.Key, 4);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.Parent, binaryTree.Root.LeftChild);
            Assert.AreEqual(binaryTree.Size, 3);

            binaryTree.Insert(3);

            Assert.IsNotNull(binaryTree.Root.LeftChild.RightChild.LeftChild);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.LeftChild.Key, 3);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.LeftChild.Parent, binaryTree.Root.LeftChild.RightChild);
            Assert.AreEqual(binaryTree.Size, 4);

            binaryTree.Remove(6);

            Assert.IsNotNull(binaryTree.Root);
            Assert.AreEqual(binaryTree.Root.Key, 4);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.Parent, binaryTree.Root.LeftChild);
            Assert.AreEqual(binaryTree.Size, 3);
        }

        [Test]
        public void RemoveLeftChildOfRoot_ReplaceWithSymPre()
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(6);

            Assert.IsNotNull(binaryTree.Root);
            Assert.AreEqual(binaryTree.Root.Key, 6);
            Assert.AreEqual(binaryTree.Size, 1);

            binaryTree.Insert(2);

            Assert.IsNotNull(binaryTree.Root.LeftChild);
            Assert.AreEqual(binaryTree.Root.LeftChild.Key, 2);
            Assert.AreEqual(binaryTree.Root.LeftChild.Parent, binaryTree.Root);
            Assert.AreEqual(binaryTree.Size, 2);

            binaryTree.Insert(4);

            Assert.IsNotNull(binaryTree.Root.LeftChild.RightChild);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.Key, 4);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.Parent, binaryTree.Root.LeftChild);
            Assert.AreEqual(binaryTree.Size, 3);

            binaryTree.Insert(3);

            Assert.IsNotNull(binaryTree.Root.LeftChild.RightChild.LeftChild);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.LeftChild.Key, 3);
            Assert.AreEqual(binaryTree.Root.LeftChild.RightChild.LeftChild.Parent, binaryTree.Root.LeftChild.RightChild);
            Assert.AreEqual(binaryTree.Size, 4);

            binaryTree.Remove(2);

            Assert.IsNotNull(binaryTree.Root);
            Assert.AreEqual(binaryTree.Root.LeftChild.Key, 4);
            Assert.AreEqual(binaryTree.Root.LeftChild.LeftChild.Parent, binaryTree.Root.LeftChild);
            Assert.AreEqual(binaryTree.Size, 3);
        }
    }
}