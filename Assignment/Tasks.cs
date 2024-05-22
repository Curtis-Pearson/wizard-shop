using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Tasks
    {
        // Create an instance of the shop
        // This is used to keep track of the shops current state
        private Shop _theShop = new Shop();

        // Create an instance of the character
        // This is used to keep track of the characters current state
        private Character _theCharacter = new Character(300, 0, 0, 0, 150, 0, 0, 0, 0, 0);


        // TASK 1 -----------------------------------------------
        // 1a - Create the item hierarchy
        // 1b - Load the items from the file and create instances of the items
        // 1c - Add the items to the shop list
        // ------------------------------------------------------

        // TODO: This should load the items from the file and create instances of the items adding them to the shop.
        public void LoadShop()
        {
            // Opens items text file, looping through each line/item.
            StreamReader items = new StreamReader("items.txt");
            string lineReader = items.ReadLine();
            while (lineReader != null)
            {
                // Splits line and parses integer values of each item.
                string[] lineSplit = lineReader.Split('|');
                int cost = int.Parse(lineSplit[3]);
                int weight = int.Parse(lineSplit[4]);
                int cleaningMagic = int.Parse(lineSplit[5]);
                int protectiveMagic = int.Parse(lineSplit[6]);

                // Identifies item type and creates an instance of the item, adding it to the shop.
                if (lineSplit[0].Equals("C"))
                {
                    _theShop.AddItem(new ClothingItem(lineSplit[1], lineSplit[2], cost, weight, cleaningMagic, protectiveMagic));
                }
                else if (lineSplit[0].Equals("S"))
                {
                    _theShop.AddItem(new SpellItem(lineSplit[1], lineSplit[2], cost, weight, cleaningMagic, protectiveMagic));
                }
                else
                {
                    ItemType itemType;
                    if (lineSplit[0].Equals("H1L"))
                    {
                        itemType = ItemType.LeftHand;
                    }
                    else if (lineSplit[0].Equals("H1R"))
                    {
                        itemType = ItemType.RightHand;
                    }
                    else
                    {
                        itemType = ItemType.TwoHand;
                    }
                    _theShop.AddItem(new HandItem(itemType, lineSplit[1], lineSplit[2], cost, weight, cleaningMagic, protectiveMagic));
                }
                lineReader = items.ReadLine();
            }
            items.Close();

            _theShop.ShopList.Sort();
        }


        // TASK 2 -------------------------------------------------------
        // 2a - Buy Items from the shop into the inventory 
        // 2b - Sell items from the inventory into the shop 
        // 2c - Update the character's constructur so that when it is created it starts with the correct gold and max weight
        //      Update the characters gold based on the items that the character has equipped in their 3 type inventories
        //      Update the Buy Items to only buy items if the player has enough gold
        // 2d - Add a new item to the shop 
        // 2e - Remove a selected item from the shop 
        // --------------------------------------------------------------


        // TODO: This is called when the Buy button is clicked.
        // The selected item in the shop has been passed to this method for you.
        // This should call the appropriate methods provided by the shop and character classes
        public bool BuyItemFromShop(Item item)
        {
            if (_theCharacter.BuyItem(item))
            {
                _theCharacter.InventoryList.Add(item);
                _theCharacter.InventoryList.Sort();
                _theShop.RemoveItem(item);
                return true;
            }
            return false;
        }

        // TODO: This is called when the Sell button is clicked.
        // The selected item in the inventory has been passed to this method for you.
        // This should call the appropriate methods provided by the shop and character classes
        public bool SellItemToShop(Item item)
        {
            if (_theCharacter.SellItem(item))
            {
                _theCharacter.InventoryList.Remove(item);
                _theShop.AddItem(item);
                _theShop.ShopList.Sort();
                return true;
            }
            return false;
        }

        // TODO: This is called when the Create button is clicked.
        // This should create a new dialog box which allows a new item to be created.
        public void CreateShopItem()
        {
            NewItem newForm = new NewItem();
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                _theShop.AddItem(newForm.CreatedItem);
                _theShop.ShopList.Sort();
                MessageBox.Show($"'{newForm.CreatedItem.Name}' has been added to the shop.");
            }
        }

        // TODO: This is called when the Remove button is clicked.
        // This should remove the selected item from the shop.
        public bool RemoveShopItem(Item item)
        {
            if (_theShop.ShopList.Contains(item))
            {
                _theShop.RemoveItem(item);
                return true;
            }
            return false;
        }

        // TASK 3 -------------------------------------------------------
        // 3a - Eqiup character with item in correct list (hand, clothing or spell)
        // 3b - Unequip the selected item so it appears back in the inventory
        // 3c - Update the cleaning magic label
        // 3d - Update the protective magic label
        // 3e - Update the Equip character so that it only Equips based on the equipping rules
        // 3f - Sort any list of type List<Item> by implementing the IComparable interface.
        //      You will need to call sort in the right places. 
        // --------------------------------------------------------------

        // TODO: This is called when the Euip button is clicked.
        // The selected item in the inventory has been passed to this method for you.
        // This should call the appropriate method provided by the character class
        public bool EquipItem(Item item)
        {
            if (_theCharacter.EquipItem(item))
            {
                return true;
            }
            return false;
        }

        // TODO: This is called when the Uneuip button is clicked.
        // The selected item in the character’s panel has been passed to this method for you.
        // This should call the appropriate method provided by the character class
        public bool UnequipItem(Item item)
        {
            if (_theCharacter.UnequipItem(item))
            {
                return true;
            }
            return false;
        }
     

        // TASK 4 -------------------------------------------------------
        // 4a - Save the current state of the program
        // 4b - Load the current state of the program
        // --------------------------------------------------------------

        // TODO: This is called when the Save menu item is clicked.
        // This should save the state of the program.
        public void SaveState()
        {
            // Opens or creates SaveFile.txt.
            StreamWriter saveFile = new StreamWriter("SaveFile.txt", false);

            // Iterates through a given list and writes each item's properties to the file.
            void WriteListToFile(List<Item> list)
            {
                saveFile.WriteLine(list.Count);
                foreach (var item in list)
                {
                    saveFile.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}", item.TypeOfItem, item.Name,
                        item.Description, item.Cost, item.Weight, item.CleaningMagic, item.ProtectiveMagic);
                }
            }

            // Writes the character's statistics to the file.
            saveFile.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}", _theCharacter.Gold, _theCharacter.CurrentWeight,
                _theCharacter.CleaningMagic, _theCharacter.ProtectiveMagic, _theCharacter.MaxWeight, _theCharacter.NumberClothing,
                _theCharacter.NumberSpells, _theCharacter.NumberLeftHand, _theCharacter.NumberRightHand, _theCharacter.NumberTwoHand);

            // Writes each list to the file.
            WriteListToFile(_theShop.ShopList);
            WriteListToFile(_theCharacter.InventoryList);
            WriteListToFile(_theCharacter.ClothingList);
            WriteListToFile(_theCharacter.SpellList);
            WriteListToFile(_theCharacter.HandItemList);

            saveFile.Close();
        }

        // TODO: This is called when the Load menu item is clicked.
        // This should load a previous state of the program.
        public void LoadState()
        {
            // Check if a save file exists. If not, show an error message.
            string fileName = "SaveFile.txt";
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Error! There isn't a save file currently, please save before loading.");
                return;
            }

            // Open SaveFile.txt.
            StreamReader saveFile = new StreamReader("SaveFile.txt", false);

            // Clears a given list of its items and fills the list with new items from the save file.
            void LoadItemsToList(List<Item> list)
            {
                list.Clear();
                string lineReader = saveFile.ReadLine();
                int counter = int.Parse(lineReader);
                for (int i = 0; i < counter; i++)
                {
                    lineReader = saveFile.ReadLine();
                    string[] lineSplit = lineReader.Split('|');

                    ItemType itemType = Enum.Parse<ItemType>(lineSplit[0].ToString());
                    int cost = int.Parse(lineSplit[3]);
                    int weight = int.Parse(lineSplit[4]);
                    int cleaningMagic = int.Parse(lineSplit[5]);
                    int protectiveMagic = int.Parse(lineSplit[6]);

                    switch (itemType)
                    {
                        case ItemType.Clothing:
                            list.Add(new ClothingItem(lineSplit[1], lineSplit[2], cost, weight, cleaningMagic, protectiveMagic));
                            break;

                        case ItemType.Spell:
                            list.Add(new SpellItem(lineSplit[1], lineSplit[2], cost, weight, cleaningMagic, protectiveMagic));
                            break;

                        case ItemType.LeftHand:
                        case ItemType.RightHand:
                        case ItemType.TwoHand:
                            list.Add(new HandItem(itemType, lineSplit[1], lineSplit[2], cost, weight, cleaningMagic, protectiveMagic));
                            break;

                        default:
                            continue;
                    }
                }
                list.Sort();
            }

            // Gets the character's statistics from the save file and assigns them to a new character.
            string lineReader = saveFile.ReadLine();
            string[] lineSplit = lineReader.Split('|');
            int gold = int.Parse(lineSplit[0]);
            int currentWeight = int.Parse(lineSplit[1]);
            int cleaningMagic = int.Parse(lineSplit[2]);
            int protectiveMagic = int.Parse(lineSplit[3]);
            int maxWeight = int.Parse(lineSplit[4]);
            int numberClothing = int.Parse(lineSplit[5]);
            int numberSpells = int.Parse(lineSplit[6]);
            int numberLeftHand = int.Parse(lineSplit[7]);
            int numberRightHand = int.Parse(lineSplit[8]);
            int numberTwoHand = int.Parse(lineSplit[9]);

            _theCharacter = new Character(gold, currentWeight, cleaningMagic, protectiveMagic, maxWeight,
                numberClothing, numberSpells, numberLeftHand, numberRightHand, numberTwoHand);

            // Loads each list of items from the save file to their respective lists.
            LoadItemsToList(_theShop.ShopList);
            LoadItemsToList(_theCharacter.InventoryList);
            LoadItemsToList(_theCharacter.ClothingList);
            LoadItemsToList(_theCharacter.SpellList);
            LoadItemsToList(_theCharacter.HandItemList);

            saveFile.Close();
        }
    }
}
