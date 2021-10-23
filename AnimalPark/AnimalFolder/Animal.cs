using System;

// The work is done by: Mohamed Hasan.
// Course: VT2021-DA205E-18053.

namespace AnimalPark.AnimalFolder
{
    // This abstract class is used to let different animal classes, in different categories inherit methods and properties. 
    // The Animal class  has  to  implement IAnimal  and  provide  implementation  (i.e.  code)  to methods of IAnimal
    // This is needed to be able to create class hierarchy with inheritance. 
    [Serializable]
    abstract class Animal : IAnimal
    {
        // Default attributes for all animal objects that are inherited from. 
        private string species;
        private string id;
        private string name = "";
        private double age = 0;
        private GenderType gender = GenderType.Male;
        private CategoryType category = CategoryType.Mammal;

        // Dynamic methods.
        public string Name { get => name; set => name = value; }
        public double Age { get => age; set => age = value; }
        public GenderType Gender { get => gender; set => gender = value; }
        public CategoryType Category { get => category; set => category = value; }
        public string Species { get => species; set => species = value; }
        public string ID { get => id; set => id = value; }

        //this method can be used or overridden by subclasses 
        public virtual string GetCommonInfo() { 
            string strOut = string.Empty; 
        
            strOut = id + "," + name + "," + age + "," + gender; 
            
            return strOut; 
        }

        // The subclasses inherit this method and has the task of giving a body. 
        public abstract FoodSchedule GetFoodSchedule();

        // This method is overwritten and is used to retrieve all data belonging to the newly ceated animal object.  
        // The keyvord virtual is used to modify the method and can be done by the classes that inherit it.
        public virtual string getInformation()
        {
            string text = " \t       Information \n\n Type:\t\t\t     " + species
                + "\n " + "\t\t     "  + "\n Category:\t\t     " + category +"\n";
            
            return text;
        }

    }
}
