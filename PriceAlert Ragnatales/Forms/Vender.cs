using PriceAlert_Ragnatales.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.Toolkit.Uwp.Notifications;

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
            conexao.MudarImg(cmbItens, pctrItem);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                new ToastContentBuilder()
                .AddText("Começando a procurar")
                .AddText("Apenas espere!")
                .Show();
                string nomeItem = cmbItens.Text;
                int valorAlvo = int.Parse(txtPreco.Text);

                IWebDriver driver = new ChromeDriver();

                Pesquisa pesquisa = new Pesquisa(driver, "Vender", cmbItens, txtPreco);

                pesquisa.Monitorar();

                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
