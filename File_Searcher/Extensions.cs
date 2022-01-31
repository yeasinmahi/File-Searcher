using System.Collections.Generic;

namespace File_Searcher
{
    public static class Extensions
    {
        public static IEnumerable<T> SafeWalk<T>(this IEnumerable<T> source)
        {
            var enumerator = source.GetEnumerator();
            bool? hasCurrent = null;

            do
            {
                try
                {
                    hasCurrent = enumerator.MoveNext();
                }
                catch
                {
                    hasCurrent = null; // we're not sure
                }

                if (hasCurrent ?? false) // if not sure, do not return value
                    yield return enumerator.Current;

            } while (hasCurrent ?? true); // if not sure, continue walking
        }

    }
}
