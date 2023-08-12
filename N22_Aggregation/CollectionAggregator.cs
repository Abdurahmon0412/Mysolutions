using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N22_Aggregation;
namespace N22_Aggregation
{
    public class CollectionAggregator : ICollectionAggregation
    {
        public List<T> Concat<T>(in List<T> listA, in List<T> listB)
        {
            var list = new List<T>();
            list.AddRange(listA);
            list.AddRange(listB);

            return list;
        }

        public List<T> Intersect<T>(in List<T> listA, in List<T> listB)
        {
            var list = new List<T>();
            foreach (var itemA in listA)
                if (listB.Contains(itemA))
                    list.Add(itemA);

            return list;
        }

        public List<T> Except<T>(in List<T> listA, in List<T> listB)
        {
            var list = new List<T>();
            foreach(var itemA in listA)
            {
                if (!listB.Contains(itemA))
                {
                    list.Add(itemA);
                }
            }
            return list;
        }

        public List<T> Union<T>(in List<T> listA, in List<T> listB)
        {
            var list = new List<T>();
            foreach(var itemA in listA) 
            {
                if(!list.Contains(itemA))
                    list.Add(itemA);
            }
            foreach(var itemB in listB)
            {
                if (!list.Contains(itemB))
                {
                    list.Add(itemB);
                }
            }
            return list;
        }
    }
}
