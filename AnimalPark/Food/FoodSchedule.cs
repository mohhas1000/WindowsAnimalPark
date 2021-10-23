using AnimalPark.Food;
using System;
using System.Collections.Generic;

namespace AnimalPark.AnimalFolder
{
    // The class Foodschedule is used to serve as a schedule for feeding the animals.
    [Serializable]
    public class FoodSchedule
    {
        // Default attributes for the class FoodSchedule.
        private EaterType eaterType;
        private List<string> foodList;

        // Methods
        public EaterType EaterType { get => eaterType; set => eaterType = value; }
        public List<string> Count { get => foodList; }

        // The constructor for the class. Creates an empty list.
        public FoodSchedule()
        {
            foodList = new List<string>();
        }

        // The method is used to add the schedule for the current animal. 
        public void Add(string item)
        {
            foodList.Add(item);
        }

        // The Method returns false if the given index is not within the range of the collection. 
        public bool CheckIndex(int index)
        {
            if(foodList.Count > index && foodList[index] != null)
            {
                return true;
            }
            return false;
        }

        // The method returns foodList as an aray of strings
        public string[] GetFoodListInfoStrings()
        {
            return foodList.ToArray();
        }

        public string Title()
        {
            return "sad";
        }

        public string toString()
        {
            return "sad";
        }

        public int DeleteAt(int index)
        {
            return 1;
        }
        public bool changeAt(int index, string item)
        {
            return true;
        }

    }
}