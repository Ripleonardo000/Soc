
using Microsoft.Maui.Controls;
using TuProyecto.ViewModels;

namespace soc
{
    public partial class LigasView : ContentPage
    {
        public LigasView()
        {
            InitializeComponent();
            BindingContext = new LigasViewModel();  // Asumiendo que tienes un ViewModel
        }
    }
}
