namespace RoleplayLibrary
{
    public class Dwarf : ICharacter
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public Dwarf(string name)
        {
            this.Name = name;
            this.Health = 200;
            this._items = new List<PhysicalItem>();
        }
        private List<PhysicalItem> _items;
        public void EquipItem(IItem item)
        {
            if (item is PhysicalItem)
                this._items.Add((PhysicalItem)item);
            else
                throw new InvalidCastException($"No se pudo convertir \"{item.Name}\" a PhysicalItem");

        }

        public void RemoveItem(IItem item)
        {
            if (item is PhysicalItem)
                this._items.Remove((PhysicalItem)item);
            else
                throw new InvalidCastException($"No se pudo convertir \"{item.Name}\" a PhysicalItem");
        }
        public double GetAttack()
        {
            double attack = 0;
            foreach (PhysicalItem item in this._items)
            {
                attack += item.GetAttackValue();
            }
            return attack;
        }
        public double GetDefense()
        {
            double defense = 0;
            foreach (PhysicalItem item in this._items)
            {
                defense += item.GetDefenseValue();
            }
            return defense;
        }
    }
}
