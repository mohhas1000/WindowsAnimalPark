namespace AnimalPark.Birds
{
    // This class can be defined as a factory for creating bird species and returning the object. 
    class Birdfactory
    {
        // This static method receives user input (bird species and flyingspeed).   
        public static Bird CreateBird(string species, double flyingSpeed)
        {
            // Declare an object (reference variable) of the class Bird. The variable refer to the bird species that is created. 
            Bird bird = null;

            // Switch-case. Dependeing on what the user enters, it creates a bird species. 
            switch (species) 
            {
                case "Pigeon":
                    bird = new Pigeon(flyingSpeed); 
                    break;
                case "Eagle":
                    bird = new Eagle(flyingSpeed);
                    break;
            }
            return bird;
        }
    }
}
