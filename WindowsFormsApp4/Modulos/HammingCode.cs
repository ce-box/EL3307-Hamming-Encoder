using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Modulos
{
    /**
     * Library that provides methods to implement Hamming encoding 
     * and parity error detection
     */
    class HammingCode
    {
        // Environment settings
        const int columns = 11;
        const int rows = 6;
        const int dataSize = 7;
        const int redundantBits = 4;

        // Global Variables

        // Data encoding and error detection
        /**
         * It receives a 7-bit data message and applies Hamming encoding to it
         * 
         * @param string data binary message to encode
         * @return int[,] Hamming code solution matrix
         */
        public int[,] DataEncoding(string data){
            return new int[1,2];
        }

        /**
         * It receives a message encoded in Hamming (7,4) and performs 
         * the error detection analysis.
         * 
         * @param string data binary message to analyze
         * @return int[,] Hamming code solution matrix
         */
        public int[,] ErrorDetection(string data){
            return new int[1, 2];
        }

        // Encoding Engine
        /**
         *  Receive the binary message and separate it by bits into a bit array
         *  Note: Arrange the bits in an array that reserves the bit spaces for redundancy
         *  
         *  @param string data binary message
         *  @return int[] resulting bit array
         */
        private int[] SplitData(string data){
            return new int[7];
        }

        /**
         * Computes the parity bits of the hamming encoding. 
         * It also accommodates them in their positions in the array.
         * 
         * @param int[] bitArray Bit array that contains the message data.
         * @return int[] Bit array containing the message data and the calculated parity
         */
        private int[] CalculateParity(int[] bitArray){
            return bitArray;
        }

        // Bit and position handling
        /**
         * Determine if the position of a bit belongs to the set of two to the n (2^n)
         * 
         * @param int position Bit position to be analyzed 
         * @return bool True if it is the power of two, false if not
         */
        private bool IsPowerOfTwo(int position){
            return true;
        }

        /**
         * Checks if an index has one in the specified LSB bit position
         * 
         * @param int index Position of the array being evaluated
         * @param int lsbPosition LSB bit position
         * @return bool True if there is a one in the specified position, false if not
         */
        private bool ParityBitPosition(int index, int lsbPosition){
            return true;
        }



    }
}
