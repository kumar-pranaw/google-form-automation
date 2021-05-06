using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace AutomateGoogleForm
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            for (int i = 0; i <= 26; i++)
            {
                Console.WriteLine($@"Running Instance : {i}");
                driver.Navigate().GoToUrl("https://docs.google.com/forms/d/e/1FAIpQLSerWNzBEjoSx7IeHrCLLPiaeuTiM5R4FcJY6_3e5uE-uUdaRA/viewform?usp=sf_link");


                Thread.Sleep(3000);

                driver.FindElement(By.XPath("//*[@id='i7']/div[3]/div")).Click();
                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[3]/div[1]/div/div/span/span")).Click();
                Thread.Sleep(2000);

                // Next Page
                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[2]/div/div/div[2]/div/div[1]/div/div[1]/input")).SendKeys("23");

                driver.FindElement(By.XPath("//*[@id='i12']/div[3]/div")).Click();
                driver.FindElement(By.XPath("//*[@id='i31']/div[3]/div")).Click();
                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[5]/div/div/div[2]/div/div[1]/div/div[1]/input")).SendKeys("6th");
                driver.FindElement(By.XPath("//*[@id='i48']/div[3]/div")).Click();

                //Nationality
                driver.FindElement(By.XPath("//*[@id='i61']/div[3]/div")).Click();

                //Place
                driver.FindElement(By.XPath("//*[@id='i74']/div[3]/div")).Click();

                //Family
                driver.FindElement(By.XPath("//*[@id='i87']/div[3]/div")).Click();

                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[3]/div[1]/div/div[2]/span/span")).Click();
                Thread.Sleep(2000);

                // Next Page

                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[2]/div/div/div[2]/div/span/div/label[1]/div[2]/div/div/div[3]/div")).Click();

                // Preferences 1st Start
                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[3]/div/div/div[2]/div/div[1]/div/div[36]/span/div[2]/div/div/div[3]/div")).Click();

                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[3]/div/div/div[2]/div/div[1]/div/div[28]/span/div[3]/div/div/div[3]/div")).Click();

                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[3]/div/div/div[2]/div/div[1]/div/div[38]/span/div[4]/div/div/div[3]/div")).Click();
                // End


                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[5]/div/div/div[2]/div/div[1]/div/div[20]/span/div[4]/div/div/div[3]/div")).Click();

                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[5]/div/div/div[2]/div/div[1]/div/div[22]/span/div[3]/div/div/div[3]/div")).Click();
                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[5]/div/div/div[2]/div/div[1]/div/div[44]/span/div[2]/div/div/div[3]/div")).Click();

                //Encouraged
                //driver.FindElement(By.XPath("//*[@id='i26']/div[2]")).Click();
                //driver.FindElement(By.XPath("//*[@id='i38']/div[2]")).Click();
                driver.FindElement(By.XPath("//*[@id='i77']/div[2]")).Click();

                // LESS LIKELY
                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[8]/div/div/div[2]/div/div[1]/div/div[4]/span/div[2]/div/div/div[3]/div")).Click();
                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[8]/div/div/div[2]/div/div[1]/div/div[10]/span/div[3]/div/div/div[3]/div")).Click();
                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[8]/div/div/div[2]/div/div[1]/div/div[46]/span/div[4]/div/div/div[3]/div")).Click();


                driver.FindElement(By.XPath("//*[@id='i120']/div[2]")).Click();
                driver.FindElement(By.XPath("//*[@id='i147']/div[2]")).Click();
              //  driver.FindElement(By.XPath("//*[@id='i144']/div[2]")).Click();

                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[11]/div/div/div[2]/div/div[1]/div/div[2]/span/div[4]/div/div/div[3]/div")).Click();
                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[11]/div/div/div[2]/div/div[1]/div/div[4]/span/div[4]/div/div/div[3]/div")).Click();
                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[11]/div/div/div[2]/div/div[1]/div/div[6]/span/div[5]/div/div/div[3]/div")).Click();

                driver.FindElement(By.XPath("//*[@id='i167']/div[3]/div")).Click();
                driver.FindElement(By.XPath("//*[@id='i177']/div[3]/div")).Click();
               // driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[14]/div/div/div[2]/div/div[1]/div/div[1]/input")).SendKeys("Motivated me to help people");

                driver.FindElement(By.XPath("//*[@id='i194']/div[3]/div")).Click();
                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[16]/div/div/div[2]/div/div[1]/div/div[1]/input")).SendKeys("I would like to serve my country");

                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[17]/div/div/div[2]/div/span/div/label[2]/div[2]/div/div/div[3]/div")).Click();

                driver.FindElement(By.XPath("//*[@id='i218']/div[3]/div")).Click();

                driver.FindElement(By.XPath("//*[@id='i230']/div[2]")).Click();
               // driver.FindElement(By.XPath("//*[@id='i233']/div[2]")).Click();
                //driver.FindElement(By.XPath("//*[@id='i236']/div[2]")).Click();

                driver.FindElement(By.XPath("//*[@id='i252']/div[3]/div")).Click();
                driver.FindElement(By.XPath("//*[@id='i266']/div[3]/div")).Click();
                driver.FindElement(By.XPath("//*[@id='i280']/div[3]/div")).Click();
               // driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[2]/div[26]/div/div/div[2]/div/div[1]/div/div[1]/input")).SendKeys("NGO");

                driver.FindElement(By.XPath("//*[@id='i294']/div[3]/div")).Click();
                driver.FindElement(By.XPath("//*[@id='i307']/div[3]/div")).Click();

                driver.FindElement(By.XPath("//*[@id='mG61Hd']/div[2]/div/div[3]/div[1]/div/div[2]/span/span")).Click();

                Thread.Sleep(3000);
            }
           
        }
    }
}
