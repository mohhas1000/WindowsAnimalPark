using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AnimalPark.Food
{
    // The FoodItemForm represents the GUI for adding a food item.
    // Has the task of storing input from the user related to the foodItem.
    public partial class FoodItemForm : Form
    {
        // These are attributes needed for the GUI
        private FoodItem fooditem;
        private string lettersbox = @"^[ a-zA-Z]+$", refName = null, refIngredients = null;

        // This is an association relation, in order to be able to access the variable ingredients.
        // This is why we can call on different methods such as "add" from the class ListManager.
        public FoodItem Fooditem { get => fooditem; set => fooditem = value; }

        // The constructor for the class.
        public FoodItemForm()
        {
            fooditem = new FoodItem();
            InitializeComponent();
            button_ok.DialogResult = DialogResult.OK;
            button_cancel.DialogResult = DialogResult.Cancel;
        }

        // The method is used when the user click on the button "delete".
        private void button_delete_Click(object sender, EventArgs e)
        {
            if(RB_Recipe.SelectedItems.Count > 0)
            {
                int index = RB_Recipe.SelectedIndices[0];
                fooditem.Ingredients.DeleteAt(index);
                RB_Recipe.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("You must select an ingredient in the list ");
            }
        }

        // The method is used when the user click on the button "change".
        private void button_change_Click(object sender, EventArgs e)
        {
            if (checkInputValue())
            {
                if (RB_Recipe.SelectedItems.Count > 0)
                {
                    int index = RB_Recipe.SelectedIndices[0];
                    fooditem.Ingredients.ChangeAt(refIngredients, index);
                    RB_Recipe.Items.Clear();
                    showItems();
                }
                else
                {
                    MessageBox.Show("You must select an ingredient in the list ");
                }
            }
        }

        // Uptade the ingrediens list.
        private void showItems()
        {
            List<string> list = fooditem.Ingredients.ToStringList();
            foreach (var x in list)
            {
                RB_Recipe.Items.Add(x);
            }
        }

        // Storing the input from user when the button "add" is clicked.
        private void add_button_Click(object sender, EventArgs e)
        {
            if (checkInputValue())
            {
                RB_Recipe.Items.Add(refIngredients);
                fooditem.Name = refName;
                fooditem.Ingredients.Add(refIngredients);
                textBox_ingedient.Text = "";
            }
        }

        // Checking the input from the user, this is to prevent compilation errors.
        private bool checkInputValue()
        {
            if (!Regex.IsMatch(textBox_Foodname.Text, lettersbox))
            {
                MessageBox.Show("Enter a valid name with letters only!");
                return false;
            }
            if (string.IsNullOrEmpty(textBox_ingedient.Text))
            {
                MessageBox.Show("Enter some value!");
                return false;
            }
            refName = textBox_Foodname.Text;
            refIngredients = textBox_ingedient.Text;
            return true;
        }
    }
}
