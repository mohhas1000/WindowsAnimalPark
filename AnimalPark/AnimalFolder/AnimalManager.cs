using AnimalPark.Food;
using System;
using System.Collections.Generic;

namespace AnimalPark.AnimalFolder
{
    // This class has the task of storing all animal objects in a collection of the type List<IAnimal>.
    // Implementing a generic interface 
    // Serializable is used to make all animal objects contained in the AnimalManager class serializable, ->
    // -> so that the data can be saved to and opened from files 
    public class AnimalManager : ListManager<IAnimal>
    {
        private int startID = 999;

        // This method is used to add the animal object in the list.
        public bool AddAnimal(IAnimal animal)
        {
            bool key = false;
            if(animal != null)
            {
                animal.ID = GetNewID(animal.Category);
                Add(animal);
                key = true;
   
            }
            return key;
        }

        // This method is used to give the ID attribute a letter for all animal species. B for Bird Species and M for Mammal species.
        public string GetNewID(CategoryType category)
        {
            switch (category)
            {
                case CategoryType.Bird:
                    startID++;
                    return "B" + startID.ToString();
                case CategoryType.Mammal:
                    startID++;
                    return "M" + startID.ToString();
            }
            return null; 
        }
    }
}
