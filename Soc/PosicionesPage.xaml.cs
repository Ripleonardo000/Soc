using Microsoft.Maui.Controls;
using soc.Services;
using System.Collections.Generic;

namespace soc
{
    public partial class PosicionesPage : ContentPage
    {
        private readonly FootballDataService _service;
        private readonly string _idLiga;

        public PosicionesPage(string idLiga)
        {
            InitializeComponent();
            _service = new FootballDataService();
            _idLiga = idLiga;
            CargarPosiciones();
        }

        private async void CargarPosiciones()
        {
            var posiciones = await _service.ObtenerTablaPosicionesAsync(_idLiga);
            PosicionesListView.ItemsSource = posiciones;
        }
    }
}
