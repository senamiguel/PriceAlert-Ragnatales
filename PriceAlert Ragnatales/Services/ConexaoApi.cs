using Newtonsoft.Json;
using PriceAlert_Ragnatales.Models;

namespace PriceAlert_Ragnatales.Services
{
    internal class ConexaoApi
    {

        private async Task<List<Item>> LoadItemsFromApi(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var json = await client.GetStringAsync(url);
                var items = JsonConvert.DeserializeObject<List<Item>>(json);
                return items;
            }
        }

        internal async void Consumir(ComboBox cmbItens)
        {
            var items = await LoadItemsFromApi("https://raw.githubusercontent.com/joeltonguerreiro/ragnatales-items/refs/heads/main/json/data.json");
            cmbItens.DataSource = items;
            cmbItens.DisplayMember = "jname";
        }
    }
}
