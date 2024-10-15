using Newtonsoft.Json;
using PriceAlert_Ragnatales.Models;
using OpenQA.Selenium;
using Selenium = OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PriceAlert_Ragnatales
{
    public partial class Comprar : Form
    {
        public Comprar()
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
            string nomeItem = cmbItens.Text;
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ragnatales.com.br/buymarket");

        }

        private void cmbItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbItens.SelectedIndex >= 0)
            {
                var selectedItem = (Item)cmbItens.SelectedItem;
                try
                {
                    pctrItem.Load($"http://db.irowiki.org/image/item/{selectedItem.id}.png");
                }
                catch
                {
                    pctrItem.Load($"https://ih1.redbubble.net/image.4905811447.8675/flat,750x,075,f-pad,750x1000,f8f8f8.jpg");
                }
            }
        }
    }
}
