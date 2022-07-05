namespace Libreria
{
    public class Producto
    {
        
        private int codigo_de_barras;
        private string nombre_del_producto;
        private string descripcion;
        private float precio;
        
        public int Codigo_de_Barras
        {
            set{ codigo_de_barras = value; }
            get { return codigo_de_barras; }

        }

        public string Nombre_Del_Producto
        {
            set { nombre_del_producto = value; }
            get { return nombre_del_producto; }
        }

        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public float Precio
        {
            set { precio = value; }
            get { return precio; }
        }


        public override string ToString()
        {
            return "Cod" + codigo_de_barras + "Nom_product" + nombre_del_producto + "Descrip" +
                   descripcion + "$" + precio;
        }
        
    }
}