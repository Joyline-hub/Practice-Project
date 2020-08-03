using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;


namespace Practice_Project
{
    class LoginPageObjects
    {

        public LoginPageObjects()
        {
            PageFactory.InitElements(Program2.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public POClasss Login(string userName, string password)
        {
            /*txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();*/

            txtUserName.EnterTest(userName);
            txtPassword.EnterTest(password);
            btnLogin.Clicks();

            return new POClasss();
        }
    }
}
