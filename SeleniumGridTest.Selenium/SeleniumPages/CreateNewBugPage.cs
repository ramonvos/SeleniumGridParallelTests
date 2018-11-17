using OpenQA.Selenium;
using SeleniumGridTest.Helpers;
using SeleniumGridTest.Helpers.Helpers;
using SeleniumGridTest.Selenium.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Selenium.SeleniumPages
{
    public class CreateNewBugPage : BasePage
    {
        public IWebDriver Instance { get; set; }

        ButtonHelper objButton = null;
        ComboBoxHelper objCombo = null;
        TextBoxHelper objText = null;
        public CreateNewBugPage(IWebDriver driver) : base(driver)
        {
            Instance = driver;
            objButton = new ButtonHelper(Instance);
            objCombo = new ComboBoxHelper(Instance);
            objText = new TextBoxHelper(Instance);
        }

        public const String url = "";
        public IWebElement linkCriarTarefa => Instance.FindElement(By.LinkText("Report Issue"));


        public IWebElement ddlCategoria => Instance.FindElement(By.Id("category_id"));

        private By locatorDdlCategoria = By.Id("category_id");
        public IWebElement ddlFrequecia => Instance.FindElement(By.Id("reproducibility"));
        public IWebElement ddlGravidade => Instance.FindElement(By.Id("severity"));
        public IWebElement ddlPrioridade => Instance.FindElement(By.Id("priority"));
        public IWebElement ddlAtribuir => Instance.FindElement(By.Id("handler_id"));


        public IWebElement txtResumo => Instance.FindElement(By.Id("summary"));
        public IWebElement txtDescricao => Instance.FindElement(By.Id("description"));
        public IWebElement txtPassos => Instance.FindElement(By.Id("steps_to_reproduce"));
        public IWebElement txtAdicionais => Instance.FindElement(By.Id("additional_info"));




        public IWebElement txtMarcadores => Instance.FindElement(By.Id("tag_string"));

        public IWebElement btnExpandirPerfil => Instance.FindElement(By.XPath("//a[@id='profile_closed_link']/i"));
        private By locatorbtnExpandirPerfil = By.XPath("//a[@id='profile_closed_link']/i");

        public IWebElement txtPlataforma => Instance.FindElement(By.Id("platform"));
        private By locatortxtPlataforma = By.Id("platform");
        public IWebElement txtSO => Instance.FindElement(By.Id("os"));
        public IWebElement txtVersaoSO => Instance.FindElement(By.Id("os_build"));

        public IWebElement txtEnviarArquivos => Instance.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Tamanho máximo: 5,000 kB'])[1]/following::div[1]"));

        public IWebElement rbVisibilidadePublico => Instance.FindElement(By.XPath("//form[@id='report_bug_form']/div/div[2]/div/div/table/tbody/tr[13]/td/label/span"));
        public IWebElement rbVisibilidadePrivado => Instance.FindElement(By.XPath("//form[@id='report_bug_form']/div/div[2]/div/div/table/tbody/tr[13]/td/label[2]/span"));
        public IWebElement ckContinuarRelatando => Instance.FindElement(By.XPath("//form[@id='report_bug_form']/div/div[2]/div/div/table/tbody/tr[14]/td/label/span"));


        public IWebElement btnSalvar => Instance.FindElement(By.XPath("//input[@value='Submit Issue']"));


        public IWebElement msgSucesso => Instance.FindElement(By.XPath("//div[@id='main-container']/div[2]/div[2]/div/div/div/div[2]/p"));
        public By msgSucessoLocator = By.XPath("//div[@id='main-container']/div[2]/div[2]/div/div/div/div[2]/p");

        public IWebElement msgErro => Instance.FindElement(By.XPath("//*[@id='main-container']/div[2]/div[2]/div/div/div[2]/p[2]"));


        public CreateNewBugPage OpenNewBugPage()
        {
            objButton.ClickButton(linkCriarTarefa);

            return new CreateNewBugPage(Instance);
        }
        public CreateNewBugPage CreateNewBug(string categoria, string frequencia, string gravidade, string prioridade, bool selecionarPerfil,
            string plataforma, string so, string versaoSo, string atribuirA, string resumo, string descricao, string passos, string informacoesAdicionais, bool privado, bool continuarRelatando)
        {

            //WaitForElementHelpers.WaitForElementDisplayed(locatorDdlCategoria);
            objCombo.SelectText(ddlCategoria,categoria);
            objCombo.SelectText(ddlFrequecia,frequencia);
            objCombo.SelectText(ddlGravidade, gravidade);
            objCombo.SelectText(ddlPrioridade, prioridade);
            //if (selecionarPerfil)
            //{
            //    if (SelecionarPerfilOculto())
            //    {
            //        btnExpandirPerfil.ClickButton();
            //    }


            //    WaitForElementHelpers.WaitForElementDisplayed(locatortxtPlataforma);
            // objText.TypeInTextBox(txtPlataforma,plataforma);
            //    txtSO.TypeInTextBox(so);
            //    txtVersaoSO.TypeInTextBox(versaoSo);
            //}

            //ddlAtribuir.SelectText(atribuirA);

            objText.TypeInTextBox(txtResumo,resumo);
            objText.TypeInTextBox(txtDescricao,descricao);
            objText.TypeInTextBox(txtPassos,passos);

            //txtAdicionais.TypeInTextBox(informacoesAdicionais);

            //if (privado)
            //{
            //    rbVisibilidadePrivado.RadioButtonSelect();
            //}
            //if (continuarRelatando)
            //{
            //    ckContinuarRelatando.CheckboxChecked();
            //}
            ////txtEnviarArquivos.SendKeys(@"C:\Users\ramon\source\repos\AutomacaoMantisBT-Ramon\AutomacaoMantisBT.Testes\bin\Debug\TestResult\2018-10-05\ReportTest - sexta-feira, 5 de outubro de 2018.html");



            return new CreateNewBugPage(Instance);
        }

        public CreateNewBugPage saveNewBug()
        {

            objButton.ClickButton(btnSalvar);

            return new CreateNewBugPage(Instance);
        }

        private bool SelecionarPerfilOculto()
        {
            try
            {
                return btnExpandirPerfil.Displayed;
            }
            catch
            {

                return false;
            }
        }
    }
}
