using RoleplayLibrary;

public static class Program
{
    public static void Main()
    {
        Spell spell = new Spell("Fireball", 50);
        SpellBook libroDeHechizos = new SpellBook("Book of Fire");
        libroDeHechizos.AddSpell(spell);

        Dwarf Enano = new Dwarf("Gimli");
        Elf Elfo = new Elf("Legolas");
        Wizard Mago = new Wizard("Gandalf", libroDeHechizos);

        PhysicalItem HachaDeGimli = new PhysicalItem("Axe of Gimli", 50, 0);
        PhysicalItem EscudoDeGimli = new PhysicalItem("Shield of Gimli", 0, 50);

        MagicItem BastonMagico = new MagicItem("Magic Stick", 50, 0);
        MagicItem SombreroMagico = new MagicItem("Magic Hat", 0, 50);


        Enano.EquipItem(HachaDeGimli);
        Enano.EquipItem(EscudoDeGimli);

        Mago.EquipItem(SombreroMagico);
        Mago.EquipItem(BastonMagico);
        
        Elfo.EquipItem(BastonMagico);
        Elfo.EquipItem(SombreroMagico);
        Elfo.EquipItem(EscudoDeGimli);
        Elfo.EquipItem(HachaDeGimli);
        Elfo.EquipItem(libroDeHechizos);


        try {
            Enano.EquipItem(libroDeHechizos);
        } catch(InvalidCastException e) {
            Console.WriteLine("No se puede equipar un libro de hechizos a un Enano: " + e.Message);
        }
        
        try {
            Mago.EquipItem(HachaDeGimli);
        } catch(InvalidCastException e) {
            Console.WriteLine("No se puede equipar un item físico a un mago" + e.Message);
        }

        try
        {
            Enano.EquipItem(BastonMagico);
        } catch(InvalidCastException e)
        {
            Console.WriteLine("No se puede equipar un item mágico a un enano" + e.Message);
        }

        Console.WriteLine($"El enano tiene un ataque de: {Enano.GetAttack()} y una defensa de: {Enano.GetDefense()}");
        Console.WriteLine($"El elfo tiene un ataque de: {Elfo.GetAttack()} y una defensa de: {Elfo.GetDefense()}");
        Console.WriteLine($"El mago tiene un ataque de: {Mago.GetAttack()} y una defensa de: {Mago.GetDefense()}");
    }
}