namespace IteratorHW;

static class Extensions
{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> list, Func<T, bool> predicate)
    {
        List<T> filteredList = new List<T>();

        foreach (T item in list)
        {
            if (predicate(item))
            {
                filteredList.Add(item);
            }
        }

        return filteredList;
    }
    public static IEnumerable<T> Skip<T>(this IEnumerable<T> list, int count)
    {
        if(count <= 0)
        {
            Console.WriteLine("Вкажіть додатнє число.");
            return list;
        }

        List<T> skipList = new List<T>();

        IEnumerator<T> enumerator = list.GetEnumerator();

        while (true)
        {
            bool moveNextSuccessful = enumerator.MoveNext();
            if (!moveNextSuccessful)
            {
                break;
            }

            if (count > 0)
            {
                count--;
            }
            else
            {
                skipList.Add(enumerator.Current);
            }
        }
        return skipList;
    }

    public static IEnumerable<T> SkipWhile<T>(this IEnumerable<T> source, Func<T, bool> predicate)
    {
        List<T> skipList = new List<T>();

        bool isMet = false;

        IEnumerator<T> enumerator = source.GetEnumerator();

        while (true)
        {
            bool moveNextSuccessful = enumerator.MoveNext();
            if (!moveNextSuccessful)
            {
                break;
            }

            if (!isMet && predicate(enumerator.Current))
            {
                continue;
            }
            else
            {
                isMet = true;
                skipList.Add(enumerator.Current);
            }
        }

        enumerator.Dispose();

        return skipList;
    }
    public static IEnumerable<T> Take<T>(this IEnumerable<T> list, int count)
    {
        if (count <= 0)
        {
            Console.WriteLine("Вкажіть додатнє число.");
            return list;
        }

        List<T> takenList = new List<T>();

        IEnumerator<T> enumerator = list.GetEnumerator();

        while (count > 0 && enumerator.MoveNext())
        {
            takenList.Add(enumerator.Current);
            count--;
        }

        enumerator.Dispose();

        return takenList;
    }

    public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> list, Func<T, bool> predicate)
    {
        List<T> takenList = new List<T>();
        bool isMet = false;

        IEnumerator<T> enumerator = list.GetEnumerator();

        while (!isMet && enumerator.MoveNext())
        {
            if (predicate(enumerator.Current))
            {
                takenList.Add(enumerator.Current);
            }
            else
            {
                isMet = true;
            }
        }

        enumerator.Dispose();

        return takenList;
    }

    public static T First<T>(this IEnumerable<T> list, Func<T, bool> predicate)
    {
        if (list == null)
        {
            Console.WriteLine("У списку немає елементів.");
        }

        foreach (T item in list)
        {
            if (predicate(item))
            {
                return item;
            }
        }

        return default(T);
    }

    public static T FirstOrDefault<T>(this IEnumerable<T> list, Func<T, bool> predicate)
    {
        if (list == null)
        {
            Console.WriteLine("У списку немає елементів.");
        }
        else
        {
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
        }
        return default(T);
    }

}
