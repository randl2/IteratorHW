namespace IteratorHW.Interfaces;

public interface IList<T> : ICollection<T>
{
    T this[int index] { get; set; }
    int IndexOf(T item);
    void RemoveAt(int index);
}