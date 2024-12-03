using System.Collections.Generic;
using Microsoft.Maui.Controls;
using soc.Services; // Aseg�rate de que este espacio de nombres est� incluido

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
