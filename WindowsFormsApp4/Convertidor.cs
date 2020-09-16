using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Convertidor
    {
        public string bi_hexa(string numero)
        {
            if (numero.Length % 4 == 1)
            {
                numero = "000" + numero;
                return separador_4d(numero);

            }
            else if (numero.Length % 4 == 2)
            {
                numero = "00" + numero;
                return separador_4d(numero);
            }
            else if (numero.Length % 4 == 3)
            {
                numero = "0" + numero;
                return separador_4d(numero);
            }
            else
            {
                return separador_4d(numero);
            }


        }
        public string separador_4d(string numero)
        {
            string final = "";
            int con = 0;

            while (con != numero.Length / 4)
            {
                final = final + diccionario_B_H(numero.Substring(con * 4, 4));
                con++;
            }


            return final;
        }
        public string diccionario_B_H(string caracter)
        {
            switch (caracter)
            {
                case "0000":
                    return "0";

                case "0001":
                    return "1";

                case "0010":
                    return "2";

                case "0011":
                    return "3";

                case "0100":
                    return "4";

                case "0101":
                    return "5";

                case "0110":
                    return "6";

                case "0111":
                    return "7";

                case "1000":
                    return "8";

                case "1001":
                    return "9";

                case "1010":
                    return "A";

                case "1011":
                    return "B";

                case "1100":
                    return "C";

                case "1101":
                    return "D";

                case "1110":
                    return "E";

                case "1111":
                    return "F";

                default:
                    return "error";

            }
        }

        public string bi_octal(string numero)
        {
            if (numero.Length % 3 == 1)
            {
                numero = "00" + numero;
                return separador_3d(numero);

            }
            else if (numero.Length % 3 == 2)
            {
                numero = "0" + numero;
                return separador_3d(numero);
            }
            else
            {
                return separador_3d(numero);
            }
        }
        public string separador_3d(string numero)
        {
            string final = "";
            int con = 0;

            while (con != numero.Length / 3)
            {
                final = final + diccionario_B_O(numero.Substring(con * 3, 3));
                con++;
            }


            return final;
        }
        public string diccionario_B_O(string caracter)
        {


            switch (caracter)
            {

                case "000":
                    return "0";

                case "001":
                    return "1";

                case "010":
                    return "2";

                case "011":
                    return "3";

                case "100":
                    return "4";


                case "101":
                    return "5";

                case "110":
                    return "6";

                case "111":
                    return "7";
                default:
                    return "error";

            }
        }


        public string hexa_bi(string numero)
        {
            string binario = "";
            int ind = 0;
            
            while (numero.Length != ind)
            {
                string letra = numero.Substring(ind, 1);
                

                binario = binario + diccionario_H_B(letra);
                ind++;
            }

            return binario;
        }
        public string diccionario_H_B(string n)
        {
            if (n == "0") { return "0000"; }
            else if (n == "1") { return "0001"; }
            else if (n == "2") { return "0010"; }
            else if (n == "3") { return "0011"; }
            else if (n == "4") { return "0100"; }
            else if (n == "5") { return "0101"; }
            else if (n == "6") { return "0110"; }
            else if (n == "7") { return "0111"; }
            else if (n == "8") { return "1000"; }
            else if (n == "9") { return "1001"; }
            else if (n == "A") { return "1010"; }
            else if (n == "B") { return "1011"; }
            else if (n == "C") { return "1100"; }
            else if (n == "D") { return "1101"; }
            else if (n == "E") { return "1110"; }
            else if (n == "F") { return "1111"; }
            else { return "error"; }

        }

        

    }
}
