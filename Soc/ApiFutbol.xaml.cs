using System;
using System.Collections.Generic;
using Microsoft.Maui.Controls;
using soc.Services;

namespace soc
{
    public partial class ApiFutbol : ContentPage
    {
        private FootballDataService _service;

        public ApiFutbol()
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
                var partidos = await _service.ObtenerProximosPartidosAsync(liga.Id);
                await Navigation.PushAsync(new ProximosPartidosPage(partidos));
            }
        }
    }
}
