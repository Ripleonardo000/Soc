using soc;
using System.Collections.Generic;
using System.ComponentModel;

namespace TuProyecto.ViewModels
{
    public class LigasViewModel : INotifyPropertyChanged
    {
        private List<Liga> _ligas;  // Lista privada que contiene las ligas
        public List<Liga> Ligas
        {
            get => _ligas;
            set
            {
                _ligas = value;
                OnPropertyChanged(nameof(Ligas));  // Notificar que la lista de ligas ha cambiado
            }
        }

        public LigasViewModel()
        {
            // Aqu� estamos simulando la obtenci�n de ligas
            // En una aplicaci�n real, esto podr�a ser desde una API o base de datos
            Ligas = new List<Liga>
            {
                new Liga
                {
                    LigaId = 1,
                    Nombre = "Serie A",
                    Descripcion = "La Serie A es la liga de f�tbol profesional de Italia.",
                    Clubes = new List<Club>

                     {
                        new Club { ClubId = 1, Nombre = "Juventus", Ciudad = "Tur�n" },
                        new Club { ClubId = 2, Nombre = "AC Milan", Ciudad = "Mil�n" }
                    }
                },
                new Liga
                {
                    LigaId = 2,
                    Nombre = "Premier League",
                    Descripcion = "La Premier League es la liga de f�tbol profesional de Inglaterra.",
                    Clubes = new List<Club>
                    {
                        new Club { ClubId = 3, Nombre = "Manchester United", Ciudad = "Manchester" },
                        new Club { ClubId = 4, Nombre = "Liverpool", Ciudad = "Liverpool" }
                    }
                }
            };
        }


        // Evento necesario para que la vista se actualice cuando cambie una propiedad
        public event PropertyChangedEventHandler PropertyChanged;

        // M�todo para notificar los cambios de las propiedades a la vista
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
