using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class CollectionTypes
    {
        int n1 = 10;
        int n2 = 20;
        int n3 = 30;

        //non-generic collection
        ArrayList list = new ArrayList();
        
        public void StoreData()
        {
            list.Add(n1);
            list.Add(n2);
            list.Add(n3);
        }

        //generic collection
        List<int> list2 = new List<int>();

        public void StoreData2()
        {
            list2.Add(n1);
            list2.Add(n2);
            list2.Add(n3);
        }
    }
}
