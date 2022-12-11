using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class UC_1_AbiltyToCreateBST_AddingNumbers<T> where T : IComparable<T>
    { 
        public T NodeData { get; set; }
        public UC_1_AbiltyToCreateBST_AddingNumbers <T> leftTree { get; set; }
        public UC_1_AbiltyToCreateBST_AddingNumbers <T> rightTree { get; set; }

        public UC_1_AbiltyToCreateBST_AddingNumbers(T nodeData)
        {
            this.NodeData = nodeData;
            this.leftTree = leftTree;
            this.rightTree = rightTree;
        }
        int leftcount=0, rightcount=0;
        bool result=false;
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if(currentNodeValue.CompareTo(item) > 0 ) 
            {
                if (this.leftTree == null)
                    this.leftTree = new UC_1_AbiltyToCreateBST_AddingNumbers<T>(item);
                else
                    this.leftTree.Insert(item);

                
            }
            else 
            {
                if (this.rightTree == null)
                    this.rightTree = new UC_1_AbiltyToCreateBST_AddingNumbers<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }



         


    }
}
