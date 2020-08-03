using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace Practice_Project
{
    class Program
    {


        static void Main(string[] args)
        {
            
            Program prog1 = new Program();
            prog1.TestMethod();

           
        }
        public void TestMethod()
        {

            ExcelReader.PopulateInCollection(@"C:\Users\joyline.m\Downloads\Selenium C#\ExcelReader.xlsx");
            //Program2 prog = new Program2();
            Program2.driver = new FirefoxDriver();            // IWebDriver driver = new InternetExplorerDriver();

            //driver.Manage().Window.Maximize();
            Program2.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            Console.WriteLine("launched browser");

            LoginPageObjects loginPage = new LoginPageObjects();


            //POClasss eapage = loginPage.Login("execute","automation");

            //eapage.FillUserForm("J", "melita", "Mendonca");



            //using excel
            POClasss eapage = loginPage.Login(ExcelReader.ReadData(1, "UserName"), ExcelReader.ReadData(1, "Password"));

            eapage.FillUserForm(ExcelReader.ReadData(1, "Initial"), ExcelReader.ReadData(1, "MiddleName"), ExcelReader.ReadData(1, "FirstName"));

            //POClasss page = new POClasss();

            //page.txtInitial.SendKeys("Text");

            // prog.SelectDropDown("TitleId", "Ms.", PropertyType.Id);
            /* prog.EnterTest("Initial", "J", PropertyType.Name);

             Console.WriteLine("Initial field value is: " + prog.GetText("Initial", PropertyType.Id));
             Console.WriteLine("TiTle is: " + prog.GetTextFromDDL("TitleId", PropertyType.Name));

             prog.Click("Save", PropertyType.Name);*/

            /*IWebElement element = driver.FindElement(By.Name("q"));

            element.SendKeys("Test");
            element.SendKeys(Keys.Enter);
            Console.WriteLine("Executed Test");*/

            Program2.driver.Close();
            Console.WriteLine("Closed browser");
        }

    }
        
           
    }

     

       

