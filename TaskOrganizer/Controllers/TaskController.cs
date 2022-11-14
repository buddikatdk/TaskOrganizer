using System;
using System.Collections.Generic;
using System.Globalization;
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
            //initialize current checking date
            DateTime nowDate = startingDate.AddDays(-1);
            int IsValidDateCount = 0;

            //then i put condition for checking stating date is holiday or not and by incrementing no of days
            do
            {
                nowDate = nowDate.AddDays(1);
                if (IsValidDate(nowDate))
                {
                    IsValidDateCount++;
                }

            } while ((noOfDays > IsValidDateCount));

            return IncrementalValidation(nowDate);
        }

        public bool IsValidDate(DateTime endingDate)
        {
            //first i get specified holidays from Holiday service
            List<Holiday> holidays = _holidayService.GetSpecifiedHolidays();
            bool isValid = true;
            foreach (Holiday holiday in holidays)
            {
                DateTime hdate = DateTime.ParseExact(holiday.holiDate, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                if (hdate == endingDate && (hdate.DayOfWeek != DayOfWeek.Saturday || hdate.DayOfWeek != DayOfWeek.Sunday))
                {
                    isValid = false;
                }
            }

            if(endingDate.DayOfWeek == DayOfWeek.Saturday || endingDate.DayOfWeek == DayOfWeek.Sunday)
            {
                isValid = false;
            }

            return isValid;
        }

        public string IncrementalValidation(DateTime endingDate)
        {
            do
            {
                if(!IsValidDate(endingDate))
                {
                    endingDate = endingDate.AddDays(1);
                }

            } while (!IsValidDate(endingDate));
            return endingDate.ToLongDateString();
        }
    }
}
