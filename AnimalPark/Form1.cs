using System.Windows.Forms;
using System;
using AnimalPark.Bird;
using AnimalPark.AnimalFolder;
using System.Text.RegularExpressions;
using AnimalPark.Mammals;
using AnimalPark.Mammal;
using AnimalPark.Birds;
using AnimalPark.Food;
using System.Collections.Generic;
using System.IO;
using AnimalPark.UtilitiesLibrary;

// The work is done by: Mohamed Hasan.
// Course: VT2021-DA205E-18053.

namespace AnimalPark
{
    // The MainForm represents the GUI (Graphical User Interface)
    // Has the task of storing input from the user and display different results.
    public partial class mainForm : Form
    {
        // These are attributes needed for the class GUI.
        public IAnimal animal = null; // An object (reference variable) of Animal.
        private FoodManager food_manager = null;
        public AnimalManager manager = null;
        public Boolean key = false, saveKey = true;
        public string lettersbox = @"^[a-zA-Z ]+$", refName = null, imageLocation = null, refFilePath = "", RefFileName = "Untitled", refFilePathXML= "";
        public int refAge, refOwners, resultInt;
        public double refTailLength, refFlyingSpeed, refEagleLength;
        public CategoryType refCategory;
        public string refSpecies;
        private SaveFileDialog saveFile = null;
        private OpenFileDialog openFile = null;
        private DialogResult result;
        private XMLSerializerUtility utility;

        public mainForm()
        {
            InitializeComponent();
        }

        // This method is called when the form is displayed for the first time.
        private void mainForm_Load(object sender, EventArgs e)
        {
            // List boxes that bind to the enumerations GenderType and CategoryType.
            listBox_gender.DataSource = Enum.GetValues(typeof(GenderType));
            listBox_category.DataSource = Enum.GetValues(typeof(CategoryType));
            listBox_gender.SelectedIndex = 0; // Blue highlight (marking) on the first item in each category.
            listBox_category.SelectedIndex = 0;
            refCategory = CategoryType.Mammal; // Default settings.
            manager = new AnimalManager();
            food_manager = new FoodManager();
            refSpecies = "Dog";
            utility = new XMLSerializerUtility();
        }

        // This method is called when the user changes the animal directory. 
        private void listBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_category.SelectedItem != null)
            {
                CategoryType category = (CategoryType)listBox_category.SelectedItem;

                switch (category) // Display different species depending on whether it is Mammal or Bird.
                {
                    case CategoryType.Mammal:
                        listBox_species.DataSource = Enum.GetValues(typeof(MammalSpecies));
                        break;
                    case CategoryType.Bird:
                        listBox_species.DataSource = Enum.GetValues(typeof(BirdSpecies));
                        break;
                }
            }
            else
            {
                listBox_species.DataSource = Enum.GetValues(typeof(AnimalSpecies)); // For grade B: Display all species in the listbox. 
            }

        }

        // This method is called when the user changes the species directory and displays different graphical fields for input. 
        private void listBox_species_SelectedIndexChanged(object sender, EventArgs e)
        {
            refSpecies = listBox_species.SelectedItem.ToString();
            textBox_specOne.Text = "";
            textBox_secondTwo.Text = "";
            switch (refSpecies)
            {
                case "Cat":
                    groupBox_objectspec.Text = MammalSpecies.Cat.ToString() + " specifications";
                    label_firstspec.Text = "Tail length (cm): ";
                    label_secondspec.Text = "Cat color: ";
                    refCategory = CategoryType.Mammal;
                    break;
                case "Dog":
                    groupBox_objectspec.Text = MammalSpecies.Dog.ToString() + " specifications";
                    label_firstspec.Text = "Tail length (cm): ";
                    label_secondspec.Text = "No. of owners: ";
                    refCategory = CategoryType.Mammal;
                    break;
                case "Pigeon":
                    groupBox_objectspec.Text = BirdSpecies.Pigeon.ToString() + " specifications";
                    label_firstspec.Text = "Flying speed (m/s): ";
                    label_secondspec.Text = "Homing pigeon? (yes/no): ";
                    refCategory = CategoryType.Bird;
                    break;
                case "Eagle":
                    groupBox_objectspec.Text = BirdSpecies.Eagle.ToString() + " specifications";
                    label_firstspec.Text = "Flying speed (m/s): ";
                    label_secondspec.Text = "Eagle length (cm): ";
                    refCategory = CategoryType.Bird;
                    break;
                default: return;
            }

        }

        // For grade A: This method is called when user ticks the checkbox.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listBox_category.Enabled = false;
                listBox_category.ClearSelected();
            }
            else
            {
                listBox_category.Enabled = true;
                listBox_category.SelectedIndex = 0;
            }
        }

        // What happens when the user clicks on the button "Add". 
        private void add_button_Click(object sender, EventArgs e)
        {
            animal = null;
            key = validateCommonInput(); // Checks if the common inputs from the user has been confirmed.
            if (key)
            {
                if (refCategory == CategoryType.Mammal)
                {
                    animal = createMammal(); // The method createMammal is used to create a mammal species.
                }
                else
                {
                    animal = createBird(); // The method createMammal is used to create a bird species.
                }

            }

            if (animal != null)
            {
                ComboBoxForSort.SelectedIndex = 0;
                showResult(); // Display the result.
                RB_EaterType.Text = "";
                foreach (var item in animal.GetFoodSchedule().GetFoodListInfoStrings())
                {
                    RB_EaterType.Text += item.ToString() + Environment.NewLine;
                }
                showAllAnimals();
                saveKey = false;
            }
        }

        // For grade A: showing all animals in a listview. 
        private void showAllAnimals()
        {
            listView_Animals.Items.Clear();
            string[] box = manager.GetListInfoStrings();
            foreach (var x in box)
            {
                if (x != null)
                {
                    var array = x.Split(',');
                    listView_Animals.Items.Add(new ListViewItem(new string[] { array[0], array[1], array[2], array[3] }));
                }
            }
            if (listView_Animals.Items.Count > 0)
            {
                listView_Animals.Items[0].Selected = true;
            }
        }

        // The method is used to represent the result by showing all information about the newly added animal.
        private void showResult()
        {
            // Dynamic binding
            animal.Species = refSpecies;
            animal.Name = refName;
            animal.Age = refAge;
            animal.Gender = (GenderType)listBox_gender.SelectedIndex;
            labelForFood2.Text = animal.GetFoodSchedule().EaterType.ToString();
            animal.Category = refCategory;

            manager.AddAnimal(animal);
            RichBox_Result.Text = animal.getInformation();
            resetField();

        }

        // The method validates the common inputs from user and displays error message if error occurs.
        private bool validateCommonInput()
        {
            if (!Regex.IsMatch(textBox_name.Text, lettersbox))
            {
                MessageBox.Show("Enter a valid name with letters only!");
                return false;
            }
            if (!int.TryParse(textBox_age.Text, out refAge))
            {
                MessageBox.Show("Enter a valid age with numbers only!");
                return false;
            }
            refName = textBox_name.Text;
            return true;
        }

        // The method is used to sort the animal list by checking the component ComboBox.
        private void ComboBoxForSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxForSort.SelectedIndex == 1)
            {
                manager.sort(1);
            }
            if (ComboBoxForSort.SelectedIndex == 2)
            {
                manager.sort(2);
            }
            showAllAnimals();
        }

        // This method is used to present the information for the selected animal object in listview.
        private void listView_Animals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Animals.SelectedItems.Count > 0)
            {
                RB_EaterType.Text = "";
                int index = listView_Animals.SelectedIndices[0];
                animal = manager.GetAt(index);
                RichBox_Result.Text = animal.getInformation();
                labelForFood2.Text = animal.GetFoodSchedule().EaterType.ToString();
                foreach (var item in animal.GetFoodSchedule().GetFoodListInfoStrings())
                {
                    RB_EaterType.Text += item.ToString() + Environment.NewLine;
                }
                ShowRecipe();
            }
        }

        // This method create a new form to add food items and save it in the list from the class FoodManager. 
        private void FoodItem_button_Click(object sender, EventArgs e)
        {
            FoodItemForm f2 = new FoodItemForm();
            if (f2.ShowDialog() == DialogResult.OK)
            {
                if (f2.Fooditem.Ingredients.Count > 0)
                {
                    food_manager.addFoodItem(f2.Fooditem);
                    showAllFoodItems();        
                } 
            }
            
        }

        // This method is used to display all foodItems. 
        private void showAllFoodItems()
        {
            lstRecipeList.Items.Clear();
            List<FoodItem> food_list = food_manager.GetFoodItems();
            foreach (var x in food_list)
            {
                lstRecipeList.Items.Add(new ListViewItem(new string[] { x.Name, x.toString() }));
            }
        }

        // This method is used to delete an animal from the listview.
        private void delete_button_Click(object sender, EventArgs e)
        {
            if (listView_Animals.SelectedItems.Count > 0)
            {
                int index = listView_Animals.SelectedIndices[0];
                food_manager.deleteKey(manager.GetAt(index).ID);
                manager.DeleteAt(index);
                showAllAnimals();
                reset();
                saveKey = false;
            }

        }

        // Reset
        private void reset()
        {
            RichBox_Result.Text = "";
            RB_EaterType.Text = "";
            RB_Ingredients.Text = "";
        }

        // Grade B 
        // This method is used to connect an animal with a food item.
        private void connect_button_Click(object sender, EventArgs e)
        {
            if (listView_Animals.SelectedItems.Count > 0 && lstRecipeList.SelectedItems.Count > 0)
            {
                int index = listView_Animals.SelectedIndices[0];
                int index2 = lstRecipeList.SelectedIndices[0];

                string[] arr = lstRecipeList.Items[index2].SubItems[1].Text.Split(',');
                List<string> ls = new List<string>();
                ls.Add(lstRecipeList.Items[index2].SubItems[0].Text + ": ");
                foreach (var x in arr)
                {
                    ls.Add(x + ",");
                }
                ls.Add("\n");
                food_manager.add(manager.GetAt(index).ID, ls.ToArray());

                ShowRecipe();
            }
        }

        // Grade A: This method is used to display the food items associated with the selected animal.
        private void ShowRecipe()
        {
            RB_Ingredients.Text = "";
            int index = listView_Animals.SelectedIndices[0];
            List<string[]> d_list = food_manager.GetRecipeListInfoStrings(listView_Animals.Items[index].SubItems[0].Text);

            foreach (var x in d_list)
            {
                foreach (var y in x)
                {
                    RB_Ingredients.Text += y.ToString();

                }
            }
        }

        // This method is used to change a selected animal by name or age.
        private void change_button_Click(object sender, EventArgs e)
        {
            if (listView_Animals.SelectedItems.Count > 0)
            {
                int index = listView_Animals.SelectedIndices[0];
                if (Regex.IsMatch(textBox_name.Text, lettersbox))
                {
                    manager.GetAt(index).Name = textBox_name.Text;
                    manager.ChangeAt(manager.GetAt(index), index);
                    textBox_name.Text = "";
                    showAllAnimals();
                    saveKey = false;
                }
                if (int.TryParse(textBox_age.Text, out refAge))
                {
                    manager.GetAt(index).Age = Convert.ToDouble(textBox_age.Text);
                    manager.ChangeAt(manager.GetAt(index), index);
                    textBox_age.Text = "";
                    showAllAnimals();
                    saveKey = false;
                }
                else
                {
                    MessageBox.Show("Enter a valid age or name for update!");
                }
            }

        }

        private int MessageBox_Function()
        {
            result = MessageBox.Show(
                           "Do you want to save change to " + RefFileName + "?",
                           "Messsage",
                           MessageBoxButtons.YesNoCancel,
                           MessageBoxIcon.Information);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                return 1;
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }

        // This method is called when the user click on the menubutton "new".
        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            if (!saveKey)
            {
                resultInt = MessageBox_Function();
                if (resultInt == 2)
                {
                    resetAll();
                    saveKey = true;
                }
                else if (resultInt == 1)
                {
                    saveFile_Function();
                    resetAll();
                }
            }
            else
            {
                resetAll();
            }

        }

        private void OpenBFile_Click(object sender, EventArgs e)
        {
            if (!saveKey)
            {
                resultInt = MessageBox_Function();
                if (resultInt == 1)
                {
                    saveFile_Function();
                    openFile_funtion();
                }
                else if(resultInt == 2)
                {
                    openFile_funtion();
                }
            }
            else
            {
                openFile_funtion();
            }

        }

        // This method is used to allow the user to select an Binary file and presents its data.
        private void openFile_funtion()
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "Binary File(*.bin) | *.bin";
            openFile.Title = "Save as";
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                refFilePath = openFile.FileName;
                try
                {
                    manager.BinaryDeSerialize(refFilePath);
                    showAllAnimals();
                    RefFileName = Path.GetFileName(refFilePath);
                    saveKey = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("File couldn't be saved!");
            }
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            saveFile_Function();
        }

        // This method is used to allow the user to select an XML-file to save data in the file
        private void importXMLFile_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "XML Files (*.xml)|*.xml";
            openFile.Title = "Save as";
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                refFilePathXML = openFile.FileName;
                try
                {
                    List<FoodItem> box = utility.OpenXMLFile<FoodItem>(refFilePathXML);
                    foreach(var x in box)
                    {
                        food_manager.addFoodItem(x);
                    }
                    showAllFoodItems();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("File couldn't be saved!");
            }
        }

        // This method is used to allow the user to select an XML-file and presents its data.
        private void exportXMLFile_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "XML Files (*.xml)|*.xml";
            openFile.Title = "Save as";
            openFile.RestoreDirectory = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                refFilePathXML = openFile.FileName;
                try
                {
                    List<FoodItem> food_list = food_manager.GetFoodItems();
                    utility.SaveXMLFile<List<FoodItem>>(refFilePathXML, food_list);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("File couldn't be saved!");
            }
        }

        // This method is used when the user clicks on the "save File" menu button  
        private void saveFile_Function()
        {
            if (RefFileName == "Untitled")
            {
                SaveAsBFile.PerformClick();
            }
            else
            {
                try
                {
                    manager.BinarySerialize(refFilePath);
                    RefFileName = Path.GetFileName(refFilePath);
                    saveKey = true;
                    MessageBox.Show("The data has been saved!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }

            }
        }

        // This method is used to allow the user to select a file (saveFileDialog) and then save the data as a binary file.
        private void SaveAsBFile_Click(object sender, EventArgs e)
        {
            saveFile = new SaveFileDialog();
            saveFile.Filter = "Binary File(*.bin) | *.bin";
            saveFile.Title = "Save as";
            saveFile.RestoreDirectory = true;

            if (manager.Count > 0)
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    refFilePath = saveFile.FileName;
                    try
                    {
                        manager.BinarySerialize(refFilePath);
                        RefFileName = Path.GetFileName(refFilePath);
                        saveKey = true;
                        MessageBox.Show("The data has been saved!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("File couldn't be saved!");
                }
            }
            else
            {
                MessageBox.Show("There is no data for saving!");
            }

        }

        // This method is called when the user click on the menubutton "exit".
        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        // This method is called when the user wants to clear the graphic fields.
        private void resetAll()
        {
            resetField();
            checkBox1.Checked = false;
            RichBox_Result.Text = "";
            lstRecipeList.Items.Clear();
            food_manager.ResetAll();
            manager.DeleteAll();
            refFilePath = "";
            RefFileName = "Untitled";
            saveKey = true;

        }

        // This method is called when the user wants to clear the graphic fields.
        private void clear_button_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        // This class has the task of creating a bird species by reading the users input. 
        private IAnimal createBird()
        {
            animal = null;
            if (!double.TryParse(textBox_specOne.Text.ToString(), out refFlyingSpeed)) // Validates the unique value for the Bird object.
            {
                MessageBox.Show("Enter a valid value for the flying speed!");
            }
            else
            {
                animal = Birdfactory.CreateBird(refSpecies, refFlyingSpeed); // The class Birdfactory creats a bird species and get the object as return. 

                if (refSpecies == "Eagle")
                {
                    if (!double.TryParse(textBox_secondTwo.Text, out refEagleLength)) // Validates the unique value for the Eagle object. 
                    {
                        MessageBox.Show("Enter a valid value for Eagle length");
                        return null;
                    }
                    else
                    {
                        ((Eagle)animal).EagleLength = refEagleLength; // Initiates the unique value of the Eagle object. 
                    }
                }
                if (refSpecies == "Pigeon")
                {
                    if (!Regex.IsMatch(textBox_secondTwo.Text, lettersbox)) // Validates the unique value for the Pigeon object. 
                    {
                        MessageBox.Show("Enter a valid value for homing pigeon");
                        return null;
                    }
                    else
                    {
                        ((Pigeon)animal).HomingPigeon = textBox_secondTwo.Text; // Initiates the unique value of the Pigeon object. 
                    }
                }

            }
            return animal;
        }

        // This class has the task of creating a mammal species by reading the users input. 
        private IAnimal createMammal()
        {
            animal = null;
            if (!double.TryParse(textBox_specOne.Text.ToString(), out refTailLength))  // Validates the unique value for the Mammal object.
            {
                MessageBox.Show("Enter a valid value for the tail length!");
            }
            else
            {
                animal = Mammalfactory.CreateMammal(refSpecies, refTailLength); // The class MammalFactory creats a mammal species and get the object as return. 

                if (refSpecies == "Dog")
                {
                    if (!int.TryParse(textBox_secondTwo.Text, out refOwners)) // Validates the unique value for the Dog object.
                    {
                        MessageBox.Show("Enter a valid value for number of owners!");
                        return null;
                    }
                    else
                    {
                        ((Dog)animal).NrOwners1 = refOwners; // Initiates the unique value of the Dog object.
                    }
                }
                if (refSpecies == "Cat")
                {
                    if (!Regex.IsMatch(textBox_secondTwo.Text, lettersbox))// Validates the unique value for the Cat object.
                    {
                        MessageBox.Show("Enter a valid value for the cat color!");
                        return null;
                    }
                    else
                    {
                        ((Cat)animal).CatColor = textBox_secondTwo.Text; // Initiates the unique value of the Cat object.
                    }
                }

            }
            return animal;
        }

        // This method is called when the user wants to clear all the fields or after adding an animal.
        private void resetField()
        {
            textBox_name.Text = "";
            textBox_age.Text = "";
            textBox_specOne.Text = "";
            textBox_secondTwo.Text = "";
            if (!checkBox1.Checked)
            {
                listBox_category.SelectedIndex = 0;
            }
            listBox_gender.SelectedIndex = 0;
            listBox_species.SelectedIndex = 0;
            pictureBox1.ImageLocation = "";
            listView_Animals.Items.Clear();
            RB_EaterType.Text = "";
            RB_Ingredients.Text = "";
        }

        // For grade A: The user can upload an image for the selected animal. 
        private void img_button_Click(object sender, EventArgs e)
        {
            imageLocation = "";
            try
            {
                // OpenFileDialog has the task of displaying a standard dialog box that prompts the user to open a image ffile.
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|All files (*.*)|*.*";
                dialog.Title = "Load image";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
