namespace RoleplayLibrary
{
    public class SpellBook : IItem
    {
        public string Name { get; set; }

        public SpellBook(string name)
        {
            this.Name = name;
            this._spells = new List<Spell>();
        }
        public List<Spell> _spells { get; set; }
        public void AddSpell(Spell spell)
        {
            this._spells.Add(spell);
        }
        public void RemoveSpell(Spell spell)
        {
            this._spells.Remove(spell);
        }
        public double GetAttackValue()
        {
            double attack = 0;
            foreach (Spell spell in this._spells)
            {
                attack += spell.attackValue;
            }
            return attack;
        }
        public double GetDefenseValue()
        {
            return 0;
        }
    }
}
