﻿using OpenQA.Selenium;
using WebDriverUniversityTest.IFrames;

namespace WebDriverUniversityTest.Pages
{
    class HomePage : BasePage
    {
        //Constructor ========================================================================================================
        public HomePage(IWebDriver driver) : base(driver) { }

        //IFrame =============================================================================================================
        public Video LoadHomePageVideoIFrame()
        {
            return new Video(driver.FindElement(By.Id("udemy-promo-thumbnail")));
        }

        //Navigation to pages ================================================================================================
        public ContactUsPage ClickContactUs()
        {
            driver.FindElement(By.CssSelector("#contact-us .thumbnail")).Click();
            return new ContactUsPage(driver);
        }

        public void ClickLoginPortal()
        {
            driver.FindElement(By.CssSelector("#login-portal .thumbnail")).Click();
        }

        public ButtonsPage ClickButtonClicks()
        {
            driver.FindElement(By.CssSelector("#button-clicks .thumbnail")).Click();
            return new ButtonsPage(driver);
        }

        public ToDoListPage ClickToDoList()
        {
            driver.FindElement(By.CssSelector("#to-do-list .thumbnail")).Click();
            return new ToDoListPage(driver);
        }

        public PageObjectModelPage ClickPageObjectModel()
        {
            driver.FindElement(By.CssSelector("#page-object-model .thumbnail")).Click();
            return new PageObjectModelPage(driver);
        }

        public AccordionPage ClickAccordion()
        {
            driver.FindElement(By.CssSelector("[href='Accordion/index.html'] .thumbnail")).Click();
            return new AccordionPage(driver);
        }

        public DropdownCheckboxRadioPage ClickDropdownCheckboxRadio()
        {
            driver.FindElement(By.CssSelector("#dropdown-checkboxes-radiobuttons .thumbnail")).Click();
            return new DropdownCheckboxRadioPage(driver);
        }

        public AjaxPage ClickAjaxLoader()
        {
            driver.FindElement(By.CssSelector("#ajax-loader .thumbnail")).Click();
            return new AjaxPage(driver);
        }

        public ActionsPage ClickActions()
        {
            driver.FindElement(By.CssSelector("#actions .thumbnail")).Click();
            return new ActionsPage(driver);
        }

        public void ClickPopUpAlerts()
        {
            driver.FindElement(By.CssSelector("#popup-alerts .thumbnail")).Click();
        }

        public IFramePage ClickIFrame()
        {
            driver.FindElement(By.CssSelector("#iframe .thumbnail")).Click();
            return new IFramePage(driver);
        }

        public void ClickHiddenElements()
        {
            driver.FindElement(By.CssSelector("#hidden-elements .thumbnail")).Click();
        }

        public void ClickDataTable()
        {
            driver.FindElement(By.CssSelector("#data-table .thumbnail")).Click();
        }
    }
}
