// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using TaskOrganizer.Controllers;
using TaskOrganizer.Interfaces;
using TaskOrganizer.Services;

//Configure services =>  Dependancy Injection configure Holiday Service
var serviceProvider = new ServiceCollection().AddSingleton<iHolidayInterface, iHolidayService>().BuildServiceProvider();
var holidayService = serviceProvider.GetService<iHolidayInterface>();

//Initiate objects
TaskController task = new TaskController(holidayService);

//Menu driven program
Console.WriteLine("---------------------------------Task Organizer---------------------------------");
Console.WriteLine();
Console.WriteLine("1. Calculate my deadline ");
Console.WriteLine("2. Re try ");
Console.WriteLine("3. Exit ? (y/n) ");

int option = Convert.ToInt32(Console.ReadLine());

switch(option)
{
    case 1:
        DateTime endingDate;
        Console.WriteLine("Please Enter Starting date (format should be as MM/dd/yyyy)");
        DateTime date = Convert.ToDateTime(Console.ReadLine());

        Console.WriteLine("Please Enter Task effort(days requried)");
        int dayCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        endingDate = Convert.ToDateTime(task.CalculateEndDate(date, dayCount));
        Console.WriteLine("Your task deadline will be " + endingDate);
        break;
    case 2:
        break;
    case 3:
        break;
}
