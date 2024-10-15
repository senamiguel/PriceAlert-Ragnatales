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

                IWebDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://web.whatsapp.com");
                Thread.Sleep(5000);
                qrCode(driver);
                if (qrcodescan)
                {
                    SystemSounds.Exclamation.Play();
                }
                driver.Navigate().GoToUrl("https://ragnatales.com.br/market");
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
