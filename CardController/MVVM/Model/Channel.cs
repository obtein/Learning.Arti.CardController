using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardController.MVVM.Model
{
    partial class Channel:INotifyPropertyChanged
    {
		private int errorCode;
		public int ErrorCode
		{
			get
			{
				return errorCode;
			}
			set
			{
				if ( errorCode != value )
				{
                    errorCode = value;
					OnPropertyChanged(nameof(ErrorCode));
                }
			}
		}

		private double current;
		public double Current
		{
			get
			{
				return current;
			}
			set
			{
				if ( current != value )
				{
					current = value;
					OnPropertyChanged(nameof(Current));
				}
			}
		}

		private bool isOpen;
		public bool IsOpen
		{
			get
			{
				return isOpen;
			}
			set
			{
				if (isOpen != value )
				{
					isOpen = value;
					OnPropertyChanged(nameof(IsOpen));
				}
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged ( string propertyName )
        {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs( propertyName ) );
        }
    }
}
