using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class NewItem : Form
    {
        // Item being created.
        private Item _item;

        // Initialise form and assign Enum values to combo box.
        public NewItem()
        {
            InitializeComponent();
            ItemTypeComboBox.DataSource = Enum.GetValues(typeof(ItemType));
        }
        
        // Get item being created.
        public Item CreatedItem { get { return _item; } }

        // Display error message for invalid integer parsing.
        private static void ErrorMessage(string value, string variable)
        {
            MessageBox.Show($"Error! '{variable}' cannot be '{value}' as it must be a positive number.");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Fetch values for each variable from the form's text boxes and performs error checking.
            ItemType itemType = Enum.Parse<ItemType>(ItemTypeComboBox.SelectedItem.ToString());

            string name = NameTextBox.Text;
            if (String.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show($"Error! 'Name' cannot be blank.");
                return;
            }

            string description = DescriptionTextBox.Text;
            if (String.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show($"Error! 'Description' cannot be blank.");
                return;
            }

            if ((!int.TryParse(CostTextBox.Text, out int cost)) && (cost >= 0))
            {
                ErrorMessage(CostTextBox.Text, "Cost");
                return;
            }

            if ((!int.TryParse(WeightTextBox.Text, out int weight)) && (weight >= 0))
            {
                ErrorMessage(WeightTextBox.Text, "Weight");
                return;
            }

            if ((!int.TryParse(CleaningMagicTextBox.Text, out int cleaningMagic)) && (cleaningMagic >= 0))
            {
                ErrorMessage(CleaningMagicTextBox.Text, "Cleaning Magic");
                return;
            }

            if ((!int.TryParse(ProtectiveMagicTextBox.Text, out int protectiveMagic)) && (protectiveMagic >= 0))
            {
                ErrorMessage(ProtectiveMagicTextBox.Text, "Protective Magic");
                return;
            }

            // Compares item type of item being created.
            switch (itemType)
            {
                case ItemType.Clothing:
                    _item = new ClothingItem(name, description, cost, weight, cleaningMagic, protectiveMagic);
                    break;

                case ItemType.Spell:
                    _item = new SpellItem(name, description, cost, weight, cleaningMagic, protectiveMagic);
                    break;

                case ItemType.LeftHand:
                case ItemType.RightHand:
                case ItemType.TwoHand:
                    _item = new HandItem(itemType, name, description, cost, weight, cleaningMagic, protectiveMagic);
                    break;

                default:
                    break;
            }
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
