﻿using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Junior.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        public IWebElement UserNameField => wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@name='username']")));
        public IWebElement PasswordField => wait.Until(ExpectedConditions.ElementExists(By.XPath("//input[@name='password']")));
        public IWebElement LoginButton => wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@type='submit']")));

        public void LoginIntoTheApplication(string userName, string password)
        {
            UserNameField.SendKeys(userName);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }
    }
}
