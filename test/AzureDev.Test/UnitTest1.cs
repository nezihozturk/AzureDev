using System;
using Xunit;
using AzureDev.Controllers;

namespace AzureDev.Test
{

   
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnMyName()
        {   
            var returnValue = controller.Get();
            Assert.NotEmpty(returnValue);

        }

        [Fact]
        public void Test1()
        {   

        }
    }
}
