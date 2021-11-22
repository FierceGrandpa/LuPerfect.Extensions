namespace System
{
    public static partial class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime birthdate)
        {
            var today = DateTime.Today;

            var age = today.Year - birthdate.Year;

            if (birthdate.Date > today.AddYears(-age)) 
                age--;

            return age;
        }
    }
}