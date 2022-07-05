using System;

namespace Ejer_1
{
    public class Banco
    {
        //atributos 


        private Cliente cliente1, cliente2, cliente3, cliente4;

        // var cliente4;
        //Constructor
        public Banco()
        {
            cliente1 = new Cliente("Juan");
            cliente2 = new Cliente("Hernan");
            cliente3 = new Cliente("Roberto");
        }


        //metodos

        public void Operar()
        {
            cliente1.Depositar(1000);
            Console.WriteLine("El cliente {0} hizo un deposito de $ 1000 ", cliente1);
            cliente2.Depositar(2000);
            Console.WriteLine("El cliente {0} hizo un deposito de $ 2000 ", cliente2);
            cliente3.Depositar(3000);
            Console.WriteLine("El cliente {0} hizo un deposito de $ 3000 ", cliente3);
            cliente3.Extraer(150);
            Console.WriteLine("El cliente {0} hizo una extraccion de $ 150 ", cliente3);
        }

        public void Depositos_Totales()
        {
            float t;
            t = cliente1.Retornar_Monto() + cliente2.Retornar_Monto() + cliente3.Retornar_Monto();

            Console.WriteLine("La caja del banco es igual a $ {0}", t);

            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }
    }
}