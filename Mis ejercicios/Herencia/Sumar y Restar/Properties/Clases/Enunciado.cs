namespace Sumar_y_Restar
{
    public class Enunciado
    {
        /*
         * Ahora plantearemos el primer problema utilizando herencia. Supongamos que necesitamos implementar dos
         * clases que llamaremos Suma y Resta. Cada clase tiene como atributo valor1, valor2 y resultado. Las propiedades a
         * definir son Valor1, Valor2 y Resultado, el método Operar (que en el caso de la clase "Suma" suma los dos Valores y en el
         * caso de la clase "Resta" hace la diferencia entre Valor1 y Valor2.

Si analizamos ambas clases encontramos que muchas propiedades son idénticos. En estos casos es bueno definir una 
clase padre que agrupe dichas propiedades, atributos y responsabilidades comunes.

La relación de herencia que podemos disponer para este problema es:

                                        Operacion

                        Suma                              Resta
Solamente el método operar es distinto para las clases Suma y Resta (esto hace que no lo podamos disponer 
en la clase Operacion), luego las propiedades Valor1, Valor2 son idénticos a las dos clases, esto hace que podamos 
disponerlos en la clase Operacion. Lo mismo las propiedades Valor1, Valor2 y Resultado se definirán en la clase padre Operacion.
Crear un proyecto y luego crear cuatro clases llamadas: Operacion, Suma, Resta y Prueba
         */
    }
}