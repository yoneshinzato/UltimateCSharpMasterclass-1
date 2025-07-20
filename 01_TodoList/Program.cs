// var todos = new List<string>();

// Console.WriteLine("Hello!");

// bool shallExit = false;
// while (!shallExit)
// {
//     Console.WriteLine();
//     Console.WriteLine("What do you want to do?");
//     Console.WriteLine("[S]ee all todos");
//     Console.WriteLine("[A]dd a todo");
//     Console.WriteLine("[R]emove a todo");
//     Console.WriteLine("[E]xit");

//     var userChoice = Console.ReadLine();

//     switch (userChoice)
//     {
//         case "E":
//         case "e":
//             shallExit = true;
//             break;
//         case "S":
//         case "s":
//             SeeAllTodos();
//             break;
//         case "A":
//         case "a":
//             AddTodo();
//             break;
//         case "R":
//         case "r":
//             RemoveTodo();
//             break;
//         default:
//             Console.WriteLine("Invalid choice");
//             break;
//     }
// }

// Console.ReadKey();

// void SeeAllTodos()
// {
//     if (todos.Count == 0)
//     {
//         ShowNoTodosMessage();
//         return;
//     }
//     for (int i = 0; i < todos.Count; i++)
//     {
//         Console.WriteLine($"{i + 1}. {todos[i]}");
//     }
// }

// void AddTodo()
// {
//     string description;
//     do
//     {
//         Console.WriteLine("Enter the TODO description:");
//         description = Console.ReadLine();
//     }
//     while (!IsDescriptionValid(description));
//     todos.Add(description);
// }

// bool IsDescriptionValid(string description)
// {
//     if (description == "")
//     {
//         Console.WriteLine("The description cannot be empty");
//         return false;
//     }
//     if (todos.Contains(description))
//     {
//         Console.WriteLine("The description must be unique.");
//         return false;
//     }
//     return true;
// }

// void RemoveTodo()
// {
//     if (todos.Count == 0)
//     {
//         ShowNoTodosMessage();
//         return;
//     }

//     int index;
//     do
//     {
//         Console.WriteLine("Select the index of the TODO you want to remove:");
//         SeeAllTodos();
//     } while (!TryReadIndex(out index));

//     RemoveTodoAtIndex(index - 1);
// }

// bool TryReadIndex(out int index)
// {
//     var userInput = Console.ReadLine();
//     if (userInput == "")
//     {
//         index = 0;
//         Console.WriteLine("Selected index cannot be empty");
//         return false;
//     }
//     if (int.TryParse(userInput, out index) &&
//         index >= 1 &&
//         index <= todos.Count)
//     {
//         return true;
//     }
//     Console.WriteLine("The given index is not valid.");
//     return false;
// }

// void RemoveTodoAtIndex(int index)
// {
//     var todoToBeRemoved = todos[index];
//     todos.RemoveAt(index);
//     Console.WriteLine("TODO removed: " + todoToBeRemoved);
// }

// void ShowNoTodosMessage()
// {
//     Console.WriteLine("No TODOs have been added yet.");
// }

// Console.WriteLine();
//     Console.WriteLine("What do you want to do?");
//     Console.WriteLine("[S]ee all todos");
//     Console.WriteLine("[A]dd a todo");
//     Console.WriteLine("[R]emove a todo");
//     Console.WriteLine("[E]xit");

// var userChoice = Console.ReadLine();

// bool someBoolean = true;
// var someOtherBoolean = false;

// bool isUserInputAbc = userChoice == "ABC";
// bool isUserInputNotAbc = userChoice != "ABC";
// Console.WriteLine(isUserInputAbc);
// Console.WriteLine(isUserInputNotAbc);
// Console.WriteLine("You entered: " + userChoice);

// var is10Modulo3EqualTo1 = 10 % 3 == 1;
// Console.WriteLine("Is 10 modulo 3 equal to 1? " + is10Modulo3EqualTo1);
// var isEven = 10 % 2 == 0;
// Console.WriteLine("Is 10 even? " + isEven);
// Console.ReadKey();

// var number = 10;
// var isLargerThan4AndSmallerThan9 = number > 4 && number < 9;
// var isEqualTo20OrLargerThan6OrSmallerThan200 = number == 20 || number > 6 || number < 200;
// Console.WriteLine("Is the number equal to 20? " + isEqualTo20OrLargerThan6OrSmallerThan200);
// Console.WriteLine("Is the number variable larger than 4 and smaller than 9? " + isLargerThan4AndSmallerThan9);

// var isEqualTo123OrEvenAndSmallerThan200 = number == 123 || (number % 2 == 0 && number < 200);
// Console.WriteLine("Is the number equal to 123 or even and smaller than 200? " + isEqualTo123OrEvenAndSmallerThan200);


// Console.WriteLine("What do you want to do?");
// Console.WriteLine("[S]ee all todos");
// Console.WriteLine("[A]dd a todo");
// Console.WriteLine("[R]emove a todo");
// Console.WriteLine("[E]xit");

// var userChoice = Console.ReadLine();

// if (userChoice.Length <= 3)
// {
//     Console.WriteLine("You entered a short string");
// }
// else if (userChoice.Length < 10)
// {
//     Console.WriteLine("You entered a medium-length string");
// }
// else
// {
//     Console.WriteLine("You entered a long string");
// }

// Console.ReadKey(); 

//    void PrintSelectedOption(string selectedOption)
//{
//    Console.WriteLine("Selected option: " + selectedOption);
//}


//    Console.WriteLine("What do you want to do?");
//    Console.WriteLine("[S]ee all todos");
//    Console.WriteLine("[A]dd a todo");
//    Console.WriteLine("[R]emove a todo");
//    Console.WriteLine("[E]xit");

//    var userChoice = Console.ReadLine();

//switch (userChoice)
//{
//    case "S":
//    case "s":
//        PrintSelectedOption("See all TODOS");
//        break;

//    case "A":
//    case "a":
//        PrintSelectedOption("Add a TODO");
//        break;

//    case "R":
//    case "r":
//        PrintSelectedOption("Remove a TODO");
//        break;

//    case "E":
//    case "e":
//        PrintSelectedOption("Exit, goodbye!");
//        break;

//    default:
//        Console.WriteLine("Invalid choice");
//        break;

//}

//char ConvertPointsToGrade(int points)
//{
//    return points switch
//    {
//10 or 9 => 'A',
//8 or 7 or 6 => 'B',
//5 or 4 or 3 => 'C',
//2 or 1  => 'D',
//0 => 'E',
//_ => '!',

//>= 90 => 'A',
//>= 80 => 'B',
//>= 50 => 'C',
//_ => 'D' 
// anything below 50 gets a D
//};

//}

//char ConvertPointsToGrade(int points)
//{
//    switch (points)
//    {
//        case 10:
//        case 9:
//            return 'A'
//        case 8:
//        case 7:
//        case 6:
//            return 'B';
//        case 5: 
//        case 4:
//        case 3:
//            return 'C';
//        case 2: 
//        case 1:
//            return 'D';
//        case 0:
//            return 'E';
//        default:
//            return '!';

//    }
//}
//var number = 0;

//while (number < 10)
//{
//    number++;
//    Console.WriteLine(number);
//}
//Console.WriteLine("Loop is finished");

// Console.ReadKey();

Console.WriteLine("Enter a word");

var userInput = Console.ReadLine();