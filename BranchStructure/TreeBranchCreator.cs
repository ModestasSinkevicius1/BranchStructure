using System;

namespace BranchStructure
{   
    class TreeBranchCreator
    {
        //variable used to update deepest depth.
        private int maxDepth = 0;

        public void AddNumbers(int number, Branch b)
        {
            //checking whether if element was added to branches.
            bool isAdded = false;

            //we check if list is empty. If yes we create a new branch.
            if (b.GetBranches().Count <= 0)
            {
                b.GetBranches().Add(new Branch(number));
                isAdded = true;
            }

            //checking which side of branch should element be assigned to.
            else if (!isAdded)
                for (int i = 0; i < b.GetBranches().Count; i++)
                {
                    if (b.GetBranches()[i].GetNumber() < b.GetNumber() && number < b.GetNumber() && b.GetBranches()[i].GetNumber() != 0 && !isAdded)
                    {
                        AddNumbers(number, b.GetBranches()[i]);
                        isAdded = true;

                    }
                    else if (b.GetBranches()[i].GetNumber() > b.GetNumber() && b.GetBranches()[i].GetNumber() != 0 && !isAdded)
                    {
                        AddNumbers(number, b.GetBranches()[i]);
                        isAdded = true;
                    }

                }
            //if element was not assigned then new branch is created and assigned element there.
            if (!isAdded)
                b.GetBranches().Add(new Branch(number));
        }

        //getting the deepest depth from the branch structure.
        public int GetMaxDepth(Branch b)
        {
            return maxDepth;           
        }

        //getting all depths from the branch structure.
        public void FindDepth(Branch b, int depth)
        {
            foreach (Branch brnch in b.GetBranches())
            {
                FindDepth(brnch, depth + 1);
            }
            
            if (maxDepth < depth)
                maxDepth = depth;
        }

    }
}
