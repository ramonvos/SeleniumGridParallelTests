using NUnit.Framework;
using SeleniumGridTest.Selenium.SeleniumPages;
using SeleniumGridTest.UI.Tests.Base;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.UI.Tests.Tests
{
    [TestFixture, Order(1), Parallelizable(ParallelScope.Self)]
    public class LoginTests : TestBase
    {
        
        LoginPage objLogin = null;
        HomePage objHome = null;
        [Test, Description("Testar realizar login informando dados validados e validar se foi exibido a página inicial")]
        public void TEST_LoginSuccess()
        {
            objLogin = new LoginPage(_driver);

            string login = ConfigurationManager.AppSettings["USERNAME"];
            string senha = ConfigurationManager.AppSettings["PASSWORD"];


            objLogin.NavigateToLoginPage().LogIn(login, senha);

            //ValidationResult.AssertElementDisplayed(objHome.containerPrincipal);
        }

        [Test, Description("Testa realizar login informando login e senha invalidos e validar se foi exibido mensagem de validação.")]
        public void TEST_LoginInvalidUsername()
        {
            objLogin = new LoginPage(_driver);
            objLogin.NavigateToLoginPage().LogIn("teste", "teste");

            //ValidationResult.AssertTextInElement(objLogin.msgErroLogin, "Your account may be disabled or blocked or the username/password you entered is incorrect.");
        }

        [Test, Description("Testa realizar login informando login invalido e validar se foi exibido mensagem de validação.")]
        public void TEST_LoginInvalidPassword()
        {
            objLogin = new LoginPage(_driver);
            objLogin.NavigateToLoginPage().LogIn("teste", "teste");

           // ValidationResult.AssertTextInElement(objLogin.msgErroLogin, "Your account may be disabled or blocked or the username/password you entered is incorrect.");
        }

        [Test, Description("Testa realizar login informando senha invalida e validar se foi exibido mensagem de validação.")]
        public void TEST_LoginUserRequired()
        {
            objLogin = new LoginPage(_driver);
            objLogin.NavigateToLoginPage().LogIn("", string.Empty);

            //ValidationResult.AssertTextInElement(objLogin.msgErroLogin, "Your account may be disabled or blocked or the username/password you entered is incorrect.");
        }

        [Test, Description("Testa realizar login sem informar login e validar se foi exibido mensagem de validação.")]
        public void TEST_LoginUserEmpty()
        {
            objLogin = new LoginPage(_driver);
            objLogin.NavigateToLoginPage().LogIn("", string.Empty);

            //ValidationResult.AssertTextInElement(objLogin.msgErroLogin, "Your account may be disabled or blocked or the username/password you entered is incorrect.");
        }

        [Test, Description("Testa realizar login sem informar senha e validar se foi exibido mensagem de validação.")]
        public void TEST_LoginPasswordEmpty()
        {
            objLogin = new LoginPage(_driver);
            objLogin.NavigateToLoginPage().LogIn("teste", "");

            //ValidationResult.AssertTextInElement(objLogin.msgErroLogin, "Your account may be disabled or blocked or the username/password you entered is incorrect.");
        }

        [Test, Description("Testa realizar login sem informar login e senha e validar se foi exibido mensagem de validação.")]
        public void TEST_LoginUserAndPasswordEmpty()
        {
            objLogin = new LoginPage(_driver);
            objLogin.NavigateToLoginPage().LogIn("", "");

            //ValidationResult.AssertTextInElement(objLogin.msgErroLogin, "Your account may be disabled or blocked or the username/password you entered is incorrect.");

        }


    }
}
