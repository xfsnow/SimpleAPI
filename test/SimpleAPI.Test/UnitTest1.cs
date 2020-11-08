using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        
        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            // Equal 判断类型
            Assert.Equal("Test Name", returnValue);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
