using System.Reflection.Emit;
//I don't know what this is but it seems useful so I haven't deleted it, it appeared by itself

//Initialize most variables here
int affection = 0;
int actions = 10;
bool correctChoice = false;
string playerAction;
string affectionPhrase = null;
bool satiety = false;
bool played = false;
bool petted = false;

//Start of game
Console.WriteLine("DEV: Welcome to my interactive terminal game. Your task is to befriend this digital cat.");
Console.WriteLine("DEV: You are equipped with cat treats and a toy. Good luck.");
Console.WriteLine("SYSTEM: The cat approaches you with a minor amount of curiosity. Try to gain its attention.");
Console.WriteLine("OPTION: You may choose to STAND still, WALK towards it, or CROUCH down to its level.");
string firstChoice = Console.ReadLine();
if (firstChoice == "STAND")
{
    Console.WriteLine("ACTION: You chose to stand still as the cat approaches. It circles your legs and decides to stay with you for a bit.");
    correctChoice = true;
}
else if (firstChoice == "WALK")
{
    Console.WriteLine("ACTION: You chose to walk towards the cat. It decides to walk away from you.");
    correctChoice = false;
}
else if (firstChoice == "CROUCH")
{
    Console.WriteLine("ACTION: You chose to crouch down as the cat approaches you. It walks up to you and decides to stay with you for a bit.");
    correctChoice = true;
}

//Set affectionPhrase based on current level of affection before every action
if (affection == 0)
{
    affectionPhrase = "The cat is paying attention to you but not particularly interested.";
}

//Action 1
if (correctChoice == true)
{
    Console.WriteLine("SYSTEM: Congratulations. You've gained the cat's attention. Now try befriending it.");
    Console.WriteLine($"SYSTEM: {affectionPhrase} You have {actions} actions left to befriend the cat");
    Console.WriteLine("OPTION: Do you choose to FEED it, PET it, or PLAY with it?");
    playerAction = Console.ReadLine();
    if (playerAction == "FEED")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        Console.WriteLine("OPTION: Choose how many treats to feed the cat. Input just the number.");
        played = false;
        petted = false;
        string treatsFed = Console.ReadLine();
        int currentActionTreatsFed = int.Parse(treatsFed);
        if (satiety == false)
        {
            if (currentActionTreatsFed == 0)
            {
                Console.WriteLine($"SYSTEM: Because you chose to feed the cat no treats, the action has been wasted.");
            }
            else if (currentActionTreatsFed == 1)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a bit more but it still looks a bit hungry.");
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed == 2)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a lot more.");
                affection++;
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed >= 3)
            {
                Console.WriteLine($"SYSTEM: You tried to feed the cat {currentActionTreatsFed} treats. It refused.");
            }
            else
            {
                Console.WriteLine("SYSTEM: You chose an invalid option and wasted the action.");
            }
        }
        else if (satiety == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to eat.");
        }
    }
    else if (playerAction == "PLAY")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        petted = false;
        if (played == false)
        {
            Console.WriteLine("SYSTEM: You used the toy to play with the cat. After playing with the cat, it seems to like you a bit more.");
            affection++;
            played = true;
        }
        else if (played == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to play.");
        }
    }
    else if (playerAction == "PET")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        played = false;
        if (petted == false)
        {
            Console.WriteLine($"SYSTEM: After petting the cat, it seems to like you a bit more.");
            affection++;
            petted = true;
        }
        else if (petted == true)
        {
            Console.WriteLine("SYSTEM: The cat refused your petting.");
        }

    }
    else
    {
        Console.WriteLine("ACTION: You chose an invalid option and wasted the action.");
    }
    actions--;
} else if (correctChoice == false)
{
    Console.WriteLine("SYSTEM: You have failed. The game is now terminating. Good luck next time.");
}

//Set affectionPhrase based on current level of affection before every action
if (affection >= 1)
{
    affectionPhrase = "The cat is a bit interested in you.";
}
else if (affection == 0)
{
    affectionPhrase = "The cat is paying attention to you but not particularly interested.";
}

//Action 2
if (actions == 9)
{
    Console.WriteLine($"SYSTEM: {affectionPhrase} You have {actions} actions left to befriend the cat");
    Console.WriteLine("OPTION: Do you choose to FEED it, PET it, or PLAY with it?");
    playerAction = Console.ReadLine();
    if (playerAction == "FEED")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        Console.WriteLine("OPTION: Choose how many treats to feed the cat. Input just the number.");
        played = false;
        petted = false;
        string treatsFed = Console.ReadLine();
        int currentActionTreatsFed = int.Parse(treatsFed);
        if (satiety == false)
        {
            if (currentActionTreatsFed == 0)
            {
                Console.WriteLine($"SYSTEM: Because you chose to feed the cat no treats, the action has been wasted.");
            }
            else if (currentActionTreatsFed == 1)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a bit more but it still looks a bit hungry.");
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed == 2)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a lot more.");
                affection++;
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed >= 3)
            {
                Console.WriteLine($"SYSTEM: You tried to feed the cat {currentActionTreatsFed} treats. It refused.");
            }
            else
            {
                Console.WriteLine("SYSTEM: You chose an invalid option and wasted the action.");
            }
        }
        else if (satiety == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to eat.");
        }
    }
    else if (playerAction == "PLAY")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        petted = false;
        if (played == false)
        {
            Console.WriteLine("SYSTEM: You used the toy to play with the cat. After playing with the cat, it seems to like you a bit more.");
            affection++;
            played = true;
        }
        else if (played == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to play.");
        }
    }
    else if (playerAction == "PET")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        played = false;
        if (petted == false)
        {
            Console.WriteLine($"SYSTEM: After petting the cat, it seems to like you a bit more.");
            affection++;
            petted = true;
        }
        else if (petted == true)
        {
            Console.WriteLine("SYSTEM: The cat refused your petting.");
        }

    }
    else
    {
        Console.WriteLine("ACTION: You chose an invalid option and wasted the action.");
    }
    actions--;
}

//Set affectionPhrase based on current level of affection before every action
if (affection >= 4)
{
    affectionPhrase = "The cat is being friendlier to you.";
}
else if (affection >= 1)
{
    affectionPhrase = "The cat is a bit interested in you.";
}
else if (affection == 0)
{
    affectionPhrase = "The cat is paying attention to you but not particularly interested.";
}

//Action 3
if (actions == 8)
{
    Console.WriteLine($"SYSTEM: {affectionPhrase} You have {actions} actions left to befriend the cat");
    Console.WriteLine("OPTION: Do you choose to FEED it, PET it, or PLAY with it?");
    playerAction = Console.ReadLine();
    if (playerAction == "FEED")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        Console.WriteLine("OPTION: Choose how many treats to feed the cat. Input just the number.");
        played = false;
        petted = false;
        string treatsFed = Console.ReadLine();
        int currentActionTreatsFed = int.Parse(treatsFed);
        if (satiety == false)
        {
            if (currentActionTreatsFed == 0)
            {
                Console.WriteLine($"SYSTEM: Because you chose to feed the cat no treats, the action has been wasted.");
            }
            else if (currentActionTreatsFed == 1)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a bit more but it still looks a bit hungry.");
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed == 2)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a lot more.");
                affection++;
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed >= 3)
            {
                Console.WriteLine($"SYSTEM: You tried to feed the cat {currentActionTreatsFed} treats. It refused.");
            }
            else
            {
                Console.WriteLine("SYSTEM: You chose an invalid option and wasted the action.");
            }
        }
        else if (satiety == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to eat.");
        }
    }
    else if (playerAction == "PLAY")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        petted = false;
        if (played == false)
        {
            Console.WriteLine("SYSTEM: You used the toy to play with the cat. After playing with the cat, it seems to like you a bit more.");
            affection++;
            played = true;
        }
        else if (played == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to play.");
        }
    }
    else if (playerAction == "PET")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        played = false;
        if (petted == false)
        {
            Console.WriteLine($"SYSTEM: After petting the cat, it seems to like you a bit more.");
            affection++;
            petted = true;
        }
        else if (petted == true)
        {
            Console.WriteLine("SYSTEM: The cat refused your petting.");
        }

    }
    else
    {
        Console.WriteLine("ACTION: You chose an invalid option and wasted the action.");
    }
    actions--;
}

//Set affectionPhrase based on current level of affection before every action
if (affection >= 7)
{
    affectionPhrase = "You are liked by the cat";
}
else if (affection >= 4)
{
    affectionPhrase = "The cat is being friendlier to you.";
}
else if (affection >= 1)
{
    affectionPhrase = "The cat is a bit interested in you.";
}
else if (affection == 0)
{
    affectionPhrase = "The cat is paying attention to you but not particularly interested.";
}

//Action 4
if (actions == 7)
{
    Console.WriteLine($"SYSTEM: {affectionPhrase} You have {actions} actions left to befriend the cat");
    Console.WriteLine("OPTION: Do you choose to FEED it, PET it, or PLAY with it?");
    playerAction = Console.ReadLine();
    if (playerAction == "FEED")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        Console.WriteLine("OPTION: Choose how many treats to feed the cat. Input just the number.");
        played = false;
        petted = false;
        string treatsFed = Console.ReadLine();
        int currentActionTreatsFed = int.Parse(treatsFed);
        if (satiety == false)
        {
            if (currentActionTreatsFed == 0)
            {
                Console.WriteLine($"SYSTEM: Because you chose to feed the cat no treats, the action has been wasted.");
            }
            else if (currentActionTreatsFed == 1)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a bit more but it still looks a bit hungry.");
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed == 2)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a lot more.");
                affection++;
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed >= 3)
            {
                Console.WriteLine($"SYSTEM: You tried to feed the cat {currentActionTreatsFed} treats. It refused.");
            }
            else
            {
                Console.WriteLine("SYSTEM: You chose an invalid option and wasted the action.");
            }
        }
        else if (satiety == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to eat.");
        }
    }
    else if (playerAction == "PLAY")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        petted = false;
        if (played == false)
        {
            Console.WriteLine("SYSTEM: You used the toy to play with the cat. After playing with the cat, it seems to like you a bit more.");
            affection++;
            played = true;
        }
        else if (played == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to play.");
        }
    }
    else if (playerAction == "PET")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        played = false;
        if (petted == false)
        {
            Console.WriteLine($"SYSTEM: After petting the cat, it seems to like you a bit more.");
            affection++;
            petted = true;
        }
        else if (petted == true)
        {
            Console.WriteLine("SYSTEM: The cat refused your petting.");
        }

    }
    else
    {
        Console.WriteLine("ACTION: You chose an invalid option and wasted the action.");
    }
    actions--;
}

//Set affectionPhrase based on current level of affection before every action
if (affection >= 7)
{
    affectionPhrase = "You are liked by the cat";
}
else if (affection >= 4)
{
    affectionPhrase = "The cat is being friendlier to you.";
}
else if (affection >= 1)
{
    affectionPhrase = "The cat is a bit interested in you.";
}
else if (affection == 0)
{
    affectionPhrase = "The cat is paying attention to you but not particularly interested.";
}

//Action 5
if (actions == 6)
{
    Console.WriteLine($"SYSTEM: {affectionPhrase} You have {actions} actions left to befriend the cat");
    Console.WriteLine("OPTION: Do you choose to FEED it, PET it, or PLAY with it?");
    playerAction = Console.ReadLine();
    if (playerAction == "FEED")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        Console.WriteLine("OPTION: Choose how many treats to feed the cat. Input just the number.");
        played = false;
        petted = false;
        string treatsFed = Console.ReadLine();
        int currentActionTreatsFed = int.Parse(treatsFed);
        if (satiety == false)
        {
            if (currentActionTreatsFed == 0)
            {
                Console.WriteLine($"SYSTEM: Because you chose to feed the cat no treats, the action has been wasted.");
            }
            else if (currentActionTreatsFed == 1)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a bit more but it still looks a bit hungry.");
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed == 2)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a lot more.");
                affection++;
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed >= 3)
            {
                Console.WriteLine($"SYSTEM: You tried to feed the cat {currentActionTreatsFed} treats. It refused.");
            }
            else
            {
                Console.WriteLine("SYSTEM: You chose an invalid option and wasted the action.");
            }
        }
        else if (satiety == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to eat.");
        }
    }
    else if (playerAction == "PLAY")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        petted = false;
        if (played == false)
        {
            Console.WriteLine("SYSTEM: You used the toy to play with the cat. After playing with the cat, it seems to like you a bit more.");
            affection++;
            played = true;
        }
        else if (played == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to play.");
        }
    }
    else if (playerAction == "PET")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        played = false;
        if (petted == false)
        {
            Console.WriteLine($"SYSTEM: After petting the cat, it seems to like you a bit more.");
            affection++;
            petted = true;
        }
        else if (petted == true)
        {
            Console.WriteLine("SYSTEM: The cat refused your petting.");
        }
    }
    else if (playerAction == "DsakopsNdas")
    {
        affection = 1000;
        Console.WriteLine("DEV: okay vro");
    }
    else
    {
        Console.WriteLine("ACTION: You chose an invalid option and wasted the action.");
    }
    actions--;
}

//Set affectionPhrase based on current level of affection before every action
if (affection >= 100)
{
    affectionPhrase = "the cat fws you heavy vro.";
}
else if (affection >= 11)
{
    affectionPhrase = "You've befriended the cat.";
}
else if (affection >= 7)
{
    affectionPhrase = "You are liked by the cat";
}
else if (affection >= 4)
{
    affectionPhrase = "The cat is being friendlier to you.";
}
else if (affection >= 1)
{
    affectionPhrase = "The cat is a bit interested in you.";
}
else if (affection == 0)
{
    affectionPhrase = "The cat is paying attention to you but not particularly interested.";
}

//Action 6
{
    Console.WriteLine($"SYSTEM: {affectionPhrase} You have {actions} actions left to befriend the cat");
    Console.WriteLine("OPTION: Do you choose to FEED it, PET it, or PLAY with it?");
    playerAction = Console.ReadLine();
    if (playerAction == "FEED")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        Console.WriteLine("OPTION: Choose how many treats to feed the cat. Input just the number.");
        played = false;
        petted = false;
        string treatsFed = Console.ReadLine();
        int currentActionTreatsFed = int.Parse(treatsFed);
        if (satiety == false)
        {
            if (currentActionTreatsFed == 0)
            {
                Console.WriteLine($"SYSTEM: Because you chose to feed the cat no treats, the action has been wasted.");
            }
            else if (currentActionTreatsFed == 1)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a bit more but it still looks a bit hungry.");
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed == 2)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a lot more.");
                affection++;
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed >= 3)
            {
                Console.WriteLine($"SYSTEM: You tried to feed the cat {currentActionTreatsFed} treats. It refused.");
            }
            else
            {
                Console.WriteLine("SYSTEM: You chose an invalid option and wasted the action.");
            }
        }
        else if (satiety == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to eat.");
        }
    }
    else if (playerAction == "PLAY")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        petted = false;
        if (played == false)
        {
            Console.WriteLine("SYSTEM: You used the toy to play with the cat. After playing with the cat, it seems to like you a bit more.");
            affection++;
            played = true;
        }
        else if (played == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to play.");
        }
    }
    else if (playerAction == "PET")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        played = false;
        if (petted == false)
        {
            Console.WriteLine($"SYSTEM: After petting the cat, it seems to like you a bit more.");
            affection++;
            petted = true;
        }
        else if (petted == true)
        {
            Console.WriteLine("SYSTEM: The cat refused your petting.");
        }

    }
    else
    {
        Console.WriteLine("ACTION: You chose an invalid option and wasted the action.");
    }
    actions--;
}

//Set affectionPhrase based on current level of affection before every action
if (affection >= 100)
{
    affectionPhrase = "the cat fws you heavy vro.";
}
else if (affection >= 11)
{
    affectionPhrase = "You've befriended the cat.";
}
else if (affection >= 7)
{
    affectionPhrase = "You are liked by the cat";
}
else if (affection >= 4)
{
    affectionPhrase = "The cat is being friendlier to you.";
}
else if (affection >= 1)
{
    affectionPhrase = "The cat is a bit interested in you.";
}
else if (affection == 0)
{
    affectionPhrase = "The cat is paying attention to you but not particularly interested.";
}

//Action 7
if (actions == 4)
{
    Console.WriteLine($"SYSTEM: {affectionPhrase} You have {actions} actions left to befriend the cat");
    Console.WriteLine("OPTION: Do you choose to FEED it, PET it, or PLAY with it?");
    playerAction = Console.ReadLine();
    if (playerAction == "FEED")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        Console.WriteLine("OPTION: Choose how many treats to feed the cat. Input just the number.");
        played = false;
        petted = false;
        string treatsFed = Console.ReadLine();
        int currentActionTreatsFed = int.Parse(treatsFed);
        if (satiety == false)
        {
            if (currentActionTreatsFed == 0)
            {
                Console.WriteLine($"SYSTEM: Because you chose to feed the cat no treats, the action has been wasted.");
            }
            else if (currentActionTreatsFed == 1)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a bit more but it still looks a bit hungry.");
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed == 2)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a lot more.");
                affection++;
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed >= 3)
            {
                Console.WriteLine($"SYSTEM: You tried to feed the cat {currentActionTreatsFed} treats. It refused.");
            }
            else
            {
                Console.WriteLine("SYSTEM: You chose an invalid option and wasted the action.");
            }
        }
        else if (satiety == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to eat.");
        }
    }
    else if (playerAction == "PLAY")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        petted = false;
        if (played == false)
        {
            Console.WriteLine("SYSTEM: You used the toy to play with the cat. After playing with the cat, it seems to like you a bit more.");
            affection++;
            played = true;
        }
        else if (played == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to play.");
        }
    }
    else if (playerAction == "PET")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        played = false;
        if (petted == false)
        {
            Console.WriteLine($"SYSTEM: After petting the cat, it seems to like you a bit more.");
            affection++;
            petted = true;
        }
        else if (petted == true)
        {
            Console.WriteLine("SYSTEM: The cat refused your petting.");
        }

    }
    else
    {
        Console.WriteLine("ACTION: You chose an invalid option and wasted the action.");
    }
    actions--;
}

//Set affectionPhrase based on current level of affection before every action
if (affection >= 100)
{
    affectionPhrase = "the cat fws you heavy vro.";
}
else if (affection >= 11)
{
    affectionPhrase = "You've befriended the cat.";
}
else if (affection >= 7)
{
    affectionPhrase = "You are liked by the cat";
}
else if (affection >= 4)
{
    affectionPhrase = "The cat is being friendlier to you.";
}
else if (affection >= 1)
{
    affectionPhrase = "The cat is a bit interested in you.";
}
else if (affection == 0)
{
    affectionPhrase = "The cat is paying attention to you but not particularly interested.";
}

//Action 8
if (actions == 3)
{
    Console.WriteLine($"SYSTEM: {affectionPhrase} You have {actions} actions left to befriend the cat");
    Console.WriteLine("OPTION: Do you choose to FEED it, PET it, or PLAY with it?");
    playerAction = Console.ReadLine();
    if (playerAction == "FEED")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        Console.WriteLine("OPTION: Choose how many treats to feed the cat. Input just the number.");
        played = false;
        petted = false;
        string treatsFed = Console.ReadLine();
        int currentActionTreatsFed = int.Parse(treatsFed);
        if (satiety == false)
        {
            if (currentActionTreatsFed == 0)
            {
                Console.WriteLine($"SYSTEM: Because you chose to feed the cat no treats, the action has been wasted.");
            }
            else if (currentActionTreatsFed == 1)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a bit more but it still looks a bit hungry.");
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed == 2)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a lot more.");
                affection++;
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed >= 3)
            {
                Console.WriteLine($"SYSTEM: You tried to feed the cat {currentActionTreatsFed} treats. It refused.");
            }
            else
            {
                Console.WriteLine("SYSTEM: You chose an invalid option and wasted the action.");
            }
        }
        else if (satiety == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to eat.");
        }
    }
    else if (playerAction == "PLAY")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        petted = false;
        if (played == false)
        {
            Console.WriteLine("SYSTEM: You used the toy to play with the cat. After playing with the cat, it seems to like you a bit more.");
            affection++;
            played = true;
        }
        else if (played == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to play.");
        }
    }
    else if (playerAction == "PET")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        played = false;
        if (petted == false)
        {
            Console.WriteLine($"SYSTEM: After petting the cat, it seems to like you a bit more.");
            affection++;
            petted = true;
        }
        else if (petted == true)
        {
            Console.WriteLine("SYSTEM: The cat refused your petting.");
        }

    }
    else
    {
        Console.WriteLine("ACTION: You chose an invalid option and wasted the action.");
    }
    actions--;
}

//Set affectionPhrase based on current level of affection before every action
if (affection >= 100)
{
    affectionPhrase = "the cat fws you heavy vro.";
}
else if (affection >= 11)
{
    affectionPhrase = "You've befriended the cat.";
}
else if (affection >= 7)
{
    affectionPhrase = "You are liked by the cat";
}
else if (affection >= 4)
{
    affectionPhrase = "The cat is being friendlier to you.";
}
else if (affection >= 1)
{
    affectionPhrase = "The cat is a bit interested in you.";
}
else if (affection == 0)
{
    affectionPhrase = "The cat is paying attention to you but not particularly interested.";
}

//Action 9
if (actions == 2)
{
    Console.WriteLine($"SYSTEM: {affectionPhrase} You have {actions} actions left to befriend the cat");
    Console.WriteLine("OPTION: Do you choose to FEED it, PET it, or PLAY with it?");
    playerAction = Console.ReadLine();
    if (playerAction == "FEED")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        Console.WriteLine("OPTION: Choose how many treats to feed the cat. Input just the number.");
        played = false;
        petted = false;
        string treatsFed = Console.ReadLine();
        int currentActionTreatsFed = int.Parse(treatsFed);
        if (satiety == false)
        {
            if (currentActionTreatsFed == 0)
            {
                Console.WriteLine($"SYSTEM: Because you chose to feed the cat no treats, the action has been wasted.");
            }
            else if (currentActionTreatsFed == 1)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a bit more but it still looks a bit hungry.");
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed == 2)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a lot more.");
                affection++;
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed >= 3)
            {
                Console.WriteLine($"SYSTEM: You tried to feed the cat {currentActionTreatsFed} treats. It refused.");
            }
            else
            {
                Console.WriteLine("SYSTEM: You chose an invalid option and wasted the action.");
            }
        }
        else if (satiety == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to eat.");
        }
    }
    else if (playerAction == "PLAY")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        petted = false;
        if (played == false)
        {
            Console.WriteLine("SYSTEM: You used the toy to play with the cat. After playing with the cat, it seems to like you a bit more.");
            affection++;
            played = true;
        }
        else if (played == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to play.");
        }
    }
    else if (playerAction == "PET")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        played = false;
        if (petted == false)
        {
            Console.WriteLine($"SYSTEM: After petting the cat, it seems to like you a bit more.");
            affection++;
            petted = true;
        }
        else if (petted == true)
        {
            Console.WriteLine("SYSTEM: The cat refused your petting.");
        }

    }
    else
    {
        Console.WriteLine("ACTION: You chose an invalid option and wasted the action.");
    }
    actions--;
}

//Set affectionPhrase based on current level of affection before every action
if (affection >= 100)
{
    affectionPhrase = "the cat fws you heavy vro.";
}
else if (affection >= 11)
{
    affectionPhrase = "You've befriended the cat.";
}
else if (affection >= 7)
{
    affectionPhrase = "You are liked by the cat";
}
else if (affection >= 5)
{
    affectionPhrase = "The cat is being friendlier to you.";
}
else if (affection >= 1)
{
    affectionPhrase = "The cat is a bit interested in you.";
}
else if (affection == 0)
{
    affectionPhrase = "The cat is paying attention to you but not particularly interested.";
}

//Action 10
if (actions == 1)
{
    Console.WriteLine($"SYSTEM: {affectionPhrase} You have {actions} actions left to befriend the cat");
    Console.WriteLine("OPTION: Do you choose to FEED it, PET it, or PLAY with it?");
    playerAction = Console.ReadLine();
    if (playerAction == "FEED")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        Console.WriteLine("OPTION: Choose how many treats to feed the cat. Input just the number.");
        played = false;
        petted = false;
        string treatsFed = Console.ReadLine();
        int currentActionTreatsFed = int.Parse(treatsFed);
        if (satiety == false)
        {
            if (currentActionTreatsFed == 0)
            {
                Console.WriteLine($"SYSTEM: Because you chose to feed the cat no treats, the action has been wasted.");
            }
            else if (currentActionTreatsFed == 1)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a bit more but it still looks a bit hungry.");
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed == 2)
            {
                Console.WriteLine($"SYSTEM: You fed the cat {currentActionTreatsFed} treats. It likes you a lot more.");
                affection++;
                affection++;
                satiety = true;
            }
            else if (currentActionTreatsFed >= 3)
            {
                Console.WriteLine($"SYSTEM: You tried to feed the cat {currentActionTreatsFed} treats. It refused.");
            }
            else
            {
                Console.WriteLine("SYSTEM: You chose an invalid option and wasted the action.");
            }
        }
        else if (satiety == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to eat.");
        }
    }
    else if (playerAction == "PLAY")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        petted = false;
        if (played == false)
        {
            Console.WriteLine("SYSTEM: You used the toy to play with the cat. After playing with the cat, it seems to like you a bit more.");
            affection++;
            played = true;
        }
        else if (played == true)
        {
            Console.WriteLine("SYSTEM: The cat didn't want to play.");
        }
    }
    else if (playerAction == "PET")
    {
        Console.WriteLine($"ACTION: You chose to {playerAction}.");
        satiety = false;
        played = false;
        if (petted == false)
        {
            Console.WriteLine($"SYSTEM: After petting the cat, it seems to like you a bit more.");
            affection++;
            petted = true;
        }
        else if (petted == true)
        {
            Console.WriteLine("SYSTEM: The cat refused your petting.");
        }

    }
    else
    {
        Console.WriteLine("ACTION: You chose an invalid option and wasted the action.");
    }
    actions--;
}

//Finale
if (actions == 0)
{
    Console.WriteLine("SYSTEM: You have no actions left. Let's see if you befriended the cat enough to take it home.");
    if (affection >= 100)
    {
        Console.WriteLine("okay buddy");
        Console.WriteLine("SECRET ENDING");
    }
    else if (affection >= 12)
    {
        Console.WriteLine("SUCCESS: You successfully befriended the cat!");
        Console.WriteLine("SYSTEM: Congratulations. What would you like to name the cat?");
        string catName = Console.ReadLine();
        Console.WriteLine($"SYSTEM: You take {catName} home and you live happily with your new cat. Good work.");
        Console.WriteLine("GOOD ENDING");
    }
    else if (affection >= 5)
    {
        Console.WriteLine("FAILURE: The cat seemed to like you a bit but didn't really care.");
        Console.WriteLine("BAD ENDING");
    }
    else if (affection >= 0)
    {
        Console.WriteLine("FAILURE: The cat got bored of you and walked away.");
        Console.WriteLine("BAD ENDING");
    }
}