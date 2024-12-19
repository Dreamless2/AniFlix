using System.Text.RegularExpressions;
using Avalonia.Controls;

namespace Aniflix.Readers
{
    internal class EnvReader
    {
        [GeneratedRegex("[^0-9]")]
        private static partial Regex IsNotDigitRegex();

        public void OnlyNumbers(object? sender, TextChangedEventArgs e)
        {
            if (IsNotDigitRegex().IsMatch(txID.Text))
            {
                txID.Text = "";
            }
        }
    }
}
