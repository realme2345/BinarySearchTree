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
            BinaryTree<int> binaryTree = new BinaryTree<int>(56); //Creting an object for class
            binaryTree.Insert(30);  //Inserting the values to the Binary tree
            binaryTree.Insert(70);
            binaryTree.Display();
            binaryTree.GetSize();
        }
    }
}
