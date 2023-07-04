
using System.Runtime.CompilerServices;
using System.Security.Principal;
using static System.Net.Mime.MediaTypeNames;

var menuOption = "";
List<string> ToDos = new List<string>();
void displayMenu()
{
    do
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[S]ee all TODOs");
        Console.WriteLine("[A]dd a TODO");
        Console.WriteLine("[R]emove a TODO");
        Console.WriteLine("[E]xit");
        menuOption = Console.ReadLine();
        menuOption = menuOption.ToUpper();

        if(menuOption == "S")
        {
            SeeToDo(ToDos);
        }
        else if(menuOption == "A")
        {
            AddToDo(ToDos);

        }else if(menuOption == "R")
        {
            RemoveToDo();
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }

    } while (menuOption != "E");

    if(menuOption == "E")
    {
        Environment.Exit(0);
    }
}
void SeeToDo(List<string> ToDos)
{
    if(ToDos.Count == 0)
    {
        Console.WriteLine("No ToDos");
    }

    for(int i = 0; i < ToDos.Count; i++)
    {
        Console.WriteLine(i+1 + ". " + ToDos[i]);
    }
    
}

void AddToDo(List<string> ToDos)
{
    var userInput = " ";
    bool loop = true;
    do
    {
        Console.WriteLine("Enter a ToDo Description");
        userInput = Console.ReadLine();
        if(!ToDos.Contains(userInput) && userInput != "")
        {
            Console.WriteLine("ToDo successfully added: " + userInput);
            ToDos.Add(userInput);
            loop = false;
        }
    } while (loop == true);
}

void RemoveToDo()
{
    bool loop = true;
  
        var userInput = "";
        int num = -1;
        bool isitInt;

    if (ToDos.Count < 1)
    {
        do
        {
            Console.WriteLine("There are no items");
            displayMenu();
            break;


        } while (ToDos.Count < 1 || isitInt == false);
    }
    else
    {
        do
        {
            Console.WriteLine("Please enter the index of the ToDos");
            userInput = Console.ReadLine();
            isitInt = int.TryParse(userInput, out num);
 
            if (num > ToDos.Count())
            {
                Console.WriteLine("Not a valid index");

            }
            else if (num == 0)
            {
                Console.WriteLine("User Inputs is empty");
 
            }
        } while (isitInt == false || num <= 0 || num > ToDos.Count());
        Console.WriteLine("ToDo removed: " + userInput);
        ToDos.RemoveAt(num-1);
    }   
 }


displayMenu();





