// See https://aka.ms/new-console-template for more information
using NhlSystemClassLibrary;

//Prompt and read in the team name
//Console.Write("Enter the team name: ");
//string teamName = Console.ReadLine();
try
{
    Team oilers = new Team("Oilers", "Edmonton", "Rogers", Conference.Western, Division.Pacific);
    Console.WriteLine(oilers);

}
catch(ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Incorrect exception thrown"); 
}
//Create a new Team instance
