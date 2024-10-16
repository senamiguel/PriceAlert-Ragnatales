using Newtonsoft.Json;
using PriceAlert_Ragnatales.Models;
using System.Net.Http;

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

        internal async Task MudarImg(ComboBox cmbItens, PictureBox pctrItem)
        {
            if (cmbItens.SelectedIndex >= 0)
            {
                var selectedItem = (Item)cmbItens.SelectedItem;
                try
                {
                    await Task.Run(() => pctrItem.LoadAsync($"http://db.irowiki.org/image/item/{selectedItem.id}.png"));
                }
                catch
                {
                    await Task.Run(() => pctrItem.LoadAsync($"https://static.vecteezy.com/system/resources/thumbnails/017/785/303/small/creative-wrong-icon-3d-render-png.png"));
                }
            }
        }

    }
}
