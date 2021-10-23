using AnimalPark.AnimalFolder;
using System;

namespace AnimalPark.Mammals
{
    // This class is used by different mammal species that inherit the attribute taillength. 
    // This class inherits from the super class Animal. 
    [Serializable]
    abstract class Mammal : Animal
    {
        // Default attributes  
        private double taillength;

        // The class constructor that receives a double value and initializes to the attribute taillength.
        public Mammal(double taillength)
        {
            this.taillength = taillength;
        }

        // This method is overwritten by different mammal species to pass on the attribute flying speed. 
        public override string getInformation()
        {
            string text = base.getInformation();

            text += "\n Tail length (cm):\t     " + taillength;
            return text;
        }
    }
}
