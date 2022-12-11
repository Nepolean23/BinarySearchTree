using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class UC_3_AbilityToCreateBST_Search<T> where T:IComparable<T>
    {
        public T NodeData { get; set; }

        public UC_3_AbilityToCreateBST_Search<T> leftTree { get; set; }
        public UC_3_AbilityToCreateBST_Search<T> rightTree { get; set; }

        public UC_3_AbilityToCreateBST_Search(T nodeData)
        {
            this.NodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }

        int leftcount=0, rightcount=0;
        bool result = false;

        public void Insert(T item)
        {
            T Currentvalue = this.NodeData;
             if(Currentvalue.CompareTo(this.NodeData)> 0 ) 
             {
                if(this.leftTree == null)
                this.leftTree= new UC_3_AbilityToCreateBST_Search<T>(item);
                else
                    this.leftTree.Insert(item);
             }
             else
             {
                if (this.righTree == null)
                    this.righTree = new UC_3_AbilityToCreateBST_Search<T>(item);
                else
                    this.leftTree.Insert(item);
             }
        }
        public void Display()
        {
            if(leftTree!=null)
            {
                this.leftcount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if(this.rightTree!=null)
            {
                this.rightcount++;
                this.rightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size"+" "+(1+this.leftcount+this.rightcount));

        }
        public bool IfExists(T element, UC_3_AbilityToCreateBST_Search<T> node)
        {
            if (node==null)
                return false;
            if(node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST"+" "+node.NodeData);
                result = true;
            }
            else
            
                Console.WriteLine("The current element is {0}",node.NodeData);
                if (element.CompareTo(NodeData) < 0)
                    IfExists(element, node.leftTree);
                if(element.CompareTo(NodeData)>0)
                    IfExists(element, node.rightTree);
                return result;

            
        }
    }
}
