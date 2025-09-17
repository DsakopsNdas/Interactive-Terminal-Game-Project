using System.Reflection.Emit;

//Initialize most variables here
int affection = 0;
int actions = 10;
bool correctChoice = false;
string playerAction;
string affectionPhrase = null;

//Set affectionPhrase based on current level of affection
if (affection == 0)
{
    affectionPhrase = "The cat is paying attention to you but not particularly interested.";
} else if (affection >= 1)
{
    affectionPhrase = "The cat is a bit interested in you.";
} else if (affection >= 4)
{
    affectionPhrase = "The cat is being friendlier to you.";
} else if (affection >= 7)
{
    affectionPhrase = "You are liked by the cat";
} else if (affection >= 10)
{
    affectionPhrase = "You've befriended the cat.";
} else if (affection >= 100)
{
    affectionPhrase = "the cat fws you heavy vro.";
}

Console.WriteLine("DEV: Welcome to my interactive terminal game. Your task is to befriend this digital cat.");
Console.WriteLine("DEV: You are equipped with cat treats and a toy. Good luck.");
Console.WriteLine("SYSTEM: The cat approaches you with a minor amount of curiosity. Try to gain its attention.");
Console.WriteLine("OPTION: You may choose to STAND still, WALK towards it, or CROUCH down to its level.");
string firstChoice = Console.ReadLine();
if (firstChoice == "STAND")
{
    Console.WriteLine("SYSTEM: You chose to stand still as the cat approaches. It circles your legs and decides to stay with you for a bit.");
    correctChoice = true;
} else if (firstChoice == "WALK")
{
    Console.WriteLine("SYSTEM: You chose to walk towards the cat. It decides to walk away from you.");
    correctChoice = false;
} else if (firstChoice == "CROUCH")
{
    Console.WriteLine("SYSTEM: You chose to crouch down as the cat approaches you. It walks up to you and decides to stay with you for a bit.");
    correctChoice = true;
}
if (correctChoice == true)
{
    Console.WriteLine("SYSTEM: Congratulations. You've gained the cat's attention. Now try befriending it.");
    Console.WriteLine($"SYSTEM: {affectionPhrase} You have {actions} actions left to befriend the cat. Do you choose to FEED it, PET it, SCRATCH it, or PLAY with it?");

} else if (correctChoice == false)
{
    Console.WriteLine("SYSTEM: You have failed. The game is now terminating. Good luck next time.");
}