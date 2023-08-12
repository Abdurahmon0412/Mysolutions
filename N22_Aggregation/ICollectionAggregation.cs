using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_Aggregation
{
    public interface ICollectionAggregation
    {
        List<T> Concat<T>(in List<T> listA, in List<T> listB);
        List<T> Intersect<T>(in List<T> listA, in List<T> listB);
        List<T> Except<T>(in List<T> listA, in List<T> listB);
        List<T> Union<T>(in List<T> listA, in List<T> listB);

    }
}
