using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinraySerchTree
{
    public class Node
    {
        public int item;

        public Node leftc;
        public Node rightc;

        public int data;

        public Node(int data)
        {
            item = data;
            leftc = null;
            rightc = null;
        }
    }
}
