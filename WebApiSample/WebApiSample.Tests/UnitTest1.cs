using WebApiSample.Controllers;

namespace WebApiSample.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new WeatherForecastController(null);
            var weather = controller.Get();
            Assert.True(weather.Count() > 0);
        }
    }
}