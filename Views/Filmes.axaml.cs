using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Avalonia.Controls;
using Avalonia.Interactivity;
using TMDbLib.Client;

namespace Aniflix;

public partial class Filmes : Window
{
    DateTime dataLancamento;
    public Filmes()
    {
        InitializeComponent();
    }

    private static string FormatString(string input)
    {
        return "#" + input.Replace(" ", string.Empty);
    }

    public void OnlyNumbers(object? sender, TextChangedEventArgs e)
    {
        if (Regex.IsMatch(txID.Text, "[^0-9]"))
        {
            txID.Text = "";
        }

    }

    public void OnLostFocus(object? sender, RoutedEventArgs e)
    {
        var client = new TMDbClient("1dcbf681735d3e7454953f5b7c22b6dc")
        {
            DefaultLanguage = "pt-BR",
            DefaultCountry = "BR"
        };


        var movie = client.GetMovieAsync(txID.Text).Result;
        txTitulo.Text = movie.Title;
        txSinopse.Text = movie.Overview;
        txTituloOriginal.Text = movie.OriginalTitle;
        txDataLancamento.Text = movie.ReleaseDate?.ToString("dd/MM/yyyy");
        txFranquia.Text = FormatString(txTitulo.Text);
        txGenero.Text = movie.Genres[0].Name;

        if (DateTime.TryParseExact(txDataLancamento.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataLancamento))
        {
            string ano = dataLancamento.Year.ToString();
            txTags.Text = "#Filme #Filme" + ano;
        }
    }
}