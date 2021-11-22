namespace System
{
    public static partial class DateTimeExtensions
    {
        public static DateTime RemoveSeconds(this DateTime dateTime) => dateTime.AddSeconds(-dateTime.Second);
    }
}