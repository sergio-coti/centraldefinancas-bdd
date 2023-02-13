using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeFinancas.BDD.Helpers
{
    public static class TestHelper
    {
        public static string? BASE_URL
            => @"http://centraldefinancascoti.azurewebsites.net/";

        public static void CreateScreenshot(WebDriver driver, string fileName)
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile($"c:\\temp\\{fileName}.png", ScreenshotImageFormat.Png);
        }
    }
}
