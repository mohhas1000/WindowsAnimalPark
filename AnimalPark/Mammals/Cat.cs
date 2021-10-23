using AnimalPark.AnimalFolder;
using AnimalPark.Food;
using System;

namespace AnimalPark.Mammals
{
    // This class inherits from the Mammal class and represents all Cat objects. 
    [Serializable]
    class Cat : Mammal
    {
        // This attribute is what makes Cat objects unique. 
        private string catColor = null;

        //let subclasses fix the
        private FoodSchedule foodSchedule;

        // The base class contructor needs to be called becauce the Mammal class doesn't have a default constructor. 
        // The value of the attribute taillength is passed on to the Mammal class.
        public Cat(double taillength) : base(taillength)
        {
            SetFoodSchedule();
        }

        public string CatColor { get => catColor; set => catColor = value; }
       
        // This method is called from the constructor. 
        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Carnivore;
            foodSchedule.Add("Morning:  Cooked beef and milk");
            foodSchedule.Add("Lunch:     Chicken and water");
            foodSchedule.Add("Evening:  Turkey and milk");
        }
        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }

        // This method is overwritten and is used to return all values for the Cat object 
        public override string getInformation()
        {
            string text = base.getInformation();

            text += "\n Cat color:\t\t     " + catColor;
            return text;
        }
    }
}
