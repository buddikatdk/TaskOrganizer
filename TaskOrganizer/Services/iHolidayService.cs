using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOrganizer.Interfaces;
using TaskOrganizer.Model;

namespace TaskOrganizer.Services
{
    public class iHolidayService : iHolidayInterface
    {
        private readonly List<Holiday> _hcontext;

        public iHolidayService()
        {
            //here we specifies the list of specfic holidays with description
            _hcontext = new List<Holiday>()
            {
                //January
                new Holiday() { holiDate = "2022/01/02", holidayDescription = "poya day" },
                new Holiday() { holiDate = "2022/01/08", holidayDescription = "international freedom day" },

                //February
                new Holiday() { holiDate = "2022/01/02", holidayDescription = "poya day" },
                new Holiday() { holiDate = "2022/01/08", holidayDescription = "international freedom day" },

                //March
                new Holiday() { holiDate = "2022/01/02", holidayDescription = "poya day" },
                new Holiday() { holiDate = "2022/01/08", holidayDescription = "international freedom day" },

                //April
                new Holiday() { holiDate = "2022/01/02", holidayDescription = "poya day" },
                new Holiday() { holiDate = "2022/01/08", holidayDescription = "international freedom day" },

                //May
                new Holiday() { holiDate = "2022/01/02", holidayDescription = "poya day" },
                new Holiday() { holiDate = "2022/01/08", holidayDescription = "international freedom day" },

                //June
                new Holiday() { holiDate = "2022/01/02", holidayDescription = "poya day" },
                new Holiday() { holiDate = "2022/01/08", holidayDescription = "international freedom day" },

                //July
                new Holiday() { holiDate = "2022/01/02", holidayDescription = "poya day" },
                new Holiday() { holiDate = "2022/01/08", holidayDescription = "international freedom day" },

                //Aguest
                new Holiday() { holiDate = "2022/01/02", holidayDescription = "poya day" },
                new Holiday() { holiDate = "2022/08/23", holidayDescription = "international freedom day" },

                //September
                new Holiday() { holiDate = "2022/01/02", holidayDescription = "poya day" },
                new Holiday() { holiDate = "2022/01/08", holidayDescription = "international freedom day" },

                //Octomber
                new Holiday() { holiDate = "2022/01/02", holidayDescription = "poya day" },
                new Holiday() { holiDate = "2022/01/08", holidayDescription = "international freedom day" },

                //November
                new Holiday() { holiDate = "2022/01/02", holidayDescription = "poya day" },
                new Holiday() { holiDate = "2022/01/08", holidayDescription = "international freedom day" },

                //December
                new Holiday() { holiDate = "2022/11/14", holidayDescription = "poya day" },
                new Holiday() { holiDate = "2022/01/08", holidayDescription = "international freedom day" }
            };
        }

        public List<Holiday> GetSpecifiedHolidays()
        {
            return _hcontext;
        }
    }
}
