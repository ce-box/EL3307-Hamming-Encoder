using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Modulos
{
    // (11,7)
    class Hamming
    {
        // Script Settings
        const int rows = 6;
        const int cols = 11;
        const int parityQty = 4;
        const int bitsQty = 7;

        private int[,] HammingMatrix = new int[rows,cols];
        private int[] bits = new int[bitsQty];
        private int[] parityBits = new int[parityQty];

        // Main  Function
        public int[,] EncodeHamming(string data)
        {
            InitMatrix();
            StringToBitArray(data);
            WriteFirstLine();
            foreach (int bit in bits)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            CalculateParity();
            ShowMatrix();
            return HammingMatrix; 
        }

        public int[,] ErrorDetection(string data) { return HammingMatrix; }

        private bool StringToBitArray(string data)
        {
            if(data.Length != 7) return false;

            for(int i = 0; i < 7; i++)
                bits[i] = data[i].Equals('1') ? 1 : 0;

            return true;
        }

        private void WriteFirstLine()
        {
            int bit = 0;
            for(int i = 0; i < 11; i++)
            {
                if(!IsPowerOfTwo(i+1)) 
                {
                    HammingMatrix[0, i] = bits[bit];
                    HammingMatrix[5, i] = bits[bit];
                    bit++;
                }
            }
        }

        private void CalculateParity() 
        {
            for(int pb = 0; pb < parityQty; pb++)
            {
                int parityCol = ((int)Math.Pow(2,pb)) - 1;
                int counter = 0;

                for(int col = 0; col < cols; col++)
                {
                    if (IsPowerOfTwo(col + 1)) continue;

                    // Bitwise >> operator 
                    if ((((col+1) >> pb) & 1) == 1)                    {
                        int data = HammingMatrix[0, col];
                        counter += data;
                        HammingMatrix[pb+1, col] = data;
                    }
                }

                // Calculate parity
                parityBits[pb] = counter % 2 == 0 ? 0 : 1;

                // Fill matrix (parity positions)
                HammingMatrix[pb + 1, parityCol] = parityBits[pb];
                HammingMatrix[5, parityCol] = parityBits[pb];

                Console.WriteLine("Paridad =>" + pb + " :: " + parityBits[pb]);
            }
        }

        private void FillSolvedMatrix() 
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(HammingMatrix[row, col]);
                    Console.Write(", ");
                }
                Console.WriteLine();
            }
        }



        // -------------------------------------------

        private void InitMatrix() 
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    HammingMatrix[row, col] = 5;
                }
            }
        }

        private void ShowMatrix()
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int data = HammingMatrix[row, col];
                    if (data == 5)
                        Console.Write(" ");
                    else
                        Console.Write(data);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }

        private bool IsPowerOfTwo(int num)
        {
            var exponent = Math.Log(num, 2);
            return exponent % 1 == 0;
        }

    }
}
