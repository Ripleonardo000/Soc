using Microsoft.Maui.Controls;
using soc.Services;
using System;

namespace soc
{
    public partial class TablaPosiciones : ContentPage
    {
        private readonly FootballDataService _service;

        public TablaPosiciones()
        {
            InitializeComponent();
            _service = new FootballDataService();
            CargarLigas();
        }

        private async void CargarLigas()
        {
            var ligas = await _service.ObtenerLigasAsync();
            LigasListView.ItemsSource = ligas;
        }

        private async void OnLigaSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is LigaDto liga)
            {
                await Navigation.PushAsync(new PosicionesPage(liga.Id));
            }
        }
    }
}
