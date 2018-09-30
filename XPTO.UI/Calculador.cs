using System;
using System.Collections.Generic;
using System.Linq;

namespace XPTO.UI
{
    public class Calculador
    {
        public void GerarDigitoVerificador(string caminho, string nomeArquivoSemDV, string nomeArquivoComDV)
        {
            List<string> MatriculasComDV = new List<string>();
            
            string[] multiplicadores = { "5", "4", "3", "2" };
            string[] exadecimal = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
            string matriculaSemDV = string.Empty;
            string matriculaComDV = string.Empty;

            try
            {
                string[] matriculasSemDv = ManipuladorArquivo.LerArquivo(caminho + nomeArquivoSemDV);

                for (int i = 0; i < matriculasSemDv.Length; i++)
                {
                    int total = 0;
                    int resto = 0;
                    int resultado = 0;

                    matriculaSemDV = matriculasSemDv[i];

                    for (int j = 0; j < matriculaSemDV.Count(); j++)
                    {
                        int multiplicador = Convert.ToInt32(multiplicadores[j].ToString());

                        resultado = Calcular(Convert.ToInt32(matriculaSemDV[j].ToString()), multiplicador);

                        total += resultado;
                    }

                    resto = total % 16;

                    matriculaComDV = matriculaSemDV + "-" + exadecimal[resto];

                    MatriculasComDV.Add(matriculaComDV);

                    ManipuladorArquivo.GravarArquivo(caminho, nomeArquivoComDV, MatriculasComDV.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método: GerarDigitoVerificador \n" + ex.Message);
            }
        }

        public int Calcular(int valor, int multiplicador)
        {
            return valor * multiplicador;
        }
    }
}
