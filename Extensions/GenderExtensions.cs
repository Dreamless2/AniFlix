using System.Text;

namespace Aniflix.Extensions
{
    public static class GenderExtensions
    {
        public static void CleanNames()
        {
            string[] genres = { "ação", "mistério", "ficção científica", "thriller" };

            StringBuilder result = new StringBuilder();

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