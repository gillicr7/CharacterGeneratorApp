namespace CharacterGeneratorApp;

class Program
{
    static void Main(string[] args)
    {
        CharacterGenerator generator = new CharacterGenerator();
        List<Character> characters = new List<Character>();

        // AI suggested using a loop to repeat the menu.
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n1. Skapa en karaktär");
            Console.WriteLine("2. Visa alla karaktärer");
            Console.WriteLine("3. Avsluta");

            string? choice = Console.ReadLine();

            if (choice == "1")
            {
                Character character = generator.GenerateCharacter();
                characters.Add(character);

                Console.WriteLine($"Du skapade {character.Name}!");
            }
            else if (choice == "2")
            {
                // AI suggested checking for an empty list before displaying characters.
                if (characters.Count == 0)
                {
                    Console.WriteLine("Det finns inga karaktärer ännu. Skapa en först!");
                }
                else
                {
                    foreach (Character character in characters)
                    {
                        Console.WriteLine($"\nNamn: {character.Name}");
                        Console.WriteLine($"Styrka: {character.Strength}");
                        Console.WriteLine($"Snabbhet: {character.Speed}");
                        Console.WriteLine($"Livspoäng: {character.Health}");
                        Console.WriteLine($"Specialförmåga: {character.SpecialAbility}");
                    }
                }
            }
            else if (choice == "3")
            {
                running = false;
            }
            else
            {
                // AI suggested adding feedback for invalid menu choices.
                Console.WriteLine("Ogiltigt val. Välj 1, 2 eller 3.");
            }
        }
    }
}