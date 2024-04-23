using System;
using System.Collections.Generic;

namespace ConsoleTree
{
    public class MainClass
    {
        public class Node
        {
            public string Name { get; }
            public List<Node> Children { get; }

            public Node(string name)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Node name cannot be empty or whitespace", nameof(name));
                }

                Name = name;
                Children = new List<Node>();
            }

            public void AddChild(Node child)
            {
                if (child == null)
                {
                    throw new ArgumentNullException("Child node cannot be null");
                }

                if (Children.Contains(child))
                {
                    throw new InvalidOperationException("Child node already exists in the children list");
                }

                Children.Add(child);
            }
        }

        public class Leaf
        {
            public string Name { get; }

            public Leaf(string name)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Leaf name cannot be empty or whitespace", nameof(name));
                }

                Name = name;
            }
        }
    }
}
