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
            conexao.Consumir(cmbItensC);

            cmbItensC.SelectedIndexChanged += cmbItensC_SelectedIndexChanged;
        }
        private void btnIniciarC_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeItem = cmbItensC.Text;
                int valorAlvo = int.Parse(txtPrecoC.Text);

                IWebDriver driver = new ChromeDriver();

                Pesquisa pesquisa = new Pesquisa(driver, "Comprar", cmbItensC, txtPrecoC);

                pesquisa.Monitorar();


                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void cmbItensC_SelectedIndexChanged(object sender, EventArgs e)
        {
            await conexao.MudarImg(cmbItensC, pctrItemC);
        }
    }
}
