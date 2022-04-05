using System.Threading.Tasks;

namespace com.registration_automation.Interfaces
{
    public interface ILoginService
    {
       Task<bool> loginProjetos(OpenQA.Selenium.IWebDriver driver);
    }
}
