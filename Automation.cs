using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class Automation
    {
        public void Launchbrowser()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://phptravels.com/demo/");
            try
            {
                driver.FindElement(By.Name("first_name1")).SendKeys("Name1");
                //driver.FindElement(By.Name("first_name")).SendKeys("Name1");
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw (e);
            }
            finally
            {
                
                //driver.Close();
                //driver.Quit();
            }
            
        }
    }
}