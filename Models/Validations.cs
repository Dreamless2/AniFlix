using System.Text.RegularExpressions;

namespace Aniflix.Models
{
    public static partial class Validations
    {
        [RegexGenerator(@"\d+", RegexOptions.Compiled, 50)]
        private static partial Regex IsDigitsOnly();

        public static bool IsDigit(string input)
        {
            return IsDigitsOnly().IsMatch(input);
        }


    }
}
