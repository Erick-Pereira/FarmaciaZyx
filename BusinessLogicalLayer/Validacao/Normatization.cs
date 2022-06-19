using System.Globalization;
using System.Text.RegularExpressions;

namespace BusinessLogicalLayer
{
    public class Normatization
    {
        /// <summary>
        /// Normatiza o nome
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>Retorna uma string com o nome nomatizado</returns>
        public string NormatizeName(string nome)
        {
            string nomeNormatizado = new CultureInfo("pt-br").TextInfo.ToTitleCase(nome);
            //Trim -> Remove espaços em branco do começo e do fim da string (mas não do meio)
            nomeNormatizado = nomeNormatizado.Trim();
            //Função que remove os espaços extra entre as strings (deixando apenas um)
            return Regex.Replace(nome, @"\s+", " ");
        }
    }
}
