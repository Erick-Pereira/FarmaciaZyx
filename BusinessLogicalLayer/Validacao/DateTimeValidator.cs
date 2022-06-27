namespace BusinessLogicalLayer
{
    public class DateTimeValidator
    {
        public int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
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