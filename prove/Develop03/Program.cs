using System;
using System.Collections.Generic;

// Variables to store the user's chosen option, the chosen scripture, and the verse number
int option;
string chosenScripture;
string verseNumber = string.Empty;

while (true)
{
    Console.WriteLine("Choose a scripture:");
    Console.WriteLine("1. Moses 1:3");
    Console.WriteLine("2. Moses 7:18");
    Console.WriteLine("3. Abraham 3:22-23");
    Console.WriteLine("4. Matthew 5:14-16");
    Console.WriteLine("5. John 14:6");
    Console.WriteLine("6. 1 Nephi 3:7");
    Console.WriteLine("7. 2 Nephi 2:27");

    // Try to parese the user's input as an integer
    if (int.TryParse(Console.ReadLine(), out option) && option >= 1 && option <= 7)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.");
    }
}

// Create a reference object based on the user's chosen option
Reference reference;
switch (option)
{
    case 1:
        
        verseNumber = "Moses 1:3";
        chosenScripture = "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.";
        reference = new Reference("Moses", 1, 3);
        break;
    case 2:
        
        verseNumber = "Moses 7:18";
        chosenScripture = "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.";
        reference = new Reference("Moses", 7, 18);
        break;
    case 3:
    
        verseNumber = "Abraham 3:22-23";
        chosenScripture = "Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.";
        reference = new Reference("Abraham", 3, 22);
        
        break;
    case 4:
        verseNumber = "Matthew 5:14-16";
        chosenScripture = "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.";
        reference = new Reference("Matthew", 5, 14);
        break;
    case 5:
        verseNumber = "John 14:6";
        chosenScripture = "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.";
        reference = new Reference("John", 14, 6);
        break;
    case 6:
        verseNumber = "1 Nephi 3:7";
        chosenScripture = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        reference = new Reference("1 Nephi", 3, 7);
        
        break;
    case 7:
        
        verseNumber = "2 Nephi 2:27";
        chosenScripture = "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.";
        reference = new Reference("2 Nephi", 2, 27);
        break;
    default:
        
        chosenScripture = "Invalid option";
        reference = new Reference("Invalid", 0, 0);
        break;
}
// Create a scripture object with the chosen reference and scripture
Console.Clear();
Scripture scripture = new Scripture(reference, chosenScripture);
Console.WriteLine(verseNumber);
Console.WriteLine(scripture.GetDisplayText());
Console.WriteLine();
Console.WriteLine("Press enter to start hiding words...");

Console.ReadLine();


while (true)
{
    Console.Clear();
    scripture.HideRandomWords(4); // hide 4 random word
    chosenScripture = scripture.GetDisplayText();
    Console.WriteLine($"{verseNumber} {chosenScripture}");
    Console.WriteLine(" ");
    Console.WriteLine("Press 'q' to quit and any other key to continue");
    


    if (Console.ReadKey().Key.ToString().ToLower() == "q")
    {
        break;
    }

    if (scripture.IsCompletelyHidden())
    {
        Console.WriteLine("All words are hidden. Press enter to quit");
        Console.ReadLine();
        break;
    }
}
