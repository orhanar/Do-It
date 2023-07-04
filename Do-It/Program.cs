
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

    } while (menuOption != "E");
}
void SeeToDo(List<string> ToDos)
{
    for(int i = 0; i < ToDos.Count; i++)
    {
        Console.WriteLine(i+1 + ". " + ToDos[i]);
    }
    
}

void AddToDo(List<string> ToDos)
{
    var userInput = " ";
    do
    {
        Console.WriteLine("Enter a ToDo Description");
        userInput = Console.ReadLine();
        if(!ToDos.Contains(userInput) && userInput != " ")
        {
            ToDos.Add(userInput);
        }
        

    } while (userInput == " ");
  
}

void RemoveToDo()
{

}

displayMenu();
Console.ReadKey();





