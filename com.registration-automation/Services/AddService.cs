using com.registration_automation.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading.Tasks;

namespace com.registration_automation.Services
{
    public class AddService :IAddUserService
    {
        public AddService()
        {
        }

        public async Task<bool> CreateUserProjetos(string email, string password, IWebDriver driver)
         {
            driver.Navigate().GoToUrl("http://projetos.gateware.com.br:8000/intranet/users/new");
            var userInput = driver.FindElement(By.Id("username"));
            var emailInput = driver.FindElement(By.Id("email"));
            var firstNameInput = driver.FindElement(By.Name("first_names"));
            var lastNameInput = driver.FindElement(By.Name("last_name"));
            var passwordInput = driver.FindElement(By.Name("password"));
            var selectInput = driver.FindElement(By.XPath("//*[@id='profile']/option[3]"));
            var passwordConfirmInput = driver.FindElement(By.Name("password_confirm"));
            var urlInput = driver.FindElement(By.Name("url"));
            emailInput.SendKeys(email);
            userInput.SendKeys(email);
            firstNameInput.SendKeys(email);
            lastNameInput.SendKeys(email);
            passwordInput.SendKeys(password);
            passwordConfirmInput.SendKeys(password);
            urlInput.SendKeys(email);
            selectInput.Click();
            var buttonConfirm = driver.FindElement(By.ClassName("form-button40"));
            //buttonConfirm.Click();
            driver.Close();

            return true;
        }
    }
}
