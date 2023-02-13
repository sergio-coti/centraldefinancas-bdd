using CentralDeFinancas.BDD.Helpers;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace CentralDeFinancas.BDD.TestSteps
{
    [Binding]
    public class AutenticarUsuarioTestSteps
    {
        private WebDriver? _driver;

        [Given(@"Acessar a página de autenticação de usuários")]
        public void GivenAcessarAPaginaDeAutenticacaoDeUsuarios()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();

            _driver.Navigate().GoToUrl(TestHelper.BASE_URL + "Account/Login");
        }

        [Given(@"Informar o email de acesso ""([^""]*)""")]
        public void GivenInformarOEmailDeAcesso(string email)
        {
            var element = _driver.FindElement(By.XPath("//*[@id=\"Email\"]"));
            element.SendKeys(email);
        }

        [Given(@"Informar a senha de acesso ""([^""]*)""")]
        public void GivenInformarASenhaDeAcesso(string senha)
        {
            var element = _driver.FindElement(By.XPath("//*[@id=\"Senha\"]"));
            element.SendKeys(senha);
        }

        [When(@"Solicitar a realização do acesso")]
        public void WhenSolicitarARealizacaoDoAcesso()
        {
            var element = _driver.FindElement(By.XPath("/html/body/div/div/div/div/form/div[3]/input"));
            element.Click();
        }

        [Then(@"Sistema autentica o usuário e exibe a página dashboard")]
        public void ThenSistemaAutenticaOUsuarioEExibeAPaginaDashboard()
        {
            _driver.Url
                .Should()
                .Be(TestHelper.BASE_URL + "Dashboard/Index");

            TestHelper.CreateScreenshot(_driver, "AutenticarUsuarioComSucesso");

            _driver.Close();
        }

        [Then(@"Sistema informa que o acesso é negado")]
        public void ThenSistemaInformaQueOAcessoENegado()
        {
            var element = _driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/strong"));
            element.Text
                .Should()
                .Be("Acesso negado. Usuário não encontrado.");

            TestHelper.CreateScreenshot(_driver, "AcessoNegado");

            _driver.Close();
        }

    }
}
