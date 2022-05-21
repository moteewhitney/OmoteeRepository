using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectGroupsI.Utilities;

namespace TestProjectGroupsI.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement Username => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));

        IWebElement EmailAddress => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[2]/input"));

        IWebElement Password => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(3) > input"));

        IWebElement GetSignUp => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));

        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));





        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public void EnterUsername()
        {
            Username.SendKeys("Mowtteeiiw");
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }


        public void EnterEmailAddress()
        {
            EmailAddress.SendKeys("ohearreal@hotmail.com");
        }


        public void EnterPassword()
        {
            Password.SendKeys("Spring22");
        }
        

        public void ClickOnGetSignUp()
        {
            GetSignUp.Click();
        }


        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }


    }
}
