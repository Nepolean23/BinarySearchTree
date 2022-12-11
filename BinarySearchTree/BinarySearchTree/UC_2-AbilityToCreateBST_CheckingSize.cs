using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class UC_2_AbilityToCreateBST_CheckingSize<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }

        public UC_2_AbilityToCreateBST_CheckingSize<T> leftTree { get; set; }
        public UC_2_AbilityToCreateBST_CheckingSize<T> rightTree { get; set; }

        public UC_2_AbilityToCreateBST_CheckingSize( T NodeData)
        {
            this.NodeData = NodeData;
            this.leftTree = null;
            this.rightTree = null;
        }

        int leftcount=0, rightcount=0;
        bool result=false;

        public void Insert(T item)
        {
            T currentvalue = this.NodeData;
            if (currentvalue.CompareTo(NodeData) > 0 ) 
            {
                if (leftTree == null)
                    leftTree = new UC_2_AbilityToCreateBST_CheckingSize<T>(item);
                else
                    leftTree.Insert(item);

            }
            else
            {
                if(rightTree==null)
                    rightTree=new UC_2_AbilityToCreateBST_CheckingSize<T>(item);
                else
                    rightTree.Insert(item);
            }
        }
         public void Display()
         {
            if (this.leftTree != null)
            {
                leftcount++;
                leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if(this.rightTree!=null)
            {
                rightcount++;
                rightTree.Display();
            }
         }
         public void GetSize()
         {
            Console.WriteLine("Size"+" "+(1+this.leftcount+this.rightcount));
         }

    }
}
