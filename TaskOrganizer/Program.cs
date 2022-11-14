// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using TaskOrganizer.Controllers;
using TaskOrganizer.Interfaces;
using TaskOrganizer.Services;

//Configure services =>  Dependancy Injection configure Holiday Service , Validation Service
var serviceProvider = new ServiceCollection().AddSingleton<iHolidayInterface, iHolidayService>().BuildServiceProvider();
var validationServiceProvider = new ServiceCollection().AddSingleton<iValidateInterface, iValidateService>().BuildServiceProvider();
var holidayService = serviceProvider.GetService<iHolidayInterface>();
var validationService = validationServiceProvider.GetService<iValidateInterface>();

//Initiate objects
TaskController task = new TaskController(holidayService);

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
        DateTime date = DateTime.Now;
        int dayCount = 0;
        try
        {
            string doption = null;
            string coption = null;
            bool dflag = false;
            bool cflag = false;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Please Enter Starting date (format should be as MM/dd/yyyy)");
                var dateString = Console.ReadLine();
                if (validationService.DateValidation(dateString))
                {
                    date = Convert.ToDateTime(dateString);
                    dflag = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Validation failed when entering Staring date");
                    Console.WriteLine("Do you want to enter staring date again ? (y/n) ");
                    doption = Console.ReadLine();
                    if (doption == "y" || doption == "Y")
                    {
                        dflag = true;
                    }
                    else
                    {
                        dflag = true;
                        return;
                    }
                }
            } while (dflag);
           
            Console.WriteLine();
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please Enter Task effort(days requried)");
                var dayCountString = Console.ReadLine();
                if (validationService.NoOfDaysValidation(dayCountString))
                {
                    dayCount = Convert.ToInt32(dayCountString);
                    cflag = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Validation failed when entering Day count");
                    Console.WriteLine("Do you want to enter correct day count again ? (y/n)");
                    coption = Console.ReadLine();
                    if (coption == "y" || doption == "Y")
                    {
                        cflag = true;
                    }
                    else
                    {
                        cflag = true;
                        return;
                    };
                }
            } while (cflag);
            
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

