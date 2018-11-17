using OpenQA.Selenium;
using SeleniumGridTest.Helpers.SeleniumFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumGridTest.Selenium.SeleniumPages
{
    public class UpdateBugStepsPage : DriverFactory
    {
        public IWebDriver Instance { get; set; }
        public UpdateBugStepsPage(IWebDriver driver) : base(driver)
        {
            Instance = driver;
        }

        public IWebElement linkVerTarefas => Instance.FindElement(By.LinkText("View Issues"));

        public IWebElement btnUpdateBug => Instance.FindElement(By.XPath("//*[@id='buglist']/tbody/tr[1]/td[2]"));

        public IWebElement btnSave => Instance.FindElement(By.XPath("//input[@value='Update Information']"));

        public IWebElement ddlCategoria => Instance.FindElement(By.Id("category_id"));

        private By locatorDdlCategoria = By.Id("category_id");
        public IWebElement ddlFrequecia => Instance.FindElement(By.Id("reproducibility"));
        public IWebElement ddlGravidade => Instance.FindElement(By.Id("severity"));
        public IWebElement ddlPrioridade => Instance.FindElement(By.Id("priority"));
        public IWebElement ddlAtribuir => Instance.FindElement(By.Id("handler_id"));

        public IWebElement txtResumo => Instance.FindElement(By.Id("summary"));
        public IWebElement txtDescricao => Instance.FindElement(By.Id("description"));
        public IWebElement txtPassos => Instance.FindElement(By.Id("steps_to_reproduce"));
        public IWebElement txtAdicionais => Instance.FindElement(By.Id("additional_information"));


        public IWebElement btnExpandirPerfil => Instance.FindElement(By.XPath("//a[@id='profile_closed_link']/i"));
        private By locatorbtnExpandirPerfil = By.XPath("//a[@id='profile_closed_link']/i");
        public IWebElement txtPlataforma => Instance.FindElement(By.Id("platform"));
        private By locatortxtPlataforma = By.Id("platform");
        public IWebElement txtSO => Instance.FindElement(By.Id("os"));
        public IWebElement txtVersaoSO => Instance.FindElement(By.Id("os_build"));

        public IWebElement ckVisibilidadePrivado => Instance.FindElement(By.Id("private"));


        public UpdateBugStepsPage OpenViewTask()
        {
            //linkVerTarefas.ClickLink();

            return new UpdateBugStepsPage(Instance);
        }

        public UpdateBugStepsPage ClickUpdateBug()
        {
            //btnUpdateBug.ClickButton();

            return new UpdateBugStepsPage(Instance);
        }


        public UpdateBugStepsPage FillFormUpdateBug(string categoria, string frequencia, string gravidade, string prioridade, bool selecionarPerfil,
           string plataforma, string so, string versaoSo, string atribuirA, string resumo, string descricao, string passos, string informacoesAdicionais, bool privado)
        {

            //WaitForElementHelpers.WaitForElementDisplayed(locatorDdlCategoria);
            //ddlCategoria.SelectText(categoria);
            //ddlFrequecia.SelectText(frequencia);
            //ddlGravidade.SelectText(gravidade);
            //ddlPrioridade.SelectText(prioridade);
            //if (selecionarPerfil)
            //{
            //    WaitForElementHelpers.WaitForElementDisplayed(locatortxtPlataforma);
            //    txtPlataforma.ClearAndTypeInTextBox(plataforma);
            //    txtSO.ClearAndTypeInTextBox(so);
            //    txtVersaoSO.ClearAndTypeInTextBox(versaoSo);
            //}

            //ddlAtribuir.SelectText(atribuirA);

            //txtResumo.ClearAndTypeInTextBox(resumo);
            //txtDescricao.ClearAndTypeInTextBox(descricao);
            //txtPassos.ClearAndTypeInTextBox(passos);

            //txtAdicionais.ClearAndTypeInTextBox(informacoesAdicionais);

            //if (privado)
            //{
            //    ckVisibilidadePrivado.RadioButtonSelect();
            //}

            ////txtEnviarArquivos.SendKeys(@"C:\Users\ramon\source\repos\AutomacaoMantisBT-Ramon\AutomacaoMantisBT.Testes\bin\Debug\TestResult\2018-10-05\ReportTest - sexta-feira, 5 de outubro de 2018.html");



            return new UpdateBugStepsPage(Instance);
        }



        public UpdateBugStepsPage ClickSaveUpdate()
        {
            //btnSave.ClickButton();

            return new UpdateBugStepsPage(Instance);
        }
    }
}
