using System.Security.Cryptography.X509Certificates;

namespace _02._1._03_Library
{
    public class Converter
    {
        // Generamos el metodo de clase que convierte de decimal a binario
        public static string DecimalToBinary(int numero)
        {
            string valorBinario = string.Empty; // Variable que vamos a retornar
            // Generamos dos variables, una para verificar si el resultado de la division es igual a 0 y otra para verificar el resto
            int resultDiv = numero;
            int restoDiv;
            
            if(resultDiv >= 0)
            {
                do
                {
                    restoDiv = resultDiv % 2;
                    resultDiv /= 2;
                    valorBinario = restoDiv.ToString() + valorBinario; // Lo hago de esta manera para ir dejando la ultima division en la primer posicion
                } while (resultDiv > 0);
            }

            return valorBinario;
        }
        // Generamos el metodo de 
    }
}
