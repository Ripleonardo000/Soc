using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using soc.Services;

namespace soc
{
    public partial class GoleadoresPage : ContentPage
    {
        private readonly FootballDataService _footballDataService;
        private List<LigaDto> _ligas;

        public GoleadoresPage()
        {
            InitializeComponent();
            _footballDataService = new FootballDataService();
            CargarLigas();
        }

        private async void CargarLigas()
        {
            _ligas = await _footballDataService.ObtenerLigasAsync();
            LigasPicker.ItemsSource = _ligas;
        }

        private async void OnLigaSelected(object sender, EventArgs e)
        {
            var selectedLiga = LigasPicker.SelectedItem as LigaDto;
            if (selectedLiga != null)
            {
                // Aquí obtienes los goleadores de la liga seleccionada
                var goleadores = await _footballDataService.ObtenerGoleadoresAsync(selectedLiga.Id);
                GoleadoresListView.ItemsSource = goleadores;
            }
        }
    }
}
