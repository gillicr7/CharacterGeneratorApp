namespace CharacterGeneratorApp;

public class CharacterGenerator
{
    private readonly string[] abilities = { "Healing", "Fireball", "Invisibility", "Super speed" };

    private readonly string[] names = { "Luna", "Thor", "Nova", "Zara", "Atlas" };
    private readonly Random random = new();

    // AI suggested selecting random items from arrays.
    public Character GenerateCharacter()
    {
        var name = names[random.Next(names.Length)];
        var specialAbility = abilities[random.Next(abilities.Length)];

        var strength = random.Next(1, 11);
        var speed = random.Next(1, 11);
        var health = random.Next(50, 151);

        return new Character(name, strength, speed, health, specialAbility);
    }
}