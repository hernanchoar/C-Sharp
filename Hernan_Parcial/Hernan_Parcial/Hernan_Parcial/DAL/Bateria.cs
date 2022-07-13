using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan_Parcial
{
    class Bateria
    {
        private float _cantidad; 
        private int _capacidadHs = 200;
        private int _consumo;

        private int _gasto;
        
        

        //public Bateria(float cantidad, int capacidadHs, int consumo)
        //{
        //    Cantidad = cantidad;
        //    CapacidadHs = capacidadHs;
        //    Consumo = consumo;
        //}
        public int Gasto { get => _gasto; set => _gasto = value; }
        public float Cantidad { get => _cantidad; set => _cantidad = value; }
        public int CapacidadHs { get => _capacidadHs; set => _capacidadHs = value; }
        public int Consumo { get => _consumo; set => _consumo = value; }
        
        
        
        //Metodos 
        
        //Para gastar le pasamos las horas de duracion de la bateria y la cantidad de bateria que se gasta por hora
        public int Gastar_Bateria(int p_horas)
        {
             _gasto = p_horas - _consumo;
            return _gasto;
        }
        
        
        
        
        
    }
}
