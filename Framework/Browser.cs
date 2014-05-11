using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Framework
{
    public static class Browser
    {
        private static readonly IWebDriver webDriver = new FirefoxDriver();

        public static IWebDriver Driver
        {
            get
            {
                return webDriver;
            }
        }

        public static void GoTo(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}