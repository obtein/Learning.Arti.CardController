using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardController.MVVM.Model;

namespace CardController.MVVM.ViewModel
{
    partial class Controller : INotifyPropertyChanged
    {
        #region UIDATA
        private ObservableCollection<Card> cardListMain;
		public ObservableCollection<Card> CardListMain
		{
			get
			{
				return cardListMain;
			}
			set
			{
				if ( cardListMain != value )
				{
                    cardListMain = value;
					OnPropertyChanged(nameof(CardListMain));
                }
			}
		}

		private ObservableCollection<Channel> channelList1;
		public ObservableCollection<Channel> ChannelList1
		{
			get
			{
				return channelList1;
			}
			set
			{
				if (channelList1 != value)
                {
                    channelList1 = value;
					OnPropertyChanged(nameof(ChannelList1));
                }
			}
		}

        private ObservableCollection<Channel> channelList2;
        public ObservableCollection<Channel> ChannelList2
        {
            get
            {
                return channelList2;
            }
            set
            {
                if ( channelList2 != value )
                {
                    channelList2 = value;
                    OnPropertyChanged( nameof( ChannelList2 ) );
                }
            }
        }

        private ObservableCollection<Channel> channelList3;
        public ObservableCollection<Channel> ChannelList3
        {
            get
            {
                return channelList3;
            }
            set
            {
                if ( channelList3 != value )
                {
                    channelList3 = value;
                    OnPropertyChanged( nameof( ChannelList3 ) );
                }
            }
        }
        #endregion

        public Communication SerialCom { get; set; }

        public Controller ()
        {

            InitProperties();
            InitUI();
        }

        private void InitProperties ()
        {
            CardListMain = new ObservableCollection<Card>();

            ChannelList1 = new ObservableCollection<Channel>();
            CardListMain.Add( new Card() );
            CardListMain [0].ChannelList = ChannelList1;

            ChannelList2 = new ObservableCollection<Channel>();
            CardListMain.Add( new Card() );
            CardListMain [1].ChannelList = ChannelList2;

            ChannelList3 = new ObservableCollection<Channel>();
            CardListMain.Add( new Card() );
            CardListMain [2].ChannelList = ChannelList3;

        }

        private void InitUI ()
        {
        }

        public event PropertyChangedEventHandler? PropertyChanged; 
		private void OnPropertyChanged ( string propertyName )
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }
    }
}
