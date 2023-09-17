namespace RoleplayLibrary
{
    public class Wizard : ICharacter
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public SpellBook SpellBook { get; set; }

        private List<MagicItem> _items;

        public void EquipItem(IItem item)
        {
            if (item is MagicItem)
                this._items.Add((MagicItem)item);
            else
                throw new InvalidCastException($"No se pudo convertir \"{item.Name}\" a MagicItem");
        }

        public void RemoveItem(IItem item)
        {
            if (item is MagicItem)
                this._items.Remove((MagicItem)item);
            else
                throw new InvalidCastException($"No se pudo convertir \"{item.Name}\" a MagicItem");
        }

        public double GetAttack()
        {
            double attack = 0;
            foreach (MagicItem item in this._items)
            {
                attack += item.GetAttackValue();
            }
            attack += this.SpellBook.GetAttackValue();
            return attack;
        }
        public double GetDefense()
        {
            double defense = 0;
            foreach (IItem item in this._items)
            {
                if (item is MagicItem)
                    defense += item.GetDefenseValue();
            }
            return defense;
        }

        public Wizard(string name, SpellBook spellBook)
        {
            this.Name = name;
            this.Health = 100;
            this._items = new List<MagicItem>();
            this.SpellBook = spellBook;
        }

    }
}
