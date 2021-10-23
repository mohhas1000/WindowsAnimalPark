using AnimalPark.UtilitiesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalPark.AnimalFolder
{
    // This generic class is used to create objects of collection of the type List<T>, where the symbol T defines what type it is of.
    public class ListManager<T> : IListMangager<T>
    {
        // Default attributes for the class listManager.
        private int count = 0;
        private List<T> generic_List;
        private BinSerializerUtility binutilities;
        public int Count { get => count; }

        // The constructor for the class. Creates an empty list.
        public ListManager()
        {
            binutilities = new BinSerializerUtility();
            generic_List = new List<T>();
        }

        // Add a new object to the list
        public bool Add(T type)
        {
            count++;
            generic_List.Add(type);
            return true;
        }

        // Replace (change) an object in a position with a new object.
        public bool ChangeAt(T type, int index)
        {
            generic_List.RemoveAt(index);
            generic_List.Insert(index, type);
            return true;
        }

        // Remove an object from the list.at a certain position  
        public bool DeleteAt(int index)
        {
            bool key = false;
            if (index >= 0 && index <= generic_List.Count)
            {
                generic_List.RemoveAt(index);
                --count;
                key = true;
            }
            return key;
        }

        // The method GetAnimalInfoStrings returns  an  array  (string[ ])  by  calling the GetCommonInfo() method of every element of the list. 
        public string[] GetListInfoStrings()
        {
            string[] list = new string[100];

            for (int i = 0; i < generic_List.Count(); i++)
            {
                list[i] = ((IAnimal)generic_List.ElementAt(i)).GetCommonInfo();
            }
            return list;
        }

        // For Grade B: sorting the list by either Age or Name. 
        public void sort(int v)
        {
            if (v == 1)
            {
                generic_List = generic_List.OrderByDescending(arr => ((IAnimal)arr).Age).ToList();
            }
            else
            {
                generic_List = generic_List.OrderBy(arr => ((IAnimal)arr).Name).ToList(); ;
            }
        }

        // Return an object from a certain position in the list. 
        public T GetAt(int index)
        {
            if (generic_List.Count > 0)
            {
                if (generic_List.ElementAt(index) != null)
                {
                    return generic_List.ElementAt(index);
                }
            }
            return default(T);
        }

        public bool Checkindex(int index)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            count = 0;
            generic_List.Clear();
        }

        // This method is used to return all ingrediens for a food item.
        public List<string> ToStringList()
        {
            List<string> list = new List<string>(); ;

            for (int i = 0; i < generic_List.Count(); i++)
            {
               list.Add(generic_List.ElementAt(i).ToString());
            }
            return list;
        }

        // This method is used to save the contents of the AnimalManager object by calling the class BinSerializerUtility.
        public void BinarySerialize(string fileName)
        {
            string fileExt = System.IO.Path.GetExtension(fileName);
            if(fileExt == ".bin")
            {
                binutilities.SaveBinFile<List<T>>(generic_List, fileName);
            }
        }

        // This method is used to fetch the contents of the AnimalManager object by calling the class BinSerializerUtility.
        public void BinaryDeSerialize(string fileName)
        {
            string fileExt = System.IO.Path.GetExtension(fileName);
            if (fileExt == ".bin")
            {
                generic_List = binutilities.OpenBinFile<T>(fileName);
            }
        }

    }
}
