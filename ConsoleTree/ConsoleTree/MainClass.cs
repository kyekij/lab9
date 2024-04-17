using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTree;

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
                Name = name;
                Children = new List<Node>();
            }

            public void AddChild(Node child)
            {
                Children.Add(child);
            }
        }

        public class Leaf
        {
            public string Name { get; }

            public Leaf(string name)
            {
                Name = name;
            }
        }
    }
}
