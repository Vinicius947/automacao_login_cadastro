using com.registration_automation.Interfaces;
using com.registration_automation.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Test
{
    public class LoginServiceTest
    {
        private readonly LoginService _Login;
        private readonly IWebDriver _webDriver;
        public LoginServiceTest()
        {
            _webDriver = new ChromeDriver("C:/ChromeDrive");
            _Login = new LoginService();
        }
          [Fact]
        public int TesteNavegation()
        {
            var teste = _Login.loginProjetos(_webDriver);

            var v =  teste.IsCompletedSuccessfully.CompareTo(true);
            _webDriver.Close();
            return  v;
            
            //Assert.Equal(teste, );

        }
   

    }
}
