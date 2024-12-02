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
            // Aquí estamos simulando la obtención de ligas
            // En una aplicación real, esto podría ser desde una API o base de datos
            Ligas = new List<Liga>
            {
                new Liga
                {
                    LigaId = 1,
                    Nombre = "Serie A",
                    Descripcion = "La Serie A es la liga de fútbol profesional de Italia.",
                    Clubes = new List<Club>

                     {
                        new Club { ClubId = 1, Nombre = "Juventus", Ciudad = "Turín" },
                        new Club { ClubId = 2, Nombre = "AC Milan", Ciudad = "Milán" }
                    }
                },
                new Liga
                {
                    LigaId = 2,
                    Nombre = "Premier League",
                    Descripcion = "La Premier League es la liga de fútbol profesional de Inglaterra.",
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

        // Método para notificar los cambios de las propiedades a la vista
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
