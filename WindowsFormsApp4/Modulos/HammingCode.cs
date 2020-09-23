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
        public static int[,] hammingMatrix = new int[rows, columns];
        public static string lastParity = "";
        public static string currentParity = "";
        public static int errorBit = 0;

        // Data encoding and error detection
        /**
         * It receives a 7-bit data message and applies Hamming encoding to it
         * 
         * @param string data binary message to encode
         * @param int partity Defines whether the algorithm will encode with even (0) or odd (1) parity
         * @return int[,] Hamming code solution matrix
         */
        public int[,] DataEncoding(string data, int parity) {
            return new int[1, 2];
        }

        /**
         * It receives a message encoded in Hamming (7,4) and performs 
         * the error detection analysis.
         * 
         * @param string data binary message to analyze
         * @param int partity Defines whether the algorithm will parse the message with even (0) or odd (1) parity
         * @return int[,] Hamming code solution matrix
         */
        public int[,] ErrorDetection(string data, int parity) {
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
        private int[] SplitData(string data) {
            return new int[7];
        }

        /**
         * Computes the parity bits of the hamming encoding. 
         * It also accommodates them in their positions in the array.
         * 
         * @param int[] bitArray Bit array that contains the message data.
         * @return int[] Bit array containing the message data and the calculated parity
         */
        private int[] CalculateParity(int[] bitArray) {
            return bitArray;
        }

        // Error detection Engine
        /**
         * Extracts the parity bits from a given code.
         * 
         * @param int[] bitArray Bit array that contains the message data
         * @return int[] Array with the parity bits of the original message
         */
        private int[] GetParityBits(int[] bitArray){
            return bitArray;
        }

        /**
         * Compare two parity arrays to detect if there are errors in the transmitted message
         * 
         * @param int[] p1 Parity Bit Array
         * @param int[] p2 Parity Bit Array
         * @return bool If the parities are equal, it returns true, otherwise false.
         */
        private bool CompareParity(int[] p1, int[] p2){
            return true;
        }

        /**
         * Finds the error in the message and generates the error array.
         * 
         * @param int[] p1 Parity Bit Array
         * @param int[] p2 Parity Bit Array
         * @return int[] Array of errors, a 0 indicates that there was no parity error, 
         *               a 1 indicates that there was.
         */
        private int[] FindError(int[] p1, int[] p2)
        {
            return p1;
         }

        /**
         * Computes the position of the corrupted bit in the message.
         * 
         * @param int[] errorArray State array of parity errors
         * @return int Damaged bit position
         */
        private int GetErrorPosition(int[] errorArray){
            return 0;
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

        // Matrix handling
        /**
         * Start the matrix by filling it with neutral values
         */
        private void Init(){

        }

        /**
         * Fill the first row of the matrix with only the information from the data bits
         * 
         * @param int[] data Array with hamming code
         */
        private void WriteFirstLine(int[] data){

        }

        /**
         * Write remaning data in Hamming code matrix
         * 
         * @param int[] data Array with hamming code
         */
        private void WriteLines(int[] data){

        }

        /**
         * Show matrix in console
         */
        private void Show(){

        }

    }
}
