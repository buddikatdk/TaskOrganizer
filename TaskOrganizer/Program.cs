// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using TaskOrganizer.Controllers;
using TaskOrganizer.Interfaces;
using TaskOrganizer.Services;
using TaskOrganizer.Utility.Validations;

//Configure services =>  Dependancy Injection configure Holiday Service
var serviceProvider = new ServiceCollection().AddSingleton<iHolidayInterface, iHolidayService>().BuildServiceProvider();
var holidayService = serviceProvider.GetService<iHolidayInterface>();

//Initiate objects
TaskController task = new TaskController(holidayService);
Validations validate = new Validations();

//Menu driven program
int option;
do
{
    Console.WriteLine();
    Console.WriteLine("---------------------------------Task Organizer---------------------------------");
    Console.WriteLine();
    Console.WriteLine(" 1. Calculate My Task Deadline ");
    Console.WriteLine(" 2. Re Try ?");
    Console.WriteLine(" 3. Exit ? ");
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------------------");

    option = Convert.ToInt32(Console.ReadLine());

    if(option == 1)
    {
        DateTime endingDate;
        bool dflag = false;
        bool cflag = false;
        DateTime date = DateTime.Now;
        int dayCount = 0;
        try
        {
            Console.WriteLine("Please Enter Starting date (format should be as MM/dd/yyyy)");
            date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine();
        
            Console.WriteLine("Please Enter Task effort(days requried)");
            dayCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            endingDate = Convert.ToDateTime(task.CalculateEndDate(date, dayCount));
            Console.WriteLine("Your task deadline will be " + endingDate);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Do you want to check again ? (y/n)");
            string op = Console.ReadLine();
            if (op == "y" || op == "Y") { option = 2; } else { option = 3; }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Console.WriteLine();
            Console.WriteLine("Program Terminated due to error ! .... Do you want to Restart program ? (y/n)");
            string input = Console.ReadLine();
            if (input == "y" || input == "Y") { option = 2; } else { option = 3; }
        }
    }
    else if(option == 3)
    {
        return;
    }
}while(option == 2);

