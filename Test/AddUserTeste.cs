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
    public class AddUserTeste
    {
        private readonly AddService _Add;
        private readonly IWebDriver _webDriver;
        public AddUserTeste()
        {
            _webDriver = new ChromeDriver("C:/ChromeDrive");
            _Add = new AddService();
        }
        [Fact]
        public int TesteAdd()
        {

            var teste = _Add.CreateUserProjetos("a","b",_webDriver);
            var v = teste.IsCompletedSuccessfully.CompareTo(true);
            _webDriver.Close();

            return v;

            //Assert.Equal(teste, );

        }
    }
}
