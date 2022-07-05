using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApplication1
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      //Cadena de caracteres Ejer 1 
    /*
      string nombre1, nombre2;
      int edad1, edad2;
      string linea;
      
      Console.WriteLine("Ingrese el nombre de la persona 1 ");
      nombre1 = Console.ReadLine();
      Console.WriteLine("Ingrese el nombre de la persona 2 ");
      nombre2 = Console.ReadLine();
      Console.WriteLine("Ingrese la edad de la persona 1 ");
      linea = Console.ReadLine();
      edad1 = Convert.ToInt16(linea);
      Console.WriteLine("Ingrese la edad de la persona 2 ");
      linea = Console.ReadLine();
      edad2 = Convert.ToInt16(linea);


      if (edad1 > edad2)
      {
          Console.WriteLine("La persona de mayor edad es {0} con una edad de {1}",nombre1,edad1);
      }else
        Console.WriteLine("La persona de mayor edad es {0} con una edad de {1}",nombre2,edad2);
*/
    
    
    
    //Mostrar mayoria de edad Ejer 2 
    Persona persona = new Persona();
    /*
    Console.WriteLine("Indique el nombre de la persona");
    persona.Nombre = Console.ReadLine();
    
    Console.WriteLine("Indique la edad de la persona");
    persona.Linea = Console.ReadLine();
    persona.Edad = Convert.ToInt16(persona.Linea);
   */
    persona.Inicializa(persona.Nombre,persona.Linea,persona.Edad);
    persona.Mostrar_datos(persona.Nombre,persona.Edad);
    persona.Mostrar_mayoria_de_edad(persona.Edad);


    }
  }


  public class Persona
  {
    //Confeccionar una clase que permita carga el nombre y la edad de una persona.
    //Mostrar los datos cargados. Imprimir un mensaje si es mayor de edad (edad>=18)

    //Declaracion de variables
    private string nombre;
    private int edad;
    private string linea;
    
    //Modificadores de acceso 
    public string Nombre
    {
      set { nombre = value; }
      get { return nombre; }
    }

    public int Edad
    {
      set { edad = value; }
      get { return edad; }
    }

    public string Linea
    {
      set { linea = value; }
      get { return linea; }
    }
    //Metodos 

    public void Inicializa(string m_nombre, string m_linea , int m_edad)
    {
      Console.WriteLine("Indique el nombre de la persona");
      Nombre = Console.ReadLine();
      Console.WriteLine("Indique la edad de la persona");
      Linea = Console.ReadLine();
      Edad = Convert.ToInt16(Linea);
    }
    
    
    public void Mostrar_datos(string m_nombre, int m_edad)
    {
       Console.WriteLine("Nombre = {0} y edad = {1}", nombre, edad);
    }
    public void Mostrar_mayoria_de_edad(int m_edad)
    {
      
      if (m_edad >= 18)
      {
        Console.WriteLine("Es mayor de edad");
      }
      else
        Console.WriteLine("Es menor de edad");

      
    }

  }
}