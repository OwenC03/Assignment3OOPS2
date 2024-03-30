

namespace Assignment3.Tests
{
    public interface ILinkedListADT
    {
        void AddLast(User user);
        void Clear();
        int Count();
        User GetValue(int i);
    }
}