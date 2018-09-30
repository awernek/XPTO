using System.IO;

namespace XPTO.UI
{
    public static class ManipuladorArquivo
    {
        public static string[] LerArquivo(string caminho)
        {
            return File.ReadAllLines(caminho);
        }

        public static void GravarArquivo(string caminho, string nomeArquivoComDV, string[] matriculas)
        {
            File.WriteAllLines(caminho + nomeArquivoComDV, matriculas);
        }
    }
}
