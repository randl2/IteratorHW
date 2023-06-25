namespace IteratorHW.Interfaces;

public interface IEnumerator<T>
{
    bool MoveNext();
    void Reset();
    T Current { get; }
}
