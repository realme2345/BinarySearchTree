using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Binary Search Tree");
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(56);
            binaryTree.Insert(30);
            binaryTree.Insert(70);
        }
    }
}
