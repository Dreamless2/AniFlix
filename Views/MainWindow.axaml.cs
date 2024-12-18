using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Aniflix.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // function OpenMovies
        public static void OpenMovies(object sender, RoutedEventArgs e)
        {
            var window = new Filmes();
            window.Show();
        }
    }
}