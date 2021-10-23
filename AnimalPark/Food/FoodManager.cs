using System.Collections.Generic;
using System.Linq;

namespace AnimalPark.Food
{
    // For grade B: This class is used to connect an animal to food items. 
    class FoodManager
    {
        // These attributes are necessary to create a list of pairs (Animal ID, ingredients)
        private Dictionary<string, string[]> f_list;
        private List<FoodItem> FoodItem_list;
        private List<string[]> box;

        // The constructor for the class. Creates an empty list.
        public FoodManager()
        {
            f_list = new Dictionary<string, string[]>();
            FoodItem_list = new List<FoodItem>();
        }

        // Adding a foodItem to a list. 
        public void addFoodItem(FoodItem fooditem)
        {
            FoodItem_list.Add(fooditem);
        }

        // Returning the foodItem List. 
        public List<FoodItem> GetFoodItems()
        {
            return FoodItem_list;
        }

        //Reset
        public void ResetAll()
        {
            FoodItem_list.Clear();
        }

        // This method is used to pair an animal with ingredients and store it in the list.  
        public void add(string refName, string[] refIngredients)
        {

            if (f_list.ContainsKey(refName)) // Goes in here if the animal already has an ingredient list.
            {
                if (!f_list[refName].Contains(refIngredients[0]))  // Prevent duplicates
                {
                    f_list[refName] = f_list[refName].Concat(refIngredients).ToArray(); // Concatenates the existing list with the new ingredients.
                }
            }
            else // NO
            {
                f_list.Add(refName, refIngredients); // Adding
            }
        }

        // When the animal is deleted, then the ingredients for the animal will be deleted here.
        public void deleteKey(string id)
        {
            f_list.Remove(id);
        }

        // Returning all the ingredients list for display
        public Dictionary<string, string[]> getAllIngredients()
        {
            return f_list;
        }

        // Returning the searched ingredient list through the animal's ID for display
        public List<string[]> GetRecipeListInfoStrings(string id)
        {
            box = new List<string[]>();
            foreach (KeyValuePair<string, string[]> entry in f_list)
            {
                if (entry.Key == id)
                {
                    box.Add(entry.Value);
                }
            }
            return box;
        }

    }
}

