using System.IO.Ports;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CardController.Enums;
using CardController.MVVM.Model;

namespace CardController
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort serialPort;
        List<Card> cards = new List<Card>();

        List<Channel> channels1 = new List<Channel>();
        double [] c1Curr = new double[8];
        List<Channel> channels2 = new List<Channel>();
        double [] c2Curr = new double [8];
        List<Channel> channels3 = new List<Channel>();
        double [] c3Curr = new double [8];

        public MainWindow ()
        {
            serialPort = new SerialPort ("COM9",115200,Parity.None,8,StopBits.One);
            serialPort.Handshake = Handshake.None;
            serialPort.ReadTimeout = -1;
            serialPort.WriteTimeout = -1;
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.Open();
            InitProperties ();
            InitializeComponent();
        }

        private void SerialPort_DataReceived ( object sender, SerialDataReceivedEventArgs e )
        {
            int length = serialPort.BytesToRead;
            byte [] temp = new byte[length];
            for (int i = 0; i < length; i++ )
            {
                temp [i] = (byte)serialPort.ReadByte();
            }
            if ( temp [5] == (byte)0xC9 )
            {
                CommunicationPackages.CalculateChannelInspectionResponse(8,8,8);
            }
            else if ( temp [5] == (byte)0xCA )
            {
                //Analog Inspec
            }
            else if ( temp [5] == (byte)0xCB )
            {
                //Card Error Inspec
            }
            else if ( temp [5] == (byte)0xCC )
            {
                // War Mode
            }
            else if ( temp [5] == (byte)0xCD )
            {
                // Temp inspec
            }
            else if ( temp [5] == (byte)0xCE )
            {
                // Open Close Card1
            }
            else if ( temp [5] == (byte)0xCF )
            {
                // Open Close Card2
            }
            else if ( temp [5] == (byte)0xD0 )
            {
                // Open Close Card3
            }
            else if ( temp [5] == (byte)0xD4 )
            {
                // Open Channel CARD 1
            }
            else if ( temp [5] == (byte)0xD5 )
            {
                // Open Channel CARD 2
            }
            else if ( temp [5] == (byte)0xD6 )
            {
                // Open Channel CARD 3
            }
            else if ( temp [5] == (byte)0xD7 )
            {
                // Close Channel CARD 1
            }
            else if ( temp [5] == (byte)0xD8 )
            {
                // Close Channel CARD 2
            }
            else if ( temp [5] == (byte)0xD9 )
            {
                // Close Channel CARD 3
            }

        }
        //Enumerable.SequenceEqual( temp, CommunicationPackages.Card3OpenOrCloseInspection )
        private void InitProperties ()
        {

            // 3 Cards
            cards.Add( new Card() );
            cards [0].CardTemp = 0;
            cards [0].CardVoltage = 0;
            cards [0].IsOpenC = true;
            cards.Add( new Card() );
            cards [1].CardTemp = 0;
            cards [1].CardVoltage = 0;
            cards [1].IsOpenC = true;
            cards.Add( new Card() );
            cards [2].CardTemp = 0;
            cards [2].CardVoltage = 0;
            cards [2].IsOpenC = true;
            // 8 channels
            channels1.Add( new Channel() );
            channels1 [0].Current = 0;
            c1Curr [0] = 0;
            channels1 [0].ErrorCode = 0;
            channels1 [0].IsOpen = true;
            channels1.Add( new Channel() );
            channels1 [1].Current = 0;
            c1Curr [1] = 0;
            channels1 [1].ErrorCode = 0;
            channels1 [1].IsOpen = true;
            channels1.Add( new Channel() );
            channels1 [2].Current = 0;
            c1Curr [2] = 0;
            channels1 [2].ErrorCode = 0;
            channels1 [2].IsOpen = true;
            channels1.Add( new Channel() );
            channels1 [3].Current = 0;
            c1Curr [3] = 0;
            channels1 [3].ErrorCode = 0;
            channels1 [3].IsOpen = true;
            channels1.Add( new Channel() );
            channels1 [4].Current = 0;
            channels1 [4].ErrorCode = 0;
            channels1 [4].IsOpen = true;
            channels1.Add( new Channel() );
            channels1 [5].Current = 0;
            channels1 [5].ErrorCode = 0;
            channels1 [5].IsOpen = true;
            channels1.Add( new Channel() );
            channels1 [6].Current = 0;
            channels1 [6].ErrorCode = 0;
            channels1 [6].IsOpen = true;
            channels1.Add( new Channel() );
            channels1 [7].Current = 0;
            channels1 [7].ErrorCode = 0;
            channels1 [7].IsOpen = true;

            channels2.Add( new Channel() );
            channels2 [0].Current = 0;
            channels2 [0].ErrorCode = 0;
            channels2 [0].IsOpen = true;
            channels2.Add( new Channel() );
            channels2 [1].Current = 0;
            channels2 [1].ErrorCode = 0;
            channels2 [1].IsOpen = true;
            channels2.Add( new Channel() );
            channels2 [2].Current = 0;
            channels2 [2].ErrorCode = 0;
            channels2 [2].IsOpen = true;
            channels2.Add( new Channel() );
            channels2 [3].Current = 0;
            channels2 [3].ErrorCode = 0;
            channels2 [3].IsOpen = true;
            channels2.Add( new Channel() );
            channels2 [4].Current = 0;
            channels2 [4].ErrorCode = 0;
            channels2 [4].IsOpen = true;
            channels2.Add( new Channel() );
            channels2 [5].Current = 0;
            channels2 [5].ErrorCode = 0;
            channels2 [5].IsOpen = true;
            channels2.Add( new Channel() );
            channels2 [6].Current = 0;
            channels2 [6].ErrorCode = 0;
            channels2 [6].IsOpen = true;
            channels2.Add( new Channel() );
            channels2 [7].Current = 0;
            channels2 [7].ErrorCode = 0;
            channels2 [7].IsOpen = true;

            channels3.Add( new Channel() );
            channels3 [0].Current = 0;
            channels3 [0].ErrorCode = 0;
            channels3 [0].IsOpen = true;
            channels3.Add( new Channel() );
            channels3 [1].Current = 0;
            channels3 [1].ErrorCode = 0;
            channels3 [1].IsOpen = true;
            channels3.Add( new Channel() );
            channels3 [2].Current = 0;
            channels3 [2].ErrorCode = 0;
            channels3 [2].IsOpen = true;
            channels3.Add( new Channel() );
            channels3 [3].Current = 0;
            channels3 [3].ErrorCode = 0;
            channels3 [3].IsOpen = true;
            channels3.Add( new Channel() );
            channels3 [4].Current = 0;
            channels3 [4].ErrorCode = 0;
            channels3 [4].IsOpen = true;
            channels3.Add( new Channel() );
            channels3 [5].Current = 0;
            channels3 [5].ErrorCode = 0;
            channels3 [5].IsOpen = true;
            channels3.Add( new Channel() );
            channels3 [6].Current = 0;
            channels3 [6].ErrorCode = 0;
            channels3 [6].IsOpen = true;
            channels3.Add( new Channel() );
            channels3 [7].Current = 0;
            channels3 [7].ErrorCode = 0;
            channels3 [7].IsOpen = true;
        }

        #region Card1OpenCloseChannels
        private void Button_Click ( object sender, RoutedEventArgs e ) //Card1 Ch1 
        {
            if ( channels1 [0].IsOpen )
            {
                card1Ch1Status.Background = Brushes.DarkRed;
                channels1 [0].IsOpen = false;
            }
            else
            {
                card1Ch1Status.Background= Brushes.Green;
                channels1 [0].IsOpen = true;
            }
        }

        private void Button_Click_1 ( object sender, RoutedEventArgs e ) //Card1 Ch2
        {
            if ( channels1 [1].IsOpen )
            {
                card1Ch2Status.Background = Brushes.DarkRed;
                channels1 [1].IsOpen = false;
            }
            else
            {
                card1Ch2Status.Background = Brushes.Green;
                channels1 [1].IsOpen = true;
            }
        }

        private void Button_Click_2 ( object sender, RoutedEventArgs e ) //Card1 Ch3
        {
            if ( channels1 [2].IsOpen )
            {
                card1Ch3Status.Background = Brushes.DarkRed;
                channels1 [2].IsOpen = false;
            }
            else
            {
                card1Ch3Status.Background = Brushes.Green;
                channels1 [2].IsOpen = true;
            }
        }

        private void Button_Click_3 ( object sender, RoutedEventArgs e ) //Card1 Ch4
        {
            if ( channels1 [3].IsOpen )
            {
                card1Ch4Status.Background = Brushes.DarkRed;
                channels1 [3].IsOpen = false;
            }
            else
            {
                card1Ch4Status.Background = Brushes.Green;
                channels1 [3].IsOpen = true;
            }
        }

        private void Button_Click_4 ( object sender, RoutedEventArgs e ) //Card1 Ch5
        {
            if ( channels1 [4].IsOpen )
            {
                card1Ch5Status.Background = Brushes.DarkRed;
                channels1 [4].IsOpen = false;
            }
            else
            {
                card1Ch5Status.Background = Brushes.Green;
                channels1 [4].IsOpen = true;
            }
        }

        private void Button_Click_5 ( object sender, RoutedEventArgs e ) //Card1 Ch6
        {
            if ( channels1 [5].IsOpen )
            {
                card1Ch6Status.Background = Brushes.DarkRed;
                channels1 [5].IsOpen = false;
            }
            else
            {
                card1Ch6Status.Background = Brushes.Green;
                channels1 [5].IsOpen = true;
            }
        }

        private void Button_Click_6 ( object sender, RoutedEventArgs e ) //Card1 Ch7
        {
            if ( channels1 [6].IsOpen )
            {
                card1Ch7Status.Background = Brushes.DarkRed;
                channels1 [6].IsOpen = false;
            }
            else
            {
                card1Ch7Status.Background = Brushes.Green;
                channels1 [6].IsOpen = true;
            }
        }

        private void Button_Click_7 ( object sender, RoutedEventArgs e ) //Card1 Ch8
        {
            if ( channels1 [7].IsOpen )
            {
                card1Ch8Status.Background = Brushes.DarkRed;
                channels1 [7].IsOpen = false;
            }
            else
            {
                card1Ch8Status.Background = Brushes.Green;
                channels1 [7].IsOpen = true;
            }
        }

        #endregion

        #region Card2OpenCloseChannels
        private void Button_Click_8 ( object sender, RoutedEventArgs e ) //Card2 Ch1
        {
            if ( channels2 [0].IsOpen )
            {
                card2Ch1Status.Background = Brushes.DarkRed;
                channels2 [0].IsOpen = false;
            }
            else
            {
                card2Ch1Status.Background = Brushes.Green;
                channels2 [0].IsOpen = true;
            }
        }

        private void Button_Click_9 ( object sender, RoutedEventArgs e ) //Card2 Ch2
        {
            if ( channels2 [1].IsOpen )
            {
                card2Ch2Status.Background = Brushes.DarkRed;
                channels2 [1].IsOpen = false;
            }
            else
            {
                card2Ch2Status.Background = Brushes.Green;
                channels2 [1].IsOpen = true;
            }
        }

        private void Button_Click_10 ( object sender, RoutedEventArgs e ) //Card2 Ch3
        {
            if ( channels2 [2].IsOpen )
            {
                card2Ch3Status.Background = Brushes.DarkRed;
                channels2 [2].IsOpen = false;
            }
            else
            {
                card2Ch3Status.Background = Brushes.Green;
                channels2 [2].IsOpen = true;
            }
        }

        private void Button_Click_11 ( object sender, RoutedEventArgs e ) //Card2 Ch4
        {
            if ( channels2 [3].IsOpen )
            {
                card2Ch4Status.Background = Brushes.DarkRed;
                channels2 [3].IsOpen = false;
            }
            else
            {
                card2Ch4Status.Background = Brushes.Green;
                channels2 [3].IsOpen = true;
            }
        }

        private void Button_Click_12 ( object sender, RoutedEventArgs e ) //Card2 Ch5
        {
            if ( channels2 [4].IsOpen )
            {
                card2Ch5Status.Background = Brushes.DarkRed;
                channels2 [4].IsOpen = false;
            }
            else
            {
                card2Ch5Status.Background = Brushes.Green;
                channels2 [4].IsOpen = true;
            }
        }

        private void Button_Click_13 ( object sender, RoutedEventArgs e ) //Card2 Ch6
        {
            if ( channels2 [5].IsOpen )
            {
                card2Ch6Status.Background = Brushes.DarkRed;
                channels2 [5].IsOpen = false;
            }
            else
            {
                card2Ch6Status.Background = Brushes.Green;
                channels2 [5].IsOpen = true;
            }
        }

        private void Button_Click_14 ( object sender, RoutedEventArgs e ) //Card2 Ch7
        {
            if ( channels2 [6].IsOpen )
            {
                card2Ch7Status.Background = Brushes.DarkRed;
                channels2 [6].IsOpen = false;
            }
            else
            {
                card2Ch7Status.Background = Brushes.Green;
                channels2 [6].IsOpen = true;
            }
        }

        private void Button_Click_15 ( object sender, RoutedEventArgs e ) //Card2 Ch8
        {
            if ( channels2 [7].IsOpen )
            {
                card2Ch8Status.Background = Brushes.DarkRed;
                channels2 [7].IsOpen = false;
            }
            else
            {
                card2Ch8Status.Background = Brushes.Green;
                channels2 [7].IsOpen = true;
            }
        }

        #endregion

        #region Card3OpenCloseChannels
        private void Button_Click_16 ( object sender, RoutedEventArgs e ) //Card3 Ch1
        {
            if ( channels3 [0].IsOpen )
            {
                card3Ch1Status.Background = Brushes.DarkRed;
                channels3 [0].IsOpen = false;
            }
            else
            {
                card3Ch1Status.Background = Brushes.Green;
                channels3 [0].IsOpen = true;
            }
        }

        private void Button_Click_17 ( object sender, RoutedEventArgs e ) //Card3 Ch2
        {
            if ( channels3 [1].IsOpen )
            {
                card3Ch2Status.Background = Brushes.DarkRed;
                channels3 [1].IsOpen = false;
            }
            else
            {
                card3Ch2Status.Background = Brushes.Green;
                channels3 [1].IsOpen = true;
            }
        }

        private void Button_Click_18 ( object sender, RoutedEventArgs e ) //Card3 Ch3
        {
            if ( channels3 [2].IsOpen )
            {
                card3Ch3Status.Background = Brushes.DarkRed;
                channels3 [2].IsOpen = false;
            }
            else
            {
                card3Ch3Status.Background = Brushes.Green;
                channels3 [2].IsOpen = true;
            }
        }

        private void Button_Click_19 ( object sender, RoutedEventArgs e ) //Card3 Ch4
        {
            if ( channels3 [3].IsOpen )
            {
                card3Ch4Status.Background = Brushes.DarkRed;
                channels3 [3].IsOpen = false;
            }
            else
            {
                card3Ch4Status.Background = Brushes.Green;
                channels3 [3].IsOpen = true;
            }
        }

        private void Button_Click_20 ( object sender, RoutedEventArgs e ) //Card3 Ch5
        {
            if ( channels3 [4].IsOpen )
            {
                card3Ch5Status.Background = Brushes.DarkRed;
                channels3 [4].IsOpen = false;
            }
            else
            {
                card3Ch5Status.Background = Brushes.Green;
                channels3 [4].IsOpen = true;
            }
        }

        private void Button_Click_21 ( object sender, RoutedEventArgs e ) //Card3 Ch6
        {
            if ( channels3 [5].IsOpen )
            {
                card3Ch6Status.Background = Brushes.DarkRed;
                channels3 [5].IsOpen = false;
            }
            else
            {
                card3Ch6Status.Background = Brushes.Green;
                channels3 [5].IsOpen = true;
            }
        }

        private void Button_Click_22 ( object sender, RoutedEventArgs e ) //Card3 Ch7
        {
            if ( channels3 [6].IsOpen )
            {
                card3Ch7Status.Background = Brushes.DarkRed;
                channels3 [6].IsOpen = false;
            }
            else
            {
                card3Ch7Status.Background = Brushes.Green;
                channels3 [6].IsOpen = true;
            }
        }

        private void Button_Click_23 ( object sender, RoutedEventArgs e ) //Card3 Ch8
        {
            if ( channels3 [7].IsOpen )
            {
                card3Ch8Status.Background = Brushes.DarkRed;
                channels3 [7].IsOpen = false;
            }
            else
            {
                card3Ch8Status.Background = Brushes.Green;
                channels3 [7].IsOpen = true;
            }
        }
        #endregion

        #region Card1ChannelErrors
        private void Button_Click_24 ( object sender, RoutedEventArgs e ) // Card1 Ch1 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [0].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [0].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_25 ( object sender, RoutedEventArgs e ) // Card1 Ch1 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [0].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [0].ErrorCode -= 2;
                b.Background = Brushes.LimeGreen;
            }
        }

        private void Button_Click_26 ( object sender, RoutedEventArgs e ) // Card1 Ch1 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [0].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [0].ErrorCode -= 1;
                b.Background = Brushes.LightGreen;
            }
        }

        private void Button_Click_27 ( object sender, RoutedEventArgs e ) // Card1 Ch2 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [1].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [1].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_28 ( object sender, RoutedEventArgs e ) // Card1 Ch2 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [1].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [1].ErrorCode -= 2;
                b.Background = Brushes.LimeGreen;
            }
        }

        private void Button_Click_29 ( object sender, RoutedEventArgs e ) // Card1 Ch2 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [1].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [1].ErrorCode -= 1;
                b.Background = Brushes.LightGreen;
            }
        }

        private void Button_Click_30 ( object sender, RoutedEventArgs e ) // Card1 Ch3 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [2].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [2].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_31 ( object sender, RoutedEventArgs e ) // Card1 Ch3 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [2].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [2].ErrorCode -= 2;
                b.Background = Brushes.LimeGreen;
            }
        }

        private void Button_Click_32 ( object sender, RoutedEventArgs e ) // Card1 Ch3 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [2].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [2].ErrorCode -= 1;
                b.Background = Brushes.LightGreen;
            }
        }

        private void Button_Click_33 ( object sender, RoutedEventArgs e ) // Card1 Ch4 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [3].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [3].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_34 ( object sender, RoutedEventArgs e ) // Card1 Ch4 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [3].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [3].ErrorCode -= 2;
                b.Background = Brushes.LimeGreen;
            }
        }

        private void Button_Click_35 ( object sender, RoutedEventArgs e ) // Card1 Ch4 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [3].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [3].ErrorCode -= 1;
                b.Background = Brushes.LightGreen;
            }
        }

        private void Button_Click_36 ( object sender, RoutedEventArgs e ) // Card1 Ch5 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [4].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [4].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_37 ( object sender, RoutedEventArgs e ) // Card1 Ch5 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [4].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [4].ErrorCode -= 2;
                b.Background = Brushes.LimeGreen;
            }
        }

        private void Button_Click_38 ( object sender, RoutedEventArgs e ) // Card1 Ch5 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [4].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [4].ErrorCode -= 1;
                b.Background = Brushes.LightGreen;
            }
        }

        private void Button_Click_39 ( object sender, RoutedEventArgs e ) // Card1 Ch6 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [5].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [5].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_40 ( object sender, RoutedEventArgs e ) // Card1 Ch6 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [5].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [5].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_41 ( object sender, RoutedEventArgs e ) // Card1 Ch6 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [5].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [5].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_42 ( object sender, RoutedEventArgs e ) // Card1 Ch7 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [6].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [6].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_43 ( object sender, RoutedEventArgs e ) // Card1 Ch7 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [6].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [6].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_44 ( object sender, RoutedEventArgs e ) // Card1 Ch7 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [6].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [6].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_45 ( object sender, RoutedEventArgs e ) // Card1 Ch8 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [7].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [7].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_46 ( object sender, RoutedEventArgs e ) // Card1 Ch8 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [7].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [7].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_47 ( object sender, RoutedEventArgs e ) // Card1 Ch8 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels1 [7].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels1 [7].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        #endregion

        #region Card2ChannelErrors
        private void Button_Click_48 ( object sender, RoutedEventArgs e ) // Card2 Ch1 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [0].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [0].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_49 ( object sender, RoutedEventArgs e )// Card2 Ch1 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [0].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [0].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_50 ( object sender, RoutedEventArgs e )// Card2 Ch1 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [0].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [0].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_51 ( object sender, RoutedEventArgs e )// Card2 Ch2 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [1].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [1].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_52 ( object sender, RoutedEventArgs e )// Card2 Ch2 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [1].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [1].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_53 ( object sender, RoutedEventArgs e )// Card2 Ch2 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [1].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [1].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_54 ( object sender, RoutedEventArgs e )// Card2 Ch3 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [2].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [2].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_55 ( object sender, RoutedEventArgs e )// Card2 Ch3 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [2].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [2].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_56 ( object sender, RoutedEventArgs e )// Card2 Ch3 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [2].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [2].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_57 ( object sender, RoutedEventArgs e )// Card2 Ch4 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [3].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [3].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_58 ( object sender, RoutedEventArgs e )// Card2 Ch4 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [3].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [3].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_59 ( object sender, RoutedEventArgs e )// Card2 Ch4 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [3].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [3].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_60 ( object sender, RoutedEventArgs e )// Card2 Ch5 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [4].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [4].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_61 ( object sender, RoutedEventArgs e )// Card2 Ch5 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [4].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [4].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_62 ( object sender, RoutedEventArgs e )// Card2 Ch5 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [4].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [4].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_63 ( object sender, RoutedEventArgs e )// Card2 Ch6 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [5].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [5].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_64 ( object sender, RoutedEventArgs e )// Card2 Ch6 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [5].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [5].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_65 ( object sender, RoutedEventArgs e )// Card2 Ch6 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [5].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [5].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_66 ( object sender, RoutedEventArgs e )// Card2 Ch7 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [6].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [6].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_67 ( object sender, RoutedEventArgs e )// Card2 Ch7 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [6].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [6].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_68 ( object sender, RoutedEventArgs e )// Card2 Ch7 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [6].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [6].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_69 ( object sender, RoutedEventArgs e )// Card2 Ch8 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [7].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [7].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_70 ( object sender, RoutedEventArgs e )// Card2 Ch8 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [7].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [7].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }

        }

        private void Button_Click_71 ( object sender, RoutedEventArgs e )// Card2 Ch8 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels2 [7].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels2 [7].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }
        #endregion

        #region Card3ChannelErrors
        private void Button_Click_72 ( object sender, RoutedEventArgs e )// Card3 Ch1 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [0].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [0].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_73 ( object sender, RoutedEventArgs e )// Card3 Ch1 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [0].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [0].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_74 ( object sender, RoutedEventArgs e )// Card3 Ch1 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [0].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [0].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_75 ( object sender, RoutedEventArgs e )// Card3 Ch2 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [1].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [1].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_76 ( object sender, RoutedEventArgs e )// Card3 Ch2 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [1].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [1].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_77 ( object sender, RoutedEventArgs e )// Card3 Ch2 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [1].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [1].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_78 ( object sender, RoutedEventArgs e )// Card3 Ch3 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [2].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [2].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_79 ( object sender, RoutedEventArgs e )// Card3 Ch3 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [2].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [2].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_80 ( object sender, RoutedEventArgs e )// Card3 Ch3 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [2].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [2].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_81 ( object sender, RoutedEventArgs e )// Card3 Ch4 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [3].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [3].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_82 ( object sender, RoutedEventArgs e )// Card3 Ch4 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [3].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [3].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_83 ( object sender, RoutedEventArgs e )// Card3 Ch4 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [3].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [3].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_84 ( object sender, RoutedEventArgs e )// Card3 Ch5 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [4].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [4].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_85 ( object sender, RoutedEventArgs e )// Card3 Ch5 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [4].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [4].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_86 ( object sender, RoutedEventArgs e )// Card3 Ch5 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [4].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [4].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_87 ( object sender, RoutedEventArgs e )// Card3 Ch6 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [5].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [5].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_88 ( object sender, RoutedEventArgs e )// Card3 Ch6 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [5].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [5].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_89 ( object sender, RoutedEventArgs e )// Card3 Ch6 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [5].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [5].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_90 ( object sender, RoutedEventArgs e )// Card3 Ch7 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [6].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [6].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_91 ( object sender, RoutedEventArgs e )// Card3 Ch7 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [6].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [6].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_92 ( object sender, RoutedEventArgs e )// Card3 Ch7 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [6].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [6].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_93 ( object sender, RoutedEventArgs e )// Card3 Ch8 E2
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [7].ErrorCode += 4;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [7].ErrorCode -= 4;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_94 ( object sender, RoutedEventArgs e )// Card3 Ch8 E1
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [7].ErrorCode += 2;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [7].ErrorCode -= 2;
                b.Background = Brushes.Green;
            }
        }

        private void Button_Click_95 ( object sender, RoutedEventArgs e )// Card3 Ch8 E0
        {
            Button b = sender as Button;
            if ( b.Background != Brushes.IndianRed )
            {
                channels3 [7].ErrorCode += 1;
                b.Background = Brushes.IndianRed;
            }
            else
            {
                channels3 [7].ErrorCode -= 1;
                b.Background = Brushes.Green;
            }
        }
        #endregion
    }
}