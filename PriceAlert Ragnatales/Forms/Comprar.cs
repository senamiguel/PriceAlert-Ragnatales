using PriceAlert_Ragnatales.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PriceAlert_Ragnatales
{
    public partial class Comprar : Form
    {
        ConexaoApi conexao = new ConexaoApi();
        public Comprar()
        {
            InitializeComponent();
            conexao.Consumir(cmbItens);

            cmbItens.SelectedIndexChanged += cmbItens_SelectedIndexChanged;
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeItem = cmbItens.Text;
                int valorAlvo = int.Parse(txtPreco.Text);

                IWebDriver driver = new ChromeDriver();

                Pesquisa pesquisa = new Pesquisa(driver, "Comprar", cmbItens, txtPreco);

                pesquisa.Monitorar();


                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexao.MudarImg(cmbItens, pctrItem);
        }
    }
}
