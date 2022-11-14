using TaskOrganizer.Interfaces;
using TaskOrganizer.Services;

namespace TaskOrganizerTest
{
    public class ValidationTest
    {
        private readonly iValidateInterface _validationService;

        public ValidationTest()
        {
            _validationService = new iValidateService();
        }

        [Theory]
        [InlineData("08/19/2022")]
        [InlineData("10/12/2022")]
        public void Should_Validate_Date(string value)
        {

            //Act
            var isValidDate = _validationService.DateValidation(value);

            //Assert
            Assert.True(isValidDate);
        }

        [Theory]
        [InlineData("5")]
        public void Should_Validate_NoOfDays(string noOfDays)
        {

            //Act
            var isValidNoOfDays = _validationService.NoOfDaysValidation(noOfDays);

            //Assert
            Assert.True(isValidNoOfDays);

        }
    }
}