using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOrganizer.Interfaces
{
    public interface iValidateInterface
    {
        public bool DateValidation(string staringDate);
        public bool NoOfDaysValidation(string noOfDays);
    }
}
