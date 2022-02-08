public interface IComparer<in T>
{
    int Compare(T? x, T? y);
}