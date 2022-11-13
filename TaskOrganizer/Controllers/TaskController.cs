using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOrganizer.Interfaces;
using TaskOrganizer.Model;
using TaskOrganizer.Services;

namespace TaskOrganizer.Controllers
{
    public class TaskController
    {
        private readonly iHolidayInterface _holidayService;

        public TaskController(iHolidayInterface holidayService)
        {
            _holidayService = holidayService;
        }

        //Controller for calculate the End date. I stored the logic here and return the Task End Date
        //retrive the Holydays from the holyday service

        public string CalculateEndDate(DateTime startingDate, int noOfDays)
        {

            //first i get specified holidays from Holiday service
            List<Holiday> holidays = _holidayService.GetSpecifiedHolidays();

            //initialize end date
            DateTime endingDate = startingDate;
            DateTime nowDate = startingDate;

            //then i put condition for checking stating date is holiday or not and by incrementing no of days
            do
            {
                if (nowDate.DayOfWeek == DayOfWeek.Sunday || nowDate.DayOfWeek == DayOfWeek.Saturday)
                {
                    endingDate = endingDate.AddDays(1);
                }

                foreach (Holiday holiday in holidays)
                {
                    if(nowDate == Convert.ToDateTime(holiday.holiDate))
                    {
                        endingDate = endingDate.AddDays(1);
                    }
                }

                endingDate = endingDate.AddDays(1);

                nowDate.AddDays(1);
                noOfDays--;

            } while (noOfDays == 0);
            //also icheck startdate.daysOfWeek is week end or not
            //then i calculate end date and return that date
            return endingDate.ToLongDateString();
        }
    }
}
