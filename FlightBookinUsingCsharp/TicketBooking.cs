using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace TicketBooking
{
    class TicketBooking
    {
        IWebDriver driver = new ChromeDriver();




        [SetUp]
        public void OpenBrowser()
        {
            driver.Navigate().GoToUrl("https://in.via.com/");
            driver.Manage().Window.Maximize();

        }

        [Test]
        public void Login()

        {
            //clickOnPopup   
            driver.FindElement(By.XPath("//button[@class='No thanks']")).Click();

            //WaitFor5Seconds
            Thread.Sleep(5000);

            //ClickOnSignIn
            driver.FindElement(By.XPath("(//div[@class='elementPad menuLabel  secNavIcon'])[3]")).Click();

            //EnterTheUserName
            driver.FindElement(By.Id("loginIdText")).SendKeys("amold@gmail.com");
            //EnterThePassword
            driver.FindElement(By.Id("passwordText")).SendKeys("9922974130");


            //EnterThePassword
            driver.FindElement(By.XPath("//input[@value='Sign In']")).Click();
        }


        [Test]
        public void EnterDetails()
        {

          

            //WaitFor10Seconds
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //EnterTheFromText
            driver.FindElement(By.Id("source")).SendKeys("Hyd");


            //WaitFor5Seconds
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //SelectTheFrom
            driver.FindElement(By.XPath("(//li[@class='ui-menu-item'])[1]")).Click();


            //EnterTheToText
            Actions action = new Actions(driver);
            driver.FindElement(By.Id("destination")).SendKeys("aur");

            //SelectTheTo
            action.MoveToElement(driver.FindElement(By.XPath("//span[contains(text(),'Aurangabad,Aurangabad - India')]"))).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            //ToSelectThe
            IWebElement text = driver.FindElement(By.Id("destination"));
            text.SendKeys(Keys.ArrowDown + Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //SelectTheDate
            driver.FindElement(By.XPath("(//div[@data-date=\"25\"])[1]")).Click();


            //ToSelectAdultMoreThan1   
            for (int i = 1; i < 3; i++)
            {
                driver.FindElement(By.XPath("(//div[@class='plus'])[1]")).Click();
            }

            //ClickOnTheSearchFlights
            driver.FindElement(By.XPath("//div[@id='search-flight-btn']")).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //ClickOnAvalibaleFlightsBookButton
            driver.FindElement(By.XPath("(//div[@class='u_inlineblk u_width35 u_vertAlignMiddle'])[3]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //ClickOnDropdownTitle
            driver.FindElement(By.Id("adult1Title")).Click();
            SelectElement oSelect = new SelectElement(driver.FindElement(By.Id("adult1Title")));
            oSelect.SelectByText("Mr");


            //EnterTheFirstName
            driver.FindElement(By.Id("adult1FirstName")).SendKeys("Naresh");

            //EnterTheSurname
            driver.FindElement(By.Id("adult1Surname")).SendKeys("Ghuge");

            //EnterThecontactMobile
            driver.FindElement(By.Id("contactMobile")).SendKeys("9922974130");

            //EnterThecontactEmail
            driver.FindElement(By.Id("contactEmail")).SendKeys("nareshghuge@gmail.com");


            //WaitFor5Seconds
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


            /*//ClickOnDomesticInsurance
            driver.FindElement(By.XPath("//label[@for='domestic_insurance']")).Click();
            */

            //TakeVoucher
            String result = driver.FindElement(By.XPath("//div[contains(text(), 'VIADOM')]")).Text;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            //EnterTheVoucherCode
            driver.FindElement(By.Id("voucherCode")).SendKeys(result);

            //WaitFo15Seconds
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            action.MoveToElement(driver.FindElement(By.XPath("//div[@class='voucher-btn']"))).Click();

            //WaitFo15Seconds   
            Thread.Sleep(5000);
            //ClickOnProceedBooking  
            driver.FindElement(By.Id("makePayCTA")).Click();
            Console.Write("completed");




        }

        [TearDown]
        public void TearDown()
        {  
         //CloseTheBrowser
         driver.Quit();

        }
        }






    







}


