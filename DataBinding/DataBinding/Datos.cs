using System;
using System.Collections.Generic;
using System.Text;

namespace DataBinding
{
    using System.Collections.ObjectModel;
    class Datos:Notificable
    {
        private ObservableCollection<Persona> personas;

        #region Propiedades

        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set
            {
                if (personas == value)
                {
                    return;
                }
                personas = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Constrcutores
        public Datos()
        {
            Personas = new ObservableCollection<Persona>();
            for (int i = 0; i < 6; i++)
            {
                Personas.Add(new Persona()
                {
                    Nombre = $"Persona {i}",
                    Pais = $"Pais {i}"
                });
            }
        }
        #endregion

    }
}
