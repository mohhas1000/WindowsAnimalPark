using AnimalPark.AnimalFolder;
using System.Xml.Serialization;

namespace AnimalPark.Food
{
    // This class is used for create food schedule while the program is running
    [XmlRoot("ArrayOfFoodItem")] // This is the root of the FoodItem and its use to instruct the XmlSerializer.
    public class FoodItem
    {
        // Default attributes.
        private ListManager<string> ingredients;
        private string name = "";

        // Dynamic methods.
        [XmlElement("Name")]
        public string Name { get => name; set => name = value; }

        // The variable ingredients is a collection of the type ListManager. 
        // This will be used for calling the methods (add, remove or change etc) directly from the class ListManager, without writing any manager class
        public ListManager<string> Ingredients { get => ingredients; set { } }

        // The constructor for the class. Creates an empty list.
        public FoodItem()
        {
            ingredients = new ListManager<string>();
        }

        // Returning all food items that have been created. 
        public string toString()
        {
            string text = "";
            if(ingredients.Count > 0)
            {
                for (int i = 0; i < ingredients.Count; i++)
                {
                   text += ingredients.GetAt(i).ToString() + ", ";
                }
                text = text.Remove(text.Length - 2);
            }
            return text;
        }

    }

}
