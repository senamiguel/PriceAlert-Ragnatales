﻿
using Microsoft.Toolkit.Uwp.Notifications;
using OpenQA.Selenium;

namespace PriceAlert_Ragnatales.Services
{
    internal class Pesquisa
    {
        private IWebDriver _driver;
        private string _nomeFormulario;
        private ComboBox _cmbItens;
        private TextBox _txtPreco;

        public Pesquisa(IWebDriver driver, string nomeFormulario, ComboBox cmbItens, TextBox txtPreco)
        {
            _driver = driver;
            _nomeFormulario = nomeFormulario;
            _cmbItens = cmbItens;
            _txtPreco = txtPreco;
        }
        internal void Monitorar()
        {
            string nomeItem = _cmbItens.Text;
            int valorAlvo = int.Parse(_txtPreco.Text);

            string xpathSearchBox = _nomeFormulario == "Vender" ?
                "//*[@id='app']/div/div/div[2]/div/div[3]/label/div/div[1]/input" :
                "//*[@id='app']/div/div/div[2]/div/div[3]/div[1]/label/div/div[1]/input";

            string xpathTableRow = _nomeFormulario == "Vender" ?
                "//*[@id='app']/div/div/div[2]/div/div[4]/div/div/div/div/div/table/tbody/tr" :
                "//*[@id='app']/div/div/div[2]/div/div[3]/div[2]/div/div/div/div/div/table/tbody/tr[1]";

            string site = _nomeFormulario == "Vender" ?
                "https://ragnatales.com.br/market" :
                "https://ragnatales.com.br/buymarket";

            List<int> Itens = new List<int>();
            _driver.Navigate().GoToUrl(site);
            Thread.Sleep(3000);
            while (true)
            {
                int count = 1;
                _driver.FindElement(By.XPath(xpathSearchBox)).SendKeys(nomeItem);
                Thread.Sleep(1000);
                _driver.FindElement(By.XPath(xpathSearchBox)).SendKeys(OpenQA.Selenium.Keys.Enter);
                Thread.Sleep(4000);

                while (true)
                {
                    try
                    {
                        var itemL = _driver.FindElement(By.XPath($"{xpathTableRow}[{count}]/td[3]/div/span"));

                        if (string.IsNullOrEmpty(itemL.Text))
                        {
                            if (Itens.Count > 0)
                            {
                                Itens.RemoveAt(Itens.Count - 1);
                            }
                            break;
                        }
                        else
                        {
                            string itemText = itemL.Text.Replace(".", "");
                            Itens.Add(int.Parse(itemText));
                        }

                        count++;
                    }
                    catch (NoSuchElementException)
                    {
                        break;
                    }
                }
                Itens.Sort();

                if (Itens.Count > 0 &&
                    ((_nomeFormulario == "Vender" && Itens[0] <= valorAlvo) ||
                        (_nomeFormulario != "Vender" && Itens[Itens.Count - 1 ] >= valorAlvo)))
                {
                    if(_nomeFormulario == "Vender")
                    {
                        new ToastContentBuilder()
                            .AddHeader("itemNotification", "Item Encontrado", "0001")
                            .AddText("🎉 Item Encontrado!")
                            .AddText($"🔍 Nome do item: {nomeItem}")
                            .AddText($"💰 Melhor preço: {Itens[0]}")
                            .AddAttributionText("Ragnatales Price Alert")
                            .Show();
                        if (MessageBox.Show($"Item Encontrado!\nNome do item: {nomeItem}\nMelhor preço: {Itens[0]}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            _driver.Quit();
                        }
                        
                        break;
                    }
                    new ToastContentBuilder()
                        .AddHeader("itemNotification", "Item Encontrado", "0001")
                        .AddText("🎉 Item Encontrado!")
                        .AddText($"🔍 Nome do item: {nomeItem}")
                        .AddText($"💰 Melhor preço: {Itens[Itens.Count - 1]}") 
                        .AddAttributionText("Ragnatales Price Alert") 
                        .Show();
                    if (MessageBox.Show($"Item Encontrado!\nNome do item: {nomeItem}\nMelhor preço: {Itens[0]}", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        _driver.Quit();
                    }
                    break;
                }
                else
                {
                    Thread.Sleep(300000); // Tentar novamente em 5 min
                    Itens.Clear();
                    _driver.FindElement(By.XPath(xpathSearchBox)).Clear();
                    _driver.Navigate().Refresh();
                }
                
            }
        }
    }
}
