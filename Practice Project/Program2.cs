using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace Practice_Project
{

    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    public static class Program2
    {

        public static IWebDriver driver { get; set; }

        /*public void EnterTest(string element, string value, PropertyType elementtype)
        {

            if (elementtype == PropertyType.Id)
               driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        public void Click(string element, PropertyType elementtype)
        {

            if(elementtype == PropertyType.Id)
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == PropertyType.Name)
                driver.FindElement(By.Name(element)).Click();
        }

        //selecting a dropdown control

        public void SelectDropDown(string element, string value, PropertyType elementtype)
        {

            if (elementtype == PropertyType.Id)
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }

        public string GetText(string element, PropertyType elementtype)
        {

            if (elementtype == PropertyType.Id)
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == PropertyType.Name)
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            else return string.Empty;
        }

        public string GetTextFromDDL(string element, PropertyType elementtype)
        {

            if (elementtype == PropertyType.Id)
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == PropertyType.Name)
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return string.Empty;
        }*/


        //static and this is used only when the method should be made as extension method
        public static void EnterTest(this IWebElement element, string value)
        {

            element.SendKeys(value);
        }

        public static void Clicks(this IWebElement element)
        {

            element.Click();
        }

        public static void SelectDropDown(this IWebElement element, string value)
        {

           
                new SelectElement(element).SelectByText(value);
           
        }

        public static string GetText(this IWebElement element)
        {

           
                return element.GetAttribute("value");
           
        }

        public static string GetTextFromDDL(this IWebElement element)
        {

           
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
            
        }



    }
}
