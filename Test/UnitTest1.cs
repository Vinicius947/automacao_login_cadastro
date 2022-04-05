using com.registration_automation.Controllers;
using com.registration_automation.Interfaces;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        private readonly Mock<ILoginService> _login;
        private readonly Mock<IAddUserService> _addUser;
        private readonly CreateUserProjetcsController _controller;

        public UnitTest1()
        {
            _login = new Mock<ILoginService>();
            _addUser = new Mock<IAddUserService>();
            _controller = new CreateUserProjetcsController(_login.Object,_addUser.Object);
        }
        [Fact]
        public Task Test1()
        {
           var teste = _controller.CreateUser("a", "b");
           teste.IsCompletedSuccessfully.CompareTo(true);
            return  teste;
        }
    }
}
