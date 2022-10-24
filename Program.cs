
//variables are here
string adjective;
string person;
string verb;
string place;
string adverb;
string pronoun;
string pronoun2;
string verb2;
string person2;
string award;
//the boolean for playing again will be true
bool playAgain = true;
string decision;


while(playAgain == true)
{
    Console.WriteLine("Please enter a adjective.");
    adjective = Console.ReadLine();
    Console.WriteLine("Please enter a person's name.");
    person = Console.ReadLine();
    Console.WriteLine("Please enter a verb.");
    verb = Console.ReadLine();
    Console.WriteLine("Please enter a place.");
    place = Console.ReadLine();
    Console.WriteLine("Please enter an adverb");
    adverb = Console.ReadLine();
    Console.WriteLine("Please enter a pronoun.");
    pronoun = Console.ReadLine();
    Console.WriteLine("Please enter another pronoun");
    pronoun2 = Console.ReadLine();
    Console.WriteLine("Please enter another verb");
    verb2 = Console.ReadLine();
    Console.WriteLine("Please enter another person's name");
    person2 = Console.ReadLine();
    Console.WriteLine("Please enter a award title");
    award = Console.ReadLine();
    //not the best storyteller...
    Console.WriteLine($"There was a {adjective} person named {person}.{pronoun} {verb} all day working at the {place}.They did their job rather {adverb}.One day there was a new person named {person2}.{pronoun2} did the job twice as {verb2} on their first day.They both received awards for {award} and lived happiliy ever after.");
    Console.WriteLine("Would you like to try again?Type Y to try again or N to end.");
    decision = Console.ReadLine().ToUpper();
    //if the user wanted to try again, pressing "Y" will send them to the beginning
 if(decision == "Y")
    {
      playAgain = true;
    }
    else if(decision == "N")
    {
      //if the user wanted to stop pressing "N" will end the program
      playAgain = false;
    }
    else
    {
        Console.WriteLine("Please pick a valid option.");
    }
} 