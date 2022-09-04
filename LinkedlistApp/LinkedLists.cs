using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedlistApp
{
    public class LinkedListNode
    {
        public string data;
        public LinkedListNode next;

        public LinkedListNode(string x)
        {
            data = x;
            next = null;
        }
    }

    public static class LinkedListHelpers
    {
        static int count = 0;
        static LinkedListNode Root = null;
        
        /*Add new data to front*/
        public static void AddNodeFront(string data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = Root;
            Root = node;
            count = count+1;
        }
        /*Add new data to end*/
        public static void AddNodeEnd(string data)
        {
            LinkedListNode newNode = new LinkedListNode(data);
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                LinkedListNode x = new LinkedListNode(null);
                x = Root;
                while (x.next != null)
                    x = x.next;

                x.next = newNode;
            }
        }
        
        /*print out the list */
        public static void PrintList()
        {
            LinkedListNode runner = Root;
            while(runner != null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }

        /*delete the nodes with values that are repeated more than x times*/
        public static void DeleteRepeatValues(int x)
        {
            List<NodeElements> elems = new List<NodeElements>();
            if (Root != null)
            {
                elems.Add(new NodeElements { Count = 1, NodeItem = Root.data });
                var m = Root;
                while (m.next != null)
                {
                    var item = elems.FirstOrDefault(o => o.NodeItem.Equals(m.next.data))?? new NodeElements();
                    if (item.Count == x)
                    {
                        //remove current
                        m.next = m.next.next;
                        
                    }
                    else
                    {
                        if (item.Count>0)
                        {
                            item.Count++;
                        }
                        else
                        {
                            elems.Add(new NodeElements { Count = 1, NodeItem = m.next.data });
                        }
                        m = m.next;
                    }
                }
            }
        }

        public class NodeElements
        {
            public string NodeItem { get; set; }
            public int Count { get; set; }
        }
    }
}
