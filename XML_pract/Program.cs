using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_pract
{
    class Program
    {
        private static void PrintNodes(XmlNode nodes, int spaces)
        {
            int spacesForThisNode = spaces + 2;

            for (int i = 0; i < spacesForThisNode; i++)
                Console.Write(' ');
            Console.WriteLine(nodes.Name);
            foreach (XmlNode node in nodes)
            {
                if (node.ChildNodes.Count != 0)
                {
                    PrintNodes(node, spacesForThisNode);
                }
            }
        }
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load("XML.xml");
            var root = document.LastChild;
            Console.WriteLine(root.Name);
            var nodes = root.ChildNodes;

            int spaces = 0;
            foreach (XmlNode node in nodes)
            {
                PrintNodes(node, spaces);
            }
            Console.ReadLine();
        }
    }
}
