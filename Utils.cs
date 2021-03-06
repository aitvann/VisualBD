using System;
using System.Collections.Generic;
using Npgsql;

namespace ViauslDB
{
    public static class Utils
    {
        public static void AddParametrsFromDescription(IEnumerable<(string, object)> description, NpgsqlParameterCollection parameters)
        {
            foreach (var t in description)
                parameters.AddWithValue(t.Item1, t.Item2);
        }

        public static IEnumerable<string> IncrementalNameParametrs(int initial = 1)
        {
            var i = initial;
            while (true)
                yield return $"p{i}";
        }
    }

    static class IEnumerableExtensions
    {
        public static IEnumerable<T> ToEnumerable<T>(this T item)
        {
            yield return item;
        }
    }
}
