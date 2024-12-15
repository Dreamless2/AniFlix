using Avalonia.Controls;
using Avalonia.Interactivity;
using TMDbLib.Client;

namespace Aniflix;

public partial class Filmes : Window
{
    public Filmes()
    {
        InitializeComponent();
    }

    public static void ID_Change(object sender, RoutedEventArgs e)
    {
        var api = ConfigurationManager.AppSettings["api"];
        var client = new TMDbClient(ConfigurationManager)
        filmes.Show();
    }
}