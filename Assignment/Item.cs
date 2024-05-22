using System;

namespace Assignment
{
    // Enum - Type of item
    public enum ItemType
    {
        Clothing,
        Spell,
        LeftHand,
        RightHand,
        TwoHand,
    }
    public abstract class Item : IComparable<Item>
    {
        // Type of item
        private ItemType _typeOfItem;
        // Name of item
        private string _name;
        // Description of item
        private string _description;
        // Weight of item
        private int _weight;
        // Cost of item
        private int _cost;
        // Cleaning magic of item
        private int _cleaningMagic;
        // Protective magic of item
        private int _protectiveMagic;
        // Icon name, this will use a given icon in the GUI
        // there are three other icons you can set this to, either "clothing-icon", "spell-icon" or "hand-icon"
        protected string _iconName = "default-icon";
        
        // Constructor for an Item
        public Item(ItemType typeOfItem, string name, string description, int cost, int weight, int cleaningMagic,
            int protectiveMagic)
        {
            _typeOfItem = typeOfItem;
            _name = name;
            _description = description;
            _cost = cost;
            _weight = weight;
            _cleaningMagic = cleaningMagic;
            _protectiveMagic = protectiveMagic;
        }

        public ItemType TypeOfItem { get { return _typeOfItem; } }
        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public int Weight { get { return _weight; } }
        public int Cost { get { return _cost; } }
        public int CleaningMagic { get { return _cleaningMagic; } }
        public int ProtectiveMagic { get { return _protectiveMagic; } }
        public string IconName { get { return _iconName; } }

        public int CompareTo(Item other)
        {
            if (other == null)
            {
                return 1;
            }
            return _name.CompareTo(other.Name);
        }
    }

    public class ClothingItem : Item
    {
        public ClothingItem(string name, string description, int cost, int weight, int cleaningMagic,
            int protectiveMagic) : base(ItemType.Clothing, name,
                description, cost, weight, cleaningMagic, protectiveMagic)
        {
            _iconName = "clothing-icon";
        }
    }
    
    public class SpellItem : Item
    {
        public SpellItem(string name, string description, int cost, int weight, int cleaningMagic,
            int protectiveMagic) : base(ItemType.Spell, name,
                description, cost, weight, cleaningMagic, protectiveMagic)
        {
            _iconName = "spell-icon";
        }
    }

    public class HandItem : Item
    {
        public HandItem(ItemType itemType, string name, string description, int cost, int weight,
            int cleaningMagic, int protectiveMagic) : base(itemType, name,
                description, cost, weight, cleaningMagic, protectiveMagic)
        {
            _iconName = "hand-icon";
        }
    }
}
