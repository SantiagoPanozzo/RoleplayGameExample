namespace RoleplayLibrary
{
    public class Elf : ICharacter
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public Elf(string name)
        {
            this.Name = name;
            this.Health = 60;
            this._items = new List<IItem>();
        }

        private List<IItem> _items;
        public void EquipItem(IItem item)
        {
            this._items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this._items.Remove(item);
        }
        public double GetAttack()
        {
            double attack = 0;
            foreach (IItem item in this._items)
            {
                attack += item.GetAttackValue();
            }
            return attack;
        }
        public double GetDefense()
        {
            double defense = 0;
            foreach (IItem item in this._items)
            {
                defense += item.GetDefenseValue();
            }
            return defense;
        }
    }
}
