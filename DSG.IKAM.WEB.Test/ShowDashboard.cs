using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace DSG.IKAM.WEB.Test
{
    class ShowDashboard
    {
        //private const string CaseUrl = "https://localhost:44378/";
        private const string CaseUrl = "https://www.google.co.th";
        private IWebDriver driver;

        [SetUp] 
        public void StartBrowser()
        {

            /*
            string workingPath = Assembly.GetExecutingAssembly().Location;
            string driverPath = Path.Combine(workingPath,  @"..\..\..\packages\Selenium.WebDriver.ChromeDriver.95.0.4638.6900\driver\win32\chromedriver");
            string driverFullPath = Path.GetFullPath(driverPath);
            driver = new ChromeDriver(driverFullPath);
            */
            driver = new ChromeDriver();
            
        }

        [Test] 
        public void Case1_Load_DashboardPage()
        {
            //string title = driver.Title;
            //string pageSource = driver.PageSource;
            //driver.Navigate().Back();
            //driver.Navigate().Forward();
            //driver.Navigate().Refresh();
            
            driver.Url = CaseUrl;

            //driver.Navigate().GoToUrl(CaseUrl);
            driver.Manage().Window.Maximize();

            /*
            IWebElement element = driver.FindElement(By.Id(""));
            
            //Webelement Commands
            element.Click();
            element.Clear();
            element.SendKeys("test test");
            bool isEnabled = element.Enabled;
            bool isSelected = element.Selected;
            element.Submit();
            string txt = element.Text;
            string tagName = element.TagName;
            string color = element.GetCssValue("class");
            */
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
