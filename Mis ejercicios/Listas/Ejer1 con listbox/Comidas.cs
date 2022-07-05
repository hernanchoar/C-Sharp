using System.Collections.Generic;

namespace Ejer1_con_listbox
{
    public class Comidas
    {
        private List<Comidas> lista_Comidas = new List<Comidas>();


        public List<Comidas> ComidasList
        {
            set { lista_Comidas = value; }
            get { return lista_Comidas; }
        }

        private string minutas;

        public string Minutas
        {
            set { minutas = value; }
            get { return minutas; }
        }


        public override string ToString()
        {
            return "La comida es" + minutas;
        }


        public void Agregar_Comidas(Comidas minutas)
        {
            lista_Comidas.Add(minutas);
        }
    }
}