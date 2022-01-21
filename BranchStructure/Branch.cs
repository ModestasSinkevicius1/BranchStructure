using System;
using System.Collections.Generic;

namespace BranchStructure
{
    class Branch
    {
        public int number { get; set; }

        private List<Branch> branches = new List<Branch>();
        public Branch(int number)
        {
            this.number = number;
        }

        public int GetNumber()
        {
            return number;
        }

        public List<Branch> GetBranches()
        {
            return branches;
        }
        
    }
}
