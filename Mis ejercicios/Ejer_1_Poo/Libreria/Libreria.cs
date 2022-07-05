using System.Collections.Generic;

namespace Libreria
{
    public class Libreria
    {
        
            private float Recaudacion_Total;
            
            private List<Producto> _productos = new List<Producto>();
           
            
            public List<Producto> Productos
            {
                set { _productos = value; }
                get { return _productos; }

            }
        
            public Libreria()
            {
                if (Productos == null)
                {
                    Productos = new List<Producto>();
                }
                
            }
            
        
            public float recaudacion_total
            {
                set { Recaudacion_Total = value; }
                get { return Recaudacion_Total; }
            }

          

            //Metodos 
            
            // Creo un metodo para ingresar un producto 
            public void Ingresar_Producto(Producto producto)
            {
            _productos.Add(producto);
            }
            
            }
}
           

           
        
        
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
             
             
          
        
        
        

        
        
        
        
        