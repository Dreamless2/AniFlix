using Avalonia.Controls;
using Avalonia.Interactivity;
using dotenv.net;
using TMDbLib.Client;

namespace Aniflix;

public partial class Filmes : Window
{
    public Filmes()
    {
        InitializeComponent();
    }

    public void OnTextChanged(object? sender, RoutedEventArgs e)
    {
        DotEnv.Load(options: new DotEnvOptions(ignoreExceptions: false));
        var apikey = DotEnv.Read();
        var key = apikey["TMDB_KEY"];
        var client = new TMDbClient(key);
        var movie = client.GetMovieAsync(txID.Text).Result;
        txTitulo.Text = movie.OriginalTitle;
    }
}