namespace AnimalPark.AnimalFolder
{
    // The interface IAnimal helps us to make rules for the subclasses. Which methods to implement or not.
    public interface IAnimal
    {
        string ID { get; set; }
        string Name { get; set; }
        double Age { get ; set; }
        GenderType Gender { get ; set ; }
        CategoryType Category { get ; set ; }
        string Species { get ; set; }
        string getInformation();

        // The abstract method is used to present the common values in ListView.
        abstract string GetCommonInfo();

        // The abstract method needs to implemented in the sub classes; Dog, Cat etc. 
        abstract FoodSchedule GetFoodSchedule();

    }
}