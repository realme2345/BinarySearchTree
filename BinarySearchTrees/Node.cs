﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int d) // creating Constructer
        {
            data = d;
            left = null;
            right = null;
        }
    }
}

