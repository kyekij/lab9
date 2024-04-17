using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ConsoleTree;
using static ConsoleTree.MainClass;

namespace ConsoleTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Создаем дерево
            var root = new Node("Root");
            var node1 = new Node("Node 1");
            var node2 = new Node("Node 2");
            var leaf1 = new Node("Leaf 1"); // Заменяем Leaf на Node
            var leaf2 = new Node("Leaf 2"); // Заменяем Leaf на Node
            var leaf3 = new Node("Leaf 3"); // Заменяем Leaf на Node

            root.AddChild(node1);
            root.AddChild(node2);
            node1.AddChild(leaf1);
            node2.AddChild(leaf2);
            node2.AddChild(leaf3);

            // Визуальное представление дерева
            Console.WriteLine("Дерево:");
            Class1.Display(root);
        }
    }

}
