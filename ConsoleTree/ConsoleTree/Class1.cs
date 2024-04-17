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
    public class Class1
    {
        public static void Display(Node node, int depth = 0)
        {
            Console.WriteLine(new string(' ', depth * 2) + node.Name);
            foreach (var child in node.Children)
            {
                Display(child, depth + 1);
            }
        }
    }
}
