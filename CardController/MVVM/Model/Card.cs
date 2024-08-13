using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardController.MVVM.Model
{
    partial class Card : INotifyPropertyChanged
    {
		private ObservableCollection<Channel> channelList;
		public ObservableCollection<Channel> ChannelList
		{
			get
			{
				return channelList;
			}
			set
			{
				if (channelList != value)
                {
                    channelList = value;
					OnPropertyChanged(nameof(ChannelList));
                }
			}
		}

		private bool isOpenC;
		public bool IsOpenC
		{
			get
			{
				return isOpenC;
			}
			set
			{
				if ( isOpenC != value )
				{
                    isOpenC = value;
					OnPropertyChanged(nameof(IsOpenC));
                }
			}
		}

		private double cardVoltage;
		public double CardVoltage
		{
			get
			{
				return cardVoltage;
			}
			set
			{
				if ( cardVoltage != value )
				{
                    cardVoltage = value;
					OnPropertyChanged(nameof(CardVoltage));
                }
			}
		}

		private double cardTemp;
		public double CardTemp
		{
			get
			{
				return cardTemp;
			}
			set
			{
				if ( cardTemp != value )
                {
                    cardTemp = value;
					OnPropertyChanged(nameof(CardTemp));
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
