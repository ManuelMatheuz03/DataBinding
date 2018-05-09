﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataBinding
{
    using System.ComponentModel;
    class Persona:Notificable
    {
        #region Atributos
        private string nombre;
        private string pais;
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                if (nombre == value)
                {
                    return;
                }
                nombre = value;
                OnPropertyChanged();
            }

        }
        public string Pais
        {
            get
            {
                return pais;
            }

            set
            {
                if (pais == value)
                {
                    return;
                }
                pais = value;
                OnPropertyChanged();
            }

        }

        #endregion

        #region Implementacion
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
