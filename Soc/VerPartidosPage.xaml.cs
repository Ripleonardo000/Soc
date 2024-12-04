using System;
using Microsoft.Maui.Controls;

namespace soc
{
    public partial class VerPartidosPage : ContentPage
    {
        public VerPartidosPage()
        {
            InitializeComponent();
        }

        private async void OnFutbolLibreOPC1Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://librefutbol.su/");
        }

        private async void OnFutbolLibreOPC2Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://futbollibre.pe/");
        }

        private async void OnRojaDirectaClicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://www.rojadirectaenvivo.pl/");
        }

        private async void OnRojaDirectaOPC2Clicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://rojadirectatv.me.in/");
        }
    }
}
