using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TaskOrganizer.Interfaces;

namespace TaskOrganizer.Services
{
    public class iValidateService : iValidateInterface
    {
        public bool DateValidation(string staringDate)
        {
            var dateTimeRegex = new Regex(@"(\d{2})/(\d{2})/(\d{4})");
            if (dateTimeRegex.IsMatch(staringDate))
            {
                return true;
            }
            return false;
        }

        public bool NoOfDaysValidation(string noOfDays)
        {
            var numberRegex = new Regex(@"^\d+$");
            if(numberRegex.IsMatch(noOfDays))
            {
                return true;
            }
            return false;
        }
    }
}
