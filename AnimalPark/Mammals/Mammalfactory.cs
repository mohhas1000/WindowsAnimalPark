namespace AnimalPark.Mammals
{
    // This class can be defined as a factory for creating mammal species and returning the object.
    class Mammalfactory
    {
        // This static method receives user input (mammal species and taillength).
        public static Mammal CreateMammal(string species, double taillength)
        {
            // Declare an object (reference variable) of the class mammal. The variable refer to the mammal species that is created. 
            Mammal mammal = null;

            // Switch-case. Dependeing on what the user enters, it creates a mammal species. 
            switch (species)
            {
                case "Dog":
                    mammal = new Dog(taillength);
                    break;
                case "Cat":
                    mammal = new Cat(taillength);
                    break;
            }
            return mammal;
        }

    }
}
