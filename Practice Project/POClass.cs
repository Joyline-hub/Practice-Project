using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project
{
    class POClasss
    {
        //Program2 prog = new Program2();
       
        public POClasss()
        {
            PageFactory.InitElements(Program2.driver, this);
        }


        [FindsBy(How = How.Id, Using = "TitleID")]
        public IWebElement ddTitleId { get; set; }

        [FindsBy(How = How.Id, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        public void FillUserForm(string initial, string middleName, string firstName)
        {
            /* txtInitial.SendKeys(initial);
             txtFirstName.SendKeys(firstName);
             txtMiddleName.SendKeys(middleName);
             btnSave.Click();*/

            /*Program2 prog = new Program2();
            prog.EnterTest(txtInitial, initial);
            prog.EnterTest(txtFirstName, firstName);
            prog.EnterTest(txtMiddleName, middleName);
            prog.Click(btnSave);*/

            txtFirstName.EnterTest(firstName);
            txtInitial.EnterTest(initial);
            
            txtMiddleName.EnterTest(middleName);
            btnSave.Clicks();

        }



    }
}
