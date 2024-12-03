using System.Collections.Generic;
using Microsoft.Maui.Controls;
using soc.Services; // Asegúrate de que este espacio de nombres esté incluido

namespace soc
{
    public partial class ProximosPartidosPage : ContentPage
    {
        public ProximosPartidosPage(List<Partido> partidos)
        {
            InitializeComponent();
            PartidosListView.ItemsSource = partidos;
        }
    }
}
