using System;

namespace Examen_final_programacion
{
    
    int result = 10;
    try {
    int a = 0;
    int b = 50;
    result = a/ b;
    Console.WriteLine("División OK");
    } catch (Exception e) {
    Console.WriteLine("Error general");
    } finally {
    Console.WriteLine("Resultado: {0}", result);
    }
   
}