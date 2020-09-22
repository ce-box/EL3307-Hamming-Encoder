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
        public string EncodeHamming(string data)
        {
            StringToBitArray(data);
            WriteFirstLine();
            foreach (int bit in bits)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            ShowMatrix();
            CalculateParity();
            return data; 
        } 

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
            // TODO: Completar esta función
            // Aplicar  XOR (^) A los campos
            for(int parityBit = 0; parityBit < parityQty; parityBit++)
            {
                for(int bitPos = 0; bitPos < 11; bitPos++)
                {
                    if(IsPowerOfTwo(bitPos + 1))
                        continue;
                    if (((bitPos >> parityBit) & 1) == 1)
                        // Apply XOR
                        parityBits[parityBit] = parityBits[parityBit] ^ HammingMatrix[0, bitPos];

                }
                Console.WriteLine("Paridad =>"+parityBit+" :: "+parityBits[parityBit]);
            }
        }

        private void FillSolvedMatrix() { }



        // -------------------------------------------

        private void InitMatrix() { }

        private void ShowMatrix()
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

        private bool IsPowerOfTwo(int num)
        {
            var exponent = Math.Log(num, 2);
            return exponent % 1 == 0;
        }

    }
}
