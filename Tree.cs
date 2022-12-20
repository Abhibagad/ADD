using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BinraySerchTree
{
  public class Tree
    {
       
        public Node root;

        public Tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int id)
        {
            Node newNode = new Node(id);
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while(true)
                {
                    parent = current;
                    if(id < current.item)
                    {
                        current = current.leftc;
                        if(current == null)
                        {
                            parent.leftc = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightc;
                        if(current == null)
                        {
                            parent.rightc = newNode;
                            return;
                        }
                    }
                }
                

            }
            
        }
        public void Display(Node Root)
        {
            if (Root != null)
            {
                Console.WriteLine(Root.item + "|");
                Display(Root.leftc);
                Display(Root.rightc);
            }
        }


    }
}
