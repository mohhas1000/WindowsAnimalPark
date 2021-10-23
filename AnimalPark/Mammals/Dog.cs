using AnimalPark.AnimalFolder;
using AnimalPark.Food;
using System;

namespace AnimalPark.Mammals
{
    // This class inherits from the Mammal class and represents all Dog objects.
    [Serializable]
    class Dog : Mammal
    {
        // This attribute is what makes Dog objects unique. 
        private int NrOwners = 000000;

        //let subclasses fix the
        private FoodSchedule foodSchedule;

        // The base class contructor needs to be called becauce the Mammal class doesn't have a default constructor. 
        // The value of the attribute taillength is passed on to the Mammal class.
        public Dog(double taillength) : base(taillength)
        {
            SetFoodSchedule();
        }

        public int NrOwners1 { get => NrOwners; set => NrOwners = value; }
       
        // This method is called from the constructor. 
        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Omnivorous;
            foodSchedule.Add("Morning:  Carrots and water");
            foodSchedule.Add("Lunch:     Salmon and water");
            foodSchedule.Add("Evening:  Chicken and water");
        }

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }

        // This method is overwritten and is used to return all values for the Dog object 
        public override string getInformation()
        {
            string text = base.getInformation();

            text += "\n No. of owners:\t     " + NrOwners;
            return text;
        }
    }
}
