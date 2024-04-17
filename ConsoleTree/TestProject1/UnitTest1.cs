using ConsoleTree;
using NUnit.Framework;
using System;
using static ConsoleTree.MainClass;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }

    public class NodeTests
    {
        [Test]
        public void AddChild_ValidChild_NodeHasChild()
        {
            // Arrange
            Node parentNode = new Node("ParentNode");
            Node childNode = new Node("ChildNode");

            // Act
            parentNode.AddChild(childNode);

            // Assert
            Assert.IsTrue(parentNode.Children.Contains(childNode));
        }

        [Test]
        public void AddChild_NullChild_ThrowsArgumentNullException()
        {
            // Arrange
            Node parentNode = new Node("ParentNode");

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => parentNode.AddChild(null));
        }

        [Test]
        public void AddChild_SameChildTwice_ThrowsInvalidOperationException()
        {
            // Arrange
            Node parentNode = new Node("ParentNode");
            Node childNode = new Node("ChildNode");
            parentNode.AddChild(childNode);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => parentNode.AddChild(childNode));
        }
    }

    [TestFixture]
    public class LeafTests
    {
        [Test]
        public void LeafConstructor_ValidName_NameMatches()
        {
            // Arrange
            string name = "LeafName";

            // Act
            Leaf leaf = new Leaf(name);

            // Assert
            Assert.AreEqual(name, leaf.Name);
        }

        [Test]
        public void LeafConstructor_EmptyName_ThrowsArgumentException()
        {
            // Arrange
            string name = "";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Leaf(name));
        }

    }

    [TestFixture]
    public class MainClassTests
    {
        [Test]
        public void NodeConstructor_ValidName_NameMatches()
        {
            // Arrange
            string name = "NodeName";

            // Act
            Node node = new Node(name);

            // Assert
            Assert.AreEqual(name, node.Name);
        }

        [Test]
        public void NodeAddChild_ValidChild_ChildAdded()
        {
            // Arrange
            Node parentNode = new Node("ParentNode");
            Node childNode = new Node("ChildNode");

            // Act
            parentNode.AddChild(childNode);

            // Assert
            Assert.IsTrue(parentNode.Children.Contains(childNode));
        }

        [Test]
        public void NodeAddChild_NullChild_ThrowsArgumentNullException()
        {
            // Arrange
            Node parentNode = new Node("ParentNode");

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => parentNode.AddChild(null));
        }

        [Test]
        public void LeafConstructor_ValidName_NameMatches()
        {
            // Arrange
            string name = "LeafName";

            // Act
            Leaf leaf = new Leaf(name);

            // Assert
            Assert.AreEqual(name, leaf.Name);
        }

        [Test]
        public void LeafConstructor_EmptyName_ThrowsArgumentException()
        {
            // Arrange
            string name = "";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Leaf(name));
        }

    }
}