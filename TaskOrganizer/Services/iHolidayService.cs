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
        private readonly List<Holiday> _context;

        public iHolidayService()
        {
            //here we specifies the list of specfic holidays with description
            _context = new List<Holiday>()
            {
                //January
                new Holiday() { holiDate = "2022/01/14", holidayDescription = "Tamil Thai Pongal day" },
                new Holiday() { holiDate = "2022/01/17", holidayDescription = "Duruthu Full Moon Poya day" },

                //February
                new Holiday() { holiDate = "2022/02/04", holidayDescription = "National day" },
                new Holiday() { holiDate = "2022/02/16", holidayDescription = "Navam Full Moon Poya day" },

                //March
                new Holiday() { holiDate = "2022/03/01", holidayDescription = "Mahasivarathri day" },
                new Holiday() { holiDate = "2022/03/17", holidayDescription = "Madin Full Moon Poya day" },

                //April
                new Holiday() { holiDate = "2022/04/11", holidayDescription = "Sinhala And Tamil holiday" },
                new Holiday() { holiDate = "2022/04/12", holidayDescription = "Sinhala And Tamil holiday" },
                new Holiday() { holiDate = "2022/04/13", holidayDescription = "Sinhala And Tamil New Year's Eve holiday" },
                new Holiday() { holiDate = "2022/04/14", holidayDescription = "Sinhala And Tamil New Year's day" },
                new Holiday() { holiDate = "2022/04/15", holidayDescription = "Good Friday" },
                new Holiday() { holiDate = "2022/04/16", holidayDescription = "Bak Full Moon Poya day" },
                new Holiday() { holiDate = "2022/04/17", holidayDescription = "Easter sunday" },

                //May
                new Holiday() { holiDate = "2022/05/01", holidayDescription = "May day" },
                new Holiday() { holiDate = "2022/05/02", holidayDescription = "Special Bank holiday" },
                new Holiday() { holiDate = "2022/05/03", holidayDescription = "Eid al-Fitr holiday" },
                new Holiday() { holiDate = "2022/05/15", holidayDescription = "Vesak Full Moon Poya day" },
                new Holiday() { holiDate = "2022/05/16", holidayDescription = "Day After Vesak Full Moon Poya day" },

                //June
                new Holiday() { holiDate = "2022/06/14", holidayDescription = "Poson Full Moon Poya day" },

                //July
                new Holiday() { holiDate = "2022/07/13", holidayDescription = "Esala Full Moon Poya day" },

                //Aguest
                new Holiday() { holiDate = "2022/08/11", holidayDescription = "Nikini Full Moon Poya day" },
                new Holiday() { holiDate = "2022/08/23", holidayDescription = "Test Case holiday" },

                //September
                new Holiday() { holiDate = "2022/09/10", holidayDescription = "Binara Full Moon Poya day" },

                //Octomber
                new Holiday() { holiDate = "2022/10/09", holidayDescription = "Milad-Un-Nabi day And Vap Full Moon Poya day" },
                new Holiday() { holiDate = "2022/10/10", holidayDescription = "Special Bank holiday" },

                //November
                new Holiday() { holiDate = "2022/11/07", holidayDescription = "Ill Full Moon Poya day" },

                //December
                new Holiday() { holiDate = "2022/12/07", holidayDescription = "Unduvap Full Moon Poya day" },
                new Holiday() { holiDate = "2022/12/24", holidayDescription = "Christmas Eve day" },
                new Holiday() { holiDate = "2022/12/25", holidayDescription = "Christmas day" },
                new Holiday() { holiDate = "2022/12/26", holidayDescription = "Special Bank holiday" }
            };
        }

        public List<Holiday> GetSpecifiedHolidays()
        {
            return _context;
        }
    }
}
