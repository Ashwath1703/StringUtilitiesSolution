namespace StringUtilities
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns true if the string starts with an upper-case letter.
        /// </summary>
        public static bool StartsWithUpperCase(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            return char.IsUpper(value[0]);
        }
    }
}