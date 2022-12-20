using BinraySerchTree;

namespace LinkedListExample
{
    class Progarm
    {
        public static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Insert(56);
            tree.Insert(30);
            tree.Insert(70);
            tree.Display(tree.ReturnRoot());
        }
    }
}
