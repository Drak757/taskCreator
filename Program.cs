using System;
using System.Collections.Generic;

List<string> taskList = new List<string>();
bool running = true;

while(running) {

Console.WriteLine("=== Mini To-Do List ===");
Console.WriteLine("1. Add task");
Console.WriteLine("2. Remove task");
Console.WriteLine("3. Show tasks");
Console.WriteLine("4. Clear all tasks");
Console.WriteLine("5. Exit");

Console.WriteLine("Enter a choice: ");
string input = Console.ReadLine();

bool success = int.TryParse(input, out int choice);

    if(!success){
        Console.WriteLine("Invalid input. Please enter a number");
        continue;
    }

switch (choice)
    {
        case 1:
        Console.WriteLine("Enter a task: ");
        
        string task = Console.ReadLine();
        
        taskList.Add(task);
        
        Console.WriteLine("Task added!");
        break;
        
        case 2:
       Console.WriteLine("Which task do you want to remove?");
       string taskInput = Console.ReadLine();
       
      bool taskRemovedSuccess = int.TryParse(taskInput, out int taskNumber);
      
        if(!taskRemovedSuccess){
            Console.WriteLine("Invalid input. Please enter a task number.");
            break;
        }
            int index = taskNumber - 1;
            
            if(index >= 0 && index < taskList.Count){
                taskList.RemoveAt(index);
                Console.WriteLine("Task removed!");
            } else {
                Console.WriteLine("Invalid task number.");
            }

        break;
        
        case 3:
        if (taskList.Count == 0) {
            Console.WriteLine("No tasks in the list yet.");
        } else {
            Console.WriteLine("Here is the task list:");
            
            for(int i = 0; i < taskList.Count; i++){
                Console.WriteLine((i + 1) + ". " + taskList[i]);
        }
        }
        break;
        
        case 4:
        taskList.Clear();
        Console.WriteLine("Tasks are cleared!");
        break;
        
        case 5:
        running = false;
        break;
        
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}

    Console.WriteLine("Goodbye.");