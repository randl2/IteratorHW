namespace IteratorHW.NewCollectionsInterfaces;

public interface IPriorityQueue<T>
{
    int Count { get; }
    void Enqueue(T item);
    T Dequeue();
    T Peek();
}
