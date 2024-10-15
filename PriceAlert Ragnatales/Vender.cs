using Newtonsoft.Json;
using OpenQA.Selenium;
using PriceAlert_Ragnatales.Models;
using Selenium = OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Media;

namespace PriceAlert_Ragnatales
{
    public partial class Vender : Form
    {
        bool qrcodescan = false;
        public Vender()
        {
            InitializeComponent();
            Consumir();
        }

        private async void Consumir()
        {
            var items = await LoadItemsFromApi("https://raw.githubusercontent.com/joeltonguerreiro/ragnatales-items/refs/heads/main/json/data.json");
            cmbItens.DataSource = items;
            cmbItens.DisplayMember = "jname";
        }

        private async Task<List<Item>> LoadItemsFromApi(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var json = await client.GetStringAsync(url);
                var items = JsonConvert.DeserializeObject<List<Item>>(json);
                return items;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeItem = cmbItens.Text;
                int valorAlvo = int.Parse(txtPreco.Text);
                string contato = txtZap.Text;

                string xpathSearchBox = "//*[@id=\"app\"]/div/div/div[2]/div/div[3]/label/div/div[1]/input";
                string xpathTableRow = "//*[@id='app']/div/div/div[2]/div/div[4]/div/div/div/div/div/table/tbody/tr";
                string xpathWhatsAppSearch = "//*[@id='side']/div[1]/div/div/div[2]/div/div[1]/p";
                string xpathMessageBox = "//*[@id='main']/footer/div[1]/div/span/div/div[2]/div[1]/div[2]/div[1]";

                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://web.whatsapp.com");
                Thread.Sleep(5000);
                qrCode(driver);
                Thread.Sleep(5000);
                if (qrcodescan)
                {
                    SystemSounds.Exclamation.Play();
                }

                driver.Navigate().GoToUrl("https://ragnatales.com.br/market");
                Thread.Sleep(3000);
                List<int> Itens = new List<int>();
                while (true)
                {
                    
                    driver.FindElement(By.XPath(xpathSearchBox)).SendKeys(nomeItem);
                    Thread.Sleep(1000);
                    driver.FindElement(By.XPath(xpathSearchBox)).SendKeys(Selenium.Keys.Enter);
                    Thread.Sleep(4000);

                    int count = 1;
                    while (true)
                    {
                        try
                        {
                            var itemL = driver.FindElement(By.XPath($"{xpathTableRow}[{count}]/td[3]/div/span"));

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
                    if (Itens.Count > 0 && Itens[0] <= valorAlvo)
                    {
                        break;
                    }
                    else
                    {
                        Thread.Sleep(300000);
                        Itens.Clear();
                        driver.FindElement(By.XPath(xpathSearchBox)).Clear();
                    }
                }

                Thread.Sleep(3000);
                driver.Navigate().GoToUrl("https://web.whatsapp.com");
                Thread.Sleep(8000);

                // Usando variáveis XPath para WhatsApp
                driver.FindElement(By.XPath(xpathWhatsAppSearch)).SendKeys(contato);
                driver.FindElement(By.XPath(xpathWhatsAppSearch)).SendKeys(Selenium.Keys.Enter);
                driver.FindElement(By.XPath(xpathMessageBox)).SendKeys($"Isso é apenas um teste automatizado. Preço Item:  {Itens[0]} Zenys. Preço Alvo: {valorAlvo}");
                driver.FindElement(By.XPath(xpathMessageBox)).SendKeys(Selenium.Keys.Enter);

                MessageBox.Show("Tarefa finalizada com sucesso");
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void qrCode(IWebDriver driver)
        {
            try
            {
                while (!qrcodescan)
                {
                    var qrElement = driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div[2]/div[3]/div[1]/div/div/div[2]/div"));
                    if (qrElement == null)
                    {
                        qrcodescan = true;
                    }
                }
            }
            catch (NoSuchElementException)
            {
                qrcodescan = true;
            }
        }
    }
}
