using System.Diagnostics;

namespace PriceAlert_Ragnatales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/senamiguel",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void btnDisc_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://discord.gg/pfaetdJP",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Vender formVenda = new Vender();
            formVenda.Show();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Comprar formCompra = new Comprar();
            formCompra.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://prnt.sc/f8lCrSdEAxCj",
                UseShellExecute = true
            };
            Process.Start(psInfo);  
        }
    }
}
