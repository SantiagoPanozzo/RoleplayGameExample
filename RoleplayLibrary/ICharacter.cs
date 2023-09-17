namespace RoleplayLibrary
{
    public interface ICharacter
    {
        public double GetAttack();
        public double GetDefense();
        public void EquipItem(IItem item);
        public void RemoveItem(IItem item);
    }
}
