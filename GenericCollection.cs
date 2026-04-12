using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class GenericCollection
    {
        //1 
        List<int> list = new List<int>();

        public void StoreData()
        {
            list.Add(10);
            list.Add(20);
            list.Add(30);
        }

        //2
        Dictionary<int, string>  dict = new Dictionary<int, string>();

        public void StoreData2()
        {
            dict.Add(1, "John");
            dict.Add(2, "Jane");
            dict.Add(3, "Bob");
        }

        //3
        SortedList<int, int> sl = new SortedList<int, int>();

        public void StoreData3()
        {
            sl.Add(3, 3);
            sl.Add(1, 45);
            sl.Add(2, 66);
        }

        //4
        Queue<bool> qu = new Queue<bool>();

        public void StoreData4()
        {
            qu.Enqueue(true);
            qu.Enqueue(false);
            qu.Enqueue(true);

            qu.Dequeue(); 
        }

        //5
        Stack<string> st = new Stack<string>();

        public void StoreData5()
        {
            st.Push("10");
            st.Push("20");
            st.Push("30");

            st.Pop(); 
        }
    }
}
