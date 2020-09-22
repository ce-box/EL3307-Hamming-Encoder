using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Modulos
{
    // (17 bit ,12 data) --> 17 cols vs 5 r --> (7) filas
    class Hamming
    {
        const int rows = 7;
        const int cols = 17;
        const int parityBits = 5;

        int[,] HammingMatrix = new int[rows,cols];
        int[] bits = new int[12];
        

        /*
         *  Verificar msj de entrada
         */
        private bool StringToBitArray(string data)
        {
            if (data.Length != 12) return false;

            for (int i = 0; i < 12; i++)
            {
                if (data[i] != '1' || data[i] != '0')
                    return false;
                bits[i] = data[i] == '1' ? 1 : 0;
            };

            return true;
        }

        /*
         * Colocar los bits de datos de la 1er y 7ma fila 
         */
        private void WriteDataBitsInLines()
        {
            int itr = 1;

            foreach (int bit in bits)
            {
                if (IsPowerOfTwo(itr)) //El número es entero?
                    continue;
                HammingMatrix[0, itr-1] = bit;
                HammingMatrix[6, itr-1] = bit;
                itr++;
            }
        }

        // El Algortimo saico que nos dacamos de la manga XD
        private bool IsPowerOfTwo(int num)
        {
            var exponent = Math.Log(num, 2);
            return exponent % 1 == 0;
        }








    }
}
