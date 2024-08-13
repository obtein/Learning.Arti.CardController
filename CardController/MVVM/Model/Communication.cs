using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardController.MVVM.Model
{
    class Communication : INotifyPropertyChanged
    {
        SerialPort serialPort;

        private ObservableCollection<Card> cardList;
        public ObservableCollection<Card> CardList
        {
            get
            {
                return cardList;
            }
            set
            {
                if(cardList != value)
                {
                    cardList = value;
                    OnPropertyChanged(nameof(CardList));
                }
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged ( string propertyName )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }
    }
}
