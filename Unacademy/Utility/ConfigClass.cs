
using OpenQA.Selenium;

namespace Unacademy
{
    public class ConfigClass
    {
        public static IWebDriver driver;
        public static string chromeDriverPath = @"C:\Users\hp\source\repos\Unacademy\Unacademy\Drivers\";

        public static string url = "https://www.unacademy.com";
        public static string filePath = @"C:\Users\hp\source\repos\Unacademy\Unacademy\Screenshots\";

        public static int PAGE_LOAD_TIMEOUT = 10;
        public static int IMPLICIT_WAIT = 10;
    }
}

