namespace BusinessLogicalLayer
{
    public class DateTimeValidator
    {
        /// <summary>
        /// Recebe data de nascimento e retorna a idade da pessoa
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <returns>Retorna a idade da pessoa</returns>
        public int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
        /// <summary>
        /// Recebe uma string com a data e verifica se ela foi informada
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Retorna vazio "" caso a data foi informada</returns>
        public string VerifyIfIsNull(string data)
        {
            data = data.Replace("/", " ");
            if (string.IsNullOrWhiteSpace(data))
            {
                return "Data deve ser informada";
            }
            return "";
        }
    }
}