using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOrganizer.Utility.Validations
{
    public class Validations
    {
        public bool DateValidation(DateTime staringDate)
        {
            if(staringDate is DateTime)
            {
                return true;
            }
            return false;
        }

        public bool NoOfDaysValidation(int noOfDays)
        {
            if (noOfDays is int && noOfDays > 0)
            {
                return true;
            }
            return false;
        }
    }
}
