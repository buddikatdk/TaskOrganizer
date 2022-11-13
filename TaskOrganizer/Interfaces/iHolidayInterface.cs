using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOrganizer.Model;

namespace TaskOrganizer.Interfaces
{
    public interface iHolidayInterface
    {
        public List<Holiday> GetSpecifiedHolidays();
    }
}
