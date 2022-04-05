using com.registration_automation.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace com.registration_automation.Services
{
    public class LoginService : ILoginService
    {
        public LoginService()
        {
        }

        public async Task<bool> loginProjetos(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://projetos.gateware.com.br:8000/");
            var loginInput = driver.FindElement(By.Id("email"));
            loginInput.SendKeys("Email");
            var passInput = driver.FindElement(By.Id("password"));
            passInput.SendKeys("Password");
            var buttonLogin = driver.FindElement(By.XPath("//*[@id='login']/table/tbody/tr[4]/td/input"));
            buttonLogin.Click();
            bool verdadeiro = true; 
            return verdadeiro;
        }
    }
}
