using Controls;
using Controls.Container;
using Controls.Grid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.Utils
{
    public static class AllProps
    {
        private static IEnumerable<T> GetPropValues<T>(this object obj )
        {
            return obj.GetType().GetProperties().Where(p => p.CanRead).Select(p => p.GetValue(obj)).OfType<T>();
        }

        public static IEnumerable<BaseEditor> GetFields(this Container container)
        {
            return container.GetPropValues<BaseEditor>();
        }

        public static IEnumerable<BaseEditor> GetFields(this GridRow gridRow)
        {
            return gridRow.GetPropValues<BaseEditor>();
        }

        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (T item in collection) action(item);
        }

        public static string[][] ToTable<T>(this IEnumerable<T> collection, Func<T,IEnumerable<object>> func, params string[] header)
        {
            return new[] { header }.Concat(collection.Select(e => func(e).Select(v => v == null ? string.Empty : v.ToString()).ToArray())).ToArray();
        }
    }
}
