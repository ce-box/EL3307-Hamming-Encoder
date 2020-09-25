using System;

namespace WindowsFormsApp4.Modulos
{
    /**
     * Library that provides methods to implement Hamming (7,4) encoding 
     * and parity error detection
     */
    class HammingCode
    {
        // Environment settings
        const int defaultVal = 5; // Default value of the matrix, it cannot be neither 0 nor 1
        const int dataSize = 12;
        const int redundantBits = 5;
        const int columns = dataSize + redundantBits;
        const int rows = redundantBits + 2;
        public int parity = 0; // Even parity by default


        // Global Variables
        public static int[,] hammingMatrix = new int[rows, columns];

        // Error Detection  Variables
        public int[] originalParity, currentParity;
        public int[] errorArray = new int[redundantBits];
        public int errorBit = 0;


        // -----------------------------------------------------------------
        // Data encoding and error detection
        /**
         * It receives a 7-bit data message and applies Hamming encoding to it
         * 
         * @param string data binary message to encode
         * @return int[,] Hamming code solution matrix
         */
        public int[,] DataEncoding(string data)
        {
            if (data.Length != dataSize) return new int[0, 0];

            int[] bitArray = SplitInputData(data);
            bitArray = CalculateParity(bitArray);

            FillMatrix(bitArray);
            Show();

            return hammingMatrix;
        }

        /**
         * It receives a message encoded in Hamming (7,4) and performs 
         * the error detection analysis.
         * 
         * @param string data binary message to analyze
         * @return int[,] Hamming code solution matrix
         */
        public int[,] ErrorDetection(string data)
        {
            if (data.Length != columns) return new int[0, 0];

            int[] bitArray = SplitCodeData(data);
            originalParity = GetParityBits(bitArray);

            bitArray = CalculateParity(bitArray);
            currentParity = GetParityBits(bitArray);

            if (!CompareParity(originalParity, currentParity))
                errorArray = FindError(originalParity, currentParity);

            errorBit = GetErrorPosition(errorArray);

            FillMatrix(bitArray);
            Show();

            return hammingMatrix;
        }

        /**
         * Allows you to configure the encoding parity, even (0) or odd (1).
         * 
         * @param int partity Defines whether the algorithm will encode/parse 
         * the message with even (0) or odd (1) parity
         */
        public void SetParity(int parity)
        {
            this.parity = parity;
        }

        // -----------------------------------------------------------------
        // Encoding Engine
        /**
         *  Receive the binary message and separate it by bits into a bit array
         *  Note: Arrange the bits in an array that reserves the bit spaces for redundancy
         *  
         *  @param string data binary message
         *  @return int[] resulting bit array
         */
        private int[] SplitInputData(string data)
        {
            int[] bitArray = new int[columns];
            int index = 0;

            for (int i = 0; i < columns; i++)
            {

                if (!IsPowerOfTwo(i + 1))
                {
                    bitArray[i] = data[index].Equals('1') ? 1 : 0;
                    index++;
                }
            }

            return bitArray;
        }

        /**
         *  Receive the binary encoded message and separate it by bits into a bit array
         *  
         *  @param string code binary message encoded with hamming
         *  @return int[] resulting bit array
         */
        private int[] SplitCodeData(string code)
        {
            int[] bitArray = new int[columns];
            for (int i = 0; i < columns; i++)
                bitArray[i] = code[i].Equals('1') ? 1 : 0;

            return bitArray;
        }

        /**
         * Computes the parity bits of the hamming encoding. 
         * It also accommodates them in their positions in the array.
         * 
         * @param int[] bitArray Bit array that contains the message data.
         * @return int[] Bit array containing the message data and the calculated parity
         */
        private int[] CalculateParity(int[] bitArray)
        {
            for (int rb = 0; rb < redundantBits; rb++)
            {
                int parityCol = ((int)Math.Pow(2, rb)) - 1;
                int counter = 0;
                // Count occurrences of 1 
                for (int col = 0; col < columns; col++)
                {
                    if (IsPowerOfTwo(col + 1)) continue;
                    if (ParityBitPosition(col + 1, rb))
                        counter += bitArray[col];
                }

                // Determine parity
                if (parity == 1)
                    bitArray[parityCol] = counter % 2 == 0 ? 1 : 0;
                else
                    bitArray[parityCol] = counter % 2 == 0 ? 0 : 1;
            }

            return bitArray;
        }

        // -----------------------------------------------------------------
        // Error detection Engine
        /**
         * Extracts the parity bits from a given code.
         * 
         * @param int[] bitArray Bit array that contains the message data
         * @return int[] Array with the parity bits of the original message
         */
        private int[] GetParityBits(int[] bitArray)
        {
            int[] parityArray = new int[redundantBits];
            int index = 0;
            for (int col = 0; col < columns; col++)
            {
                if (IsPowerOfTwo(col + 1))
                {
                    parityArray[index] = bitArray[col];
                    index++;
                }
            }
            return parityArray;
        }

        /**
         * Compare two parity arrays to detect if there are errors in the transmitted message
         * 
         * @param int[] p1 Parity Bit Array
         * @param int[] p2 Parity Bit Array
         * @return bool If the parities are equal, it returns true, otherwise false.
         */
        private bool CompareParity(int[] p1, int[] p2)
        {
            int index = 0;

            while (index < redundantBits)
            {
                if (p1[index] != p2[index])
                    return false;
                index++;
            }

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
            int[] errorArray = new int[redundantBits];
            int index = 0;

            while (index < redundantBits)
            {
                errorArray[index] = p1[index] != p2[index] ? 1 : 0;
                index++;
            }

            return errorArray;
        }

        /**
         * Computes the position of the corrupted bit in the message.
         * 
         * @param int[] errorArray State array of parity errors
         * @return int Damaged bit position
         */
        private int GetErrorPosition(int[] errorArray)
        {
            int errorPosition = 0;
            Array.Reverse(errorArray);
            string binary = string.Join("",errorArray);
            errorPosition = Convert.ToInt32(binary, 2); 
            return errorPosition;
        }

        // -----------------------------------------------------------------
        // Bit and position handling
        /**
         * Determine if the position of a bit belongs to the set of two to the n (2^n)
         * 
         * @param int position Bit position to be analyzed 
         * @return bool True if it is the power of two, false if not
         */
        private bool IsPowerOfTwo(int position)
        {
            var result = Math.Log(position, 2);
            return result % 1 == 0;
        }

        /**
         * Checks if an index has one in the specified LSB bit position
         * 
         * @param int index Position of the array being evaluated
         * @param int lsbPosition LSB bit position
         * @return bool True if there is a one in the specified position, false if not
         */
        private bool ParityBitPosition(int index, int lsbPosition)
        {
            return ((index >> lsbPosition) & 1) == 1;
        }

        // -----------------------------------------------------------------
        // Matrix handling
        /**
         * Start the matrix by filling it with neutral values
         */
        private void Init()
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    hammingMatrix[row, col] = defaultVal;
                }
            }
        }

        /**
         * Fill the hamming matrix with the data from the solution
         * 
         * @param int[] data Array with hamming code
         */
        private void FillMatrix(int[] data)
        {
            Init();
            WriteFirstLine(data);
            WriteLines(data);
            WriteLastLine(data);
        }

        /**
         * Fill the first row of the matrix with only the information from the data bits
         * 
         * @param int[] data Array with hamming code
         */
        private void WriteFirstLine(int[] data)
        {
            for (int col = 0; col < columns; col++)
            {
                if (!IsPowerOfTwo(col + 1))
                    hammingMatrix[0, col] = data[col];
            }
        }

        /**
         * Fill the last row of the matrix with the final hamming solution
         * 
         * @param int[] data Array with hamming code
         */
        private void WriteLastLine(int[] data)
        {
            for (int col = 0; col < columns; col++)
                hammingMatrix[rows - 1, col] = data[col];
        }

        /**
         * Write remaning data in Hamming code matrix
         * 
         * @param int[] data Array with hamming code
         */
        private void WriteLines(int[] data)
        {
            for (int rb = 0; rb < redundantBits; rb++)
            {
                int parityCol = ((int)Math.Pow(2, rb)) - 1;
                for (int col = 0; col < columns; col++)
                {
                    if (IsPowerOfTwo(col + 1))
                        continue;
                    if (ParityBitPosition(col + 1, rb))
                        hammingMatrix[rb + 1, col] = data[col];
                }
                hammingMatrix[rb + 1, parityCol] = data[parityCol];
            }
        }

        /**
         * Show matrix in console
         */
        private void Show()
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    int bit = hammingMatrix[row, col];
                    string value = bit != defaultVal ? bit.ToString() : " ";
                    Console.Write(value + " | ");
                }
                Console.WriteLine();
            }
        }

    }
}

