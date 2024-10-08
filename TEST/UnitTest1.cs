using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TEST
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://store.steampowered.com/");
            var link = driver.FindElement(By.XPath("//*[@class='valve_links']//a[1]"));
            link.Click();
        }
    }
}