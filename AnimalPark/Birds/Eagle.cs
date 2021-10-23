using AnimalPark.AnimalFolder;
using AnimalPark.Food;
using System;

namespace AnimalPark.Birds
{
    // This class inherits from the bird class and represents all Eagle objects. 
    [Serializable]
    class Eagle : Bird
    {
        // This attribute is what makes Eagle objects unique. 
        private double eagleLength = 0000;

        //let subclasses fix the
        private FoodSchedule foodSchedule;

        // The base class contructor needs to be called becauce the bird class doesn't have a default constructor. 
        // The value of the attribute flyingSpeed is passed on to the Bird class.
        public Eagle(double flyingSpeed) : base(flyingSpeed)
        {
            SetFoodSchedule();
        }

        public double EagleLength { get => eagleLength; set => eagleLength = value; }

        // This method is called from the constructor.
        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Carnivore;
            foodSchedule.Add("Morning:  Fish and water");
            foodSchedule.Add("Lunch:     Rabbit and water");
            foodSchedule.Add("Evening:  Snake and squirrels");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }

        // This method is overwritten and is used to return all values for the Eagle object 
        public override string getInformation()
        {
            string text = base.getInformation();

            text += "\n Eagle length (cm):\t     " + eagleLength;
            return text;
        }
    }
}
