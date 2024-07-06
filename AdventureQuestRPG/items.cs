using AdventureQuestRPG;

public class Potion : Item
{
    public Potion(string Name="potion", string Discreption = "Boosts health") : base(Name, Discreption)
    {
        this.Name = Name;
        this.Discreption = Discreption;
    }


}

public class Weapon : Item
{
    public Weapon(string Name="weapon", string Discreption = "Sharp and shiny") : base(Name, Discreption)
    {
        this.Name = Name;
        this.Discreption = Discreption;
    }
}

public class Armor : Item
{
    public Armor(string Name="armor", string Discreption = "Solid and protective") : base(Name, Discreption)
    {
        this.Name = Name;
        this.Discreption = Discreption;
    }
}