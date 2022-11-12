// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please Enter Starting date (format should be as MM/dd/yyyy)");
DateTime date = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Please Enter Task effort(days requried)");
int dayCount = Convert.ToInt32(Console.ReadLine());


//check start day is holiday or not
if(date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday || date.)
{
    Console.WriteLine("Starting date is not a week day.it's " + date.DayOfWeek + " day");
}

while(dayCount >= 0)
{




    dayCount--;
}

Console.WriteLine(date);
