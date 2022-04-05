using OpenQA.Selenium;
using System.Threading.Tasks;

namespace com.registration_automation.Interfaces
{
    public interface IAddUserService
    {
        Task<bool> CreateUserProjetos(string email, string password, IWebDriver driver);
    }
}
