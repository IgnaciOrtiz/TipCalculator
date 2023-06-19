using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace TipCalculator.Model
{
    public class TipModel : INotifyPropertyChanged
    {
        private decimal _totalPorPersona;
        private decimal _propinaPorPersona;
        private decimal _totalConPropina;
        private decimal _totalPropina;

        

        public TipModel()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
        public decimal Total { get; set; }
        public int Propina { get; set; }
        public int NoPersonas { get; set; }


        public decimal TotalPropina
        {
            get { return _totalPropina; }
            set
            {
                _totalPropina = value;
                OnPropertyChanged();
            }
        }

        public decimal TotalConPropina
        {
            get { return _totalConPropina; }
            set
            {
                _totalConPropina = value;
                OnPropertyChanged();
            }

        }

        public decimal PropinaPorPersona
        {
            get { return _propinaPorPersona; }
            set
            {
                _propinaPorPersona = value;
                OnPropertyChanged();
            }

        }

        public decimal TotalPorPersona
        {
            get { return _totalPorPersona; }
            set
            {
                _totalPorPersona = value;
                OnPropertyChanged();
            }
        }

    }
}
