using IteratorHW.NewCollectionsInterfaces;
namespace IteratorHW;

public class ObservableList<T> : List<T>, IObserveList<T>
{
    public event Action CollectionChanged;

    public new void Add(T item)
    {
        base.Add(item);
        CollectionChanged?.Invoke();
    }

    public new void Remove(T item)
    {
        base.Remove(item);
        CollectionChanged?.Invoke();
    }
    public new void RemoveAt(int index)
    {
        base.RemoveAt(index);
        CollectionChanged?.Invoke();
    }
}

