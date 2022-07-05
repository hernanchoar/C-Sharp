using System;

namespace Ejercicios_para_examen
{
    public class ConvertirBinario
    {
        public void Convertir()
        {
            int numero_Decimal = 15;
            int temporal;
            string binario = string.Empty;

            while (numero_Decimal > 0)
            {
                temporal = numero_Decimal % 2;
                numero_Decimal /= 2;
                binario = temporal.ToString() + binario;
            }
            Console.WriteLine("El numero binario es:  {0}", binario);
        }
    }
}