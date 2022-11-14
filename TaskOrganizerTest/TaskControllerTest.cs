using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskOrganizer.Controllers;
using TaskOrganizer.Interfaces;
using TaskOrganizer.Services;

namespace TaskOrganizerTest
{
    public class TaskControllerTest
    {
        private readonly TaskController _controller;
        private readonly iHolidayInterface _holidayService;

        public TaskControllerTest()
        {
            _holidayService = new iHolidayService();
            _controller = new TaskController(_holidayService);
        }

        [Fact]
        public void Return_Requested_EndDate()
        {
            //Arrange
            DateTime date = Convert.ToDateTime("08/19/2022");

            //Act
            var endDate = Convert.ToDateTime(_controller.CalculateEndDate(date, 5));

            //Assert
            Assert.Equal("08/26/2022", endDate.ToString("MM/dd/yyyy"));

        }

        [Fact]
        public void Return_NearestWorking_Date()
        {
            //Arrange
            DateTime date = Convert.ToDateTime("08/23/2022");

            //Act
            var endDate = Convert.ToDateTime(_controller.IncrementalValidation(date));

            //Assert
            Assert.Equal("08/24/2022", endDate.ToString("MM/dd/yyyy"));

        }

        [Fact]
        public void Return_IsDateValid_WorkingDate()
        {
            //Arrange
            DateTime date = Convert.ToDateTime("08/24/2022");

            //Act
            bool isValid = _controller.IsValidDate(date);

            //Assert
            Assert.Equal(true, isValid);

        }
    }
}
