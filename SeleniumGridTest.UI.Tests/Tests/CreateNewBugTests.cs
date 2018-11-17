using NUnit.Framework;
using SeleniumGridTest.Helpers.Helpers;
using SeleniumGridTest.Selenium.SeleniumPages;
using SeleniumGridTest.UI.Tests.Base;
using SeleniumGridTest.UI.Tests.Resources;
using SeleniumGridTest.UI.Tests.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.UI.Tests.Tests
{
    [TestFixture, Order(1), Parallelizable(ParallelScope.All)]
    
    public class CreateNewBugTests : TestBase
    {
        [PageObject] LoginPage objLogin;
        [PageObject] CreateNewBugPage objNewBug;

        [Test, Description("Testar cadastrar novo bug informando todos os campos no formulário e validar se a mensagem de sucesso foi exibida.")]
        public void TEST_CreateNewBugAllFieldsSuccess()
        {
            LoginPage objLogin = new LoginPage(_driver);
            CreateNewBugPage objNewBug = new CreateNewBugPage(_driver);

            objLogin.NavigateToLoginPage().LogIn();
            objNewBug.OpenNewBugPage().CreateNewBug(ConstanstsTestData.categoria, ConstanstsTestData.frequencia, ConstanstsTestData.gravidade, ConstanstsTestData.prioridade, true, "plataforma", "SO", "VErsao so", ConstanstsTestData.atribuir, ConstanstsTestData.resumo, ConstanstsTestData.descricao, ConstanstsTestData.passosReproduzir, ConstanstsTestData.informacoesAdicionais, true, true).saveNewBug();

            //WaitForElementHelpers.WaitForElementDisplayed(objNewBug.msgSucessoLocator);
            //ValidationResult.AssertTextInElement(objNewBug.msgSucesso, MessagesNewBug.MensagemSucesso);

        }

        [Test, Description("Testa cadastrar novo bug informando apenas os campos obrigatórios e e validar se a mensagem de sucesso foi exibida.")]
        public void TEST_CreateNewBugRequiredFieldsSuccess()
        {
            LoginPage objLogin = new LoginPage(_driver);
            CreateNewBugPage objNewBug = new CreateNewBugPage(_driver);

            objLogin.NavigateToLoginPage().LogIn();
            objNewBug.OpenNewBugPage().CreateNewBug(String.Empty, String.Empty, String.Empty, String.Empty, false, String.Empty, String.Empty, String.Empty, String.Empty, ConstanstsTestData.resumo, ConstanstsTestData.descricao, String.Empty, String.Empty, false, false).saveNewBug();

            //ValidationResult.AssertTextInElement(objNewBug.msgSucesso, MessagesNewBug.MensagemSucesso);

        }

        [Test, Description("Testa tentar prosseguir sem exibir o campo Resumo e validar se a mensagem de obrigatoriedade foi exibida.")]
        public void TEST_CreateNewBugSummaryRequired()
        {
            LoginPage objLogin = new LoginPage(_driver);
            CreateNewBugPage objNewBug = new CreateNewBugPage(_driver);

            objLogin.NavigateToLoginPage().LogIn();
            objNewBug.OpenNewBugPage().CreateNewBug(ConstanstsTestData.categoria, ConstanstsTestData.frequencia, ConstanstsTestData.gravidade, ConstanstsTestData.prioridade, false, "plataforma", "SO", "VErsao so", ConstanstsTestData.atribuir, String.Empty, ConstanstsTestData.descricao, ConstanstsTestData.passosReproduzir, ConstanstsTestData.informacoesAdicionais, false, false);

            // JavaScriptExecutorHelper.ExecuteJavaScript("document.getElementById('summary').removeAttribute('required')");

            objNewBug.saveNewBug();

            //ValidationResult.AssertElementContainsText(objNewBug.msgErro, MessagesNewBug.MensagemErroObrigatoriedade.Replace("@campo", "summary"));



        }

        [Test, Description("Testa tentar prosseguir sem exibir o campo Descricão e validar se a mensagem de obrigatoriedade foi exibida.")]
        public void TEST_CreateNewBugDescriptionRequired()
        {
            LoginPage objLogin = new LoginPage(_driver);
            CreateNewBugPage objNewBug = new CreateNewBugPage(_driver);

            objLogin.NavigateToLoginPage().LogIn();
            objNewBug.OpenNewBugPage().CreateNewBug(ConstanstsTestData.categoria, ConstanstsTestData.frequencia, ConstanstsTestData.gravidade, ConstanstsTestData.prioridade, false, "plataforma", "SO", "VErsao so", ConstanstsTestData.atribuir, ConstanstsTestData.resumo, String.Empty, ConstanstsTestData.passosReproduzir, ConstanstsTestData.informacoesAdicionais, false, false);

            // JavaScriptExecutorHelper.ExecuteJavaScript("document.getElementById('description').removeAttribute('required')");

            objNewBug.saveNewBug();

            //ValidationResult.AssertElementContainsText(objNewBug.msgErro, MessagesNewBug.MensagemErroObrigatoriedade.Replace("@campo", "description"));
            //A necessary field "description" was empty. Please recheck your inputs.
        }

    }
}
