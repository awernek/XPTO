using System;
using System.Windows.Forms;

namespace XPTO.UI
{
    public partial class DesafioUI : Form
    {
        public DesafioUI()
        {
            InitializeComponent();
        }

        private void btnGerarDigitoVerificador_Click(object sender, EventArgs e)
        {
            Calculador calculador = new Calculador();

            string caminho = @"C:\";
            string nomeArquivoSemDV = "matriculasSemDV.txt";
            string nomeArquivoComDV = "matriculasComDV.txt";

            try
            {
                calculador.GerarDigitoVerificador(caminho, nomeArquivoSemDV, nomeArquivoComDV);

                MessageBox.Show("Atividade realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerificarMatriculas_Click(object sender, EventArgs e)
        {
            Verificador verificador = new Verificador();
            string caminho = @"C:\";
            string nomeArquivo = "matriculasParaVerificar.txt";

            try
            {
                verificador.VerificarMatriculas(caminho, nomeArquivo);

                MessageBox.Show("Atividade realizada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
