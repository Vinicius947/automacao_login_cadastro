using com.registration_automation.Interfaces;
using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;

namespace com.registration_automation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateUserProjetcsController
    {
        private readonly ILoginService _login;
        private readonly IAddUserService _addUser;
        private readonly IWebDriver _Driver;

        public CreateUserProjetcsController(ILoginService login, IAddUserService addUser)
        {
            _login = login;
            _addUser = addUser;
            _Driver = new ChromeDriver("C:/ChromeDrive");
        }
        [HttpPost]
        public async Task CreateUser(string email,string password)
        {

           var resultLogin = _login.loginProjetos(_Driver);
            _addUser.CreateUserProjetos(email,password, _Driver);

        }
        

    }
}
