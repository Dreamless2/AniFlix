using System.Text;

namespace Aniflix.Extensions
{
    public static class GenderExtensions
    {
        public static string CleanNames()
        {
            string[] genres = { "ação", "mistério", "ficção científica", "thriller" };

            StringBuilder result = new();

            foreach (var genre in genres)
            {
                string normalizedGenre = StringExtensions.RemoveDiacritics(genre.ToLower());
                string originalGenre = genre.ToLower();

                result.Append($"#{originalGenre.Replace(" ", "")} ");

                if (originalGenre == "ação" || originalGenre == "mistério" || originalGenre == "ficção científica")
                {
                    result.Append($"#{normalizedGenre.Replace(" ", "")} ");
                }
            }
            return result.ToString().TrimEnd();
        }
    }
}