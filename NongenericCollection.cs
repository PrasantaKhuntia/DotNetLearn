using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class NongenericCollection
    {
        //1 
        ArrayList list = new ArrayList();

        public void StoreData()
        {
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add("Hello");
            list.Add(3.14);
            list.Add(true);
        }

        //2
        Hashtable ht = new Hashtable();

        public void StoreData2()
        {
            ht.Add(1, "John");
            ht.Add(2, "Jane");
            ht.Add("three", "Bob");
        }

        //3
        SortedList sl = new SortedList();

        public void StoreData3()
        {
            sl.Add(3, "Three");
            sl.Add(1, "One");
            sl.Add(2, "Two");
        }

        //4
        Queue qu = new Queue();

        public void StoreData4()
        {
            qu.Enqueue(10);
            qu.Enqueue(20);
            qu.Enqueue(30);

            qu.Dequeue(); // removes 10
        }

        //5
        Stack st = new Stack();

        public void StoreData5()
        {
            st.Push(10);
            st.Push(20);
            st.Push(30);

            st.Pop(); // removes 30
        }
    
    }
}
