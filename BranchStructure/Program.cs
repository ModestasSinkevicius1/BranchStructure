using System;

namespace BranchStructure
{
    class Program
    {               
        static void Main(string[] args)
        {
            //adding first element to branch.
            Branch b = new Branch(12); ;

            TreeBranchCreator tbc = new TreeBranchCreator();

            //adding couple elements to the branch structure.
            tbc.AddNumbers(9, b);
            tbc.AddNumbers(32, b);
            tbc.AddNumbers(3, b);
            tbc.AddNumbers(31, b);
            tbc.AddNumbers(2, b);
            tbc.AddNumbers(11, b);

            //finds all depths of the tree.
            tbc.FindDepth(b, 1);

            //gets deepest depth from created branch structure.
            Console.WriteLine($"The max depth of this tree is: {tbc.GetMaxDepth(b)}");

        }      
    }
}
