using System.Collections.Generic;

namespace AnimalPark.AnimalFolder
{
    // The interface IListManager helps us to make rules for the subclass (ListManager) -->
    // --> that will be used for creating generic collection of the type list<T> where T can be any object type.
    // These methods will be used by different objects of collection of the type List<T>
    public interface IListMangager<T>
    {
        int Count { get; }
        bool Add(T type);
        bool ChangeAt(T type, int index);
        bool Checkindex(int index);
        void DeleteAll();
        bool DeleteAt(int index);
        T GetAt(int index);
        string[] GetListInfoStrings();
        List<string> ToStringList();
        void BinarySerialize(string fileName);
        void BinaryDeSerialize(string filename);

    }
}
