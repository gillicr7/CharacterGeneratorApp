namespace CharacterGeneratorApp;

public class Character
{
    // AI suggested using a constructor to initialize character properties.
    public Character(string name, int strength, int speed, int health, string specialAbility)
    {
        Name = name;
        Strength = strength;
        Speed = speed;
        Health = health;
        SpecialAbility = specialAbility;
    }

    public string Name { get; set; }
    public int Strength { get; set; }
    public int Speed { get; set; }
    public int Health { get; set; }
    public string SpecialAbility { get; set; }
}