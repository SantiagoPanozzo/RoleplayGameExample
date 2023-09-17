namespace RoleplayLibrary
{
    public interface IItem
    {
        public string Name { get; set; }
        public double GetAttackValue();
        public double GetDefenseValue();
    }
}
