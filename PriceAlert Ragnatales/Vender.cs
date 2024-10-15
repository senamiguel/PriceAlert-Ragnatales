using PriceAlert_Ragnatales.Services;
using OpenQA.Selenium;
using PriceAlert_Ragnatales.Models;
using Selenium = OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Media;

namespace PriceAlert_Ragnatales
{
    public partial class Vender : Form
    {
        ConexaoApi conexao = new ConexaoApi();
        public Vender()
        {
            InitializeComponent();
            conexao.Consumir(cmbItens);
            
            cmbItens.SelectedIndexChanged += cmbItens_SelectedIndexChanged;
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



        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeItem = cmbItens.Text;
                int valorAlvo = int.Parse(txtPreco.Text);
                IWebDriver driver = new ChromeDriver();
                Pesquisa pesquisa = new Pesquisa(driver, "Vender" , cmbItens, txtPreco);
                pesquisa.AbrirSite();
                Thread.Sleep(8000);
                MessageBox.Show("Tarefa finalizada com sucesso");
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
