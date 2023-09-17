namespace RoleplayLibrary
{
    public class Spell
    {
        public string name { get; set; }
        public double attackValue { get; set; }
        public Spell(string name, double attackValue)
        {
            this.name = name;
            this.attackValue = attackValue;
        }
    }
}
