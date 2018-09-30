using System;
using System.Collections.Generic;

namespace XPTO.UI
{
    public class Verificador
    {
        public void VerificarMatriculas(string caminho, string nomeArquivo)
        {
            List<string> MatriculasVerificadas = new List<string>();
            string matricula = string.Empty;

            try
            {
                string[] matriculasParaVerificar = ManipuladorArquivo.LerArquivo(caminho + nomeArquivo);

                for (int i = 0; i < matriculasParaVerificar.Length; i++)
                {
                    string matriculaVerificada = string.Empty;
                    matricula = matriculasParaVerificar[i];
                    string digito = matricula.Substring(matricula.Length - 1);

                    string resultado = Verificar(digito);
                    matriculaVerificada = matricula + " " + resultado;

                    MatriculasVerificadas.Add(matriculaVerificada);
                }
                ManipuladorArquivo.GravarArquivo(caminho, "matriculasVerificadas.txt", MatriculasVerificadas.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro no método: VerificarMatriculas \n" + ex.Message);
            }
        }

        public string Verificar(string digito)
        {
            int resultado;

            if (int.TryParse(digito, out resultado))
                return "falso";
            else
                return "verdadeiro";
        }
    }
}
