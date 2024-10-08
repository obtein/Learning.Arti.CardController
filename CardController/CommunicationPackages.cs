﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using CardController.Enums;

namespace CardController
{
    /// <summary>
    /// A base model for sending packages to central processor unit
    /// initilize at compile and const thru runtime
    /// </summary>
    public static class CommunicationPackages
    {

        static CommunicationPackages ()
        {
            ChannelInspection = CalculateChannelInspection();
            AnalogInspection = CalculateAnalogInspection();
            CardErrorInspection = CalculateCardErrorInspection();
            Card1OpenOrCloseInspection = CalculateCard1OpenOrClose();
            Card2OpenOrCloseInspection = CalculateCard2OpenOrClose();
            Card3OpenOrCloseInspection = CalculateCard3OpenOrClose();

            #region OpenChannelInit
            Card1Ch1Open = CalculateOpenCommandToBeSent( 1, 1 );
            Card1Ch2Open = CalculateOpenCommandToBeSent( 1, 2 );
            Card1Ch3Open = CalculateOpenCommandToBeSent( 1, 3 );
            Card1Ch4Open = CalculateOpenCommandToBeSent( 1, 4 );
            Card1Ch5Open = CalculateOpenCommandToBeSent( 1, 5 );
            Card1Ch6Open = CalculateOpenCommandToBeSent( 1, 6 );
            Card1Ch7Open = CalculateOpenCommandToBeSent( 1, 7 );
            Card1Ch8Open = CalculateOpenCommandToBeSent( 1, 8 );
            Card2Ch1Open = CalculateOpenCommandToBeSent( 2, 1 );
            Card2Ch2Open = CalculateOpenCommandToBeSent( 2, 2 );
            Card2Ch3Open = CalculateOpenCommandToBeSent( 2, 3 );
            Card2Ch4Open = CalculateOpenCommandToBeSent( 2, 4 );
            Card2Ch5Open = CalculateOpenCommandToBeSent( 2, 5 );
            Card2Ch6Open = CalculateOpenCommandToBeSent( 2, 6 );
            Card2Ch7Open = CalculateOpenCommandToBeSent( 2, 7 );
            Card2Ch8Open = CalculateOpenCommandToBeSent( 2, 8 );
            Card3Ch1Open = CalculateOpenCommandToBeSent( 3, 1 );
            Card3Ch2Open = CalculateOpenCommandToBeSent( 3, 2 );
            Card3Ch3Open = CalculateOpenCommandToBeSent( 3, 3 );
            Card3Ch4Open = CalculateOpenCommandToBeSent( 3, 4 );
            Card3Ch5Open = CalculateOpenCommandToBeSent( 3, 5 );
            Card3Ch6Open = CalculateOpenCommandToBeSent( 3, 6 );
            Card3Ch7Open = CalculateOpenCommandToBeSent( 3, 7 );
            Card3Ch8Open = CalculateOpenCommandToBeSent( 3, 8 );
            #endregion

            #region CloseChannelInit
            Card1Ch1Close = CalculateOpenCommandToBeSent( 1, 1 );
            Card1Ch2Close = CalculateOpenCommandToBeSent( 1, 2 );
            Card1Ch3Close = CalculateOpenCommandToBeSent( 1, 3 );
            Card1Ch4Close = CalculateOpenCommandToBeSent( 1, 4 );
            Card1Ch5Close = CalculateOpenCommandToBeSent( 1, 5 );
            Card1Ch6Close = CalculateOpenCommandToBeSent( 1, 6 );
            Card1Ch7Close = CalculateOpenCommandToBeSent( 1, 7 );
            Card1Ch8Close = CalculateOpenCommandToBeSent( 1, 8 );
            Card2Ch1Close = CalculateOpenCommandToBeSent( 2, 1 );
            Card2Ch2Close = CalculateOpenCommandToBeSent( 2, 2 );
            Card2Ch3Close = CalculateOpenCommandToBeSent( 2, 3 );
            Card2Ch4Close = CalculateOpenCommandToBeSent( 2, 4 );
            Card2Ch5Close = CalculateOpenCommandToBeSent( 2, 5 );
            Card2Ch6Close = CalculateOpenCommandToBeSent( 2, 6 );
            Card2Ch7Close = CalculateOpenCommandToBeSent( 2, 7 );
            Card2Ch8Close = CalculateOpenCommandToBeSent( 2, 8 );
            Card3Ch1Close = CalculateOpenCommandToBeSent( 3, 1 );
            Card3Ch2Close = CalculateOpenCommandToBeSent( 3, 2 );
            Card3Ch3Close = CalculateOpenCommandToBeSent( 3, 3 );
            Card3Ch4Close = CalculateOpenCommandToBeSent( 3, 4 );
            Card3Ch5Close = CalculateOpenCommandToBeSent( 3, 5 );
            Card3Ch6Close = CalculateOpenCommandToBeSent( 3, 6 );
            Card3Ch7Close = CalculateOpenCommandToBeSent( 3, 7 );
            Card3Ch8Close = CalculateOpenCommandToBeSent( 3, 8 );
            #endregion


        }
        #region Inputs
        public static readonly byte [] ChannelInspection;
        public static readonly byte [] AnalogInspection;
        public static readonly byte [] CardErrorInspection;
        public static readonly byte [] Card1OpenOrCloseInspection;
        public static readonly byte [] Card2OpenOrCloseInspection;
        public static readonly byte [] Card3OpenOrCloseInspection;


        public static readonly byte [] [] CardChannelOpenRequest;
        /// <summary>
        /// Open channel packages
        /// </summary>
        #region OpenChannel
        public static readonly byte [] Card1Ch1Open;
        public static readonly byte [] Card1Ch2Open;
        public static readonly byte [] Card1Ch3Open;
        public static readonly byte [] Card1Ch4Open;
        public static readonly byte [] Card1Ch5Open;
        public static readonly byte [] Card1Ch6Open;
        public static readonly byte [] Card1Ch7Open;
        public static readonly byte [] Card1Ch8Open;
        public static readonly byte [] Card2Ch1Open;
        public static readonly byte [] Card2Ch2Open;
        public static readonly byte [] Card2Ch3Open;
        public static readonly byte [] Card2Ch4Open;
        public static readonly byte [] Card2Ch5Open;
        public static readonly byte [] Card2Ch6Open;
        public static readonly byte [] Card2Ch7Open;
        public static readonly byte [] Card2Ch8Open;
        public static readonly byte [] Card3Ch1Open;
        public static readonly byte [] Card3Ch2Open;
        public static readonly byte [] Card3Ch3Open;
        public static readonly byte [] Card3Ch4Open;
        public static readonly byte [] Card3Ch5Open;
        public static readonly byte [] Card3Ch6Open;
        public static readonly byte [] Card3Ch7Open;
        public static readonly byte [] Card3Ch8Open;
        #endregion

        /// <summary>
        /// Close channel packages
        /// </summary>
        #region CloseChannel
        public static readonly byte [] Card1Ch1Close;
        public static readonly byte [] Card1Ch2Close;
        public static readonly byte [] Card1Ch3Close;
        public static readonly byte [] Card1Ch4Close;
        public static readonly byte [] Card1Ch5Close;
        public static readonly byte [] Card1Ch6Close;
        public static readonly byte [] Card1Ch7Close;
        public static readonly byte [] Card1Ch8Close;
        public static readonly byte [] Card2Ch1Close;
        public static readonly byte [] Card2Ch2Close;
        public static readonly byte [] Card2Ch3Close;
        public static readonly byte [] Card2Ch4Close;
        public static readonly byte [] Card2Ch5Close;
        public static readonly byte [] Card2Ch6Close;
        public static readonly byte [] Card2Ch7Close;
        public static readonly byte [] Card2Ch8Close;
        public static readonly byte [] Card3Ch1Close;
        public static readonly byte [] Card3Ch2Close;
        public static readonly byte [] Card3Ch3Close;
        public static readonly byte [] Card3Ch4Close;
        public static readonly byte [] Card3Ch5Close;
        public static readonly byte [] Card3Ch6Close;
        public static readonly byte [] Card3Ch7Close;
        public static readonly byte [] Card3Ch8Close;
        #endregion

        /// <summary>
        /// Calculates Channel inspection for starting communication  
        /// </summary>
        /// <returns></returns>
        private static byte [] CalculateChannelInspection () // start of the conversation
        {
            byte [] temp = CalculateCheckSum( new byte [] { (byte)EnumCommunicationParameters.Stx,
                                                            (byte)EnumCommunicationParameters.Id,
                                                            (byte)EnumCommunicationParameters.ChInspection,
                                                            0x30, 0x30 } );
            byte [] toBeSent = { (byte)EnumCommunicationParameters.Stx,
                                 (byte)EnumCommunicationParameters.Id,
                                 (byte)EnumCommunicationParameters.ChInspection,
                                 0x30, 0x30, temp [0], temp [1],
                                 (byte)EnumCommunicationParameters.Etx};
            return toBeSent;
        }

        /// <summary>
        /// Calculates Analog inspection package
        /// </summary>
        /// <returns></returns>
        private static byte [] CalculateAnalogInspection ()
        {
            byte [] temp = CalculateCheckSum( new byte [] { (byte)EnumCommunicationParameters.Stx,
                                                            (byte)EnumCommunicationParameters.Id,
                                                            (byte)EnumCommunicationParameters.AnalogInspection,
                                                            0x30, 0x30 } );
            byte [] toBeSent = { (byte)EnumCommunicationParameters.Stx,
                                 (byte)EnumCommunicationParameters.Id,
                                 (byte)EnumCommunicationParameters.AnalogInspection,
                                 0x30, 0x30, temp [0], temp [1],
                                 (byte)EnumCommunicationParameters.Etx};
            return toBeSent;
        }

        /// <summary>
        /// Calculates card error inspection package
        /// </summary>
        private static byte [] CalculateCardErrorInspection ()
        {
            byte [] temp = CalculateCheckSum( new byte [] { (byte)EnumCommunicationParameters.Stx,
                                                            (byte)EnumCommunicationParameters.Id,
                                                            (byte)EnumCommunicationParameters.CardErrorInspection,
                                                            0x30, 0x30 } );
            byte [] toBeSent = { (byte)EnumCommunicationParameters.Stx,
                                 (byte)EnumCommunicationParameters.Id,
                                 (byte)EnumCommunicationParameters.CardErrorInspection,
                                 0x30, 0x30, temp [0], temp [1],
                                 (byte)EnumCommunicationParameters.Etx};
            return toBeSent;
        }

        /// <summary>
        /// Calculates the data for inspection open/close CARD1
        /// </summary>
        private static byte [] CalculateCard1OpenOrClose ()
        {
            byte [] temp = CalculateCheckSum( new byte [] { (byte)EnumCommunicationParameters.Stx,
                                                            (byte)EnumCommunicationParameters.Id,
                                                            (byte)EnumCommunicationParameters.OpenCloseCard1,
                                                            0x30, 0x30 } );
            byte [] toBeSent = { (byte)EnumCommunicationParameters.Stx,
                                 (byte)EnumCommunicationParameters.Id,
                                 (byte)EnumCommunicationParameters.OpenCloseCard1,
                                 0x30, 0x30, temp [0], temp [1],
                                 (byte)EnumCommunicationParameters.Etx};
            return toBeSent;
        }
        /// <summary>
        /// Calculates the data for inspection open/close CARD2
        /// </summary>
        private static byte [] CalculateCard2OpenOrClose ()
        {
            byte [] temp = CalculateCheckSum( new byte [] { (byte)EnumCommunicationParameters.Stx,
                                                            (byte)EnumCommunicationParameters.Id,
                                                            (byte)EnumCommunicationParameters.OpenCloseCard2,
                                                            0x30, 0x30 } );
            byte [] toBeSent = { (byte)EnumCommunicationParameters.Stx,
                                 (byte)EnumCommunicationParameters.Id,
                                 (byte)EnumCommunicationParameters.OpenCloseCard2,
                                 0x30, 0x30, temp [0], temp [1],
                                 (byte)EnumCommunicationParameters.Etx};
            return toBeSent;
        }
        /// <summary>
        /// Calculates the data for inspection open/close CARD3
        /// </summary>
        private static byte [] CalculateCard3OpenOrClose ()
        {
            byte [] temp = CalculateCheckSum( new byte [] { (byte)EnumCommunicationParameters.Stx,
                                                            (byte)EnumCommunicationParameters.Id,
                                                            (byte)EnumCommunicationParameters.OpenCloseCard3,
                                                            0x30, 0x30 } );
            byte [] toBeSent = { (byte)EnumCommunicationParameters.Stx,
                                 (byte)EnumCommunicationParameters.Id,
                                 (byte)EnumCommunicationParameters.OpenCloseCard3,
                                 0x30, 0x30, temp [0], temp [1],
                                 (byte)EnumCommunicationParameters.Etx};
            return toBeSent;
        }

        /// <summary>
        /// Takes Card index and channel index as input then calculates the byte array to be sent
        /// </summary>
        /// <param name="cardIndex"></param>
        /// <param name="channelIndex"></param>
        /// <returns> return checksum as byte[] = { msb[0], lsb[1]} </returns>
        private static byte [] CalculateOpenCommandToBeSent ( int cardIndex, int channelIndex )
        {
            byte toBegin = 0b00000001;
            byte [] result = new byte [12]; // to be returned
            byte [] checkSumCalc = new byte [9]; // to calculate checksum
            byte [] checkSumTemp = new byte [2]; // to send checksum Method
                                                 // Generic properties
            byte stx = (byte)EnumCommunicationParameters.Stx;
            byte etx = (byte)EnumCommunicationParameters.Etx;
            byte id = (byte)EnumCommunicationParameters.Id;
            byte msgCode = 0x00;
            // Data part
            byte dataLengthMSB = 0x30;
            byte dataLengthLSB = 0x34;
            byte dataByte1MSB = 0xFF;
            byte dataByte1LSB = 0x00;
            byte dataByte0MSB = 0xFF;
            byte dataByte0LSB = 0x00;
            // Check sum
            byte checkSumMSB;
            byte checkSumLSB;

            if ( cardIndex == 1 )
            {
                msgCode = (byte)EnumCommunicationParameters.OpenChannelCard1;
            }
            else if ( cardIndex == 2 )
            {
                msgCode = (byte)EnumCommunicationParameters.OpenChannelCard2;
            }
            else if ( cardIndex == 3 )
            {
                msgCode = (byte)EnumCommunicationParameters.OpenChannelCard3;
            }

            if ( channelIndex == 1 )
            {
                byte temp1 = toBegin;
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 2 )
            {
                byte temp1 = (byte)( toBegin << 1 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 3 )
            {
                byte temp1 = (byte)( toBegin << 2 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 4 )
            {
                byte temp1 = (byte)( toBegin << 3 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 5 )
            {
                byte temp1 = (byte)( toBegin << 4 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 6 )
            {
                byte temp1 = (byte)( toBegin << 5 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 7 )
            {
                byte temp1 = (byte)( toBegin << 6 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 8 )
            {
                byte temp1 = (byte)( toBegin << 7 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }

            checkSumCalc [0] = stx;
            checkSumCalc [1] = id;
            checkSumCalc [2] = msgCode;
            checkSumCalc [3] = dataLengthMSB;
            checkSumCalc [4] = dataLengthLSB;
            checkSumCalc [5] = dataByte1MSB;
            checkSumCalc [6] = dataByte1LSB;
            checkSumCalc [7] = dataByte0MSB;
            checkSumCalc [8] = dataByte0LSB;
            checkSumTemp = CalculateCheckSum( checkSumCalc );
            checkSumMSB = checkSumTemp [0];
            checkSumLSB = checkSumTemp [1];

            result [0] = stx;
            result [1] = id;
            result [2] = msgCode;
            result [3] = dataLengthMSB;
            result [4] = dataLengthLSB;
            result [5] = dataByte1MSB;
            result [6] = dataByte1LSB;
            result [7] = dataByte0MSB;
            result [8] = dataByte0LSB;
            result [9] = checkSumMSB;
            result [10] = checkSumLSB;
            result [11] = etx;
            return result;
        }
        /// <summary>
        /// Takes Card index and channel index as input then calculates the byte array to be sent
        /// </summary>
        /// <param name="cardIndex"></param>
        /// <param name="channelIndex"></param>
        /// <returns> return checksum as byte[] = { msb[0], lsb[1]} </returns>
        private static byte [] CalculateCloseCommandToBeSent ( int cardIndex, int channelIndex )
        {
            byte toBegin = 0b00000001;
            byte [] result = new byte [12]; // to be returned
            byte [] checkSumCalc = new byte [9]; // to calculate checksum
            byte [] checkSumTemp = new byte [2]; // to send checksum Method
                                                 // Generic properties
            byte stx = (byte)EnumCommunicationParameters.Stx;
            byte etx = (byte)EnumCommunicationParameters.Etx;
            byte id = (byte)EnumCommunicationParameters.Id;
            byte msgCode = 0x00;
            // Data part
            byte dataLengthMSB = 0x30;
            byte dataLengthLSB = 0x34;
            byte dataByte1MSB = 0xFF;
            byte dataByte1LSB = 0x00;
            byte dataByte0MSB = 0xFF;
            byte dataByte0LSB = 0x00;
            // Check sum
            byte checkSumMSB;
            byte checkSumLSB;

            if ( cardIndex == 1 )
            {
                msgCode = (byte)EnumCommunicationParameters.CloseChannelCard1;
            }
            else if ( cardIndex == 2 )
            {
                msgCode = (byte)EnumCommunicationParameters.CloseChannelCard2;
            }
            else if ( cardIndex == 3 )
            {
                msgCode = (byte)EnumCommunicationParameters.CloseChannelCard3;
            }

            if ( channelIndex == 1 )
            {
                byte temp1 = toBegin;
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 2 )
            {
                byte temp1 = (byte)( toBegin << 1 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 3 )
            {
                byte temp1 = (byte)( toBegin << 2 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 4 )
            {
                byte temp1 = (byte)( toBegin << 3 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 5 )
            {
                byte temp1 = (byte)( toBegin << 4 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 6 )
            {
                byte temp1 = (byte)( toBegin << 5 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 7 )
            {
                byte temp1 = (byte)( toBegin << 6 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }
            else if ( channelIndex == 8 )
            {
                byte temp1 = (byte)( toBegin << 7 );
                byte temp0 = (byte)( ~temp1 );
                byte [] split1 = SplitByteToTwo( temp1 );
                byte [] split0 = SplitByteToTwo( temp0 );
                dataByte1MSB = split1 [0];
                dataByte1LSB = split1 [1];
                dataByte0MSB = split0 [0];
                dataByte0LSB = split0 [1];
            }

            checkSumCalc [0] = stx;
            checkSumCalc [1] = id;
            checkSumCalc [2] = msgCode;
            checkSumCalc [3] = dataLengthMSB;
            checkSumCalc [4] = dataLengthLSB;
            checkSumCalc [5] = dataByte1MSB;
            checkSumCalc [6] = dataByte1LSB;
            checkSumCalc [7] = dataByte0MSB;
            checkSumCalc [8] = dataByte0LSB;
            checkSumTemp = CalculateCheckSum( checkSumCalc );
            checkSumMSB = checkSumTemp [0];
            checkSumLSB = checkSumTemp [1];

            result [0] = stx;
            result [1] = id;
            result [2] = msgCode;
            result [3] = dataLengthMSB;
            result [4] = dataLengthLSB;
            result [5] = dataByte1MSB;
            result [6] = dataByte1LSB;
            result [7] = dataByte0MSB;
            result [8] = dataByte0LSB;
            result [9] = checkSumMSB;
            result [10] = checkSumLSB;
            result [11] = etx;
            return result;
        }


        /// <summary>
        /// Calculates the checkSum of given array of bytes 
        /// </summary>
        /// <param name="checkSumToBeCalculated"></param>
        /// <returns> [0] as msb [1] as lsb </returns>
        private static byte [] CalculateCheckSum ( byte [] checkSumToBeCalculated )
        {
            byte tempResult = 0x00;
            foreach ( byte x in checkSumToBeCalculated )
            {
                tempResult ^= x;
            }
            return SplitByteToTwo( tempResult );
        }

        /// <summary>
        /// Splits given byte to two bytes
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static byte [] SplitByteToTwo ( byte x )
        {
            return Encoding.ASCII.GetBytes( ByteToString( x ) );
        }

        //Simple byte to string converter
        private static string ByteToString ( byte x )
        {
            return x.ToString( "X2" );
        }
        #endregion


        #region Response
        public static byte [] ChannelInspectionResponse; // length : 14

        public static byte [] AnalogInspectionResponse; // len: 116

        public static byte [] CardErrorInspectionResponse; // len: 56

        //public static byte [] CardTempInspectionResponse; // work in progress

        public static byte [] Card1OpenCloseResponse; // len 10
        public static byte [] Card2OpenCloseResponse; // len 10
        public static byte [] Card3OpenCloseResponse; // len 10


        public static byte [] CalculateChannelInspectionResponse (int card1Count, int card2Count, int card3Count)
        {
            int index = 0;
            byte [] result = new byte[14];
            result [index++] = (byte)EnumCommunicationParameters.Stx;
            result [index++] = (byte)EnumCommunicationParameters.Id;
            result [index++] = (byte)EnumCommunicationParameters.ChInspection;
            result [index++] = (byte)0x30;
            result [index++] = (byte)0x36;
            //card 1 ch count
            result [index++] = (byte)0x30;
            switch ( card1Count )
            {
                case 0:
                    result [index++] = (byte)0x30;
                    break;
                case 1:
                    result [index++] = (byte)0x31;
                    break;
                case 2:
                    result [index++] = (byte)0x32;
                    break;
                case 3:
                    result [index++] = (byte)0x33;
                    break;
                case 4:
                    result [index++] = (byte)0x34;
                    break;
                case 5:
                    result [index++] = (byte)0x35;
                    break;
                case 6:
                    result [index++] = (byte)0x36;
                    break;
                case 7:
                    result [index++] = (byte)0x37;
                    break;
                case 8:
                    result [index++] = (byte)0x38;
                    break;
            }
            //card 2 ch count
            result [index++] = (byte)0x30;
            switch ( card2Count )
            {
                case 0:
                    result [index++] = (byte)0x30;
                    break;
                case 1:
                    result [index++] = (byte)0x31;
                    break;
                case 2:
                    result [index++] = (byte)0x32;
                    break;
                case 3:
                    result [index++] = (byte)0x33;
                    break;
                case 4:
                    result [index++] = (byte)0x34;
                    break;
                case 5:
                    result [index++] = (byte)0x35;
                    break;
                case 6:
                    result [index++] = (byte)0x36;
                    break;
                case 7:
                    result [index++] = (byte)0x37;
                    break;
                case 8:
                    result [index++] = (byte)0x38;
                    break;
            }
            //card 3 ch count
            result [index++] = (byte)0x30;
            switch ( card3Count )
            {
                case 0:
                    result [index++] = (byte)0x30;
                    break;
                case 1:
                    result [index++] = (byte)0x31;
                    break;
                case 2:
                    result [index++] = (byte)0x32;
                    break;
                case 3:
                    result [index++] = (byte)0x33;
                    break;
                case 4:
                    result [index++] = (byte)0x34;
                    break;
                case 5:
                    result [index++] = (byte)0x35;
                    break;
                case 6:
                    result [index++] = (byte)0x36;
                    break;
                case 7:
                    result [index++] = (byte)0x37;
                    break;
                case 8:
                    result [index++] = (byte)0x38;
                    break;
            }
            
            //checksum
            result [index++] = (byte)0x30;
            result [index++] = (byte)0x30;

            result [index++] = (byte)EnumCommunicationParameters.Etx;
            return result;
        }

        public static byte [] CalculateAnalogInspectionResponse (double card1Voltage, double card2Voltage, double card3Voltage, double [] c1, double [] c2, double [] c3 )
        {
            int index = 0;
            byte [] result = new byte [116];
            result [index++] = (byte)EnumCommunicationParameters.Stx;
            result [index++] = (byte)EnumCommunicationParameters.Id;
            result [index++] = (byte)EnumCommunicationParameters.AnalogInspection;
            result [index++] = (byte)0x36;
            result [index++] = (byte)0x43;
            //Card1 Voltage
            byte [] temp1 = CalculateDoubleTo4Byte (card1Voltage);
            result [index++] = temp1 [0];
            result [index++] = temp1 [1];
            result [index++] = temp1 [2];
            result [index++] = temp1 [3];

            // TODO: Calculate Card1 channel currents

            //Card2 Voltage
            byte [] temp2 = CalculateDoubleTo4Byte( card2Voltage );
            result [index++] = temp2 [0];
            result [index++] = temp2 [1];
            result [index++] = temp2 [2];
            result [index++] = temp2 [3];

            // TODO: Calculate Card2 channel currents

            //Card3 Voltage
            byte [] temp3 = CalculateDoubleTo4Byte( card3Voltage );
            result [index++] = temp3 [0];
            result [index++] = temp3 [1];
            result [index++] = temp3 [2];
            result [index++] = temp3 [3];

            // TODO: Calculate Card3 channel currents

            //checksum
            result [index++] = (byte)0x30;
            result [index++] = (byte)0x30;

            result [index++] = (byte)EnumCommunicationParameters.Etx;
            return result;
        }

        public static byte [] CalculateCardErrorInspectionResponse ( int [] c1Channels, int [] c2Channels, int [] c3Channels)
        {
            byte [] result = new byte [56];
            int index = 0;
            result [index++] = (byte)EnumCommunicationParameters.Stx;
            result [index++] = (byte)EnumCommunicationParameters.Id;
            result [index++] = (byte)EnumCommunicationParameters.CardErrorInspection;
            result [index++] = (byte)0x33;
            result [index++] = (byte)0x30;

            result [index++] = (byte)0x30;
            result [index++] = ( c1Channels [0] == 128 ) ? Convert.ToByte( c1Channels [0] ) : (byte)Encoding.ASCII.GetBytes( c1Channels [0].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c1Channels [1] == 128 ) ? Convert.ToByte( c1Channels [1] ) : (byte)Encoding.ASCII.GetBytes( c1Channels [1].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c1Channels [2] == 128 ) ? Convert.ToByte( c1Channels [2] ) : (byte)Encoding.ASCII.GetBytes( c1Channels [2].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c1Channels [3] == 128 ) ? Convert.ToByte( c1Channels [3] ) : (byte)Encoding.ASCII.GetBytes( c1Channels [3].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c1Channels [4] == 128 ) ? Convert.ToByte( c1Channels [4] ) : (byte)Encoding.ASCII.GetBytes( c1Channels [4].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c1Channels [5] == 128 ) ? Convert.ToByte( c1Channels [5] ) : (byte)Encoding.ASCII.GetBytes( c1Channels [5].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c1Channels [6] == 128 ) ? Convert.ToByte( c1Channels [6] ) : (byte)Encoding.ASCII.GetBytes( c1Channels [6].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c1Channels [7] == 128 ) ? Convert.ToByte( c1Channels [7] ) : (byte)Encoding.ASCII.GetBytes( c1Channels [7].ToString() ) [0];

            result [index++] = (byte)0x30;
            result [index++] = ( c2Channels [0] == 128 ) ? Convert.ToByte( c2Channels [0] ) : (byte)Encoding.ASCII.GetBytes( c2Channels [0].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c2Channels [1] == 128 ) ? Convert.ToByte( c2Channels [1] ) : (byte)Encoding.ASCII.GetBytes( c2Channels [1].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c2Channels [2] == 128 ) ? Convert.ToByte( c2Channels [2] ) : (byte)Encoding.ASCII.GetBytes( c2Channels [2].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c2Channels [3] == 128 ) ? Convert.ToByte( c2Channels [3] ) : (byte)Encoding.ASCII.GetBytes( c2Channels [3].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c2Channels [4] == 128 ) ? Convert.ToByte( c2Channels [4] ) : (byte)Encoding.ASCII.GetBytes( c2Channels [4].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c2Channels [5] == 128 ) ? Convert.ToByte( c2Channels [5] ) : (byte)Encoding.ASCII.GetBytes( c2Channels [5].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c2Channels [6] == 128 ) ? Convert.ToByte( c2Channels [6] ) : (byte)Encoding.ASCII.GetBytes( c2Channels [6].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c2Channels [7] == 128 ) ? Convert.ToByte( c2Channels [7] ) : (byte)Encoding.ASCII.GetBytes( c2Channels [7].ToString() ) [0];

            result [index++] = (byte)0x30;
            result [index++] = ( c3Channels [0] == 128 ) ? Convert.ToByte( c3Channels [0] ) : (byte)Encoding.ASCII.GetBytes( c3Channels [0].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c3Channels [1] == 128 ) ? Convert.ToByte( c3Channels [1] ) : (byte)Encoding.ASCII.GetBytes( c3Channels [1].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c3Channels [2] == 128 ) ? Convert.ToByte( c3Channels [2] ) : (byte)Encoding.ASCII.GetBytes( c3Channels [2].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c3Channels [3] == 128 ) ? Convert.ToByte( c3Channels [3] ) : (byte)Encoding.ASCII.GetBytes( c3Channels [3].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c3Channels [4] == 128 ) ? Convert.ToByte( c3Channels [4] ) : (byte)Encoding.ASCII.GetBytes( c3Channels [4].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c3Channels [5] == 128 ) ? Convert.ToByte( c3Channels [5] ) : (byte)Encoding.ASCII.GetBytes( c3Channels [5].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c3Channels [6] == 128 ) ? Convert.ToByte( c3Channels [6] ) : (byte)Encoding.ASCII.GetBytes( c3Channels [6].ToString() ) [0];
            result [index++] = (byte)0x30;
            result [index++] = ( c3Channels [7] == 128 ) ? Convert.ToByte( c3Channels [7] ) : (byte)Encoding.ASCII.GetBytes( c3Channels [7].ToString() ) [0];

            result [index++] = (byte)0x30;
            result [index++] = (byte)0x30;
            result [index++] = (byte)EnumCommunicationParameters.Etx;

            return result;
        }

        public static byte [] CalculateCard1OpenCloseResponse ()
        {
            byte [] result = new byte [10];

            return result;
        }

        public static byte [] CalculateCard2OpenCloseResponse ()
        {
            byte [] result = new byte [10];

            return result;
        }

        public static byte [] CalculateCard3OpenCloseResponse ()
        {
            byte [] result = new byte [10];

            return result;
        }
        #endregion

        private static byte [] CalculateDoubleTo4Byte ( double input )
        {
            byte [] result = new byte [4];

            input *= 100;

            int tempTail = (int)input % 100;
            int tempHead = (int)input / 100;
            byte [] temp1 = SplitByteToTwo( (byte)tempHead );
            result [0] = temp1 [0];
            result [1] = temp1 [1];
            byte [] temp2 = SplitByteToTwo( (byte)tempTail );
            result [2] = temp2 [0];
            result [3] = temp2 [1];
            return result;
        }

    }
}
