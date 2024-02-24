using System.Collections.Generic;
using System.Linq;

namespace TheZooSimulation
{
    public static class EnumerableExtension
    {
        public static bool IsContainsKey<T>(this IEnumerable<T> enumerable, in int index) =>
            index >= 0 && index < enumerable.Count();
    }
}
