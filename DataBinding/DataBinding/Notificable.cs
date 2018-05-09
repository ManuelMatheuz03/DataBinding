using System;
using System.Collections.Generic;
using System.Text;

namespace DataBinding
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    class Notificable: INotifyPropertyChanged
    {

        #region Implementacion
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] String propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
