﻿using Senior.Config.Core;
using Senior.Pages;

namespace Senior.Steps
{
    public class PayGradesSteps
    {
        private PayGradesPage payGradesPage = new PayGradesPage();

        Random rand = new Random();
        public void AddPayGrade()
        {
            string randomName = "RandomName" + rand.Next(0, 10000);
            DriverHolder.Driver.FindElement(payGradesPage.PayGradesAddButton).Click();
            DriverHolder.Driver.FindElement(payGradesPage.PayGradesAddNameField).SendKeys(randomName);
            DriverHolder.Driver.FindElement(payGradesPage.SaveButton).Click();
        }

    }
}
