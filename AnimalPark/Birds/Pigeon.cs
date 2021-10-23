using AnimalPark.AnimalFolder;
using AnimalPark.Food;
using System;

namespace AnimalPark.Birds
{
    // This class inherits from the bird class and represents all Pigeon objects. 
    [Serializable]
    class Pigeon : Bird
    {
        // This attribute is what makes Pigeon objects unique. 
        private string homingPigeon = null;

        //let subclasses fix the
        private FoodSchedule foodSchedule;

        // The base class contructor needs to be called becauce the bird class doesn't have a default constructor. 
        // The value of the attribute flyingSpeed is passed on to the Bird class.
        public Pigeon(double flyingSpeed) : base(flyingSpeed)
        {
            SetFoodSchedule();
        }

        public string HomingPigeon { get => homingPigeon; set => homingPigeon = value; }

        // This method is called from the constructor.
        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Herbivore;
            foodSchedule.Add("Morning:  Vegetables and water");
            foodSchedule.Add("Lunch:     Grains, seed and water");
            foodSchedule.Add("Evening:  Berries and water");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }

        // This method is overwritten and is used to return all values for the Pigeon object 
        public override string getInformation()
        {
            string text = base.getInformation();

            text += "\n Homing pigeon?\t      " + homingPigeon;
            return text;
        }
    }
}
