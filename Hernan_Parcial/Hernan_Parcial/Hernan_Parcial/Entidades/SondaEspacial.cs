using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hernan_Parcial.DAL
{
    public class SondaEspacial 
    {
        
        public int AltitudMinima { get; set; }
     
        public override string ToString()
        {
            return AltitudMinima.ToString();
        }
    }
}
