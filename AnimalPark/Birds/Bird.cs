using AnimalPark.AnimalFolder;
using System;

namespace AnimalPark.Birds
{
    // This class is used by different bird species that inherit the attribute flyingspeed. 
    // This class inherits from the super class Animal. 
    [Serializable]
    abstract class Bird : Animal 
    {
        // Default attributes  
        private double flyingSpeed;

        // The class constructor that receives a double value and initializes to the attribute flyingspeed.
        public Bird(double flyingSpeed)
        {
            this.flyingSpeed = flyingSpeed;
        }

        // This method is overwritten by different bird species to pass on the attribute flying speed. 
        public override string getInformation()
        {
            string text = base.getInformation();

            text += "\n Flying speed (m/s):\t     " + flyingSpeed;
            return text;
        }
    }
}
